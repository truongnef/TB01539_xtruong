using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DTO_PolyCafe;


namespace GUI_PolyCafe
{
    public partial class frmTheLuuDong : Form
    {
        public frmTheLuuDong()
        {
            InitializeComponent();
        }

        private void frmTheLuuDong_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachThe();
        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
            rdbHoatDong.Checked = true;
        }

        private void LoadDanhSachThe()
        {
            BUSTheLuuDong bUSTheLuuDong = new BUSTheLuuDong();
            dgvDanhSachTLD.DataSource = null;
            dgvDanhSachTLD.DataSource = bUSTheLuuDong.GetTheLuuDongList();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
