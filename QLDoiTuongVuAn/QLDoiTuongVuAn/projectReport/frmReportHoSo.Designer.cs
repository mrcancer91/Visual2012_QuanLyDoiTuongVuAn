namespace QLDoiTuongVuAn.projectReport
{
    partial class frmReportHoSo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hoSoVuAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDoiTuongVuAnDataSet = new QLDoiTuongVuAn.QLDoiTuongVuAnDataSet();
            this.hoSoVuAnTableAdapter = new QLDoiTuongVuAn.QLDoiTuongVuAnDataSetTableAdapters.HoSoVuAnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hoSoVuAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDoiTuongVuAnDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hoSoVuAnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLDoiTuongVuAn.projectReport.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(946, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hồ sơ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(115, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(394, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xem báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hoSoVuAnBindingSource
            // 
            this.hoSoVuAnBindingSource.DataMember = "HoSoVuAn";
            this.hoSoVuAnBindingSource.DataSource = this.qLDoiTuongVuAnDataSet;
            // 
            // qLDoiTuongVuAnDataSet
            // 
            this.qLDoiTuongVuAnDataSet.DataSetName = "QLDoiTuongVuAnDataSet";
            this.qLDoiTuongVuAnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoSoVuAnTableAdapter
            // 
            this.hoSoVuAnTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportHoSo";
            this.Text = "frmReportHoSo";
            this.Load += new System.EventHandler(this.frmReportHoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoSoVuAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDoiTuongVuAnDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private QLDoiTuongVuAnDataSet qLDoiTuongVuAnDataSet;
        private System.Windows.Forms.BindingSource hoSoVuAnBindingSource;
        private QLDoiTuongVuAnDataSetTableAdapters.HoSoVuAnTableAdapter hoSoVuAnTableAdapter;
    }
}