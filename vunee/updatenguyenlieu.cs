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

namespace WindowsFormsApp10
{
    public partial class updatenguyenlieu : DevExpress.XtraEditors.XtraForm
    {
        private List<NguyenLieu> danhSachNguyenLieu;
        public updatenguyenlieu()
        {
            InitializeComponent();
            KhoiTaoDanhSachNguyenLieu();
            LoadNguyenLieuToGrid();
        }
        private void KhoiTaoDanhSachNguyenLieu()
        {
            danhSachNguyenLieu = new List<NguyenLieu>
            {
                new NguyenLieu { TenNguyenLieu = "Gạo", SoLuong = 50, TrangThai = "Đầy đủ" },
                new NguyenLieu { TenNguyenLieu = "Thịt bò", SoLuong = 10, TrangThai = "Thiếu" },
                new NguyenLieu { TenNguyenLieu = "Rau xà lách", SoLuong = 20, TrangThai = "Đầy đủ" },
                new NguyenLieu { TenNguyenLieu = "Cà chua", SoLuong = 15, TrangThai = "Thiếu" },
                new NguyenLieu { TenNguyenLieu = "Nước mắm", SoLuong = 5, TrangThai = "Thiếu" }
            };
        }
        private void LoadNguyenLieuToGrid()
        {
            var dt = new DataTable();
            dt.Columns.Add("Tên nguyên liệu");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Trạng thái");

            foreach (var nguyenLieu in danhSachNguyenLieu)
            {
                dt.Rows.Add(nguyenLieu.TenNguyenLieu, nguyenLieu.SoLuong, nguyenLieu.TrangThai);
            }

            dgvNguyenLieu.DataSource = dt;
            dgvNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguyenLieu.AllowUserToAddRows = false;
            dgvNguyenLieu.ReadOnly = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenNguyenLieu = dgvNguyenLieu.CurrentRow.Cells[0].Value.ToString();

            var nguyenLieu = danhSachNguyenLieu.FirstOrDefault(nl => nl.TenNguyenLieu == tenNguyenLieu);
            if (nguyenLieu != null)
            {
                danhSachNguyenLieu.Remove(nguyenLieu);
                MessageBox.Show($"Nguyên liệu '{tenNguyenLieu}' đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNguyenLieuToGrid();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatenguyenlieu_Load(object sender, EventArgs e)
        {

        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            string tenNguyenLieu = txtTenNguyenLieu.Text.Trim();
            if (string.IsNullOrEmpty(tenNguyenLieu))
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (danhSachNguyenLieu.Any(nl => nl.TenNguyenLieu.Equals(tenNguyenLieu, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Nguyên liệu đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) && soLuong >= 0)
            {
                string trangThai = soLuong > 0 ? "Đầy đủ" : "Thiếu";
                danhSachNguyenLieu.Add(new NguyenLieu { TenNguyenLieu = tenNguyenLieu, SoLuong = soLuong, TrangThai = trangThai });
                MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadNguyenLieuToGrid();
                txtTenNguyenLieu.Clear();
                txtSoLuong.Clear();
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatNguyenLieu_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tên nguyên liệu từ dòng được chọn
            string tenNguyenLieu = dgvNguyenLieu.CurrentRow.Cells["Tên nguyên liệu"].Value.ToString();

            // Tìm nguyên liệu trong danh sách theo tên
            var nguyenLieu = danhSachNguyenLieu.FirstOrDefault(nl => nl.TenNguyenLieu == tenNguyenLieu);
            if (nguyenLieu != null)
            {
                // Kiểm tra số lượng nhập vào từ TextBox
                if (int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) && soLuong >= 0)
                {
                    nguyenLieu.SoLuong = soLuong; // Cập nhật số lượng
                    nguyenLieu.TrangThai = soLuong > 0 ? "Đầy đủ" : "Thiếu"; // Cập nhật trạng thái

                    MessageBox.Show($"Nguyên liệu '{tenNguyenLieu}' đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại DataGridView
                    LoadNguyenLieuToGrid();

                    // Xóa thông tin nhập
                    txtTenNguyenLieu.Clear();
                    txtSoLuong.Clear();
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ! Vui lòng nhập số nguyên không âm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nguyên liệu không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public class NguyenLieu
        {
            public string TenNguyenLieu { get; set; }
            public int SoLuong { get; set; }
            public string TrangThai { get; set; }
        }
    }
}