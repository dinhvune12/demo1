namespace WindowsFormsApp10
{
    partial class lichlamviec
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPreviousWeek = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.lblWeek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 587);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPreviousWeek
            // 
            this.btnPreviousWeek.Location = new System.Drawing.Point(190, 649);
            this.btnPreviousWeek.Name = "btnPreviousWeek";
            this.btnPreviousWeek.Size = new System.Drawing.Size(172, 55);
            this.btnPreviousWeek.TabIndex = 1;
            this.btnPreviousWeek.Text = "Tuần trước";
            this.btnPreviousWeek.UseVisualStyleBackColor = true;
            this.btnPreviousWeek.Click += new System.EventHandler(this.btnPreviousWeek_Click);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(543, 649);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(175, 55);
            this.btnNextWeek.TabIndex = 2;
            this.btnNextWeek.Text = "Tuần sau";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(765, 668);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(23, 16);
            this.lblWeek.TabIndex = 3;
            this.lblWeek.Text = "    ";
            this.lblWeek.Click += new System.EventHandler(this.lblWeek_Click);
            // 
            // lichlamviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 747);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.btnNextWeek);
            this.Controls.Add(this.btnPreviousWeek);
            this.Controls.Add(this.dataGridView1);
            this.Name = "lichlamviec";
            this.Text = "Lịch Làm Việc";
            this.Load += new System.EventHandler(this.lichlamviec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPreviousWeek;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Label lblWeek;
    }
}