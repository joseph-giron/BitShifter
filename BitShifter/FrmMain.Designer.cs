namespace XOR_By
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnShiftBy = new System.Windows.Forms.Button();
            this.tbShiftBy = new System.Windows.Forms.TextBox();
            this.tbTextOut = new System.Windows.Forms.TextBox();
            this.cbShifter = new System.Windows.Forms.ComboBox();
            this.cvt = new System.ComponentModel.BackgroundWorker();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnOutputFile = new System.Windows.Forms.Button();
            this.tbOutFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInFile = new System.Windows.Forms.TextBox();
            this.cbExperimental = new System.Windows.Forms.CheckBox();
            this.tbLowerRange = new System.Windows.Forms.TextBox();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.tbUpperRange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbSearchIteration = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnShiftBy
            // 
            this.btnShiftBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftBy.Location = new System.Drawing.Point(387, 79);
            this.btnShiftBy.Margin = new System.Windows.Forms.Padding(6);
            this.btnShiftBy.Name = "btnShiftBy";
            this.btnShiftBy.Size = new System.Drawing.Size(169, 41);
            this.btnShiftBy.TabIndex = 3;
            this.btnShiftBy.Text = "Shift By Value";
            this.btnShiftBy.UseVisualStyleBackColor = true;
            this.btnShiftBy.Click += new System.EventHandler(this.btnXorBy_Click);
            // 
            // tbShiftBy
            // 
            this.tbShiftBy.Location = new System.Drawing.Point(580, 84);
            this.tbShiftBy.Margin = new System.Windows.Forms.Padding(6);
            this.tbShiftBy.Name = "tbShiftBy";
            this.tbShiftBy.Size = new System.Drawing.Size(178, 29);
            this.tbShiftBy.TabIndex = 2;
            // 
            // tbTextOut
            // 
            this.tbTextOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextOut.Location = new System.Drawing.Point(15, 137);
            this.tbTextOut.Margin = new System.Windows.Forms.Padding(6);
            this.tbTextOut.Multiline = true;
            this.tbTextOut.Name = "tbTextOut";
            this.tbTextOut.ReadOnly = true;
            this.tbTextOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTextOut.Size = new System.Drawing.Size(746, 322);
            this.tbTextOut.TabIndex = 4;
            // 
            // cbShifter
            // 
            this.cbShifter.FormattingEnabled = true;
            this.cbShifter.Items.AddRange(new object[] {
            "XOR",
            "OR",
            "AND",
            "Bitwise Compliment",
            "Left Shift",
            "Right Shift"});
            this.cbShifter.Location = new System.Drawing.Point(179, 85);
            this.cbShifter.Margin = new System.Windows.Forms.Padding(6);
            this.cbShifter.Name = "cbShifter";
            this.cbShifter.Size = new System.Drawing.Size(177, 32);
            this.cbShifter.TabIndex = 1;
            // 
            // cvt
            // 
            this.cvt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cvt_DoWork);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(15, 539);
            this.lblLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(91, 25);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length: ";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(15, 23);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(169, 42);
            this.btnLoadFile.TabIndex = 6;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnOutputFile
            // 
            this.btnOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputFile.Location = new System.Drawing.Point(15, 468);
            this.btnOutputFile.Name = "btnOutputFile";
            this.btnOutputFile.Size = new System.Drawing.Size(169, 42);
            this.btnOutputFile.TabIndex = 6;
            this.btnOutputFile.Text = "Output File";
            this.btnOutputFile.UseVisualStyleBackColor = true;
            this.btnOutputFile.Click += new System.EventHandler(this.btnOutputFile_Click);
            // 
            // tbOutFileName
            // 
            this.tbOutFileName.Location = new System.Drawing.Point(218, 474);
            this.tbOutFileName.Name = "tbOutFileName";
            this.tbOutFileName.Size = new System.Drawing.Size(543, 29);
            this.tbOutFileName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Shift How?";
            // 
            // tbInFile
            // 
            this.tbInFile.Location = new System.Drawing.Point(221, 29);
            this.tbInFile.Name = "tbInFile";
            this.tbInFile.Size = new System.Drawing.Size(540, 29);
            this.tbInFile.TabIndex = 9;
            // 
            // cbExperimental
            // 
            this.cbExperimental.AutoSize = true;
            this.cbExperimental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExperimental.Location = new System.Drawing.Point(125, 589);
            this.cbExperimental.Name = "cbExperimental";
            this.cbExperimental.Size = new System.Drawing.Size(526, 29);
            this.cbExperimental.TabIndex = 10;
            this.cbExperimental.Text = "Experimental - Search for string, incremental range";
            this.cbExperimental.UseVisualStyleBackColor = true;
            this.cbExperimental.CheckedChanged += new System.EventHandler(this.cbExperimental_CheckedChanged);
            // 
            // tbLowerRange
            // 
            this.tbLowerRange.Enabled = false;
            this.tbLowerRange.Location = new System.Drawing.Point(282, 691);
            this.tbLowerRange.Name = "tbLowerRange";
            this.tbLowerRange.Size = new System.Drawing.Size(88, 29);
            this.tbLowerRange.TabIndex = 11;
            this.tbLowerRange.Text = "1";
            // 
            // tbSearchString
            // 
            this.tbSearchString.Enabled = false;
            this.tbSearchString.Location = new System.Drawing.Point(282, 642);
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.Size = new System.Drawing.Size(386, 29);
            this.tbSearchString.TabIndex = 11;
            this.tbSearchString.Text = "DOS mode";
            // 
            // tbUpperRange
            // 
            this.tbUpperRange.Enabled = false;
            this.tbUpperRange.Location = new System.Drawing.Point(445, 692);
            this.tbUpperRange.Name = "tbUpperRange";
            this.tbUpperRange.Size = new System.Drawing.Size(88, 29);
            this.tbUpperRange.TabIndex = 11;
            this.tbUpperRange.Text = "1024";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 646);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search String:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 695);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Range:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 695);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "to";
            // 
            // pbSearchIteration
            // 
            this.pbSearchIteration.Location = new System.Drawing.Point(12, 789);
            this.pbSearchIteration.Minimum = 1;
            this.pbSearchIteration.Name = "pbSearchIteration";
            this.pbSearchIteration.Size = new System.Drawing.Size(755, 54);
            this.pbSearchIteration.TabIndex = 12;
            this.pbSearchIteration.Value = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 871);
            this.Controls.Add(this.pbSearchIteration);
            this.Controls.Add(this.tbSearchString);
            this.Controls.Add(this.tbUpperRange);
            this.Controls.Add(this.tbLowerRange);
            this.Controls.Add(this.cbExperimental);
            this.Controls.Add(this.tbInFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutFileName);
            this.Controls.Add(this.btnOutputFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.cbShifter);
            this.Controls.Add(this.tbShiftBy);
            this.Controls.Add(this.btnShiftBy);
            this.Controls.Add(this.tbTextOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMain";
            this.Text = "Bit Shifter By AverageJoe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShiftBy;
        private System.Windows.Forms.TextBox tbShiftBy;
        private System.Windows.Forms.TextBox tbTextOut;
        private System.Windows.Forms.ComboBox cbShifter;
        private System.ComponentModel.BackgroundWorker cvt;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnOutputFile;
        private System.Windows.Forms.TextBox tbOutFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInFile;
        private System.Windows.Forms.CheckBox cbExperimental;
        private System.Windows.Forms.TextBox tbLowerRange;
        private System.Windows.Forms.TextBox tbSearchString;
        private System.Windows.Forms.TextBox tbUpperRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbSearchIteration;
    }
}

