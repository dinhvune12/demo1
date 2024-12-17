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
    public partial class quanlisodobanFRM : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton selectedTable = null; // Bàn được chọn
        private int tableCount = 3; // Bắt đầu với 3 bàn có sẵn
        private const int tableWidth = 80, tableHeight = 30, spacing = 40;
        private const int maxColumns = 5, maxRows = 3;

        public quanlisodobanFRM()
        {
            InitializeComponent();
            simpleButton1.Click += TableButton_Click;
            simpleButton2.Click += TableButton_Click;
            simpleButton3.Click += TableButton_Click;

            // Thêm bàn vào panel1
            panel1.Controls.Add(simpleButton1);
            panel1.Controls.Add(simpleButton2);
            panel1.Controls.Add(simpleButton3);

            // Gắn sự kiện cho nút Delete, Add và Detail
            button1.Click += btdelete_Click; // Delete
            button2.Click += btradd_Click;   // Add
            button3.Click += btDetail_Click; // Detail
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TableButton_Click(object sender, EventArgs e)
        {
            selectedTable = sender as SimpleButton;
            if (selectedTable != null)
            {
                XtraMessageBox.Show($"Bạn đã chọn: {selectedTable.Text}");
            }
        }

        // Sự kiện nút Detail
        private void btDetail_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                // Dựa vào tên bàn mở form tương ứng
                switch (selectedTable.Text)
                {
                    case "Table 1":
                        tablenumber1 form1 = new tablenumber1();
                        form1.ShowDialog();
                        break;

                    case "Table 2":
                        table2 form2 = new table2();
                        form2.ShowDialog();
                        break;

                    case "Table 3":
                        table3 form3 = new table3();
                        form3.ShowDialog();
                        break;

                    default:
                        // Form mặc định cho các bàn khác
                        MessageBox.Show($"Chi tiết cho {selectedTable.Text} hiện chưa được thiết lập.");
                        break;
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn bàn nào để xem chi tiết.");
            }
        }

        // Sự kiện xóa bàn
        private void btdelete_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                panel1.Controls.Remove(selectedTable);
                selectedTable.Dispose();
                XtraMessageBox.Show("Bàn đã được xóa.");
                selectedTable = null;
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn bàn nào để xóa.");
            }
        }

        // Sự kiện thêm bàn mới
        private void btradd_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.OfType<SimpleButton>().Count() >= maxColumns * maxRows)
            {
                XtraMessageBox.Show("Không thể thêm bàn mới, đã đạt tối đa 5x3 bàn.");
                return;
            }

            tableCount++;
            SimpleButton newTable = new SimpleButton();
            newTable.Text = $"Table {tableCount}";
            newTable.Name = $"btnTable{tableCount}";
            newTable.Size = new Size(tableWidth, tableHeight);

            Point nextPosition = FindFirstEmptyPosition();
            newTable.Location = nextPosition;

            newTable.Click += TableButton_Click;
            panel1.Controls.Add(newTable);
        }

        // Tìm vị trí trống đầu tiên
        private Point FindFirstEmptyPosition()
        {
            bool[,] grid = new bool[maxRows, maxColumns];
            foreach (Control control in panel1.Controls.OfType<SimpleButton>())
            {
                int col = control.Location.X / (tableWidth + spacing);
                int row = control.Location.Y / (tableHeight + spacing);
                grid[row, col] = true;
            }

            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxColumns; col++)
                {
                    if (!grid[row, col])
                    {
                        return new Point(col * (tableWidth + spacing), row * (tableHeight + spacing));
                    }
                }
            }

            return new Point(0, 0);
        }
    }
}