using BLL_PolyCafe;
using DTO_PolyCafe;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            bool vaiTro;

            if (rdbNhanVien.Checked)
            {
                vaiTro = false;
            }
            else
            {
                vaiTro = true;
            }
            bool trangThai;

            if (rdbHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            //if (!matKhau.Equals(matKhau))
            //{
            //    MessageBox.Show("Xác nhận mật khẩu không khớp.");
            //    return;
            //}
            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                HoTen = hoTen,
                Email = email,
                MatKhau = matKhau,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUSNhanVien bus = new BUSNhanVien();
            string result = bus.InsertNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void dgvDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachNV.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();

            bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
            if (vaiTro == false)
            {
                rdbNhanVien.Checked = true;
            }
            else
            {
                rdbQuanLy.Checked = true;
            }

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai == false)
            {
                rdbHoatDong.Checked = true;
            }
            else
            {
                rdbTamNgung.Checked = true;
            }

            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // Tắt chỉnh sửa mã nhân viên
            txtMaNhanVien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            bool vaiTro;

            if (rdbQuanLy.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (rdbTamNgung.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            //if (!matKhau.Equals(xacNhanMK))
            //{
            //    MessageBox.Show("Xác nhận mật khẩu không khớp.");
            //    return;
            //}
            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                HoTen = hoTen,
                Email = email,
                MatKhau = matKhau,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUSNhanVien bus = new BUSNhanVien();
            string result = bus.UpdateNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text.Trim();
            string name = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(maNhanVien))
            {
                if (dgvDanhSachNV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDanhSachNV.SelectedRows[0];
                    maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
                    name = selectedRow.Cells["HoTen"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maNhanVien} - {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSNhanVien bus = new BUSNhanVien();
                string kq = bus.DeleteNhanVien(maNhanVien);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {maNhanVien} - {name} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
