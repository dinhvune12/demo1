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
    public partial class frmcalam : DevExpress.XtraEditors.XtraForm
    {
        public frmcalam()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }
        private void LoadDataToDataGridView()
        {
            // Tạo bảng dữ liệu giả lập
            DataTable dt = new DataTable();
            dt.Columns.Add("Thứ 2");
            dt.Columns.Add("Thứ 3");
            dt.Columns.Add("Thứ 4");
            dt.Columns.Add("Thứ 5");
            dt.Columns.Add("Thứ 6");
            dt.Columns.Add("Thứ 7");
            dt.Columns.Add("Chủ Nhật");

            // Thêm dữ liệu vào bảng
            dt.Rows.Add("Công việc A", "Công việc B", "Công việc C", "Công việc D", "Công việc E", "Công việc F", "Nghỉ ngơi");
            dt.Rows.Add("Họp 9h", "Dự án X", "Training", "Báo cáo", "Gặp khách hàng", "Dọn dẹp", "Thể thao");

            // Gán bảng dữ liệu cho DataGridView
            dataGridView2.DataSource = dt;

            // Tùy chỉnh cho đẹp
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView2.Columns[e.ColumnIndex].HeaderText;
                string cellValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                MessageBox.Show($"Bạn đã chọn ô '{columnName}' với nội dung: {cellValue}",
                                "Thông tin ô", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmcalam_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}