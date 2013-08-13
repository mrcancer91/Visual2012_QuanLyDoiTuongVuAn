namespace QLDoiTuongVuAn.projectForm
{
    partial class DialogLoaiHinhViPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaLH = new System.Windows.Forms.Label();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại hình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả";
            // 
            // lbMaLH
            // 
            this.lbMaLH.AutoSize = true;
            this.lbMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMaLH.Location = new System.Drawing.Point(115, 9);
            this.lbMaLH.Name = "lbMaLH";
            this.lbMaLH.Size = new System.Drawing.Size(38, 17);
            this.lbMaLH.TabIndex = 3;
            this.lbMaLH.Text = "lbMa";
            // 
            // txtTenLH
            // 
            this.txtTenLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTenLH.Location = new System.Drawing.Point(118, 38);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(235, 23);
            this.txtTenLH.TabIndex = 4;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMoTa.Location = new System.Drawing.Point(118, 77);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(235, 111);
            this.txtMoTa.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(170, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DialogLoaiHinhViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenLH);
            this.Controls.Add(this.lbMaLH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DialogLoaiHinhViPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogLoaiHinhViPham";
            this.Load += new System.EventHandler(this.DialogLoaiHinhViPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMaLH;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button button1;
    }
}