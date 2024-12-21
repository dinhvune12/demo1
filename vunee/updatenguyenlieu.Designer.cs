namespace WindowsFormsApp10
{
    partial class updatenguyenlieu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaNguyenLieu = new System.Windows.Forms.Button();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThemNguyenLieu = new System.Windows.Forms.Button();
            this.btnCapNhatNguyenLieu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(56, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 97);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 40F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Ingredients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 167);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 49);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Update Setting";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(67, 233);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowHeadersWidth = 51;
            this.dgvNguyenLieu.RowTemplate.Height = 24;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(903, 453);
            this.dgvNguyenLieu.TabIndex = 12;
            this.dgvNguyenLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(70, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lofi Beer";
            // 
            // btnXoaNguyenLieu
            // 
            this.btnXoaNguyenLieu.Location = new System.Drawing.Point(1227, 400);
            this.btnXoaNguyenLieu.Name = "btnXoaNguyenLieu";
            this.btnXoaNguyenLieu.Size = new System.Drawing.Size(123, 47);
            this.btnXoaNguyenLieu.TabIndex = 13;
            this.btnXoaNguyenLieu.Text = "Xoá";
            this.btnXoaNguyenLieu.UseVisualStyleBackColor = true;
            this.btnXoaNguyenLieu.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(1151, 233);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(213, 23);
            this.txtTenNguyenLieu.TabIndex = 15;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(1151, 321);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(213, 23);
            this.txtSoLuong.TabIndex = 16;
            // 
            // btnThemNguyenLieu
            // 
            this.btnThemNguyenLieu.Location = new System.Drawing.Point(976, 400);
            this.btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            this.btnThemNguyenLieu.Size = new System.Drawing.Size(99, 47);
            this.btnThemNguyenLieu.TabIndex = 17;
            this.btnThemNguyenLieu.Text = "Thêm sản phẩm mới";
            this.btnThemNguyenLieu.UseVisualStyleBackColor = true;
            this.btnThemNguyenLieu.Click += new System.EventHandler(this.btnThemNguyenLieu_Click);
            // 
            // btnCapNhatNguyenLieu
            // 
            this.btnCapNhatNguyenLieu.Location = new System.Drawing.Point(1103, 400);
            this.btnCapNhatNguyenLieu.Name = "btnCapNhatNguyenLieu";
            this.btnCapNhatNguyenLieu.Size = new System.Drawing.Size(95, 47);
            this.btnCapNhatNguyenLieu.TabIndex = 18;
            this.btnCapNhatNguyenLieu.Text = "Cập nhập";
            this.btnCapNhatNguyenLieu.UseVisualStyleBackColor = true;
            this.btnCapNhatNguyenLieu.Click += new System.EventHandler(this.btnCapNhatNguyenLieu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(997, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nhập tên nguyên liệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(997, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số lượng";
            // 
            // updatenguyenlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 739);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCapNhatNguyenLieu);
            this.Controls.Add(this.btnThemNguyenLieu);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvNguyenLieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoaNguyenLieu);
            this.Name = "updatenguyenlieu";
            this.Text = "Cập Nhập Nguyên Liệu";
            this.Load += new System.EventHandler(this.updatenguyenlieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaNguyenLieu;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThemNguyenLieu;
        private System.Windows.Forms.Button btnCapNhatNguyenLieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}