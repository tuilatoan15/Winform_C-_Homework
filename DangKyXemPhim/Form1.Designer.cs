namespace DangKyXemPhim
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnDangKy = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblNgayDangKy = new Label();
            txbTuoi = new TextBox();
            lblTuoi = new Label();
            txbPhone = new TextBox();
            lblPhone = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDangKy);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(lblNgayDangKy);
            groupBox1.Controls.Add(txbTuoi);
            groupBox1.Controls.Add(lblTuoi);
            groupBox1.Controls.Add(txbPhone);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 225);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng ký";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(224, 224, 222);
            btnDangKy.BackgroundImageLayout = ImageLayout.Zoom;
            btnDangKy.ImageAlign = ContentAlignment.BottomLeft;
            btnDangKy.Location = new Point(169, 174);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(121, 31);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(143, 121);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 25);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.Location = new Point(31, 124);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(103, 22);
            lblNgayDangKy.TabIndex = 5;
            lblNgayDangKy.Text = "Ngày đăng ký :";
            // 
            // txbTuoi
            // 
            txbTuoi.BorderStyle = BorderStyle.FixedSingle;
            txbTuoi.Location = new Point(143, 72);
            txbTuoi.Name = "txbTuoi";
            txbTuoi.Size = new Size(282, 25);
            txbTuoi.TabIndex = 4;
            // 
            // lblTuoi
            // 
            lblTuoi.Location = new Point(31, 72);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(81, 22);
            lblTuoi.TabIndex = 2;
            lblTuoi.Text = "Tuổi :";
            // 
            // txbPhone
            // 
            txbPhone.BackColor = SystemColors.Window;
            txbPhone.BorderStyle = BorderStyle.FixedSingle;
            txbPhone.Location = new Point(143, 27);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(282, 25);
            txbPhone.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(31, 30);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(81, 22);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 255, 255);
            ClientSize = new Size(488, 249);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký xem phim";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDangKy;
        private DateTimePicker dateTimePicker1;
        private Label lblNgayDangKy;
        private TextBox txbTuoi;
        private Label lblTuoi;
        private TextBox txbPhone;
        private Label lblPhone;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}
