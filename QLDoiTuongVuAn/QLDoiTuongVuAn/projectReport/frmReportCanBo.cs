using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDoiTuongVuAn.projectReport
{
    public partial class frmReportCanBo : Form
    {
        public frmReportCanBo()
        {
            InitializeComponent();
        }

        private void frmReportCanBo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDoiTuongVuAnDataSet.CanBo' table. You can move, or remove it, as needed.
            this.canBoTableAdapter.Fill(this.qLDoiTuongVuAnDataSet.CanBo);
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
