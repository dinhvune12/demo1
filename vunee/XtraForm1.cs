using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        private decimal giamGia = 0; // Phần trăm giảm giá
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private DataTable taoDuLieuBan(string maBan)
        {
            DataTable table = new DataTable();
            table.Columns.Add("TenMonAn", typeof(string));
            table.Columns.Add("DonGia", typeof(decimal));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("ThanhTien", typeof(decimal), "DonGia * SoLuong");

            switch (maBan)
            {
                case "1":
                    table.Rows.Add("Cơm gà", 50000, 2);
                    table.Rows.Add("Bún bò", 45000, 1);
                    break;
                case "2":
                    table.Rows.Add("Phở bò", 60000, 1);
                    table.Rows.Add("Gà rán", 70000, 3);
                    break;
                case "3":
                    table.Rows.Add("Bánh mì", 15000, 2);
                    table.Rows.Add("Cà phê sữa", 20000, 1);
                    table.Rows.Add("Nước cam", 25000, 1);
                    break;
                default:
                    MessageBox.Show("Mã bàn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
            return table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maBan = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(maBan))
            {
                MessageBox.Show("Vui lòng nhập mã bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dataTable = taoDuLieuBan(maBan);

            if (dataTable != null)
            {
                dataGridView1.DataSource = dataTable;

                // Tính tổng tiền gốc
                decimal tongTien = dataTable.AsEnumerable().Sum(row => row.Field<decimal>("ThanhTien"));

                // Áp dụng giảm giá nếu có
                decimal tongTienSauGiam = tongTien * (1 - giamGia / 100);

                // Hiển thị tổng tiền
                textBox2.Text = $"{tongTien:N0} VND";
                lblTongTienSauGiam.Text = $"Tổng tiền sau giảm: {tongTienSauGiam:N0} VND";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maBan = textBox1.Text.Trim();
            string fileName = $"HoaDon_{maBan}_{DateTime.Now:yyyyMMddHHmmss}.txt";

            // Lấy dữ liệu từ DataGridView
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            decimal tongTien = dataTable.AsEnumerable().Sum(row => row.Field<decimal>("ThanhTien"));
            decimal tongTienSauGiam = tongTien * (1 - giamGia / 100);

            // Xuất hóa đơn
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("=== HÓA ĐƠN THANH TOÁN ===");
                writer.WriteLine($"Mã Bàn: {maBan}");
                writer.WriteLine($"Ngày: {DateTime.Now}");
                writer.WriteLine("---------------------------------------------");
                writer.WriteLine("Tên món ăn\t\tĐơn giá\tSố lượng\tThành tiền");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["TenMonAn"].Value != null)
                    {
                        string tenMonAn = row.Cells["TenMonAn"].Value.ToString();
                        string donGia = row.Cells["DonGia"].Value.ToString();
                        string soLuong = row.Cells["SoLuong"].Value.ToString();
                        string thanhTien = row.Cells["ThanhTien"].Value.ToString();

                        writer.WriteLine($"{tenMonAn}\t\t{donGia}\t{soLuong}\t{thanhTien}");
                    }
                }

                writer.WriteLine("---------------------------------------------");
                writer.WriteLine($"Tổng Tiền Ban Đầu: {tongTien:N0} VND");
                writer.WriteLine($"Giảm Giá: {giamGia}%");
                writer.WriteLine($"Tổng Tiền Sau Giảm Giá: {tongTienSauGiam:N0} VND");
                writer.WriteLine("=== CẢM ƠN QUÝ KHÁCH ===");
            }

            // Thông báo thành công
            MessageBox.Show($"Xuất hóa đơn thành công!\nFile: {fileName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("notepad.exe", fileName);
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtGiamGia.Text, out decimal phanTramGiam) && phanTramGiam >= 0 && phanTramGiam <= 100)
            {
                giamGia = phanTramGiam; // Cập nhật phần trăm giảm giá
                MessageBox.Show($"Áp dụng giảm giá {giamGia}% thành công!", "Thông báo");

                // Tính lại tổng tiền sau giảm
                if (dataGridView1.DataSource is DataTable dataTable)
                {
                    decimal tongTien = dataTable.AsEnumerable().Sum(row => row.Field<decimal>("ThanhTien"));
                    decimal tongTienSauGiam = tongTien * (1 - giamGia / 100);

                    // Cập nhật hiển thị tổng tiền sau giảm giá
                    textBox2.Text = $"{tongTienSauGiam:N0} VND";
                    lblTongTienSauGiam.Text = $"Tổng tiền sau giảm: {tongTienSauGiam:N0} VND";
                }
            }
            else
            {
                MessageBox.Show("Mã giảm giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}