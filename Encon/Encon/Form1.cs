using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace Encon
{
    public partial class Form1 : Form
    {

     
        /// Properties
        private int Across
        {
            get { return int.Parse(this.textBoxAcross.Text); }
        }
        private int Down
        {
            get { return int.Parse(this.textBoxDown.Text); }
        }

        private long StartingPoint
        {
            get
            {
                string s = this.textBoxStartingPoint.Text;
                string digits = Regex.Replace(s, "[^0-9.]", "");
                return long.Parse(digits);
            }
        }
        private long TotalRows
        {
            get { return long.Parse(textBoxTotalRows.Text); }
        }

        private string FolderPath
        {
            get { return this.textBoxFolderPath.Text; }
            set { this.textBoxFolderPath.Text = value; }
        }

        private string FileName
        {
            get { return this.textBoxFileName.Text; }
        }

        private int Rows
        {
            get { return int.Parse(this.textBoxRowsPerFile.Text); }
        }

        /// <summary>
        ///  Constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

          
        }


        private string CreateHeader()
        {
            return "Row1P,Row1,Row2P,Row2,Row3P,Row3" + Environment.NewLine;
        }



      




        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            validateFolderPath(FolderPath);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            buttonGenerate.Enabled = false;
            buttonCancel.Enabled = true;

            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void DumpFile(ref int filenumber, string contents)
        {
            filenumber++;

            string myPath = Path.Combine(FolderPath, FileName + filenumber.ToString() + ".csv");

            File.WriteAllText(myPath, contents.ToString());
        }


        private void validateFolderPath(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }


        private void buttonFolderPicker_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Custom Description"; //not mandatory

            if (fbd.ShowDialog() == DialogResult.OK)
                FolderPath = fbd.SelectedPath;
            else
            {
                string filepath = @"C:\Encon";    // Default path.
                validateFolderPath(filepath);
                FolderPath = filepath;
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int rowcount = 0;
            int processd = 0;
            int filenumber = 0;

            StringBuilder csv = new StringBuilder();

            // Add the header info to the CSV file.
            csv.Append(CreateHeader());


            // Loop until the end.
            for (long i = 0; i < TotalRows; i++)
            {
                for (int d = 0; d < Down; d++)
                {
                    for (int a = 0; a < Across; a++)
                    {
                        long workingValue = (StartingPoint + i * Down * Across) + Down * a + d;
                        string workingStr = workingValue.ToString();


                        string seg1 = workingStr.Substring(0, workingStr.Length - 4);
                        string seg2 = workingStr.Substring(workingStr.Length - 4, 4);

                        csv.AppendFormat("{0},{1},", seg1, seg2);
                        processd++;

                    }
                    csv.AppendFormat("{0}", Environment.NewLine);
                    rowcount++;

                    if (rowcount % Rows == 0)
                    {
                        // Write it out to a file.                       
                        DumpFile(ref filenumber, csv.ToString());

                        // Check progress
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }

                        float dd = (int)(TotalRows / (Rows * Across)) + 1;


                        int progressPercent = (int)(((float)filenumber / dd) * 100.0);

                        if (progressPercent > 100) 
                            progressPercent = 100;

                        worker.ReportProgress(progressPercent);
                        


                        // Prep for the next file.
                        csv.Clear();
                        csv.Append(CreateHeader());
                    }
                }

                if (processd > TotalRows)
                {
                    // Write it out to a file.                       
                    DumpFile(ref filenumber, csv.ToString());                   
                    return;
                }
            }      
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonGenerate.Enabled = true;
            buttonCancel.Enabled = false;


            if (e.Cancelled)
            {
                MessageBox.Show("Canceled.");
            }
            else
            {
                MessageBox.Show("Done.");
            }
          
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if(worker.WorkerSupportsCancellation)
            {
                worker.CancelAsync();
            }
        }


        

       









    }
}
