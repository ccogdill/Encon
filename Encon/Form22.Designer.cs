namespace Encon
{
    partial class Form22
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
            this.textboxBarcodeMask = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxHumanMask = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textboxTestHumanMask = new System.Windows.Forms.TextBox();
            this.textboxTestBarcodeMask = new System.Windows.Forms.TextBox();
            this.textboxTestStartingNumber = new System.Windows.Forms.TextBox();
            this.ckIncludeHumanReadable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(766, 511);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(150, 44);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting Number";
            // 
            // textBoxStartingPoint
            // 
            this.textBoxStartingPoint.Location = new System.Drawing.Point(364, 61);
            this.textBoxStartingPoint.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxStartingPoint.Name = "textBoxStartingPoint";
            this.textBoxStartingPoint.Size = new System.Drawing.Size(196, 31);
            this.textBoxStartingPoint.TabIndex = 2;
            this.textBoxStartingPoint.Text = "96001";
            this.textBoxStartingPoint.TextChanged += new System.EventHandler(this.textBoxStartingPoint_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dimension (Across x Down)";
            // 
            // textBoxAcross
            // 
            this.textBoxAcross.Location = new System.Drawing.Point(362, 242);
            this.textBoxAcross.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAcross.Name = "textBoxAcross";
            this.textBoxAcross.Size = new System.Drawing.Size(196, 31);
            this.textBoxAcross.TabIndex = 4;
            this.textBoxAcross.Text = "3";
            // 
            // textBoxDown
            // 
            this.textBoxDown.Location = new System.Drawing.Point(574, 242);
            this.textBoxDown.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDown.Name = "textBoxDown";
            this.textBoxDown.Size = new System.Drawing.Size(196, 31);
            this.textBoxDown.TabIndex = 5;
            this.textBoxDown.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rows Per File";
            // 
            // textBoxRowsPerFile
            // 
            this.textBoxRowsPerFile.Location = new System.Drawing.Point(362, 292);
            this.textBoxRowsPerFile.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxRowsPerFile.Name = "textBoxRowsPerFile";
            this.textBoxRowsPerFile.Size = new System.Drawing.Size(196, 31);
            this.textBoxRowsPerFile.TabIndex = 7;
            this.textBoxRowsPerFile.Text = "3200";
            // 
            // textBoxTotalRows
            // 
            this.textBoxTotalRows.Location = new System.Drawing.Point(362, 342);
            this.textBoxTotalRows.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTotalRows.Name = "textBoxTotalRows";
            this.textBoxTotalRows.Size = new System.Drawing.Size(196, 31);
            this.textBoxTotalRows.TabIndex = 8;
            this.textBoxTotalRows.Text = "192000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Rows to Process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 446);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "File Save Location";
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(362, 440);
            this.textBoxFolderPath.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(480, 31);
            this.textBoxFolderPath.TabIndex = 11;
            this.textBoxFolderPath.Text = "C:\\Encon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Filename";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(362, 392);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(278, 31);
            this.textBoxFileName.TabIndex = 13;
            this.textBoxFileName.Text = "Encon";
            // 
            // buttonFolderPicker
            // 
            this.buttonFolderPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFolderPicker.Location = new System.Drawing.Point(856, 438);
            this.buttonFolderPicker.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFolderPicker.Name = "buttonFolderPicker";
            this.buttonFolderPicker.Size = new System.Drawing.Size(60, 44);
            this.buttonFolderPicker.TabIndex = 14;
            this.buttonFolderPicker.Text = "...";
            this.buttonFolderPicker.UseVisualStyleBackColor = true;
            this.buttonFolderPicker.Click += new System.EventHandler(this.buttonFolderPicker_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(46, 511);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(542, 44);
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
            this.buttonCancel.Location = new System.Drawing.Point(604, 511);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 44);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textboxBarcodeMask
            // 
            this.textboxBarcodeMask.Location = new System.Drawing.Point(364, 121);
            this.textboxBarcodeMask.Margin = new System.Windows.Forms.Padding(6);
            this.textboxBarcodeMask.Name = "textboxBarcodeMask";
            this.textboxBarcodeMask.Size = new System.Drawing.Size(196, 31);
            this.textboxBarcodeMask.TabIndex = 18;
            this.textboxBarcodeMask.Text = "C000096001";
            this.textboxBarcodeMask.TextChanged += new System.EventHandler(this.textboxBarcodeMask_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Barcode Mask";
            // 
            // textboxHumanMask
            // 
            this.textboxHumanMask.Location = new System.Drawing.Point(364, 179);
            this.textboxHumanMask.Margin = new System.Windows.Forms.Padding(6);
            this.textboxHumanMask.Name = "textboxHumanMask";
            this.textboxHumanMask.Size = new System.Drawing.Size(196, 31);
            this.textboxHumanMask.TabIndex = 20;
            this.textboxHumanMask.Text = "C000096001";
            this.textboxHumanMask.TextChanged += new System.EventHandler(this.textboxHumanMask_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Human Readable Mask";
            // 
            // buttonUp
            // 
            this.buttonUp.Image = global::Encon.Properties.Resources.arrow_up;
            this.buttonUp.Location = new System.Drawing.Point(295, 49);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 48);
            this.buttonUp.TabIndex = 21;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Image = global::Encon.Properties.Resources.arrow_down;
            this.buttonDown.Location = new System.Drawing.Point(295, 103);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 50);
            this.buttonDown.TabIndex = 22;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textboxTestHumanMask);
            this.groupBox1.Controls.Add(this.textboxTestBarcodeMask);
            this.groupBox1.Controls.Add(this.textboxTestStartingNumber);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Location = new System.Drawing.Point(858, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 213);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textboxTestHumanMask
            // 
            this.textboxTestHumanMask.Location = new System.Drawing.Point(61, 156);
            this.textboxTestHumanMask.Margin = new System.Windows.Forms.Padding(6);
            this.textboxTestHumanMask.Name = "textboxTestHumanMask";
            this.textboxTestHumanMask.Size = new System.Drawing.Size(196, 31);
            this.textboxTestHumanMask.TabIndex = 25;
            this.textboxTestHumanMask.Text = "C000096001";
            this.textboxTestHumanMask.TextChanged += new System.EventHandler(this.textboxTestHumanMask_TextChanged);
            // 
            // textboxTestBarcodeMask
            // 
            this.textboxTestBarcodeMask.Location = new System.Drawing.Point(61, 103);
            this.textboxTestBarcodeMask.Margin = new System.Windows.Forms.Padding(6);
            this.textboxTestBarcodeMask.Name = "textboxTestBarcodeMask";
            this.textboxTestBarcodeMask.Size = new System.Drawing.Size(196, 31);
            this.textboxTestBarcodeMask.TabIndex = 24;
            this.textboxTestBarcodeMask.Text = "C000096001";
            // 
            // textboxTestStartingNumber
            // 
            this.textboxTestStartingNumber.Location = new System.Drawing.Point(61, 49);
            this.textboxTestStartingNumber.Margin = new System.Windows.Forms.Padding(6);
            this.textboxTestStartingNumber.Name = "textboxTestStartingNumber";
            this.textboxTestStartingNumber.Size = new System.Drawing.Size(196, 31);
            this.textboxTestStartingNumber.TabIndex = 23;
            this.textboxTestStartingNumber.Text = "96001";
            // 
            // ckInclude
            // 
            this.ckIncludeHumanReadable.AutoSize = true;
            this.ckIncludeHumanReadable.Checked = true;
            this.ckIncludeHumanReadable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckIncludeHumanReadable.Location = new System.Drawing.Point(574, 181);
            this.ckIncludeHumanReadable.Name = "ckInclude";
            this.ckIncludeHumanReadable.Size = new System.Drawing.Size(202, 29);
            this.ckIncludeHumanReadable.TabIndex = 24;
            this.ckIncludeHumanReadable.Text = "Include in output";
            this.ckIncludeHumanReadable.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 701);
            this.Controls.Add(this.ckIncludeHumanReadable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textboxHumanMask);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textboxBarcodeMask);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textboxBarcodeMask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textboxHumanMask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxTestHumanMask;
        private System.Windows.Forms.TextBox textboxTestBarcodeMask;
        private System.Windows.Forms.TextBox textboxTestStartingNumber;
        private System.Windows.Forms.CheckBox ckIncludeHumanReadable;
    }
}

