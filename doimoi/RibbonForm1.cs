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
            FrmUpdateIngre NNL = new FrmUpdateIngre();
            NNL.Show();
=======
            thanhToan tt = new thanhToan();
            tt.Show();
>>>>>>> 0cbff5b03a77b5762fbb97d909b55b15445a7465:doimoi/RibbonForm1.cs
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
<<<<<<< HEAD:WindowsFormsApp10/RibbonForm1.cs
            FrmInventoryFollow ITF = new FrmInventoryFollow();
            ITF.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmManageTime manageTime = new FrmManageTime(); 
            manageTime.Show();  
=======
            XuatHoaDon xhd = new XuatHoaDon();
            xhd.Show();
>>>>>>> 0cbff5b03a77b5762fbb97d909b55b15445a7465:doimoi/RibbonForm1.cs
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
<<<<<<< HEAD:WindowsFormsApp10/RibbonForm1.cs
            FrmTimekeeping TKP = new FrmTimekeeping();
            TKP.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDivideWorkSchedule Dive = new FrmDivideWorkSchedule();               
            Dive.Show();
=======
            BaoCao bc = new BaoCao();
            bc.Show();
>>>>>>> 0cbff5b03a77b5762fbb97d909b55b15445a7465:doimoi/RibbonForm1.cs
        }
    }
}