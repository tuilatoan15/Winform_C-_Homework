namespace DinhDang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void UpdateFontStyle()
        {
            FontStyle style = FontStyle.Regular;

            if (cbBold.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (cbItalic.Checked)
            {
                style |= FontStyle.Italic;
            }
            if (cbUnderline.Checked)
            {
                style |= FontStyle.Underline;
            }

            lblOutPut.Font = new Font(lblOutPut.Font, style);
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                lblOutPut.ForeColor = Color.Red;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                lblOutPut.ForeColor = Color.Green;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                lblOutPut.ForeColor = Color.Blue;
            }
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
            {
                lblOutPut.ForeColor = Color.Black;
            }
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblOutPut.Text = txtInput.Text;
        }
    }
}
