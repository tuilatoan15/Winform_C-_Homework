namespace ComboBox
{
    partial class Form1
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
            lblSoThuNhat = new Label();
            lblSoThuHai = new Label();
            txbFirstNum = new TextBox();
            txbSecondNum = new TextBox();
            lblPhepTinh = new Label();
            cbPhepToan = new System.Windows.Forms.ComboBox();
            lblKetQua = new Label();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // lblSoThuNhat
            // 
            lblSoThuNhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoThuNhat.Location = new Point(23, 32);
            lblSoThuNhat.Name = "lblSoThuNhat";
            lblSoThuNhat.Size = new Size(118, 35);
            lblSoThuNhat.TabIndex = 0;
            lblSoThuNhat.Text = "Số thứ nhất";
            // 
            // lblSoThuHai
            // 
            lblSoThuHai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoThuHai.Location = new Point(23, 88);
            lblSoThuHai.Name = "lblSoThuHai";
            lblSoThuHai.Size = new Size(139, 35);
            lblSoThuHai.TabIndex = 1;
            lblSoThuHai.Text = "Số thứ hai";
            // 
            // txbFirstNum
            // 
            txbFirstNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFirstNum.Location = new Point(172, 31);
            txbFirstNum.Name = "txbFirstNum";
            txbFirstNum.Size = new Size(175, 29);
            txbFirstNum.TabIndex = 2;
            // 
            // txbSecondNum
            // 
            txbSecondNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSecondNum.Location = new Point(172, 85);
            txbSecondNum.Name = "txbSecondNum";
            txbSecondNum.Size = new Size(175, 29);
            txbSecondNum.TabIndex = 3;
            // 
            // lblPhepTinh
            // 
            lblPhepTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhepTinh.Location = new Point(23, 151);
            lblPhepTinh.Name = "lblPhepTinh";
            lblPhepTinh.Size = new Size(139, 35);
            lblPhepTinh.TabIndex = 4;
            lblPhepTinh.Text = "Phép tính";
            // 
            // cbPhepToan
            // 
            cbPhepToan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPhepToan.FormattingEnabled = true;
            cbPhepToan.Items.AddRange(new object[] { "Cộng", "Trừ", "Nhân", "Chia" });
            cbPhepToan.Location = new Point(172, 151);
            cbPhepToan.Name = "cbPhepToan";
            cbPhepToan.Size = new Size(175, 29);
            cbPhepToan.TabIndex = 5;
            // 
            // lblKetQua
            // 
            lblKetQua.BackColor = Color.Blue;
            lblKetQua.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.ForeColor = Color.FromArgb(255, 255, 128);
            lblKetQua.Location = new Point(23, 269);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(324, 47);
            lblKetQua.TabIndex = 6;
            lblKetQua.Text = "0";
            lblKetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.FromArgb(255, 128, 128);
            btnTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinh.Location = new Point(129, 217);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(104, 33);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += btnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(374, 325);
            Controls.Add(btnTinh);
            Controls.Add(lblKetQua);
            Controls.Add(cbPhepToan);
            Controls.Add(lblPhepTinh);
            Controls.Add(txbSecondNum);
            Controls.Add(txbFirstNum);
            Controls.Add(lblSoThuHai);
            Controls.Add(lblSoThuNhat);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComboBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoThuNhat;
        private Label lblSoThuHai;
        private TextBox txbFirstNum;
        private TextBox txbSecondNum;
        private Label lblPhepTinh;
        private System.Windows.Forms.ComboBox cbPhepToan;
        private Label lblKetQua;
        private Button btnTinh;
    }
}
