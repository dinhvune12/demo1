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
    public partial class FormNhapThongTinBan : DevExpress.XtraEditors.XtraForm
    {
        public FormNhapThongTinBan()
        {
            InitializeComponent();
        }
        public int SoLuong { get; private set; }
        public string Hang { get; private set; }
        public Image AnhBan { get; private set; }
        private void FormNhapThongTinBan_Load(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AnhBan = Image.FromFile(openFileDialog.FileName);
                pictureBoxBan.Image = AnhBan; // Hiển thị ảnh trong PictureBox
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtSoLuong.Text, out int soLuong) && !string.IsNullOrWhiteSpace(txtHang.Text) && AnhBan != null)
            {
                SoLuong = soLuong;
                Hang = txtHang.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn ảnh!", "Thông báo");
            }
        
    }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}