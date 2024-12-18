namespace WindowsFormsApp10
{
    partial class danhsachnhanvien
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.denop = new System.Windows.Forms.Button();
            this.lbgt = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dengaysinh = new DevExpress.XtraEditors.DateEdit();
            this.lbns = new System.Windows.Forms.Label();
            this.tbdc = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbmss = new System.Windows.Forms.TextBox();
            this.lbmss = new System.Windows.Forms.Label();
            this.lbdc = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dengaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dengaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 404);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "đưa ảnh của bạn vô đây";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.denop);
            this.groupBox2.Controls.Add(this.lbgt);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.dengaysinh);
            this.groupBox2.Controls.Add(this.lbns);
            this.groupBox2.Controls.Add(this.tbdc);
            this.groupBox2.Controls.Add(this.tbsdt);
            this.groupBox2.Controls.Add(this.tbname);
            this.groupBox2.Controls.Add(this.tbmss);
            this.groupBox2.Controls.Add(this.lbmss);
            this.groupBox2.Controls.Add(this.lbdc);
            this.groupBox2.Controls.Add(this.lbname);
            this.groupBox2.Controls.Add(this.lbsdt);
            this.groupBox2.Location = new System.Drawing.Point(722, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 424);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(437, 86);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(137, 23);
            this.btxoa.TabIndex = 14;
            this.btxoa.Text = "xoa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // denop
            // 
            this.denop.Location = new System.Drawing.Point(437, 235);
            this.denop.Name = "denop";
            this.denop.Size = new System.Drawing.Size(137, 23);
            this.denop.TabIndex = 13;
            this.denop.Text = "chọn để nôp";
            this.denop.UseVisualStyleBackColor = true;
            this.denop.Click += new System.EventHandler(this.denop_Click);
            // 
            // lbgt
            // 
            this.lbgt.AutoSize = true;
            this.lbgt.Location = new System.Drawing.Point(46, 235);
            this.lbgt.Name = "lbgt";
            this.lbgt.Size = new System.Drawing.Size(52, 16);
            this.lbgt.TabIndex = 12;
            this.lbgt.Text = "giới tính";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "dasdas";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nũ"});
            this.comboBox1.Location = new System.Drawing.Point(175, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "asdasd";
            // 
            // dengaysinh
            // 
            this.dengaysinh.EditValue = null;
            this.dengaysinh.Location = new System.Drawing.Point(175, 185);
            this.dengaysinh.Name = "dengaysinh";
            this.dengaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dengaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dengaysinh.Size = new System.Drawing.Size(173, 22);
            this.dengaysinh.TabIndex = 10;
            // 
            // lbns
            // 
            this.lbns.AutoSize = true;
            this.lbns.Location = new System.Drawing.Point(43, 185);
            this.lbns.Name = "lbns";
            this.lbns.Size = new System.Drawing.Size(61, 16);
            this.lbns.TabIndex = 8;
            this.lbns.Text = "ngày sinh";
            // 
            // tbdc
            // 
            this.tbdc.Location = new System.Drawing.Point(175, 156);
            this.tbdc.Name = "tbdc";
            this.tbdc.Size = new System.Drawing.Size(173, 23);
            this.tbdc.TabIndex = 7;
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(175, 126);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(173, 23);
            this.tbsdt.TabIndex = 6;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(175, 96);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(173, 23);
            this.tbname.TabIndex = 5;
            // 
            // tbmss
            // 
            this.tbmss.Location = new System.Drawing.Point(175, 66);
            this.tbmss.Name = "tbmss";
            this.tbmss.Size = new System.Drawing.Size(173, 23);
            this.tbmss.TabIndex = 4;
            // 
            // lbmss
            // 
            this.lbmss.Location = new System.Drawing.Point(43, 66);
            this.lbmss.Name = "lbmss";
            this.lbmss.Size = new System.Drawing.Size(95, 16);
            this.lbmss.TabIndex = 3;
            this.lbmss.Text = "mss";
            this.lbmss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbmss.Click += new System.EventHandler(this.lbmss_Click);
            // 
            // lbdc
            // 
            this.lbdc.Location = new System.Drawing.Point(43, 155);
            this.lbdc.Name = "lbdc";
            this.lbdc.Size = new System.Drawing.Size(95, 16);
            this.lbdc.TabIndex = 2;
            this.lbdc.Text = "địa chỉ";
            this.lbdc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbdc.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbname
            // 
            this.lbname.Location = new System.Drawing.Point(43, 94);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(95, 16);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "name";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbname.Click += new System.EventHandler(this.lbname_Click);
            // 
            // lbsdt
            // 
            this.lbsdt.Location = new System.Drawing.Point(43, 122);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(95, 16);
            this.lbsdt.TabIndex = 0;
            this.lbsdt.Text = "sdt";
            this.lbsdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbsdt.Click += new System.EventHandler(this.lbsdt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.errorProvider1.SetIconAlignment(this.dataGridView1, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.dataGridView1.Location = new System.Drawing.Point(2, 422);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 297);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "mss";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SDT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giới tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // danhsachnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 758);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "danhsachnhanvien";
            this.Text = "Quản lí danh sách nhân viên";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dengaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dengaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbmss;
        private System.Windows.Forms.Label lbdc;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.TextBox tbdc;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbmss;
        private DevExpress.XtraEditors.DateEdit dengaysinh;
        private System.Windows.Forms.Label lbns;
        private System.Windows.Forms.Label lbgt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button denop;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}