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
    public partial class xacnhanmonan : DevExpress.XtraEditors.XtraForm
    {
        private List<MonAn> danhSachMonAn;

        public xacnhanmonan()
        {
            InitializeComponent();
          
        }
        private void KhoiTaoDanhSachMonAn()
        {
            danhSachMonAn = new List<MonAn>
    {
        new MonAn { TenMonAn = "Phở bò", SoLuong = 2, TrangThai = "Chưa xác nhận" },
        new MonAn { TenMonAn = "Bún chả", SoLuong = 1, TrangThai = "Chưa xác nhận" },
        new MonAn { TenMonAn = "Cơm tấm", SoLuong = 3, TrangThai = "Chưa xác nhận" }
    };
        }
        private void LoadMonAnToGrid()
        {
            var dt = new DataTable();
            dt.Columns.Add("Tên món ăn");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Trạng thái");

            foreach (var monAn in danhSachMonAn)
            {
                dt.Rows.Add(monAn.TenMonAn, monAn.SoLuong, monAn.TrangThai);
            }

            dgvMonAn.DataSource = dt;
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonAn.AllowUserToAddRows = false;
            dgvMonAn.ReadOnly = true;
        }
        private void xacnhanmonan_Load(object sender, EventArgs e)
        {
            KhoiTaoDanhSachMonAn();
            LoadMonAnToGrid();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tên món ăn từ dòng được chọn
            string tenMonAn = dgvMonAn.CurrentRow.Cells[0].Value.ToString();

            var monAn = danhSachMonAn.FirstOrDefault(ma => ma.TenMonAn == tenMonAn);
            if (monAn != null && monAn.TrangThai == "Chưa xác nhận")
            {
                monAn.TrangThai = "Đã xác nhận";
                MessageBox.Show($"Món ăn '{tenMonAn}' đã được xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMonAnToGrid(); // Cập nhật lại danh sách
            }
            else
            {
                MessageBox.Show($"Món ăn '{tenMonAn}' đã được xác nhận trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadMonAnToGrid();
        }
        public class MonAn
        {
            public string TenMonAn { get; set; }
            public int SoLuong { get; set; }
            public string TrangThai { get; set; } // Trạng thái: "Chưa xác nhận", "Đã xác nhận"
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            if (dgvMonAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tên món ăn từ dòng được chọn
            string tenMonAn = dgvMonAn.CurrentRow.Cells[0].Value.ToString();

            var monAn = danhSachMonAn.FirstOrDefault(ma => ma.TenMonAn == tenMonAn);
            if (monAn != null && monAn.TrangThai == "Chưa xác nhận")
            {
                monAn.TrangThai = "Đã xác nhận";
                MessageBox.Show($"Món ăn '{tenMonAn}' đã được xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMonAnToGrid(); // Cập nhật lại danh sách
            }
            else
            {
                MessageBox.Show($"Món ăn '{tenMonAn}' đã được xác nhận trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTaiLai_Click_1(object sender, EventArgs e)
        {
            danhSachMonAn = new List<MonAn>
            {
                new MonAn { TenMonAn = "Hủ tiếu", SoLuong = 1, TrangThai = "Chưa xác nhận" },
                new MonAn { TenMonAn = "Bánh mì", SoLuong = 4, TrangThai = "Chưa xác nhận" },
                new MonAn { TenMonAn = "Bia", SoLuong = 2, TrangThai = "Chưa xác nhận" },
                new MonAn { TenMonAn = "Cơm mẹ nấu", SoLuong = 5, TrangThai = "Chưa xác nhận" }
            };

            // Hiển thị danh sách mới lên giao diện
            LoadMonAnToGrid();
            MessageBox.Show("Danh sách món ăn đã được tải lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}

