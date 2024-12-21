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
    public partial class khachhangtinhtrangmonan : DevExpress.XtraEditors.XtraForm
    {
        private List<MonAn> danhSachMonAn;
        public khachhangtinhtrangmonan()
        {
            InitializeComponent();
            KhoiTaoDanhSachMonAn();
            LoadMonAnToGrid();
        }
        private void KhoiTaoDanhSachMonAn()
        {
            danhSachMonAn = new List<MonAn>
            {
                new MonAn { TenMonAn = "Phở bò", TrangThai = "Đang chuẩn bị" },
                new MonAn { TenMonAn = "Bún chả", TrangThai = "Đã hoàn thành" },
                new MonAn { TenMonAn = "Cơm tấm", TrangThai = "Chưa bắt đầu" }
            };
        }
        private void LoadMonAnToGrid()
        {
            var dt = new DataTable();
            dt.Columns.Add("Tên món ăn");
            dt.Columns.Add("Trạng thái");

            foreach (var monAn in danhSachMonAn)
            {
                dt.Rows.Add(monAn.TenMonAn, monAn.TrangThai);
            }

            dgvMonAn.DataSource = dt;
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonAn.AllowUserToAddRows = false;
            dgvMonAn.ReadOnly = true;
        }
        private void khachhangtinhtrangmonan_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin món ăn từ dòng được chọn
            string tenMonAn = dgvMonAn.CurrentRow.Cells["Tên món ăn"].Value.ToString();
            string trangThai = dgvMonAn.CurrentRow.Cells["Trạng thái"].Value.ToString();

            // Hiển thị chi tiết món ăn trong các Label
            lblTenMon.Text = $"Tên món: {tenMonAn}";
            lblTrangThai.Text = $"Trạng thái: {trangThai}";
        }
        public class MonAn
        {
            public string TenMonAn { get; set; }
            public string TrangThai { get; set; }
        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {

        }
    }
}