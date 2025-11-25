using BLL_PolyCafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

        private void LoadDanhSachNhanVien()
        {
            BUSNhanVien busNhanVien = new BUSNhanVien();
            dgvDanhSachNV.DataSource = null;
            dgvDanhSachNV.DataSource = busNhanVien.GetAllNhanVienlist();

            dgvDanhSachNV.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvDanhSachNV.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvDanhSachNV.Columns["Email"].HeaderText = "Email";
            dgvDanhSachNV.Columns["MatKhau"].HeaderText = "MatKhau";
            dgvDanhSachNV.Columns["VaiTro"].Visible = false;
            dgvDanhSachNV.Columns["TrangThai"].Visible = false;
            dgvDanhSachNV.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            dgvDanhSachNV.Columns["VaiTroText"].HeaderText = "Vai Trò";
        }

        private void ClearForm()
        {
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            rdbQuanLy.Checked = false;
            rdbNhanVien.Checked = true;
            rdbHoatDong.Checked = false;
            rdbTamNgung.Checked = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
        }
    }
}
