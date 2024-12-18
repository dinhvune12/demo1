using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApp10
{
    public partial class FrmDivideWorkSchedule : DevExpress.XtraEditors.XtraForm
    {
        public FrmDivideWorkSchedule()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Confirm ", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}