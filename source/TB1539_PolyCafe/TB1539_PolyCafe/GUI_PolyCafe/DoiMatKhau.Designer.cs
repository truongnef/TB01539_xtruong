namespace GUI_PolyCafe
{
    partial class DoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMatKhauCu = new TextBox();
            txtXacNhanMK = new TextBox();
            txtMatKhauMoi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnHuy = new Button();
            btnDoiMatKhau = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 20);
            label1.Name = "label1";
            label1.Size = new Size(211, 38);
            label1.TabIndex = 0;
            label1.Text = "Quên Mật Khẩu";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(260, 91);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(355, 34);
            txtMatKhauCu.TabIndex = 1;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(260, 249);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(355, 34);
            txtXacNhanMK.TabIndex = 2;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(260, 171);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(355, 34);
            txtMatKhauMoi.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 94);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 174);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 252);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 7;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Location = new Point(137, 395);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(154, 41);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += button1_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.SteelBlue;
            btnDoiMatKhau.Location = new Point(389, 395);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(154, 41);
            btnDoiMatKhau.TabIndex = 9;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(699, 473);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(btnHuy);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
            Load += DoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMatKhauCu;
        private TextBox txtXacNhanMK;
        private TextBox txtMatKhauMoi;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnHuy;
        private Button btnDoiMatKhau;
    }
}