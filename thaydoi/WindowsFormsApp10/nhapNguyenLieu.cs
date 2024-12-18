using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApp10
{
    public partial class nhapNguyenLieu : DevExpress.XtraEditors.XtraForm
    {
        public nhapNguyenLieu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadDataFromFile();
        }
        private void SaveDataToFile()
        {
            List<string> savedData = new List<string>();

            // Duyệt qua các hàng của DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không lưu hàng trống
                {
                    string rowData = "";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        rowData += cell.Value?.ToString() + ","; // Dùng dấu ',' phân cách các cột
                    }
                    savedData.Add(rowData.TrimEnd(',')); // Loại bỏ dấu ',' cuối cùng
                }
            }

            // Lưu vào tệp (file.txt)
            System.IO.File.WriteAllLines(@"save data.txt", savedData);
        }
        private void LoadDataFromFile()
        {
            if (System.IO.File.Exists(@"save data.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"save data.txt");

                // Duyệt qua từng dòng dữ liệu và thêm vào DataGridView
                foreach (string line in lines)
                {
                    string[] cells = line.Split(',');

                    // Thêm hàng vào DataGridView
                    dataGridView1.Rows.Add(cells);
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataToFile(); // Lưu dữ liệu vào tệp
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromFile(); // Tải dữ liệu từ tệp vào DataGridView
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }
    }
}