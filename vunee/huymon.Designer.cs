namespace WindowsFormsApp10
{
    partial class huymon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDanhSachMonAn = new System.Windows.Forms.DataGridView();
            this.btnHuyMon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachMonAn
            // 
            this.dgvDanhSachMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonAn.Location = new System.Drawing.Point(29, 11);
            this.dgvDanhSachMonAn.Name = "dgvDanhSachMonAn";
            this.dgvDanhSachMonAn.RowHeadersWidth = 51;
            this.dgvDanhSachMonAn.RowTemplate.Height = 24;
            this.dgvDanhSachMonAn.Size = new System.Drawing.Size(1347, 269);
            this.dgvDanhSachMonAn.TabIndex = 0;
            this.dgvDanhSachMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnHuyMon
            // 
            this.btnHuyMon.Location = new System.Drawing.Point(417, 369);
            this.btnHuyMon.Name = "btnHuyMon";
            this.btnHuyMon.Size = new System.Drawing.Size(121, 49);
            this.btnHuyMon.TabIndex = 1;
            this.btnHuyMon.Text = "Click";
            this.btnHuyMon.UseVisualStyleBackColor = false;
            this.btnHuyMon.Click += new System.EventHandler(this.btnHuyMon_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(281, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hủy món";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // huymon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 748);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuyMon);
            this.Controls.Add(this.dgvDanhSachMonAn);
            this.Name = "huymon";
            this.Text = "Huỷ món";
            this.Load += new System.EventHandler(this.huymon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachMonAn;
        private System.Windows.Forms.Button btnHuyMon;
        private System.Windows.Forms.Label label1;
    }
}