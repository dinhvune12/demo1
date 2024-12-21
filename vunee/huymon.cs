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
    public partial class huymon : DevExpress.XtraEditors.XtraForm
    {
        private DataTable danhSachMonAn;
        public huymon()
        {
            InitializeComponent();
            KhoiTaoDanhSachMonAn(); // Tạo dữ liệu mẫu
            LoadDanhSachMonAn();

        }
        private void KhoiTaoDanhSachMonAn()
        {
            danhSachMonAn = new DataTable();
            danhSachMonAn.Columns.Add("TenMonAn", typeof(string)); // Tên món ăn
            danhSachMonAn.Columns.Add("SoLuong", typeof(int));     // Số lượng
            danhSachMonAn.Columns.Add("DonGia", typeof(decimal));  // Đơn giá

            // Dữ liệu giả lập
            danhSachMonAn.Rows.Add("Cơm gà", 2, 50000);
            danhSachMonAn.Rows.Add("Bún bò", 1, 45000);
            danhSachMonAn.Rows.Add("Phở bò", 3, 60000);
            danhSachMonAn.Rows.Add("Mì quả", 2, 50000);
            danhSachMonAn.Rows.Add("Cơm mẹ nấu", 1, 2000000000);
            danhSachMonAn.Rows.Add("Canh mẹ nấu", 3, 60000000000);
        }
        private void LoadDanhSachMonAn()
        {
            dgvDanhSachMonAn.DataSource = danhSachMonAn;
            dgvDanhSachMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachMonAn.AllowUserToAddRows = false;
            dgvDanhSachMonAn.ReadOnly = true;
        }
        private void huymon_Load(object sender, EventArgs e)
        {

        }

        private void btnHuyMon_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachMonAn.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgvDanhSachMonAn.SelectedRows[0];

                // Lấy thông tin món
                string tenMon = selectedRow.Cells["TenMonAn"].Value.ToString();

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn hủy món '{tenMon}' không?",
                    "Xác nhận hủy món",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xóa hàng khỏi DataSource
                    danhSachMonAn.Rows.RemoveAt(selectedRow.Index);

                    MessageBox.Show($"Món '{tenMon}' đã được hủy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món muốn hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
