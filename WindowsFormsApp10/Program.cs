using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new quanlisodobanFRM());
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
    }
}
