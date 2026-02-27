namespace winflag
{
    public partial class ViewerFrame : Form
    {
        public ViewerFrame()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPh.Checked)
            {
                FlagPictureBox.Image = Image.FromFile("Images/ph.jpg");
                FlagPictureBox.Visible = true;
                lblFlagNameDisplayer.Text = "Philippines";
            }
        }

        private void gboxDisplay_Enter(object sender, EventArgs e)
        {

        }

        private void lblFlagNameDisplayer_Click(object sender, EventArgs e)
        {

        }

        private void rbtnSwitz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSwitz.Checked)
            {
                FlagPictureBox.Image = Image.FromFile("Images/swiss.jpg");
                FlagPictureBox.Visible = true;
                lblFlagNameDisplayer.Text = "Switzerland";
            }
        }

        private void rbtnGreece_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGreece.Checked)
            {
                FlagPictureBox.Image = Image.FromFile("Images/greece.jpg");
                FlagPictureBox.Visible = true;
                lblFlagNameDisplayer.Text = "Greece";
            }
        }

        private void rbtnFrance_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFrance.Checked)
            {
                FlagPictureBox.Image = Image.FromFile("Images/france.jpg");
                FlagPictureBox.Visible = true;
                lblFlagNameDisplayer.Text = "France";
            }

        }

        private void cboxTitle_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = cboxTitle.Checked ? "Viewer" : "";
        }

        private void cboxCountryName_CheckedChanged(object sender, EventArgs e)
        {
            lblFlagNameDisplayer.Visible = cboxCountryName.Checked;
        }

        private void cboxProgrammer_CheckedChanged(object sender, EventArgs e)
        {
            lblProgrammer.Visible = cboxProgrammer.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
