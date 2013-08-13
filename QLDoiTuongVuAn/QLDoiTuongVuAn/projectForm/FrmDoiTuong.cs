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
    public partial class FrmDoiTuong : Form
    {
        public FrmDoiTuong()
        {
            InitializeComponent();
            KetNoiSQL.getConnectToMSSQL();
        }
        private void FrmDoiTuong_Load(object sender, EventArgs e)
        {
            KetNoiSQL.loadAllDataFromTableToDataGridView("DoiTuong", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogDoiTuong dialog = new DialogDoiTuong();
            dialog.ShowDialog();
            KetNoiSQL.loadAllDataFromTableToDataGridView("DoiTuong", dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoiTuong dt = new DoiTuong();
            dt.MaDT = Int32.Parse(dataGridView1[0, rowIndex].Value.ToString());
            dt.HoTen = dataGridView1[1, rowIndex].Value.ToString();
            string[] temp = dataGridView1[2, rowIndex].Value.ToString().Split(' ')[0].Split('/') ;
            //MessageBox.Show(dataGridView1[2, rowIndex].Value.ToString() + " " + temp[1]);
            dt.NgaySinh = new DateTime( Int32.Parse(temp[2]),
                                        Int32.Parse(temp[1]),
                                        Int32.Parse(temp[0]));
            dt.QueQuan = dataGridView1[3, rowIndex].Value.ToString();
            dt.GioiTinh = dataGridView1[3, rowIndex].Value.ToString() == "Nam" ? "Nam" : "Nữ";
            DialogDoiTuong dialog = new DialogDoiTuong(dt);
            dialog.ShowDialog();
            KetNoiSQL.loadAllDataFromTableToDataGridView("DoiTuong", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    DoiTuong lh = new DoiTuong();
                    lh.MaDT = Int32.Parse(dataGridView1[0, rowIndex].Value.ToString());
                    DoiTuong_Bus bus = new DoiTuong_Bus(lh);
                    bus.Delete(KetNoiSQL.con);
                    KetNoiSQL.loadAllDataFromTableToDataGridView("DoiTuong", dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            KetNoiSQL.loadAllDataFromTableToDataGridView("DoiTuong", dataGridView1);
        }
        int rowIndex = -1;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}
