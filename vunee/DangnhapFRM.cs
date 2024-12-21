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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp10
{
    public partial class DangnhapFRM : DevExpress.XtraEditors.XtraForm
    {
        public DataTable DanhSachTaiKhoan { get; set; }
        public DangnhapFRM()
        {
            InitializeComponent();
        }

        private void DangnhapFRM_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tenTaiKhoan = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tài khoản trong danh sách
            var taiKhoan = Program.DanhSachTaiKhoan.FirstOrDefault(tk => tk.TenTaiKhoan == tenTaiKhoan && tk.MatKhau == matKhau);

            if (taiKhoan != null)
            {
                string quyenHan = taiKhoan.QuyenHan;
                MessageBox.Show($"Đăng nhập thành công! Chào mừng, {tenTaiKhoan}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isLoggedIn = true; // Cập nhật trạng thái đăng nhập
                HienThiFormTheoQuyen(quyenHan);
                this.Hide(); // Chỉ ẩn form đăng nhập
            }
            else if (tenTaiKhoan == "admin" && matKhau == "123") // Tài khoản admin mặc định
            {
                MessageBox.Show("Đăng nhập thành công với quyền Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isLoggedIn = true; // Cập nhật trạng thái đăng nhập
                RibbonForm1 formQuanLy = new RibbonForm1();
                formQuanLy.Show();
                this.Hide(); // Chỉ ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }

        }

        private void HienThiFormTheoQuyen(string quyenHan)
        {
            switch (quyenHan)
            {
                case "Quản lý":
                    RibbonForm5 formQuanLy = new RibbonForm5();
                    formQuanLy.Show();
                    break;
                case "Nhân viên":
                    RibbonForm2 formNhanVien = new RibbonForm2();
                    formNhanVien.Show();
                    break;
                case "Nhân viên bếp":
                    RibbonForm3 formNhanVienBep = new RibbonForm3();
                    formNhanVienBep.Show();
                    break;
                case "Thu ngân":
                    RibbonForm4 formThuNgan = new RibbonForm4();
                    formThuNgan.Show();
                    break;
                default:
                    MessageBox.Show("Quyền hạn không hợp lệ!", "Thông báo");
                    break;
            }

            this.Hide();

        }
        private bool isLoggedIn = false;
        private void DangnhapFRM_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void DangnhapFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggedIn)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RibbonForm7 formThuNgan = new RibbonForm7();
            formThuNgan.Show();
        }
    }
}
    
