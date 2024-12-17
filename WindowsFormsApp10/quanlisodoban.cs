using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class quanlisodoban : DevExpress.XtraEditors.XtraForm
    {
        private BindingList<MonAn> danhSachMonAn = new BindingList<MonAn>();
        private int maMonAnTuDong = 1;
        public quanlisodoban()
        {
            InitializeComponent();
            dgvMonAn.AutoGenerateColumns = false;
            KhoiTaoDataGridView();
            dgvMonAn.DataSource = danhSachMonAn;
            danhSachMonAn.Add(new MonAn
            {
                MaMonAn = maMonAnTuDong++,
                TenMonAn = "Phở Bò",
                Gia = 50000,
                MoTa = "Phở bò truyền thống",
                TrangThai = true,
                HinhAnh = null
            });

            danhSachMonAn.Add(new MonAn
            {
                MaMonAn = maMonAnTuDong++,
                TenMonAn = "Bánh Mì",
                Gia = 20000,
                MoTa = "Bánh mì thịt nguội",
                TrangThai = true,
                HinhAnh = null
            });
            danhSachMonAn.Add(new MonAn
            {
                MaMonAn = maMonAnTuDong++,
                TenMonAn = "Mì quảng",
                Gia = 500000,
                MoTa = "Phở bò truyền thống",
                TrangThai = true,
                HinhAnh = null
            });

            danhSachMonAn.Add(new MonAn
            {
                MaMonAn = maMonAnTuDong++,
                TenMonAn = "Cao Lầu",
                Gia = 200000,
                MoTa = "Bánh mì thịt nguội",
                TrangThai = true,
                HinhAnh = null
            });
        }
        private void KhoiTaoDataGridView()
        {
            dgvMonAn.Columns.Clear();

            dgvMonAn.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã", DataPropertyName = "MaMonAn", Name = "MaMonAn" });
            dgvMonAn.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên món ăn", DataPropertyName = "TenMonAn", Name = "TenMonAn" });
            dgvMonAn.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giá", DataPropertyName = "Gia", Name = "Gia" });
            dgvMonAn.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mô tả", DataPropertyName = "MoTa", Name = "MoTa" });
            dgvMonAn.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Trạng thái", DataPropertyName = "TrangThai", Name = "TrangThai" });
            dgvMonAn.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hình ảnh", DataPropertyName = "HinhAnh", Name = "HinhAnh" });
        }
        private void quanlisodoban_Load(object sender, EventArgs e)
        {

        }

        private void dgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtGia.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal gia))
            {
                MessageBox.Show("Giá phải là một số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MonAn monAnMoi = new MonAn
            {
                MaMonAn = maMonAnTuDong++,
                TenMonAn = txtTenMonAn.Text,
                Gia = gia,
                MoTa = txtMoTa.Text,
                TrangThai = chkTrangThai.Checked,
                HinhAnh = picMonAn.Tag?.ToString()
            };

            danhSachMonAn.Add(monAnMoi);
            ClearTextBoxes();
            MessageBox.Show("Thêm món ăn thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.CurrentRow != null)
            {
                // Lấy dữ liệu dòng được chọn
                var monAnSua = dgvMonAn.CurrentRow.DataBoundItem as MonAn;

                if (monAnSua != null)
                {
                    // Kiểm tra giá trị của txtGia.Text
                    if (string.IsNullOrWhiteSpace(txtGia.Text))
                    {
                        MessageBox.Show("Giá không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(txtGia.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal gia))
                    {
                        MessageBox.Show("Giá phải là số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật thông tin món ăn
                    monAnSua.TenMonAn = txtTenMonAn.Text;
                    monAnSua.Gia = gia;
                    monAnSua.MoTa = txtMoTa.Text;
                    monAnSua.TrangThai = chkTrangThai.Checked;
                    monAnSua.HinhAnh = picMonAn.Tag?.ToString();

                    // Làm mới DataGridView
                    dgvMonAn.Refresh();
                    ClearTextBoxes();
                    MessageBox.Show("Sửa món ăn thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.CurrentRow != null)
            {
                var monAnXoa = dgvMonAn.CurrentRow.DataBoundItem as MonAn;

                if (monAnXoa != null)
                {
                    danhSachMonAn.Remove(monAnXoa);
                    ClearTextBoxes();
                    MessageBox.Show("Xóa món ăn thành công!");
                }
            }
        }
        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var monAn = dgvMonAn.Rows[e.RowIndex].DataBoundItem as MonAn;

                if (monAn != null)
                {
                    txtTenMonAn.Text = monAn.TenMonAn;
                    txtGia.Text = monAn.Gia.ToString();
                    txtMoTa.Text = monAn.MoTa;
                    chkTrangThai.Checked = monAn.TrangThai;

                    if (!string.IsNullOrEmpty(monAn.HinhAnh) && File.Exists(monAn.HinhAnh))
                    {
                        picMonAn.Image = Image.FromFile(monAn.HinhAnh);
                        picMonAn.Tag = monAn.HinhAnh;
                    }
                    else
                    {
                        picMonAn.Image = null;
                        picMonAn.Tag = null;
                    }
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh món ăn";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (picMonAn.Image != null)
                        picMonAn.Image.Dispose(); // Giải phóng hình ảnh cũ

                    picMonAn.Image = Image.FromFile(ofd.FileName);
                    picMonAn.Tag = ofd.FileName; // Lưu đường dẫn ảnh
                }
            }
        }
        private void ClearTextBoxes()
        {
            txtTenMonAn.Clear();
            txtGia.Clear();
            txtMoTa.Clear();
            chkTrangThai.Checked = false;
            picMonAn.Image = null;
            picMonAn.Tag = null;
        }

        private void txtTenMonAn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}