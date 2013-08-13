using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDoiTuongVuAn.Util;
using QLDoiTuongVuAn.Bus;
using QLDoiTuongVuAn.projectForm;

namespace QLDoiTuongVuAn
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            KetNoiSQL.getConnectToMSSQL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCanBo frm = new FrmCanBo();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoiTuong frm = new FrmDoiTuong();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLoaiHinhViPham frm = new FrmLoaiHinhViPham();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmHoSoVuAn frm = new FrmHoSoVuAn();
            frm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            QLDoiTuongVuAn.projectReport.frmReportCanBo fr = new QLDoiTuongVuAn.projectReport.frmReportCanBo();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QLDoiTuongVuAn.projectReport.frmReoirtDoiTuong fr = new QLDoiTuongVuAn.projectReport.frmReoirtDoiTuong();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            QLDoiTuongVuAn.projectReport.frmReportHoSo fr = new QLDoiTuongVuAn.projectReport.frmReportHoSo();
            fr.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
