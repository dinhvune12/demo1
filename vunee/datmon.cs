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
    public partial class datmon : DevExpress.XtraEditors.XtraForm
    {
        public datmon()
        {
            InitializeComponent();
        }
        private DataTable danhSachMonAn;
        private DataTable gioHang;
        private void KhoiTaoDanhSachMonAn()
        {
            // Tạo bảng dữ liệu món ăn
            danhSachMonAn = new DataTable();
            danhSachMonAn.Columns.Add("Mã món", typeof(int));
            danhSachMonAn.Columns.Add("Tên món ăn", typeof(string));
            danhSachMonAn.Columns.Add("Đơn giá (VND)", typeof(decimal));

            // Thêm dữ liệu món ăn vào bảng
            danhSachMonAn.Rows.Add(1, "Phở bò", 50000);
            danhSachMonAn.Rows.Add(2, "Bún chả", 45000);
            danhSachMonAn.Rows.Add(3, "Cơm gà", 60000);
            danhSachMonAn.Rows.Add(4, "Bánh mì", 20000);
            danhSachMonAn.Rows.Add(1, "Phở gà", 50000);
            danhSachMonAn.Rows.Add(2, "Súp ví cá", 450000);
            danhSachMonAn.Rows.Add(3, "Cơm mẹ nấu", 60000000);
            danhSachMonAn.Rows.Add(4, "Canh mẹ nấu", 200000000);
            // Gán dữ liệu vào DataGridView
            dgvDanhSachMonAn.DataSource = danhSachMonAn;
            dgvDanhSachMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void KhoiTaoGioHang()
        {
            gioHang = new DataTable();
            gioHang.Columns.Add("Mã món", typeof(int));
            gioHang.Columns.Add("Tên món ăn", typeof(string));
            gioHang.Columns.Add("Đơn giá (VND)", typeof(decimal));
            gioHang.Columns.Add("Số lượng", typeof(int));
            gioHang.Columns.Add("Thành tiền (VND)", typeof(decimal));

            // Thêm cột nút "+" để tăng số lượng
            DataGridViewButtonColumn btnTangSoLuong = new DataGridViewButtonColumn
            {
                HeaderText = "Thêm",
                Text = "+",
                UseColumnTextForButtonValue = true,
                Name = "Tang"
            };

            // Thêm cột nút "-" để giảm số lượng
            DataGridViewButtonColumn btnGiamSoLuong = new DataGridViewButtonColumn
            {
                HeaderText = "Giảm",
                Text = "-",
                UseColumnTextForButtonValue = true,
                Name = "Giam"
            };

            dgvGioHang.Columns.Clear();
            dgvGioHang.Columns.AddRange(
                new DataGridViewTextBoxColumn { DataPropertyName = "Mã món", HeaderText = "Mã món" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Tên món ăn", HeaderText = "Tên món ăn" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Đơn giá (VND)", HeaderText = "Đơn giá" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Số lượng", HeaderText = "Số lượng" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Thành tiền (VND)", HeaderText = "Thành tiền" },
                btnTangSoLuong,
                btnGiamSoLuong
            );

            dgvGioHang.DataSource = gioHang;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void datmon_Load(object sender, EventArgs e)
        {
            KhoiTaoDanhSachMonAn(); // Khởi tạo danh sách món ăn
            KhoiTaoGioHang();       // Khởi tạo giỏ hàng
            dgvGioHang.CellClick += dgvGioHang_CellClick;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachMonAn.CurrentRow != null)
            {
                int maMon = (int)dgvDanhSachMonAn.CurrentRow.Cells["Mã món"].Value;
                string tenMonAn = dgvDanhSachMonAn.CurrentRow.Cells["Tên món ăn"].Value.ToString();
                decimal donGia = (decimal)dgvDanhSachMonAn.CurrentRow.Cells["Đơn giá (VND)"].Value;

                // Kiểm tra xem món đã có trong giỏ hàng chưa
                DataRow existingRow = gioHang.Select($"[Mã món] = {maMon}").FirstOrDefault();
                if (existingRow != null)
                {
                    int soLuong = (int)existingRow["Số lượng"] + 1;
                    existingRow["Số lượng"] = soLuong;
                    existingRow["Thành tiền (VND)"] = donGia * soLuong;
                }
                else
                {
                    gioHang.Rows.Add(maMon, tenMonAn, donGia, 1, donGia);
                }

                TinhTongTien();
            }
        }
        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Chỉ xử lý khi nhấn vào hàng hợp lệ
            {
                if (e.ColumnIndex == dgvGioHang.Columns["Tang"].Index) // Nhấn vào nút "+"
                {
                    DataRow row = gioHang.Rows[e.RowIndex];
                    int soLuong = (int)row["Số lượng"] + 1;
                    row["Số lượng"] = soLuong;
                    row["Thành tiền (VND)"] = (decimal)row["Đơn giá (VND)"] * soLuong;
                }
                else if (e.ColumnIndex == dgvGioHang.Columns["Giam"].Index) // Nhấn vào nút "-"
                {
                    DataRow row = gioHang.Rows[e.RowIndex];
                    int soLuong = (int)row["Số lượng"] - 1;

                    if (soLuong > 0)
                    {
                        row["Số lượng"] = soLuong;
                        row["Thành tiền (VND)"] = (decimal)row["Đơn giá (VND)"] * soLuong;
                    }
                    else
                    {
                        gioHang.Rows.Remove(row); // Xóa món khi số lượng giảm về 0
                    }
                }

                TinhTongTien(); // Cập nhật tổng tiền sau mỗi thao tác
            }
        }
        private void txtTongTien_Click(object sender, EventArgs e)
        {

        }
        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataRow row in gioHang.Rows)
            {
                tongTien += Convert.ToDecimal(row["Thành tiền (VND)"]);
            }

            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Rows.Count > 0)
            {
                MessageBox.Show($"Tổng tiền cần thanh toán: {txtTongTien.Text}", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gioHang.Clear();
                txtTongTien.Text = "0 VND";
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}