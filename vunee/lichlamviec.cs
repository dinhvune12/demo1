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
    public partial class lichlamviec : DevExpress.XtraEditors.XtraForm
    {
        private DateTime startOfWeek; // Ngày bắt đầu tuần hiện tại
        private DateTime endOfWeek;
        public lichlamviec()
        {
            InitializeComponent();
            startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 1); // Thứ 2 của tuần hiện tại
            endOfWeek = startOfWeek.AddDays(6); // Chủ nhật của tuần hiện tại
            UpdateWeekLabel();
            LoadDataToDataGridView();
        }
        private void UpdateWeekLabel()
        {
            lblWeek.Text = $"Tuần từ {startOfWeek:dd/MM/yyyy} đến {endOfWeek:dd/MM/yyyy}";
        }
        private void LoadDataToDataGridView()
        {
            DataTable dt = GetWorkForWeek(startOfWeek);

            // Gán bảng dữ liệu cho DataGridView
            dataGridView1.DataSource = dt;

            // Tùy chỉnh cho đẹp
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private DataTable GetWorkForWeek(DateTime startOfWeek)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Thứ 2\nGiờ làm");
            dt.Columns.Add("Thứ 3\nGiờ làm");
            dt.Columns.Add("Thứ 4\nGiờ làm");
            dt.Columns.Add("Thứ 5\nGiờ làm");
            dt.Columns.Add("Thứ 6\nGiờ làm");
            dt.Columns.Add("Thứ 7\nGiờ làm");
            dt.Columns.Add("Chủ Nhật\nGiờ làm");

            int weekNumber = (startOfWeek.DayOfYear / 7) % 4; // Tạo dữ liệu giả lập

            switch (weekNumber)
            {
                case 0:
                    dt.Rows.Add("8:00-12:00\nKiểm tra nguyên liệu", "8:00-12:00\nChuẩn bị bàn ghế", "8:00-12:00\nPhục vụ ca sáng", "8:00-12:00\nTiếp nhận hàng hóa", "8:00-12:00\nDọn dẹp kho", "8:00-15:00\nPhục vụ nhà hàng", "Nghỉ");
                    dt.Rows.Add("13:00-15:00\nHọp đầu ca", "13:00-16:00\nNhận đặt bàn", "13:00-14:30\nKiểm tra bác đũa", "13:00-15:00\nChuẩn bị tiệc đặt trước", "14:00-17:00\nPhục vụ khách VIP", "12:00-17:00\nVệ sinh bếp", "Nghỉ");
                    break;

                case 1:
                    dt.Rows.Add("8:00-12:00\nNhập hàng ", "8:00-12:00\nSắp xếp kho", "8:00-12:00\nPhục vụ buổi sáng", "8:00-12:00\nKiểm tra thực đơn", "8:00-12:00\nHọp nhân viên", "8:00-15:00\nTiệc nhà hàng", "Nghỉ");
                    dt.Rows.Add("13:00-15:00\nKiểm tra kho lạnh", "13:00-16:00\nVệ sinh bếp", "13:00-14:30\nHọp ", "13:00-15:00\nChuẩn bị nguyên liệu", "14:00-17:00\nTiếp khách VIP", "12:00-17:00\nVệ sinh khu vực", "Nghỉ");
                    break;

                default:
                    dt.Rows.Add("9:00-13:00\nNghỉ lễ", "Nghỉ lễ", "Nghỉ lễ", "Nghỉ lễ", "9:00-13:00\nVệ sinh toàn khu vực", "Nghỉ lễ", "Nghỉ lễ");
                    break;
            }

            return dt;
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
    

        private void lichlamviec_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            startOfWeek = startOfWeek.AddDays(-7);
            endOfWeek = endOfWeek.AddDays(-7);
            UpdateWeekLabel();
            LoadDataToDataGridView();
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            startOfWeek = startOfWeek.AddDays(7);
            endOfWeek = endOfWeek.AddDays(7);
            UpdateWeekLabel();
            LoadDataToDataGridView();
        }

        private void lblWeek_Click(object sender, EventArgs e)
        {

        }
    }
}