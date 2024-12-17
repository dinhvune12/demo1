using DevExpress.XtraBars;
using DevExpress.XtraTabbedMdi;
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
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
           
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            danhsachnhanvien cc= new danhsachnhanvien();
           
           
            cc.MdiParent=this;

            cc.Show();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            quanlisodobanFRM quanlisodoban = new quanlisodobanFRM();   
            quanlisodoban.MdiParent = this;
            quanlisodoban.Show();
        }

        private void RibbonForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
            else
            {
                e.Cancel = true; 
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
<<<<<<< HEAD:WindowsFormsApp10/RibbonForm1.cs
            frm_TableStatus tableStatusForm = new frm_TableStatus();
            tableStatusForm.Show();
=======
            thanhToan tt = new thanhToan();
            tt.Show();
>>>>>>> c4160e4a997cd985ab865fc46b4849d3b90f3d31:WindowsFormsApp10thaydoi/RibbonForm1.cs
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
<<<<<<< HEAD:WindowsFormsApp10/RibbonForm1.cs
            frm_LichLV lichLamViecForm = new frm_LichLV();

            // Hiển thị form
            lichLamViecForm.Show();
=======
            XuatHoaDon xhd = new XuatHoaDon();
            xhd.Show();
>>>>>>> c4160e4a997cd985ab865fc46b4849d3b90f3d31:WindowsFormsApp10thaydoi/RibbonForm1.cs
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
<<<<<<< HEAD:WindowsFormsApp10/RibbonForm1.cs
            frmlichchamcong lichchamcongform = new frmlichchamcong();
            lichchamcongform.Show();
=======
            BaoCao bc = new BaoCao();
            bc.Show();
>>>>>>> c4160e4a997cd985ab865fc46b4849d3b90f3d31:WindowsFormsApp10thaydoi/RibbonForm1.cs
        }
    }
}