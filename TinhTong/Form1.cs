namespace TinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                lblKetQua.Text = (a + b).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.");
            }
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                lblKetQua.Text = (a - b).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lblKetQua.Text = "";
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
