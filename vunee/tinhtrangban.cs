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
        public partial class tinhtrangban : DevExpress.XtraEditors.XtraForm
        {
       
        public tinhtrangban()
            {
                InitializeComponent();
           
        }

           
        
        
        
        
        

            private void button1_Click(object sender, EventArgs e)
            {
                
            }

            private void tinhtrangban_Load(object sender, EventArgs e)
            {
            
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            tablene2 form2 = new tablene2();
            form2.ShowDialog();
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            tablene3 form3 = new tablene3();
            form3.ShowDialog();
        }

        private void cbBan1_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChange(cbBan1, "Bàn 1");
        }

        private void cbBan2_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChange(cbBan2, "Bàn 2");
        }

        private void cbBan3_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChange(cbBan3, "Bàn 3");
        }
        private void HandleCheckBoxChange(CheckBox checkBox, string tenBan)
        {
            bool isChecked = checkBox.Checked;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn {(isChecked ? "đặt" : "hủy đặt")} {tenBan} không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"{tenBan} hiện đang {(isChecked ? "được đặt" : "trống")}.", "Thông báo");
            }
            else
            {
                checkBox.Checked = !isChecked; // Khôi phục trạng thái trước đó
            }
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            table1ne form1 = new table1ne();
            form1.ShowDialog();
        }
    }
    }