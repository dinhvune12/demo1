using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class phanhoi : DevExpress.XtraEditors.XtraForm
    {
        private BindingList<Feedback> danhSachPhanHoi = new BindingList<Feedback>();
        public phanhoi()
        {
            InitializeComponent();
        }
        public class Feedback
        {
            public int ID { get; set; }
            public string NoiDung { get; set; }
            public string MucDoHaiLong { get; set; } // Tốt, Bình thường, Kém
            public DateTime ThoiGian { get; set; }
        }
        private void KhoiTaoDanhSachPhanHoi()
        {
            dgvPhanHoi.AutoGenerateColumns = false;

            dgvPhanHoi.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "Mã" });
            dgvPhanHoi.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NoiDung", HeaderText = "Nội dung phản hồi" });
            dgvPhanHoi.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MucDoHaiLong", HeaderText = "Mức độ hài lòng" });
            dgvPhanHoi.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThoiGian", HeaderText = "Thời gian phản hồi" });

            dgvPhanHoi.DataSource = danhSachPhanHoi;
            dgvPhanHoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        

        private void phanhoi_Load(object sender, EventArgs e)
        {
            KhoiTaoDanhSachPhanHoi();
        }

        private void btnThemPhanHoi_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtNoiDung.Text) && cmbMucDoHaiLong.SelectedIndex >= 0)
            {
                Feedback phanHoiMoi = new Feedback
                {
                    ID = danhSachPhanHoi.Count + 1,
                    NoiDung = txtNoiDung.Text,
                    MucDoHaiLong = cmbMucDoHaiLong.SelectedItem.ToString(),
                    ThoiGian = DateTime.Now
                };

                danhSachPhanHoi.Add(phanHoiMoi);

                MessageBox.Show("Phản hồi đã được thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNoiDung.Clear();
                cmbMucDoHaiLong.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung và chọn mức độ hài lòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuuPhanHoi_Click(object sender, EventArgs e)
        {
            string fileName = "Feedbacks.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("=== DANH SÁCH PHẢN HỒI ===");

                foreach (Feedback phanHoi in danhSachPhanHoi)
                {
                    writer.WriteLine($"Mã: {phanHoi.ID}");
                    writer.WriteLine($"Nội dung: {phanHoi.NoiDung}");
                    writer.WriteLine($"Mức độ hài lòng: {phanHoi.MucDoHaiLong}");
                    writer.WriteLine($"Thời gian: {phanHoi.ThoiGian}");
                    writer.WriteLine("-----------------------------------");
                }
            }

            MessageBox.Show($"Lưu phản hồi thành công vào file {fileName}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDocPhanHoi_Click(object sender, EventArgs e)
        {
            string fileName = "Feedbacks.txt";
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                MessageBox.Show(string.Join("\n", lines), "Danh sách phản hồi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("File phản hồi không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}