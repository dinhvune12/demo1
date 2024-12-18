using DevExpress.Utils.CommonDialogs;
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
    public partial class danhsachnhanvien : DevExpress.XtraEditors.XtraForm
    {
        public danhsachnhanvien()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";  // Chỉ chọn các file ảnh

            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                // Đặt ảnh được chọn vào PictureBox
                pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbname_Click(object sender, EventArgs e)
        {

        }

        private void lbmss_Click(object sender, EventArgs e)
        {

        }

        private void lbsdt_Click(object sender, EventArgs e)
        {

        }

        private void denop_Click(object sender, EventArgs e)
        {
            int sodt;
            bool isValid = true;
            errorProvider1.Clear();
            if (tbdc.Text == "")
            {
                errorProvider1.SetError(tbdc, "Bạn chưa nhập đầy đủ");
                isValid = false;
            }
            if (tbname.Text == "")
            {
                errorProvider1.SetError(tbname, "Bạn chưa nhập đầy đủ");
                isValid = false;
            }

            if (tbmss.Text == "")
            {
                errorProvider1.SetError(tbmss, "Bạn chưa nhập đầy đủ");
                isValid = false;
            }
            if (tbsdt.Text == "")
            {
                errorProvider1.SetError(tbsdt, "Bạn chưa nhập số điện thoại");
                isValid = false;
            }
            else if (tbsdt.Text.Length != 10 || !tbsdt.Text.All(char.IsDigit) || int.TryParse(tbsdt.Text, out sodt) == false)
            {
                errorProvider1.SetError(tbsdt, "Số điện thoại phải gồm 10 chữ số hoặc sai định dạng");
                isValid = false;
            }
            
           


            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                return;
            }


            if (dengaysinh.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh.");
                return;
            }
            if (isValid)
            {

                string mss = tbmss.Text;
                string name = tbname.Text;
                string sdt = tbsdt.Text;
                string diachi = tbdc.Text;


                DateTime datetimene = dengaysinh.DateTime;
                string formattedate = datetimene.ToString("dd/MM/yyyy");

                string gioitinh = comboBox1.SelectedItem.ToString();


                dataGridView1.Rows.Add(mss, name, sdt, diachi, formattedate, gioitinh);


                tbmss.Clear();
                tbname.Clear();
                tbsdt.Clear();
                tbdc.Clear();
                comboBox1.SelectedIndex = -1;
                dengaysinh.EditValue = null;

            }
            else
            {
                MessageBox.Show("lam theo dung yeu cau");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                if (dataGridView1.SelectedRows[0].IsNewRow)
                {
                    MessageBox.Show("Bạn không thể xóa dòng mới.");
                    return;
                }
                DialogResult result = MessageBox.Show("ban co chac muon xoa khong", "thong bao", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
                else 
                {
                    MessageBox.Show("moi ban tiep tuc ");
                }
               
                
                 
                
            }
            else
            {
                MessageBox.Show("ban khong chon gi de xoa ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}