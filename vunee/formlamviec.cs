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
    public partial class formlamviec : DevExpress.XtraEditors.XtraForm
    {
        public formlamviec()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lichlamviec frmCalamForm = new lichlamviec();

            // Hiển thị form frmcalam
            frmCalamForm.Show();
        }

        private void formlamviec_Load(object sender, EventArgs e)
        {

        }
    }
}