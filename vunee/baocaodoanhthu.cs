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
    public partial class baocaodoanhthu : DevExpress.XtraEditors.XtraForm
    {
        public baocaodoanhthu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dateTimePicker1.Value.Date;
            DateTime ngayKetThuc = dateTimePicker2.Value.Date;

            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu phải trước hoặc bằng ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo dữ liệu mẫu
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Ngày", typeof(DateTime));
            dataTable.Columns.Add("Thành tiền (VND)", typeof(int));

            // Dữ liệu mẫu
            Random rand = new Random();
            for (DateTime ngay = ngayBatDau; ngay <= ngayKetThuc; ngay = ngay.AddDays(1))
            {
                int doanhThuNgay = rand.Next(100000, 1000000); // Tạo ngẫu nhiên doanh thu từ 100,000 đến 1,000,000
                dataTable.Rows.Add(ngay, doanhThuNgay);
            }

            // Gán dữ liệu vào DataGridView
            dataGridView1.DataSource = dataTable;

            // Tính tổng doanh thu
            int tongDoanhThu = dataTable.AsEnumerable().Sum(row => Convert.ToInt32(row["Thành tiền (VND)"]));

            // Hiển thị tổng doanh thu
            textBox1.Text = tongDoanhThu.ToString("N0") + " VND";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để gửi báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ngayBatDau = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string ngayKetThuc = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string fileName = $"BaoCao_DoanhThu_{ngayBatDau}_den_{ngayKetThuc}.txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("=== BÁO CÁO DOANH THU ===");
                writer.WriteLine($"Khoảng thời gian: {ngayBatDau} đến {ngayKetThuc}");
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("Ngày\t\tDoanh thu (VND)");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string ngay = Convert.ToDateTime(row.Cells[0].Value).ToString("yyyy-MM-dd");
                        string doanhThu = row.Cells[1].Value.ToString();
                        writer.WriteLine($"{ngay}\t{doanhThu}");
                    }
                }

                writer.WriteLine("-----------------------------------------");
                writer.WriteLine($"Tổng doanh thu: {textBox1.Text}");
                writer.WriteLine("=== KẾT THÚC BÁO CÁO ===");
            }

            MessageBox.Show($"Báo cáo đã được lưu thành công!\nFile: {fileName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mở file báo cáo
            System.Diagnostics.Process.Start("notepad.exe", fileName);
        }

        private void baocaodoanhthu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(-7); // 7 ngày trước
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}