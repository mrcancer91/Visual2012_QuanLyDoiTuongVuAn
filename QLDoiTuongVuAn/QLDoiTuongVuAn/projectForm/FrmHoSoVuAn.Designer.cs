namespace QLDoiTuongVuAn.projectForm
{
    partial class FrmHoSoVuAn
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
            this.MaHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXayRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToiDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiBiHai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThietHai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoSo,
            this.MaCB,
            this.MaDT,
            this.MaLH,
            this.NgayXayRa,
            this.NgayLap,
            this.DiaDiem,
            this.ToiDanh,
            this.NguoiBiHai,
            this.ThietHai,
            this.HinhThucXuLy,
            this.NgayXuLy,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // MaHoSo
            // 
            this.MaHoSo.DataPropertyName = "MaHoSo";
            this.MaHoSo.HeaderText = "Mã hồ sơ";
            this.MaHoSo.Name = "MaHoSo";
            this.MaHoSo.ReadOnly = true;
            // 
            // MaCB
            // 
            this.MaCB.DataPropertyName = "MaCB";
            this.MaCB.HeaderText = "Mã cán bộ";
            this.MaCB.Name = "MaCB";
            this.MaCB.ReadOnly = true;
            // 
            // MaDT
            // 
            this.MaDT.DataPropertyName = "MaDT";
            this.MaDT.HeaderText = "Mã đối tượng";
            this.MaDT.Name = "MaDT";
            this.MaDT.ReadOnly = true;
            // 
            // MaLH
            // 
            this.MaLH.DataPropertyName = "MaLH";
            this.MaLH.HeaderText = "Mã loại hình vi phạm";
            this.MaLH.Name = "MaLH";
            this.MaLH.ReadOnly = true;
            // 
            // NgayXayRa
            // 
            this.NgayXayRa.DataPropertyName = "NgayXayRa";
            this.NgayXayRa.HeaderText = "Ngày phạm tội";
            this.NgayXayRa.Name = "NgayXayRa";
            this.NgayXayRa.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            // 
            // ToiDanh
            // 
            this.ToiDanh.DataPropertyName = "ToiDanh";
            this.ToiDanh.HeaderText = "Tội danh";
            this.ToiDanh.Name = "ToiDanh";
            this.ToiDanh.ReadOnly = true;
            // 
            // NguoiBiHai
            // 
            this.NguoiBiHai.DataPropertyName = "NguoiBiHai";
            this.NguoiBiHai.HeaderText = "Người bị hại";
            this.NguoiBiHai.Name = "NguoiBiHai";
            this.NguoiBiHai.ReadOnly = true;
            // 
            // ThietHai
            // 
            this.ThietHai.DataPropertyName = "ThietHai";
            this.ThietHai.HeaderText = "Thiệt hại";
            this.ThietHai.Name = "ThietHai";
            this.ThietHai.ReadOnly = true;
            // 
            // HinhThucXuLy
            // 
            this.HinhThucXuLy.DataPropertyName = "HinhThucXuLy";
            this.HinhThucXuLy.HeaderText = "Hình thức xử lý";
            this.HinhThucXuLy.Name = "HinhThucXuLy";
            this.HinhThucXuLy.ReadOnly = true;
            // 
            // NgayXuLy
            // 
            this.NgayXuLy.DataPropertyName = "NgayXuLy";
            this.NgayXuLy.HeaderText = "Ngày xử lý";
            this.NgayXuLy.Name = "NgayXuLy";
            this.NgayXuLy.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(203, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(433, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theo tên đối tượng",
            "Theo ngày lập"});
            this.comboBox1.Location = new System.Drawing.Point(290, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(711, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(337, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(494, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(644, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmHoSoVuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 398);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmHoSoVuAn";
            this.Text = "Quản lý hồ sơ";
            this.Load += new System.EventHandler(this.FrmHoSoVuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXayRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToiDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiBiHai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietHai;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucXuLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}