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
using QLDoiTuongVuAn.Entity;

namespace QLDoiTuongVuAn.projectForm
{
    public partial class FrmCanBo : Form
    {
        public FrmCanBo()
        {
            InitializeComponent();
            KetNoiSQL.getConnectToMSSQL();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    CanBo lh = new CanBo();
                    lh.MaCB = Int32.Parse(dataGridView1[0, rowIndex].Value.ToString());
                    CanBo_Bus bus = new CanBo_Bus(lh);
                    bus.Delete(KetNoiSQL.con);
                    KetNoiSQL.loadAllDataFromTableToDataGridView("CanBo", dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
        }
        int rowIndex = -1;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogCanBo dl = new DialogCanBo();
            dl.ShowDialog();
            KetNoiSQL.loadAllDataFromTableToDataGridView("CanBo", dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CanBo cb = new CanBo();
            cb.MaCB = Int32.Parse(dataGridView1[0, rowIndex].Value.ToString());
            cb.HoTen = dataGridView1[1, rowIndex].Value.ToString();
            cb.ChucVu = dataGridView1[2, rowIndex].Value.ToString();
            cb.DiaChi = dataGridView1[3, rowIndex].Value.ToString();
            cb.DienThoai = dataGridView1[4, rowIndex].Value.ToString();

            DialogCanBo dl = new DialogCanBo(cb);
            dl.ShowDialog();
            KetNoiSQL.loadAllDataFromTableToDataGridView("CanBo", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmCanBo_Load(object sender, EventArgs e)
        {
            KetNoiSQL.loadAllDataFromTableToDataGridView("CanBo", dataGridView1);
        }
    }
}
