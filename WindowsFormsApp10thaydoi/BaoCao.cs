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
    public partial class BaoCao : DevExpress.XtraEditors.XtraForm
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ngayChon = dateTimePicker1.Value.Date;

            // Tạo dữ liệu mẫu (thay thế bằng dữ liệu từ cơ sở dữ liệu)
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã hóa đơn", typeof(int));
            dataTable.Columns.Add("Tên món ăn", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Đơn giá (VND)", typeof(int));
            dataTable.Columns.Add("Thành tiền (VND)", typeof(int));

            // Dữ liệu giả lập cho ngày hôm nay
            if (ngayChon == DateTime.Today)
            {
                dataTable.Rows.Add(1, "Phở", 2, 30000, 60000);
                dataTable.Rows.Add(2, "Bún chả", 1, 40000, 40000);
                dataTable.Rows.Add(3, "Nem rán", 3, 25000, 75000);
                dataTable.Rows.Add(4, "Cơm rang", 2, 30000, 60000);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho ngày này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                textBox1.Text = "0 VND";
                return;
            }

            // Gán dữ liệu vào DataGridView
            dataGridView1.DataSource = dataTable;

            // Tính tổng doanh thu
            int tongDoanhThu = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                tongDoanhThu += Convert.ToInt32(row["Thành tiền (VND)"]);
            }

            // Hiển thị tổng doanh thu
            textBox1.Text = tongDoanhThu.ToString("N0") + " VND";
        }
    }
}