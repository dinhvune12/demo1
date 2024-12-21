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
    public partial class danhsachnhanvien : DevExpress.XtraEditors.XtraForm
    {
        private int selectedColumnIndex = -1; // Lưu vị trí cột được chọn
        private int selectedRowIndex = -1;
        public danhsachnhanvien()
        {
            InitializeComponent();
        }
            private void ThemDuLieuMau()
            {
            string imageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

            // Đường dẫn ảnh
            string image1Path = Path.Combine(imageFolderPath, "download.jpeg");
            string image2Path = Path.Combine(imageFolderPath, "ban-go-mam-non-hinh-chu-nhat.jpg");

            // Nạp ảnh nếu tồn tại
            Image image1 = File.Exists(image1Path) ? Image.FromFile(image1Path) : null;
            Image image2 = File.Exists(image2Path) ? Image.FromFile(image2Path) : null;

            // Thêm dữ liệu vào DataGridView
            dataGridView1.Rows.Add("ABD235", "Lê Văn Đẹp Trai", "0901234567", "Hà Nội", "01/01/1990", "Nam", image1);
            dataGridView1.Rows.Add("002", "Bành Văn Anh", "0987654321", "Hồ Chí Minh", "15/05/1992", "Nữ", image2);
        }
        private void danhsachnhanvien_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaSo", HeaderText = "Mã số" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ten", HeaderText = "Tên" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoDienThoai", HeaderText = "Số điện thoại" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "DiaChi", HeaderText = "Địa chỉ" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgaySinh", HeaderText = "Ngày sinh" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "GioiTinh", HeaderText = "Giới tính" });
            dataGridView1.Columns.Add(new DataGridViewImageColumn
            {
                Name = "AnhNhanVien",
                HeaderText = "Ảnh",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

            ThemDuLieuMau(); // Thêm dữ liệu mẫu
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSo.Text) || string.IsNullOrWhiteSpace(txtTen.Text) ||
        string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            // Kiểm tra số điện thoại
            if (!txtSoDienThoai.Text.All(char.IsDigit) || txtSoDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải là số và có đúng 10 chữ số!", "Thông báo");
                return;
            }

            dataGridView1.Rows.Add(
                txtMaSo.Text,
                txtTen.Text,
                txtSoDienThoai.Text,
                txtDiaChi.Text,
                dateNgaySinh.DateTime.ToString("dd/MM/yyyy"),
                comboBoxGioiTinh.SelectedItem.ToString(),
                pictureBox1.Image
            );

            ResetForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           if (selectedRowIndex >= 0 && selectedColumnIndex >= 0) // Đảm bảo đã chọn hàng và cột
    {
        string columnName = dataGridView1.Columns[selectedColumnIndex].HeaderText;

        // Hiện hộp thoại để nhập giá trị mới
        string newValue = Microsoft.VisualBasic.Interaction.InputBox(
            $"Nhập giá trị mới cho cột {columnName}:",
            "Sửa thông tin",
            dataGridView1.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value?.ToString() ?? ""
        );

        if (!string.IsNullOrWhiteSpace(newValue)) // Chỉ cập nhật nếu có giá trị nhập
        {
            // Kiểm tra nếu sửa cột "Số điện thoại"
            if (columnName == "Số điện thoại")
            {
                if (!newValue.All(char.IsDigit) || newValue.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải là số và có đúng 10 chữ số!", "Thông báo");
                    return;
                }
            }

            dataGridView1.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value = newValue;
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
        }
        else
        {
            MessageBox.Show("Giá trị nhập không hợp lệ!", "Thông báo");
        }
    }
    else if (dataGridView1.SelectedRows.Count > 0) // Trường hợp sửa toàn bộ thông tin trong hàng
    {
        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

        // Kiểm tra số điện thoại
        if (!txtSoDienThoai.Text.All(char.IsDigit) || txtSoDienThoai.Text.Length != 10)
        {
            MessageBox.Show("Số điện thoại phải là số và có đúng 10 chữ số!", "Thông báo");
            return;
        }

        selectedRow.Cells["MaSo"].Value = txtMaSo.Text;
        selectedRow.Cells["Ten"].Value = txtTen.Text;
        selectedRow.Cells["SoDienThoai"].Value = txtSoDienThoai.Text;
        selectedRow.Cells["DiaChi"].Value = txtDiaChi.Text;
        selectedRow.Cells["NgaySinh"].Value = dateNgaySinh.DateTime.ToString("dd/MM/yyyy");
        selectedRow.Cells["GioiTinh"].Value = comboBoxGioiTinh.SelectedItem.ToString();
        selectedRow.Cells["AnhNhanVien"].Value = pictureBox1.Image;

        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
    }
    else
    {
        MessageBox.Show("Vui lòng chọn một ô hoặc một hàng để sửa.", "Thông báo");
    }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa.", "Thông báo");
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        private void ResetForm()
        {
            txtMaSo.Clear();
            txtTen.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            comboBoxGioiTinh.SelectedIndex = -1;
            dateNgaySinh.EditValue = null;
            pictureBox1.Image = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Đảm bảo không phải header
            {
                selectedRowIndex = e.RowIndex;
                selectedColumnIndex = e.ColumnIndex;

                string columnName = dataGridView1.Columns[selectedColumnIndex].HeaderText;
                string cellValue = dataGridView1.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value?.ToString() ?? "Trống";

                MessageBox.Show($"Bạn đã chọn sửa cột: {columnName}\nNội dung hiện tại: {cellValue}", "Thông báo");
            }
        }
    }
}