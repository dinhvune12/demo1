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

    public partial class thanhToan : DevExpress.XtraEditors.XtraForm
    {
        public thanhToan()
        {
            InitializeComponent();
        }
        public class HoaDon
        {
            public string TenMonAn { get; set; }
            public decimal DonGia { get; set; }
            public int SoLuong { get; set; }
            public decimal ThanhTien { get { return DonGia * SoLuong; } }
        }

        // Giả lập dữ liệu hóa đơn cho các bàn
        private Dictionary<string, List<HoaDon>> danhSachBan = new Dictionary<string, List<HoaDon>>()
        {
            { "B01", new List<HoaDon> {
                new HoaDon { TenMonAn = "Cơm gà", DonGia = 50000, SoLuong = 2 },
                new HoaDon { TenMonAn = "Bún bò", DonGia = 45000, SoLuong = 1 }
            }},
            { "B02", new List<HoaDon> {
                new HoaDon { TenMonAn = "Phở bò", DonGia = 60000, SoLuong = 1 },
                new HoaDon { TenMonAn = "Gà rán", DonGia = 70000, SoLuong = 3 }
            }}
        };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void thanhToan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maBan = txtMaBan.Text.Trim();

            // Tạo bảng dữ liệu để chứa danh sách món ăn
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tên món ăn", typeof(string));
            dataTable.Columns.Add("Đơn giá (VND)", typeof(int));

            // Kiểm tra Mã bàn và thêm dữ liệu tương ứng
            switch (maBan)
            {
                case "1":
                    dataTable.Rows.Add("Phở", 30000);
                    dataTable.Rows.Add("Bún chả", 40000);
                    dataTable.Rows.Add("Nem rán", 25000);
                    break;
                case "2":
                    dataTable.Rows.Add("Cơm rang", 35000);
                    dataTable.Rows.Add("Canh chua", 30000);
                    dataTable.Rows.Add("Trứng chiên", 20000);
                    break;
                case "3":
                    dataTable.Rows.Add("Bánh mì", 15000);
                    dataTable.Rows.Add("Cà phê sữa", 20000);
                    dataTable.Rows.Add("Nước cam", 25000);
                    break;
                default:
                    // Hiện thông báo nếu Mã bàn không tồn tại
                    MessageBox.Show("Mã bàn không hợp lệ! Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Gán dữ liệu vào DataGridView
            dgvHoaDon.DataSource = dataTable;
            int tongGia = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                tongGia += Convert.ToInt32(row["Đơn giá (VND)"]);
            }

            // Hiển thị tổng giá vào TextBox txtTongGia
            txtTongGia.Text = tongGia.ToString("N0") + " VND";

        }

        private void dgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công. Tổng tiền: " + txtTongGia.Text + " VND");
        }
    
    }
}