namespace Chap5cProject
{
    partial class frmRandom
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
            this.txtNumberOfRandNums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.grpRead = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumRNs = new System.Windows.Forms.Label();
            this.lstRandomNums = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.grpCreate.SuspendLayout();
            this.grpRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumberOfRandNums
            // 
            this.txtNumberOfRandNums.Location = new System.Drawing.Point(432, 63);
            this.txtNumberOfRandNums.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNumberOfRandNums.MaxLength = 4;
            this.txtNumberOfRandNums.Name = "txtNumberOfRandNums";
            this.txtNumberOfRandNums.Size = new System.Drawing.Size(70, 31);
            this.txtNumberOfRandNums.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of random numbers to generate";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(42, 131);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(148, 69);
            this.btnCreateFile.TabIndex = 2;
            this.btnCreateFile.Text = "&Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(42, 58);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(148, 69);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "&Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnCreateFile);
            this.grpCreate.Controls.Add(this.txtNumberOfRandNums);
            this.grpCreate.Controls.Add(this.label1);
            this.grpCreate.Location = new System.Drawing.Point(78, 48);
            this.grpCreate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpCreate.Size = new System.Drawing.Size(664, 231);
            this.grpCreate.TabIndex = 0;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create a file of random numbers";
            // 
            // grpRead
            // 
            this.grpRead.Controls.Add(this.label4);
            this.grpRead.Controls.Add(this.lblAverage);
            this.grpRead.Controls.Add(this.label2);
            this.grpRead.Controls.Add(this.lblNumRNs);
            this.grpRead.Controls.Add(this.lstRandomNums);
            this.grpRead.Controls.Add(this.btnReadFile);
            this.grpRead.Location = new System.Drawing.Point(78, 344);
            this.grpRead.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpRead.Name = "grpRead";
            this.grpRead.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpRead.Size = new System.Drawing.Size(820, 588);
            this.grpRead.TabIndex = 1;
            this.grpRead.TabStop = false;
            this.grpRead.Text = "Read a file of random numbers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 502);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average value";
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(694, 500);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(114, 42);
            this.lblAverage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 502);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of random numbers in file";
            // 
            // lblNumRNs
            // 
            this.lblNumRNs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumRNs.Location = new System.Drawing.Point(372, 500);
            this.lblNumRNs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumRNs.Name = "lblNumRNs";
            this.lblNumRNs.Size = new System.Drawing.Size(114, 42);
            this.lblNumRNs.TabIndex = 3;
            // 
            // lstRandomNums
            // 
            this.lstRandomNums.FormattingEnabled = true;
            this.lstRandomNums.ItemHeight = 25;
            this.lstRandomNums.Location = new System.Drawing.Point(268, 63);
            this.lstRandomNums.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstRandomNums.Name = "lstRandomNums";
            this.lstRandomNums.Size = new System.Drawing.Size(176, 404);
            this.lstRandomNums.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(750, 967);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(940, 1040);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpRead);
            this.Controls.Add(this.grpCreate);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmRandom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS3850 Chapter 5c Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.grpRead.ResumeLayout(false);
            this.grpRead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfRandNums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.GroupBox grpRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumRNs;
        private System.Windows.Forms.ListBox lstRandomNums;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    }
}

