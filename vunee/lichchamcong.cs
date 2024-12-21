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
    public partial class lichchamcong : DevExpress.XtraEditors.XtraForm
    {
        private DateTime currentWeek;
        public lichchamcong()
        {
            InitializeComponent();
            currentWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday); // Lấy ngày đầu tuần hiện tại
            LoadDataForWeek(currentWeek);
        }
        private void UpdateWeekLabel()
        {
            lblWeek.Text = $"Tuần từ {currentWeek:dd/MM/yyyy} đến {currentWeek.AddDays(6):dd/MM/yyyy}";
        }
        
        private void LoadDataForWeek(DateTime startOfWeek)
        {
            UpdateWeekLabel();

            DataTable dt = GetChamCongForWeek(startOfWeek);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }
        private DataTable GetChamCongForWeek(DateTime startOfWeek)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ngày/Thời gian");
            dt.Columns.Add("Sáng");
            dt.Columns.Add("Chiều");
            dt.Columns.Add("Tối");

            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startOfWeek.AddDays(i);
                string ngay = currentDay.DayOfWeek.ToString();

                string sang = SinhTrangThaiChamCong(random);
                string chieu = SinhTrangThaiChamCong(random);
                string toi = currentDay.DayOfWeek == DayOfWeek.Sunday ? "Nghỉ" : SinhTrangThaiChamCong(random);

                dt.Rows.Add($"{ngay} ({currentDay:dd/MM})", sang, chieu, toi);
            }

            return dt;
        }
        private string SinhTrangThaiChamCong(Random random)
        {
            int tiLe = random.Next(100);

            if (tiLe < 10) return "Đi trễ";          // 10% khả năng xuất hiện "Đi trễ"
            if (tiLe < 50) return "Chấm công";       // 40% khả năng xuất hiện "Chấm công"
            if (tiLe < 80) return "Đã chấm công";    // 30% khả năng xuất hiện "Đã chấm công"
            return "Xin nghỉ phép";                  // 20% khả năng xuất hiện "Xin nghỉ phép"
        }
        private void ChangeWeek(int days)
        {
            DateTime newWeek = currentWeek.AddDays(days);

            if (days > 0 && newWeek > DateTime.Now.StartOfWeek(DayOfWeek.Monday))
            {
                MessageBox.Show("Bạn không thể xem lịch tuần tới vì tuần này chưa diễn ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            currentWeek = newWeek;
            LoadDataForWeek(currentWeek);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].HeaderText;
                string cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                MessageBox.Show($"Bạn đã chọn ô '{columnName}' với nội dung: {cellValue}",
                                "Thông tin ô", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void lichchamcong_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            RibbonForm1 trangChuForm = new RibbonForm1();
            trangChuForm.Show();
        }

        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            ChangeWeek(-7);
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            ChangeWeek(7);
        }
        
    
    }
}
public static class DateTimeExtensions
{
    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
    {
        int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        return dt.AddDays(-1 * diff).Date;
    }
}