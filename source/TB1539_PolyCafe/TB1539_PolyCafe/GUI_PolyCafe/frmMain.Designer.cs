namespace GUI_PolyCafe
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            loạiSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            bánHàngToolStripMenuItem = new ToolStripMenuItem();
            thẻLưuĐộngToolStripMenuItem = new ToolStripMenuItem();
            phiếuBánHàngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            pnMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.NavajoWhite;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, bánHàngToolStripMenuItem, nhânViênToolStripMenuItem, kháchHàngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.NavajoWhite;
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(224, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.BackColor = Color.NavajoWhite;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click_1;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.BackColor = Color.NavajoWhite;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.BackColor = Color.NavajoWhite;
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loạiSảnPhẩmToolStripMenuItem, sảnPhẩmToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            loạiSảnPhẩmToolStripMenuItem.BackColor = Color.NavajoWhite;
            loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            loạiSảnPhẩmToolStripMenuItem.Size = new Size(188, 26);
            loạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm";
            loạiSảnPhẩmToolStripMenuItem.Click += loạiSảnPhẩmToolStripMenuItem_Click;
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.BackColor = Color.NavajoWhite;
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(188, 26);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // bánHàngToolStripMenuItem
            // 
            bánHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thẻLưuĐộngToolStripMenuItem, phiếuBánHàngToolStripMenuItem });
            bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            bánHàngToolStripMenuItem.Size = new Size(85, 24);
            bánHàngToolStripMenuItem.Text = "Bán hàng";
            // 
            // thẻLưuĐộngToolStripMenuItem
            // 
            thẻLưuĐộngToolStripMenuItem.BackColor = Color.NavajoWhite;
            thẻLưuĐộngToolStripMenuItem.Name = "thẻLưuĐộngToolStripMenuItem";
            thẻLưuĐộngToolStripMenuItem.Size = new Size(194, 26);
            thẻLưuĐộngToolStripMenuItem.Text = "Thẻ lưu động ";
            thẻLưuĐộngToolStripMenuItem.Click += thẻLưuĐộngToolStripMenuItem_Click;
            // 
            // phiếuBánHàngToolStripMenuItem
            // 
            phiếuBánHàngToolStripMenuItem.BackColor = Color.NavajoWhite;
            phiếuBánHàngToolStripMenuItem.Name = "phiếuBánHàngToolStripMenuItem";
            phiếuBánHàngToolStripMenuItem.Size = new Size(194, 26);
            phiếuBánHàngToolStripMenuItem.Text = "Phiếu bán hàng";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(89, 24);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(100, 24);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.PeachPuff;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnMain.Location = new Point(0, 28);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1182, 685);
            pnMain.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(1182, 713);
            Controls.Add(pnMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem bánHàngToolStripMenuItem;
        private ToolStripMenuItem thẻLưuĐộngToolStripMenuItem;
        private ToolStripMenuItem phiếuBánHàngToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private Panel pnMain;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
    }
}