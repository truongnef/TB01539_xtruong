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
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            rdbHoatDong.Checked = true;
            pbHinhAnh.Image = null;
        }

        private void LoadLoaiSanPham()
        {

        }

        private void LoadDanhSachSanPham()
        {
            BUSSanPham bUSSanPham = new BUSSanPham();
            dgvDanhSachSP.DataSource = null;
            List<SanPham> lstSP = bUSSanPham.GetSanPhamList();
            dgvDanhSachSP.DataSource = lstSP;
        }
        private void btnThemSanPham_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachSP.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
            txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            txtLoaiSP.Text = row.Cells["MaLoai"].Value.ToString();
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rdbHoatDong.Checked = true;
            }
            else
            {
                rdbHoatDong.Checked = true;
            }
            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void frmSanPham_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10;
        }

    }
}
