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
    public partial class frmReoirtDoiTuong : Form
    {
        public frmReoirtDoiTuong()
        {
            InitializeComponent();
        }

        private void frmReoirtDoiTuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDoiTuongVuAnDataSet.DoiTuong' table. You can move, or remove it, as needed.
            this.doiTuongTableAdapter.Fill(this.qLDoiTuongVuAnDataSet.DoiTuong);

            this.reportViewer1.RefreshReport();
        }
    }
}
