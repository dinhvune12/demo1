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
    public partial class RibbonForm2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private XtraTabbedMdiManager mdiManager;
        public RibbonForm2()
        {
            InitializeComponent();
            mdiManager = new XtraTabbedMdiManager
            {
                MdiParent = this // Gán RibbonForm1 làm MdiParent
            };

            this.WindowState = FormWindowState.Maximized;
        }

        private void RibbonForm2_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<datmon>();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<ChamCongForm>();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<tinhtrangban>();
        }
        private void OpenChildForm<T>() where T : Form, new()
        {
            // Kiểm tra nếu form đã được mở
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is T)
                {
                    frm.Activate(); // Nếu form đã mở, kích hoạt form đó
                    return;
                }
            }

            // Tạo form con mới nếu chưa mở
            T childForm = new T
            {
                MdiParent = this // Đặt RibbonForm1 là MdiParent
            };
            childForm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<huymon>();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<lichchamcong>();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<formlamviec>();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                DangnhapFRM formDangNhap = new DangnhapFRM();
                formDangNhap.Show();
                this.Hide();
            }
        }
    }
}