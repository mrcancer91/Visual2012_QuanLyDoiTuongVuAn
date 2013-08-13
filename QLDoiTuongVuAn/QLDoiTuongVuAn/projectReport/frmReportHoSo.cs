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
    public partial class frmReportHoSo : Form
    {
        public frmReportHoSo()
        {
            InitializeComponent();
        }

        private void frmReportHoSo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDoiTuongVuAnDataSet.HoSoVuAn' table. You can move, or remove it, as needed.
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = -1;
            try
            {
                temp = Int32.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã hồ sơ chỉ là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.hoSoVuAnTableAdapter.Fill(this.qLDoiTuongVuAnDataSet.HoSoVuAn,temp);

            this.reportViewer1.RefreshReport();
        }
    }
}
