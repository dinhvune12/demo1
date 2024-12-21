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
        private List<BanAn> danhSachBan = new List<BanAn>();
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
                // Kiểm tra tên bàn
                string tenBan = selectedTable.Text;

                // Xử lý bàn cố định (1, 2, 3)
                switch (tenBan)
                {
                    case "Table 1":
                        tablenumber1 form1 = new tablenumber1();
                        form1.ShowDialog();
                        return;

                    case "Table 2":
                        tablene2 form2 = new tablene2();
                        form2.ShowDialog();
                        return;

                    case "Table 3":
                        tablene3 form3 = new tablene3();
                        form3.ShowDialog();
                        return;

                    default:
                        break; // Không phải bàn cố định
                }

                // Xử lý bàn thêm mới
                var banDuocChon = danhSachBan.FirstOrDefault(ban => ban.TenBan == tenBan);
                if (banDuocChon != null)
                {
                    // Hiển thị thông tin chi tiết
                    string chiTiet = $"Tên bàn: {banDuocChon.TenBan}\n" +
                                     $"Số lượng: {banDuocChon.SoLuong}\n" +
                                     $"Hãng: {banDuocChon.Hang}";

                    // Tạo form hiển thị thông tin
                    Form chiTietBanForm = new Form
                    {
                        Text = $"Chi Tiết - {banDuocChon.TenBan}",
                        Size = new Size(500, 500), // Kích thước lớn hơn
                        BackColor = Color.LightBlue
                    };

                    // Label hiển thị thông tin
                    Label lblChiTiet = new Label
                    {
                        Text = chiTiet,
                        AutoSize = true,
                        Location = new Point(10, 10)
                    };
                    chiTietBanForm.Controls.Add(lblChiTiet);

                    // PictureBox hiển thị ảnh
                    PictureBox pbAnhBan = new PictureBox
                    {
                        Image = banDuocChon.AnhBan,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(400, 300), // Tăng kích thước ảnh
                        Location = new Point(50, 100) // Điều chỉnh vị trí
                    };
                    chiTietBanForm.Controls.Add(pbAnhBan);

                    chiTietBanForm.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show($"Không tìm thấy chi tiết cho {tenBan}.");
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn bàn nào để xem chi tiết.");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Sự kiện xóa bàn
        private void btdelete_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                string tenBan = selectedTable.Text;

                // Xóa bàn khỏi danh sách
                var banCanXoa = danhSachBan.FirstOrDefault(ban => ban.TenBan == tenBan);
                if (banCanXoa != null)
                {
                    danhSachBan.Remove(banCanXoa);
                }

                // Xóa bàn khỏi giao diện
                panel1.Controls.Remove(selectedTable);
                selectedTable.Dispose();
                XtraMessageBox.Show($"Đã xóa {tenBan}.");
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

            // Mở form nhập thông tin bàn
            FormNhapThongTinBan formNhap = new FormNhapThongTinBan();
            if (formNhap.ShowDialog() == DialogResult.OK)
            {
                // Tìm số bàn nhỏ nhất chưa được sử dụng
                int soBanMoi = TimSoBanTrong();

                SimpleButton newTable = new SimpleButton
                {
                    Text = $"Table {soBanMoi}",
                    Name = $"btnTable{soBanMoi}",
                    Size = new Size(tableWidth, tableHeight),
                    Location = FindFirstEmptyPosition()
                };

                // Tạo đối tượng `BanAn` và lưu thông tin
                BanAn banMoi = new BanAn
                {
                    TenBan = newTable.Text,
                    SoLuong = formNhap.SoLuong,
                    Hang = formNhap.Hang,
                    AnhBan = formNhap.AnhBan
                };
                danhSachBan.Add(banMoi);

                // Thêm sự kiện Click cho bàn
                newTable.Click += TableButton_Click;
                panel1.Controls.Add(newTable);

                XtraMessageBox.Show($"Đã thêm bàn mới:\nTên: {newTable.Text}\nSố lượng: {banMoi.SoLuong}\nHãng: {banMoi.Hang}");
            }
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
        public class BanAn
        {
            public string TenBan { get; set; } // Tên bàn (VD: "Table 1")
            public int SoLuong { get; set; }  // Số lượng chỗ ngồi
            public string Hang { get; set; }  // Hãng sản xuất
            public Image AnhBan { get; set; } // Ảnh bàn
        }
        private int TimSoBanTrong()
        {
            // Tạo danh sách các số bàn hiện tại
            List<int> cacSoBanHienTai = panel1.Controls.OfType<SimpleButton>()
                .Select(btn => int.Parse(btn.Text.Replace("Table ", "")))
                .ToList();

            // Tìm số nhỏ nhất không có trong danh sách
            for (int i = 1; i <= maxColumns * maxRows; i++)
            {
                if (!cacSoBanHienTai.Contains(i))
                {
                    return i; // Số bàn trống đầu tiên
                }
            }

            return cacSoBanHienTai.Count + 1; // Nếu không tìm thấy, thêm số bàn tiếp theo
        }
    }
}