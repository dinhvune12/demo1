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
    public partial class XuatHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public XuatHoaDon()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maBan = textBox1.Text.Trim();

            // Tạo bảng dữ liệu để chứa danh sách món ăn
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tên món ăn", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(string));
            dataTable.Columns.Add("Đơn giá (VND)", typeof(int));
            dataTable.Columns.Add("Thành tiền(VND)", typeof(string));

            // Kiểm tra Mã bàn và thêm dữ liệu tương ứng
            switch (maBan)
            {
                case "1":
                    dataTable.Rows.Add("Phở", 2, 30000, 60000);
                    dataTable.Rows.Add("Bún chả", 1, 40000, 40000);
                    dataTable.Rows.Add("Nem rán", 2, 25000, 50000);
                    dataTable.Rows.Add("Mì trộn", 2, 30000, 60000);
                    break;
                case "2":
                    dataTable.Rows.Add("Cơm rang", 3, 35000, 105000);
                    dataTable.Rows.Add("Canh chua", 1, 30000, 30000);
                    dataTable.Rows.Add("Trứng chiên", 1, 20000, 20000);
                    dataTable.Rows.Add("Thịt kho", 1, 40000, 40000);
                    break;
                case "3":
                    dataTable.Rows.Add("Bánh mì", 2, 15000, 30000);
                    dataTable.Rows.Add("Cà phê sữa", 2, 20000, 40000);
                    dataTable.Rows.Add("Nước cam", 1, 25000, 25000);
                    dataTable.Rows.Add("Bánh cuốn", 1, 25000, 25000);
                    break;
                default:
                    // Hiện thông báo nếu Mã bàn không tồn tại
                    MessageBox.Show("Mã bàn không hợp lệ! Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }


            // Gán dữ liệu vào DataGridView
            dataGridView1.DataSource = dataTable;
            int tongGia = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                tongGia += Convert.ToInt32(row["Đơn giá (VND)"]);
            }

            // Hiển thị tổng giá vào TextBox txtTongGia
            textBox2.Text = tongGia.ToString("N0") + " VND";


        }

        private void XuatHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string maBan = textBox1.Text;
                string fileName = $"HoaDon_{maBan}_{DateTime.Now:yyyyMMddHHmmss}.txt";

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("=== HÓA ĐƠN THANH TOÁN ===");
                    writer.WriteLine($"Mã Bàn: {maBan}");
                    writer.WriteLine($"Ngày: {DateTime.Now}");
                    writer.WriteLine("---------------------------------------");
                    writer.WriteLine("Tên món ăn\tĐơn giá\tSố lượng\tThành tiền");

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string tenMonAn = row.Cells["TenMonAn"].Value.ToString();
                        string donGia = row.Cells["DonGia"].Value.ToString();
                        string soLuong = row.Cells["SoLuong"].Value.ToString();
                        string thanhTien = row.Cells["ThanhTien"].Value.ToString();

                        writer.WriteLine($"{tenMonAn}\t{donGia}\t{soLuong}\t{thanhTien}");
                    }

                    writer.WriteLine("---------------------------------------");
                    writer.WriteLine($"Tổng Tiền: {textBox2.Text} VND");
                    writer.WriteLine("=== CẢM ƠN QUÝ KHÁCH ===");
                }

                MessageBox.Show($"Xuất hóa đơn thành công!\nFile: {fileName}", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất hóa đơn.", "Lỗi");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}