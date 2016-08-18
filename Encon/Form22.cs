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
using DevExpress.Data;
using DevExpress.Docs;
using DevExpress.Office;
using DevExpress.Spreadsheet; 

namespace Encon
{
    public partial class Form22 : Form
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
        public Form22()
        {
            InitializeComponent();
        }


        private string CreateHeader()
        {
            string header = "";

            for (int i = 0; i < Across; i++)
            {
                if (ckIncludeHumanReadable.Checked)
                {
                    header += string.Format("ReadableRow{0},Barcode{0},", i + 1);
                }
                else
                {
                    header += string.Format("Row{0},", i + 1);
                }
            }

            return header += Environment.NewLine;
        }


        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //  validateFolderPath(FolderPath);
            if(string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Select a file type or else.");
                return;
            }

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

        //private void DumpFile(ref int filenumber, string contents)
        //{
        //    filenumber++;

        //    string myPath = Path.Combine(FolderPath, FileName + filenumber.ToString() + ".csv");

        //    File.WriteAllText(myPath, contents.ToString());
        //}


        


        private void buttonFolderPicker_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Custom Description"; //not mandatory

            if (fbd.ShowDialog() == DialogResult.OK)
                FolderPath = fbd.SelectedPath;
            else
            {
                string filepath = @"C:\Encon";    // Default path.
                //validateFolderPath(filepath);
                FolderPath = filepath;
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int rowcount = 0;
            int processd = 0;
            int filenumber = 0;



            string myPath = System.IO.Path.Combine(FolderPath, FileName + filenumber.ToString() + ".csv");
            IDocument doc = new CsvDocument(myPath);

            // Add the header info to the CSV file.
            doc.Write(CreateHeader());

            // Loop until the end.
            for (long i = 0; i < TotalRows; i++)
            {

               


                for (int d = 0; d < Down; d++)
                {
                    for (int a = 0; a < Across; a++)
                    {
                        long workingValue = (StartingPoint + i * Down * Across) + Down * a + d;
                        string hr = MaskIntField(textboxHumanMask.Text, workingValue);
                        string bc = MaskIntField(textboxBarcodeMask.Text, workingValue);

                        if (ckIncludeHumanReadable.Checked)
                        {
                            doc.Write(string.Format("{1}{0}{1},", hr, '"'));
                        }
                        doc.Write(string.Format("{1}{0}{1},", bc, '"'));
                        processd++;

                    }
                    doc.Write(string.Format("{0}", Environment.NewLine));
                    rowcount++;

                    if (rowcount % Rows == 0)
                    {
                        // Write it out to a file.                                               
                        doc.Save();

                        filenumber++;
                        myPath = System.IO.Path.Combine(FolderPath, FileName + filenumber.ToString() + ".csv");
                        doc = new CsvDocument(myPath);

                        // Add the header info to the CSV file.
                        doc.Write(CreateHeader());
                        

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

                        if (processd >= TotalRows)
                        {
                            worker.ReportProgress(100);
                            return;
                        }

                        worker.ReportProgress(progressPercent);
                        
                    }
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
            if (worker.WorkerSupportsCancellation)
            {
                worker.CancelAsync();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxStartingPoint_TextChanged(object sender, EventArgs e)
        {
            textboxTestStartingNumber.Text = textBoxStartingPoint.Text;
        }



        private void textboxBarcodeMask_TextChanged(object sender, EventArgs e)
        {
            textboxTestBarcodeMask.Text = textboxBarcodeMask.Text;
        }

        private void textboxHumanMask_TextChanged(object sender, EventArgs e)
        {
            textboxTestHumanMask.Text = textboxHumanMask.Text;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            long workingValue = long.Parse(textboxTestStartingNumber.Text) - 1;
            string val = MaskIntField(textboxHumanMask.Text, workingValue);
            string val2 = MaskIntField(textboxBarcodeMask.Text, workingValue);

            textboxTestStartingNumber.Text = workingValue.ToString();
            textboxTestBarcodeMask.Text = val2;
            textboxTestHumanMask.Text = val;
        }
        private void buttonUp_Click(object sender, EventArgs e)
        {

            long workingValue = long.Parse(textboxTestStartingNumber.Text) + 1;
            string val = MaskIntField(textboxHumanMask.Text, workingValue);
            string val2 = MaskIntField(textboxBarcodeMask.Text, workingValue);

            textboxTestStartingNumber.Text = workingValue.ToString();
            textboxTestBarcodeMask.Text = val2;
            textboxTestHumanMask.Text = val;
        }




        //{
        //        string mask = "F0000-B000-R0000";
        //        int startingPoint = 96001;

        //        string mystring = MaskIntField(mask, startingPoint);

        //        Console.WriteLine(mystring);
        //        Console.WriteLine("Press any key to exit.");
        //        Console.ReadLine();
        //}



        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        public static string MaskIntField(string Mask, long Value)
        {
            string value = Value.ToString();
            string rv = Reverse(value);
            string rm = Reverse(Mask);
            int v = 0;
            string val = "";


            foreach (char cH in rm)
            {
                if (Char.IsDigit(cH) && v < rv.Length)
                {
                    val = val + rv[v];
                    v++;
                }
                else
                {
                    val = val + cH;
                }
            }
            return Reverse(val);
        }

        private void textboxTestHumanMask_TextChanged(object sender, EventArgs e)
        {

        }

       




    }
}
