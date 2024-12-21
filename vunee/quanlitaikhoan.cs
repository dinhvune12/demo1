using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp10.MonAn;

namespace WindowsFormsApp10
{
    public partial class quanlitaikhoan : DevExpress.XtraEditors.XtraForm
    {
        public quanlitaikhoan()
        {
            InitializeComponent();
        }

        private void quanlitaikhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.Columns.Add("TenTaiKhoan", "Tên tài khoản");
            dgvTaiKhoan.Columns.Add("MatKhau", "Mật khẩu");
            dgvTaiKhoan.Columns.Add("QuyenHan", "Quyền hạn");

            // Gắn quyền hạn vào ComboBox
            cbQuyenHan.Items.Add("Nhân viên");
            cbQuyenHan.Items.Add("Quản lý");
            cbQuyenHan.Items.Add("Nhân viên bếp");
            cbQuyenHan.Items.Add("Thu ngân");

            // Hiển thị danh sách tài khoản từ Program.DanhSachTaiKhoan
            foreach (var taiKhoan in Program.DanhSachTaiKhoan)
            {
                dgvTaiKhoan.Rows.Add(taiKhoan.TenTaiKhoan, taiKhoan.MatKhau, taiKhoan.QuyenHan);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text) ||
        string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
        cbQuyenHan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn quyền hạn!", "Thông báo");
                return;
            }

            // Tạo tài khoản mới
            var taiKhoanMoi = new TaiKhoan
            {
                TenTaiKhoan = txtTenTaiKhoan.Text,
                MatKhau = txtMatKhau.Text,
                QuyenHan = cbQuyenHan.SelectedItem.ToString()
            };

            // Thêm vào danh sách toàn cục
            Program.DanhSachTaiKhoan.Add(taiKhoanMoi);

            // Thêm vào DataGridView
            dgvTaiKhoan.Rows.Add(taiKhoanMoi.TenTaiKhoan, taiKhoanMoi.MatKhau, taiKhoanMoi.QuyenHan);

            MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
            ResetForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTaiKhoan.SelectedRows[0];

                // Mã xác nhận cố định
                string matKhauMacDinh = "vu123gfg";

                // Bước 1: Yêu cầu người dùng nhập mã xác nhận
                string enteredPassword = Microsoft.VisualBasic.Interaction.InputBox(
                    "Vui lòng nhập mã xác nhận:",
                    "Xác nhận mã",
                    ""
                );

                // So sánh mã xác nhận với mã cố định
                if (enteredPassword != matKhauMacDinh)
                {
                    MessageBox.Show("Mã xác nhận không đúng!", "Thông báo");
                    return;
                }

                // Bước 2: Yêu cầu nhập mật khẩu mới
                string newPassword = Microsoft.VisualBasic.Interaction.InputBox(
                    "Vui lòng nhập mật khẩu mới:",
                    "Đổi mật khẩu",
                    ""
                );

                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show("Mật khẩu mới không hợp lệ!", "Thông báo");
                    return;
                }

                // Bước 3: Cập nhật mật khẩu trong DataGridView và danh sách tài khoản
                selectedRow.Cells["MatKhau"].Value = newPassword;

                // Cập nhật vào danh sách tài khoản
                string tenTaiKhoan = selectedRow.Cells["TenTaiKhoan"].Value.ToString();
                var taiKhoan = Program.DanhSachTaiKhoan.FirstOrDefault(tk => tk.TenTaiKhoan == tenTaiKhoan);
                if (taiKhoan != null)
                {
                    taiKhoan.MatKhau = newPassword;
                }

                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Thông báo");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTaiKhoan.SelectedRows[0];
                string tenTaiKhoan = selectedRow.Cells["TenTaiKhoan"].Value.ToString();

                // Tìm và xóa tài khoản trong danh sách toàn cục
                var taiKhoan = Program.DanhSachTaiKhoan.FirstOrDefault(tk => tk.TenTaiKhoan == tenTaiKhoan);
                if (taiKhoan != null)
                {
                    Program.DanhSachTaiKhoan.Remove(taiKhoan);
                    dgvTaiKhoan.Rows.Remove(selectedRow);

                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo");
            }
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không phải header
            {
                DataGridViewRow selectedRow = dgvTaiKhoan.Rows[e.RowIndex];

                // Chỉ hiển thị thông tin tên tài khoản và quyền hạn
                txtTenTaiKhoan.Text = selectedRow.Cells["TenTaiKhoan"].Value?.ToString();
                cbQuyenHan.SelectedItem = selectedRow.Cells["QuyenHan"].Value?.ToString();

                // Không hiển thị trực tiếp mật khẩu
                txtMatKhau.Text = "******"; // Ẩn mật khẩu
            }
        }
        private void ThemDuLieuMau()
        {
            dgvTaiKhoan.Rows.Add("quanli", "quanline", "Quản lý");
            dgvTaiKhoan.Rows.Add("nhanvien", "nhanvienne", "Nhân viên");
            dgvTaiKhoan.Rows.Add("nhanvienbep", "nhanvienbepne", "Nhân viên bếp");
            dgvTaiKhoan.Rows.Add("thungan", "thunganne", "Thu ngân");
        }
        private void ResetForm()
        {
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
            cbQuyenHan.SelectedIndex = -1; // Reset ComboBox
        }
        
}
    }