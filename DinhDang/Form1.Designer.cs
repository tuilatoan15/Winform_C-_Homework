namespace DinhDang
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
            lblInput = new Label();
            txtInput = new TextBox();
            RadioButton = new GroupBox();
            rbBlack = new RadioButton();
            rbBlue = new RadioButton();
            rbGreen = new RadioButton();
            rbRed = new RadioButton();
            Checkbox = new GroupBox();
            cbUnderline = new CheckBox();
            cbItalic = new CheckBox();
            cbBold = new CheckBox();
            lblHienThi = new Label();
            lblOutPut = new Label();
            lblThoat = new Button();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            panel2 = new Panel();
            RadioButton.SuspendLayout();
            Checkbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInput.Location = new Point(29, 13);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(56, 23);
            lblInput.TabIndex = 0;
            lblInput.Text = "Input";
            // 
            // txtInput
            // 
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(100, 11);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(280, 29);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // RadioButton
            // 
            RadioButton.BackColor = Color.FromArgb(192, 255, 192);
            RadioButton.Controls.Add(rbBlack);
            RadioButton.Controls.Add(rbBlue);
            RadioButton.Controls.Add(rbGreen);
            RadioButton.Controls.Add(rbRed);
            RadioButton.ForeColor = SystemColors.ControlText;
            RadioButton.Location = new Point(10, 3);
            RadioButton.Name = "RadioButton";
            RadioButton.Size = new Size(174, 151);
            RadioButton.TabIndex = 2;
            RadioButton.TabStop = false;
            RadioButton.Text = "Color";
            // 
            // rbBlack
            // 
            rbBlack.AutoSize = true;
            rbBlack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbBlack.ForeColor = Color.Black;
            rbBlack.Location = new Point(26, 104);
            rbBlack.Name = "rbBlack";
            rbBlack.Size = new Size(58, 21);
            rbBlack.TabIndex = 3;
            rbBlack.TabStop = true;
            rbBlack.Text = "Black";
            rbBlack.UseVisualStyleBackColor = true;
            rbBlack.CheckedChanged += rbBlack_CheckedChanged;
            // 
            // rbBlue
            // 
            rbBlue.AutoSize = true;
            rbBlue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbBlue.ForeColor = Color.Blue;
            rbBlue.Location = new Point(26, 76);
            rbBlue.Name = "rbBlue";
            rbBlue.Size = new Size(53, 21);
            rbBlue.TabIndex = 2;
            rbBlue.TabStop = true;
            rbBlue.Text = "Blue";
            rbBlue.UseVisualStyleBackColor = true;
            rbBlue.CheckedChanged += rbBlue_CheckedChanged;
            // 
            // rbGreen
            // 
            rbGreen.AutoSize = true;
            rbGreen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbGreen.ForeColor = Color.Green;
            rbGreen.Location = new Point(26, 49);
            rbGreen.Name = "rbGreen";
            rbGreen.Size = new Size(62, 21);
            rbGreen.TabIndex = 1;
            rbGreen.TabStop = true;
            rbGreen.Text = "Green";
            rbGreen.UseVisualStyleBackColor = true;
            rbGreen.CheckedChanged += rbGreen_CheckedChanged;
            // 
            // rbRed
            // 
            rbRed.AutoSize = true;
            rbRed.BackColor = Color.FromArgb(192, 255, 192);
            rbRed.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbRed.ForeColor = Color.Red;
            rbRed.Location = new Point(26, 22);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(49, 21);
            rbRed.TabIndex = 0;
            rbRed.TabStop = true;
            rbRed.Text = "Red";
            rbRed.UseVisualStyleBackColor = false;
            rbRed.CheckedChanged += rbRed_CheckedChanged;
            // 
            // Checkbox
            // 
            Checkbox.BackColor = Color.FromArgb(255, 192, 125);
            Checkbox.Controls.Add(cbUnderline);
            Checkbox.Controls.Add(cbItalic);
            Checkbox.Controls.Add(cbBold);
            Checkbox.Location = new Point(8, 3);
            Checkbox.Name = "Checkbox";
            Checkbox.Size = new Size(197, 151);
            Checkbox.TabIndex = 3;
            Checkbox.TabStop = false;
            Checkbox.Text = "Font chữ";
            // 
            // cbUnderline
            // 
            cbUnderline.AutoSize = true;
            cbUnderline.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            cbUnderline.Location = new Point(23, 107);
            cbUnderline.Name = "cbUnderline";
            cbUnderline.Size = new Size(155, 21);
            cbUnderline.TabIndex = 2;
            cbUnderline.Text = "Gạch chân (undeeline)";
            cbUnderline.UseVisualStyleBackColor = true;
            cbUnderline.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // cbItalic
            // 
            cbItalic.AutoSize = true;
            cbItalic.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cbItalic.Location = new Point(23, 63);
            cbItalic.Name = "cbItalic";
            cbItalic.Size = new Size(123, 21);
            cbItalic.TabIndex = 1;
            cbItalic.Text = "In nghiêng (Italic)";
            cbItalic.UseVisualStyleBackColor = true;
            cbItalic.CheckedChanged += cbItalic_CheckedChanged;
            // 
            // cbBold
            // 
            cbBold.AutoSize = true;
            cbBold.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbBold.Location = new Point(23, 23);
            cbBold.Name = "cbBold";
            cbBold.Size = new Size(112, 21);
            cbBold.TabIndex = 0;
            cbBold.Text = "In đậm (Bold)";
            cbBold.UseVisualStyleBackColor = true;
            cbBold.CheckedChanged += cbBold_CheckedChanged;
            // 
            // lblHienThi
            // 
            lblHienThi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHienThi.Location = new Point(7, 16);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(77, 34);
            lblHienThi.TabIndex = 4;
            lblHienThi.Text = "Hiển thị";
            // 
            // lblOutPut
            // 
            lblOutPut.BorderStyle = BorderStyle.FixedSingle;
            lblOutPut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutPut.Location = new Point(90, 16);
            lblOutPut.Name = "lblOutPut";
            lblOutPut.Size = new Size(256, 34);
            lblOutPut.TabIndex = 5;
            // 
            // lblThoat
            // 
            lblThoat.BackColor = Color.FromArgb(224, 224, 224);
            lblThoat.Location = new Point(352, 16);
            lblThoat.Name = "lblThoat";
            lblThoat.Size = new Size(81, 34);
            lblThoat.TabIndex = 6;
            lblThoat.Text = "Thoát";
            lblThoat.UseVisualStyleBackColor = false;
            lblThoat.Click += lblThoat_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(24, 66);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(RadioButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Checkbox);
            splitContainer1.Size = new Size(417, 164);
            splitContainer1.SplitterDistance = 205;
            splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtInput);
            panel1.Controls.Add(lblInput);
            panel1.Location = new Point(24, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 50);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblThoat);
            panel2.Controls.Add(lblOutPut);
            panel2.Controls.Add(lblHienThi);
            panel2.Location = new Point(5, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 59);
            panel2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(465, 299);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Định dạng";
            RadioButton.ResumeLayout(false);
            RadioButton.PerformLayout();
            Checkbox.ResumeLayout(false);
            Checkbox.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private GroupBox RadioButton;
        private RadioButton rbBlack;
        private RadioButton rbBlue;
        private RadioButton rbGreen;
        private RadioButton rbRed;
        private GroupBox Checkbox;
        private CheckBox cbUnderline;
        private CheckBox cbItalic;
        private CheckBox cbBold;
        private Label lblHienThi;
        private Label lblOutPut;
        private Button lblThoat;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel panel2;
    }
}
