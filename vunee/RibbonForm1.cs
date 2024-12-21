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
            danhsachnhanvien quanlisodoban = new danhsachnhanvien();
            quanlisodoban.MdiParent = this;
            quanlisodoban.Show();
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
           
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
           quanlisodoban quanlisodobanne = new quanlisodoban();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            thanhToan quanlisodobanne = new thanhToan();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm1 quanlisodobanne = new XtraForm1();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            baocaodoanhthu quanlisodobanne = new baocaodoanhthu();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            tinhtrangban quanlisodobanne = new tinhtrangban();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            lichlamviec quanlisodobanne = new lichlamviec();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            lichchamcong quanlisodobanne = new lichchamcong();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            updatenguyenlieu quanlisodobanne = new updatenguyenlieu();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            invento quanlisodobanne = new invento();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            time quanlisodobanne = new time();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChamCongForm quanlisodobanne = new ChamCongForm();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            quanlichamcong quanlisodobanne = new quanlichamcong();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            datmon quanlisodobanne = new datmon();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {

            datmon quanlisodobanne = new datmon();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {

            phanhoi quanlisodobanne = new phanhoi();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                DangnhapFRM formDangNhap = new DangnhapFRM();
                formDangNhap.Show();
                this.Hide(); 
            }

        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
             quanlitaikhoan quanlisodobanne = new quanlitaikhoan();
            quanlisodobanne.MdiParent = this;
            quanlisodobanne.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void ribbon_ControlRemoved(object sender, ControlEventArgs e)
        {
           
        }
    }
}