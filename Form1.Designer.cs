namespace winflag
{
    partial class ViewerFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gboxCountries = new GroupBox();
            rbtnFrance = new RadioButton();
            rbtnGreece = new RadioButton();
            rbtnSwitz = new RadioButton();
            rbtnPh = new RadioButton();
            gboxDisplay = new GroupBox();
            cboxProgrammer = new CheckBox();
            cboxCountryName = new CheckBox();
            cboxTitle = new CheckBox();
            FlagPictureBox = new PictureBox();
            lblFlagNameDisplayer = new Label();
            lblProgrammer = new Label();
            btnExit = new Button();
            gboxCountries.SuspendLayout();
            gboxDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FlagPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 49);
            label1.Name = "label1";
            label1.Size = new Size(95, 18);
            label1.TabIndex = 0;
            label1.Text = "Flag Viewer";
            // 
            // gboxCountries
            // 
            gboxCountries.Controls.Add(rbtnFrance);
            gboxCountries.Controls.Add(rbtnGreece);
            gboxCountries.Controls.Add(rbtnSwitz);
            gboxCountries.Controls.Add(rbtnPh);
            gboxCountries.Location = new Point(43, 49);
            gboxCountries.Name = "gboxCountries";
            gboxCountries.Size = new Size(204, 237);
            gboxCountries.TabIndex = 1;
            gboxCountries.TabStop = false;
            gboxCountries.Text = "Countries";
            // 
            // rbtnFrance
            // 
            rbtnFrance.AutoSize = true;
            rbtnFrance.Location = new Point(26, 182);
            rbtnFrance.Name = "rbtnFrance";
            rbtnFrance.Size = new Size(60, 19);
            rbtnFrance.TabIndex = 3;
            rbtnFrance.TabStop = true;
            rbtnFrance.Text = "France";
            rbtnFrance.UseVisualStyleBackColor = true;
            rbtnFrance.CheckedChanged += rbtnFrance_CheckedChanged;
            // 
            // rbtnGreece
            // 
            rbtnGreece.AutoSize = true;
            rbtnGreece.Location = new Point(26, 133);
            rbtnGreece.Name = "rbtnGreece";
            rbtnGreece.Size = new Size(61, 19);
            rbtnGreece.TabIndex = 2;
            rbtnGreece.TabStop = true;
            rbtnGreece.Text = "Greece";
            rbtnGreece.UseVisualStyleBackColor = true;
            rbtnGreece.CheckedChanged += rbtnGreece_CheckedChanged;
            // 
            // rbtnSwitz
            // 
            rbtnSwitz.AutoSize = true;
            rbtnSwitz.Location = new Point(26, 85);
            rbtnSwitz.Name = "rbtnSwitz";
            rbtnSwitz.Size = new Size(85, 19);
            rbtnSwitz.TabIndex = 1;
            rbtnSwitz.TabStop = true;
            rbtnSwitz.Text = "Switzerland";
            rbtnSwitz.UseVisualStyleBackColor = true;
            rbtnSwitz.CheckedChanged += rbtnSwitz_CheckedChanged;
            // 
            // rbtnPh
            // 
            rbtnPh.AutoSize = true;
            rbtnPh.Location = new Point(26, 38);
            rbtnPh.Name = "rbtnPh";
            rbtnPh.Size = new Size(83, 19);
            rbtnPh.TabIndex = 0;
            rbtnPh.TabStop = true;
            rbtnPh.Text = "Philippines";
            rbtnPh.UseVisualStyleBackColor = true;
            rbtnPh.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // gboxDisplay
            // 
            gboxDisplay.Controls.Add(cboxProgrammer);
            gboxDisplay.Controls.Add(cboxCountryName);
            gboxDisplay.Controls.Add(cboxTitle);
            gboxDisplay.Location = new Point(576, 49);
            gboxDisplay.Name = "gboxDisplay";
            gboxDisplay.Size = new Size(145, 152);
            gboxDisplay.TabIndex = 2;
            gboxDisplay.TabStop = false;
            gboxDisplay.Text = "Display";
            gboxDisplay.Enter += gboxDisplay_Enter;
            // 
            // cboxProgrammer
            // 
            cboxProgrammer.AutoSize = true;
            cboxProgrammer.Checked = true;
            cboxProgrammer.CheckState = CheckState.Checked;
            cboxProgrammer.Location = new Point(16, 109);
            cboxProgrammer.Name = "cboxProgrammer";
            cboxProgrammer.Size = new Size(93, 19);
            cboxProgrammer.TabIndex = 2;
            cboxProgrammer.Text = "Programmer";
            cboxProgrammer.UseVisualStyleBackColor = true;
            cboxProgrammer.CheckedChanged += cboxProgrammer_CheckedChanged;
            // 
            // cboxCountryName
            // 
            cboxCountryName.AutoSize = true;
            cboxCountryName.Checked = true;
            cboxCountryName.CheckState = CheckState.Checked;
            cboxCountryName.Location = new Point(16, 71);
            cboxCountryName.Name = "cboxCountryName";
            cboxCountryName.Size = new Size(104, 19);
            cboxCountryName.TabIndex = 1;
            cboxCountryName.Text = "Country Name";
            cboxCountryName.UseVisualStyleBackColor = true;
            cboxCountryName.CheckedChanged += cboxCountryName_CheckedChanged;
            // 
            // cboxTitle
            // 
            cboxTitle.AutoSize = true;
            cboxTitle.Checked = true;
            cboxTitle.CheckState = CheckState.Checked;
            cboxTitle.Location = new Point(16, 35);
            cboxTitle.Name = "cboxTitle";
            cboxTitle.Size = new Size(48, 19);
            cboxTitle.TabIndex = 0;
            cboxTitle.Text = "Title";
            cboxTitle.UseVisualStyleBackColor = true;
            cboxTitle.CheckedChanged += cboxTitle_CheckedChanged;
            // 
            // FlagPictureBox
            // 
            FlagPictureBox.Location = new Point(269, 73);
            FlagPictureBox.Name = "FlagPictureBox";
            FlagPictureBox.Size = new Size(278, 150);
            FlagPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FlagPictureBox.TabIndex = 3;
            FlagPictureBox.TabStop = false;
            FlagPictureBox.Visible = false;
            // 
            // lblFlagNameDisplayer
            // 
            lblFlagNameDisplayer.AutoSize = true;
            lblFlagNameDisplayer.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFlagNameDisplayer.Location = new Point(360, 232);
            lblFlagNameDisplayer.Name = "lblFlagNameDisplayer";
            lblFlagNameDisplayer.Size = new Size(0, 18);
            lblFlagNameDisplayer.TabIndex = 4;
            lblFlagNameDisplayer.TextAlign = ContentAlignment.MiddleCenter;
            lblFlagNameDisplayer.Click += lblFlagNameDisplayer_Click;
            // 
            // lblProgrammer
            // 
            lblProgrammer.AutoSize = true;
            lblProgrammer.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgrammer.Location = new Point(69, 340);
            lblProgrammer.Name = "lblProgrammer";
            lblProgrammer.Size = new Size(115, 18);
            lblProgrammer.TabIndex = 5;
            lblProgrammer.Text = "Althea Apostol";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(610, 340);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ViewerFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 420);
            Controls.Add(btnExit);
            Controls.Add(lblProgrammer);
            Controls.Add(lblFlagNameDisplayer);
            Controls.Add(FlagPictureBox);
            Controls.Add(gboxDisplay);
            Controls.Add(gboxCountries);
            Controls.Add(label1);
            Name = "ViewerFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viewer";
            gboxCountries.ResumeLayout(false);
            gboxCountries.PerformLayout();
            gboxDisplay.ResumeLayout(false);
            gboxDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FlagPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gboxCountries;
        private RadioButton rbtnPh;
        private GroupBox gboxDisplay;
        private RadioButton rbtnFrance;
        private RadioButton rbtnGreece;
        private RadioButton rbtnSwitz;
        private CheckBox cboxProgrammer;
        private CheckBox cboxCountryName;
        private CheckBox cboxTitle;
        private PictureBox FlagPictureBox;
        private Label lblFlagNameDisplayer;
        private Label lblProgrammer;
        private Button btnExit;
    }
}
