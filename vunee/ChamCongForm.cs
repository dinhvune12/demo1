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
    public partial class ChamCongForm : DevExpress.XtraEditors.XtraForm
    {
        private List<NhanVien> danhSachNhanVien; // Danh sách nhân viên
        private DataTable lichSuChamCong; // L
        public ChamCongForm()
        {
            InitializeComponent();
        }
        private void KhoiTaoDanhSachNhanVien()
        {
            danhSachNhanVien = new List<NhanVien>
            {
                new NhanVien { MaNhanVien = "123", TenNhanVien = "Vũ Nè" },
                new NhanVien { MaNhanVien = "456", TenNhanVien = "Ai Đó" },
                new NhanVien { MaNhanVien = "789", TenNhanVien = "Vũ Chứ Ai" },
                new NhanVien { MaNhanVien = "012", TenNhanVien = "Ồ Wao" }
            };
        }

        private void KhoiTaoLichSuChamCong()
        {
            lichSuChamCong = new DataTable();
            lichSuChamCong.Columns.Add("MaNhanVien", typeof(string));
            lichSuChamCong.Columns.Add("TenNhanVien", typeof(string));
            lichSuChamCong.Columns.Add("ThoiGian", typeof(string));
        }
        private void LoadLichSuChamCong()
        {
            dgvLichSuChamCong.DataSource = lichSuChamCong;
            dgvLichSuChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSuChamCong.AllowUserToAddRows = false;
            dgvLichSuChamCong.ReadOnly = true;
        }
        private void ChamCongForm_Load(object sender, EventArgs e)
        {
            KhoiTaoDanhSachNhanVien();
            KhoiTaoLichSuChamCong();

            // Hiển thị dữ liệu lịch sử chấm công
            LoadLichSuChamCong();

        }

        private void txtMaNhanVien_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text.Trim();

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nhanVien = danhSachNhanVien.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
            if (nhanVien == null)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ngayHomNay = DateTime.Now.ToString("dd/MM/yyyy");
            var daChamCong = lichSuChamCong.AsEnumerable().Any(row =>
                row.Field<string>("MaNhanVien") == maNhanVien &&
                row.Field<string>("ThoiGian").StartsWith(ngayHomNay));

            if (daChamCong)
            {
                MessageBox.Show("Bạn đã chấm công hôm nay rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thêm bản ghi vào lịch sử chấm công
            lichSuChamCong.Rows.Add(maNhanVien, nhanVien.TenNhanVien, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            MessageBox.Show("Chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Tải lại lịch sử chấm công
            LoadLichSuChamCong();
            txtMaNhanVien.Clear();
            txtMaNhanVien.Focus();
        }
    }
}
public class NhanVien
{
    public string MaNhanVien { get; set; }
    public string TenNhanVien { get; set; }
}
