﻿using DevExpress.XtraBars;
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
    
    public partial class RibbonForm4 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private XtraTabbedMdiManager mdiManager;
        public RibbonForm4()
        {
            InitializeComponent();
            mdiManager = new XtraTabbedMdiManager
            {
                MdiParent = this // Gán RibbonForm1 làm MdiParent
            };

            this.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<ChamCongForm>();
        }

        private void RibbonForm4_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
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

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<thanhToan>();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<XtraForm1>();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<baocaodoanhthu>();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<formlamviec>();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm<lichchamcong>();
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