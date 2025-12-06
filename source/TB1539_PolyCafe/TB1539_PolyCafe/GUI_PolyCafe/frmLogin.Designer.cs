namespace GUI_PolyCafe
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            label2 = new Label();
            chkHienThiMK = new CheckBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(629, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(629, 265);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // chkHienThiMK
            // 
            chkHienThiMK.AutoSize = true;
            chkHienThiMK.Location = new Point(629, 403);
            chkHienThiMK.Name = "chkHienThiMK";
            chkHienThiMK.Size = new Size(188, 32);
            chkHienThiMK.TabIndex = 2;
            chkHienThiMK.Text = "Hiển thị mật khẩu";
            chkHienThiMK.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SteelBlue;
            btnDangNhap.Location = new Point(540, 530);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(250, 51);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập ";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Location = new Point(862, 530);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(250, 51);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(629, 176);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(391, 34);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(629, 328);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(391, 34);
            txtMatKhau.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 498);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1178, 686);
            Controls.Add(pictureBox1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(chkHienThiMK);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox chkHienThiMK;
        private Button btnDangNhap;
        private Button btnThoat;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private PictureBox pictureBox1;
    }
}