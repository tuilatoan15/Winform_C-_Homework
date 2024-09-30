namespace TinhTong
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
            lblKetQua = new Label();
            lblA = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            lblB = new Label();
            btnTong = new Button();
            btnHieu = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblKetQua
            // 
            lblKetQua.BackColor = Color.FromArgb(4, 3, 240);
            lblKetQua.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.ForeColor = Color.FromArgb(241, 241, 22);
            lblKetQua.Location = new Point(3, 0);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(387, 74);
            lblKetQua.TabIndex = 0;
            lblKetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            lblA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblA.Location = new Point(26, 99);
            lblA.Name = "lblA";
            lblA.Size = new Size(122, 32);
            lblA.TabIndex = 1;
            lblA.Text = "Số nguyên a:";
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtA.Location = new Point(154, 99);
            txtA.Name = "txtA";
            txtA.Size = new Size(209, 29);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB.Location = new Point(154, 148);
            txtB.Name = "txtB";
            txtB.Size = new Size(209, 29);
            txtB.TabIndex = 4;
            // 
            // lblB
            // 
            lblB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblB.Location = new Point(26, 148);
            lblB.Name = "lblB";
            lblB.Size = new Size(122, 32);
            lblB.TabIndex = 3;
            lblB.Text = "Số nguyên b:";
            // 
            // btnTong
            // 
            btnTong.BackColor = Color.FromArgb(240, 133, 0);
            btnTong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTong.Location = new Point(79, 212);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(69, 37);
            btnTong.TabIndex = 5;
            btnTong.Text = "Tổng";
            btnTong.UseVisualStyleBackColor = false;
            btnTong.Click += btnTong_Click;
            // 
            // btnHieu
            // 
            btnHieu.BackColor = Color.FromArgb(145, 47, 194);
            btnHieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHieu.Location = new Point(178, 212);
            btnHieu.Name = "btnHieu";
            btnHieu.Size = new Size(69, 37);
            btnHieu.TabIndex = 6;
            btnHieu.Text = "Hiệu";
            btnHieu.UseVisualStyleBackColor = false;
            btnHieu.Click += btnHieu_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(221, 142, 114);
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(283, 212);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(69, 37);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(242, 18, 138);
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(178, 263);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(69, 37);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 242, 242);
            ClientSize = new Size(392, 328);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btnHieu);
            Controls.Add(btnTong);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Controls.Add(lblKetQua);
            ForeColor = Color.Black;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính tổng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKetQua;
        private Label lblA;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblB;
        private Button btnTong;
        private Button btnHieu;
        private Button btnReset;
        private Button btnThoat;
    }
}
