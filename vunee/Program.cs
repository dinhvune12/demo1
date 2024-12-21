using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp10.MonAn;

namespace WindowsFormsApp10
{
    internal static class Program
    {
        public static List<TaiKhoan> DanhSachTaiKhoan = new List<TaiKhoan>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DanhSachTaiKhoan.Add(new TaiKhoan { TenTaiKhoan = "quanli", MatKhau = "123", QuyenHan = "Quản lý" });
            DanhSachTaiKhoan.Add(new TaiKhoan { TenTaiKhoan = "nhanvien", MatKhau = "123", QuyenHan = "Nhân viên" });
            DanhSachTaiKhoan.Add(new TaiKhoan { TenTaiKhoan = "thungan", MatKhau = "123", QuyenHan = "Thu ngân" });
            DanhSachTaiKhoan.Add(new TaiKhoan { TenTaiKhoan = "nhanvienbepne", MatKhau = "123", QuyenHan = "Nhân viên bếp" });
            Application.Run(new DangnhapFRM());
        }
    }
    public class MonAn
    {
        public int MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public decimal Gia { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }
        public string HinhAnh { get; internal set; }


        public class TaiKhoan
        {
            public string TenTaiKhoan { get; set; }
            public string MatKhau { get; set; }
            public string QuyenHan { get; set; }
        }
    }
}
