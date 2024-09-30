using System.Windows.Forms;

namespace DangKyXemPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();

            if (string.IsNullOrEmpty(txbPhone.Text) || !long.TryParse(txbPhone.Text, out _))
            {
                if (string.IsNullOrEmpty(txbPhone.Text))
                {
                    errorProvider1.SetError(txbPhone, "Số điện thoại không được để trống!");
                }
                else if (!long.TryParse(txbPhone.Text, out _))
                {
                    errorProvider1.SetError(txbPhone, "Số điện thoại phải là số!");
                }
                
            }
            else
            {
                errorProvider1.SetError(txbPhone, null);
            }

            if (string.IsNullOrEmpty(txbTuoi.Text))
            {
                errorProvider2.SetError(txbTuoi, "Tuổi không được để trống!");
            }
            else
            {
                int tuoi = Convert.ToInt32(txbTuoi.Text);
                if (tuoi <= 17)
                {
                    errorProvider2.SetError(txbTuoi, "Tuổi phải lớn hơn 17!");
                }
                else
                {
                    errorProvider2.SetError(txbTuoi, null);
                }
            }

            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday)
            {
                errorProvider3.SetError(dateTimePicker1, "Ngày đăng ký không được là thứ 2!");
            }
            else
            {
                errorProvider3.SetError(dateTimePicker1, null);
            }

            if (errorProvider1.GetError(txbPhone) == "" && errorProvider2.GetError(txbTuoi) == "" && errorProvider3.GetError(dateTimePicker1) == "")
            {
                MessageBox.Show("Bạn đã đăng ký thành công, chúng tôi sẽ liên hệ với bạn");
            }
        }
    }
}
