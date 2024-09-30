namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double soThuNhat, soThuHai, ketQua = 0;

            if (double.TryParse(txbFirstNum.Text, out soThuNhat) && double.TryParse(txbSecondNum.Text, out soThuHai))
            {
                if (cbPhepToan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phép toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string phepToan = cbPhepToan.SelectedItem.ToString();

                switch (phepToan)
                {
                    case "Cộng":
                        ketQua = soThuNhat + soThuHai;
                        break;
                    case "Trừ":
                        ketQua = soThuNhat - soThuHai;
                        break;
                    case "Nhân":
                        ketQua = soThuNhat * soThuHai;
                        break;
                    case "Chia":
                        if (soThuHai != 0)
                            ketQua = soThuNhat / soThuHai;
                        else
                            MessageBox.Show("Không thể chia cho 0");
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn phép toán.");
                        break;
                }

                lblKetQua.Text = ketQua.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }
    }
}
