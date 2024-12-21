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
    public partial class time : DevExpress.XtraEditors.XtraForm
    {
        
        public time()
        {
            InitializeComponent();
        }

        public class LichLamViec
        {
            public string MaNhanVien { get; set; }
            public string TenNhanVien { get; set; }
            public DateTime Ngay { get; set; }
            public string Buoi { get; set; } // Sáng, Chiều, Tối
            public string CongViec { get; set; }
        }
        private List<LichLamViec> danhSachLichLamViec;

        private void KhoiTaoDanhSachLichLamViec()
        {
            danhSachLichLamViec = new List<LichLamViec>
    {
        new LichLamViec { MaNhanVien = "NV001", TenNhanVien = "Nguyễn Văn Vũ", Ngay = DateTime.Now.Date, Buoi = "Sáng", CongViec = "Chuẩn bị nguyên liệu" },
        new LichLamViec { MaNhanVien = "NV002", TenNhanVien = "Trần Thị BẢNH", Ngay = DateTime.Now.Date, Buoi = "Chiều", CongViec = "Tiếp nhận hàng" },
        new LichLamViec { MaNhanVien = "NV003", TenNhanVien = "Lê Văn CÔ", Ngay = DateTime.Now.Date, Buoi = "Tối", CongViec = "Dọn dẹp bếp" },
         new LichLamViec { MaNhanVien = "NV004", TenNhanVien = "Nguyễn Văn NGUỴET", Ngay = DateTime.Now.Date, Buoi = "Sáng", CongViec = "MÚA HIPHOP" },
        new LichLamViec { MaNhanVien = "NV007", TenNhanVien = "Trần Thị CHÓ", Ngay = DateTime.Now.Date, Buoi = "Chiều", CongViec = "ĐI DỌN RAC" },
        new LichLamViec { MaNhanVien = "NV008", TenNhanVien = "Lê Văn CÔ", Ngay = DateTime.Now.Date, Buoi = "Tối", CongViec = "NGHỈ" }
    };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfull timekeeping", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadDataToGrid()
        {
            // Tạo DataTable để hiển thị
            var dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Ngày");
            dt.Columns.Add("Buổi");
            dt.Columns.Add("Công việc");

            // Thêm dữ liệu từ danh sách vào DataTable
            foreach (var lich in danhSachLichLamViec)
            {
                dt.Rows.Add(lich.MaNhanVien, lich.TenNhanVien, lich.Ngay, lich.Buoi, lich.CongViec);
            }

            // Gán DataTable vào DataGridView
            dgvLichLamViec.DataSource = dt;
            dgvLichLamViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichLamViec.AllowUserToAddRows = false;
            dgvLichLamViec.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void time_Load(object sender, EventArgs e)
        {
            KhoiTaoDanhSachLichLamViec();
            LoadDataToGrid();
        }
            private void ClearInputFields()
            {
                txtMaNhanVien.Clear();
                txtTenNhanVien.Clear();
                txtCongViec.Clear();
                cbBuoi.SelectedIndex = -1;
            }

        private void dgvLichLamViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Ngày");
            dt.Columns.Add("Buổi");
            dt.Columns.Add("Công việc");

            foreach (var lich in danhSachLichLamViec)
            {
                dt.Rows.Add(lich.MaNhanVien, lich.TenNhanVien, lich.Ngay.ToString("dd/MM/yyyy"), lich.Buoi, lich.CongViec);
            }

            dgvLichLamViec.DataSource = dt;
            dgvLichLamViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichLamViec.AllowUserToAddRows = false;
            dgvLichLamViec.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text.Trim();
            string tenNV = txtTenNhanVien.Text.Trim();
            DateTime ngay = dtpNgayLam.Value.Date;
            string buoi = cbBuoi.SelectedItem?.ToString();
            string congViec = txtCongViec.Text.Trim();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(buoi) || string.IsNullOrEmpty(congViec))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            danhSachLichLamViec.Add(new LichLamViec { MaNhanVien = maNV, TenNhanVien = tenNV, Ngay = ngay, Buoi = buoi, CongViec = congViec });
            MessageBox.Show("Thêm lịch làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadDataToGrid();
            ClearInputFields();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLichLamViec.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = dgvLichLamViec.CurrentRow.Cells[0].Value.ToString();
            var lich = danhSachLichLamViec.FirstOrDefault(l => l.MaNhanVien == maNV);

            if (lich != null)
            {
                lich.TenNhanVien = txtTenNhanVien.Text.Trim();
                lich.Ngay = dtpNgayLam.Value.Date;
                lich.Buoi = cbBuoi.SelectedItem?.ToString();
                lich.CongViec = txtCongViec.Text.Trim();

                MessageBox.Show("Sửa lịch làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToGrid();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLichLamViec.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = dgvLichLamViec.CurrentRow.Cells[0].Value.ToString();
            var lich = danhSachLichLamViec.FirstOrDefault(l => l.MaNhanVien == maNV);

            if (lich != null)
            {
                danhSachLichLamViec.Remove(lich);
                MessageBox.Show("Xóa lịch làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToGrid();
            }
        }
    }
}