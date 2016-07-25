namespace Encon
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStartingPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAcross = new System.Windows.Forms.TextBox();
            this.textBoxDown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRowsPerFile = new System.Windows.Forms.TextBox();
            this.textBoxTotalRows = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonFolderPicker = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(383, 221);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting Number";
            // 
            // textBoxStartingPoint
            // 
            this.textBoxStartingPoint.Location = new System.Drawing.Point(181, 55);
            this.textBoxStartingPoint.Name = "textBoxStartingPoint";
            this.textBoxStartingPoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartingPoint.TabIndex = 2;
            this.textBoxStartingPoint.Text = "C000096001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dimension (Across x Down)";
            // 
            // textBoxAcross
            // 
            this.textBoxAcross.Location = new System.Drawing.Point(181, 81);
            this.textBoxAcross.Name = "textBoxAcross";
            this.textBoxAcross.Size = new System.Drawing.Size(100, 20);
            this.textBoxAcross.TabIndex = 4;
            this.textBoxAcross.Text = "3";
            // 
            // textBoxDown
            // 
            this.textBoxDown.Location = new System.Drawing.Point(287, 81);
            this.textBoxDown.Name = "textBoxDown";
            this.textBoxDown.Size = new System.Drawing.Size(100, 20);
            this.textBoxDown.TabIndex = 5;
            this.textBoxDown.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rows Per File";
            // 
            // textBoxRowsPerFile
            // 
            this.textBoxRowsPerFile.Location = new System.Drawing.Point(181, 107);
            this.textBoxRowsPerFile.Name = "textBoxRowsPerFile";
            this.textBoxRowsPerFile.Size = new System.Drawing.Size(100, 20);
            this.textBoxRowsPerFile.TabIndex = 7;
            this.textBoxRowsPerFile.Text = "3200";
            // 
            // textBoxTotalRows
            // 
            this.textBoxTotalRows.Location = new System.Drawing.Point(181, 133);
            this.textBoxTotalRows.Name = "textBoxTotalRows";
            this.textBoxTotalRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalRows.TabIndex = 8;
            this.textBoxTotalRows.Text = "192000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Rows to Process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "File Save Location";
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(181, 184);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(242, 20);
            this.textBoxFolderPath.TabIndex = 11;
            this.textBoxFolderPath.Text = "C:\\Encon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Filename";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(181, 159);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(141, 20);
            this.textBoxFileName.TabIndex = 13;
            this.textBoxFileName.Text = "Encon";
            // 
            // buttonFolderPicker
            // 
            this.buttonFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFolderPicker.Location = new System.Drawing.Point(428, 183);
            this.buttonFolderPicker.Name = "buttonFolderPicker";
            this.buttonFolderPicker.Size = new System.Drawing.Size(30, 23);
            this.buttonFolderPicker.TabIndex = 14;
            this.buttonFolderPicker.Text = "...";
            this.buttonFolderPicker.UseVisualStyleBackColor = true;
            this.buttonFolderPicker.Click += new System.EventHandler(this.buttonFolderPicker_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 221);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(302, 221);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 264);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonFolderPicker);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTotalRows);
            this.Controls.Add(this.textBoxRowsPerFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDown);
            this.Controls.Add(this.textBoxAcross);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStartingPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStartingPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAcross;
        private System.Windows.Forms.TextBox textBoxDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRowsPerFile;
        private System.Windows.Forms.TextBox textBoxTotalRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonFolderPicker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button buttonCancel;
    }
}

