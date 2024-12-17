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
    public partial class frmlichchamcong : DevExpress.XtraEditors.XtraForm
    {
        public frmlichchamcong()
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
            dt.Rows.Add("vắng", "đã chấm công", "đi trễ", "chấm công", "chấm công", "xin nghỉ phép", "chấm công");
            

            // Gán bảng dữ liệu cho DataGridView
            dataGridView1.DataSource = dt;

            // Tùy chỉnh cho đẹp
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Mở form Trang chủ
            RibbonForm1 trangChuForm = new RibbonForm1();
            trangChuForm.Show();
        }
    }
}