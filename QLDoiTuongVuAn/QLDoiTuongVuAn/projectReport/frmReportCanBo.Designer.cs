namespace QLDoiTuongVuAn.projectReport
{
    partial class frmReportCanBo
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
            this.qLDoiTuongVuAnDataSet = new QLDoiTuongVuAn.QLDoiTuongVuAnDataSet();
            this.canBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canBoTableAdapter = new QLDoiTuongVuAn.QLDoiTuongVuAnDataSetTableAdapters.CanBoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLDoiTuongVuAnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.canBoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLDoiTuongVuAn.projectReport.reportCanBo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(671, 402);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // qLDoiTuongVuAnDataSet
            // 
            this.qLDoiTuongVuAnDataSet.DataSetName = "QLDoiTuongVuAnDataSet";
            this.qLDoiTuongVuAnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // canBoBindingSource
            // 
            this.canBoBindingSource.DataMember = "CanBo";
            this.canBoBindingSource.DataSource = this.qLDoiTuongVuAnDataSet;
            // 
            // canBoTableAdapter
            // 
            this.canBoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 402);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportCanBo";
            this.Text = "frmReportCanBo";
            this.Load += new System.EventHandler(this.frmReportCanBo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDoiTuongVuAnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLDoiTuongVuAnDataSet qLDoiTuongVuAnDataSet;
        private System.Windows.Forms.BindingSource canBoBindingSource;
        private QLDoiTuongVuAnDataSetTableAdapters.CanBoTableAdapter canBoTableAdapter;
    }
}