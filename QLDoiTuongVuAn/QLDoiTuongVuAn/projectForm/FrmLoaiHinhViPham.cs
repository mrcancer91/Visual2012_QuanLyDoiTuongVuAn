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
    public partial class FrmLoaiHinhViPham : Form
    {
        public FrmLoaiHinhViPham()
        {
            InitializeComponent();
            KetNoiSQL.getConnectToMSSQL();
        }
        int rowIndex = -1;
        private void FrmLoaiHinhViPham_Load(object sender, EventArgs e)
        {
            KetNoiSQL.loadAllDataFromTableToDataGridView("LoaiHinhViPham", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogLoaiHinhViPham dialog = new DialogLoaiHinhViPham();
            dialog.ShowDialog();
            KetNoiSQL.loadAllDataFromTableToDataGridView("LoaiHinhViPham", dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoaiHinhViPham lh = new LoaiHinhViPham();
            lh.MaLH = Int32.Parse(dataGridView1[0,rowIndex].Value.ToString());
            lh.TenLH = dataGridView1[1, rowIndex].Value.ToString();
            lh.MoTa = dataGridView1[2, rowIndex].Value.ToString();

            DialogLoaiHinhViPham dialog = new DialogLoaiHinhViPham(lh);
            dialog.ShowDialog();
            KetNoiSQL.loadAllDataFromTableToDataGridView("LoaiHinhViPham", dataGridView1);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thực sự muốn xóa?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            try
            {
                LoaiHinhViPham lh = new LoaiHinhViPham();
                lh.MaLH = Int32.Parse(dataGridView1[0, rowIndex].Value.ToString());
                LoaiHinhViPham_Bus bus = new LoaiHinhViPham_Bus(lh);
                bus.Delete(KetNoiSQL.con);
                KetNoiSQL.loadAllDataFromTableToDataGridView("LoaiHinhViPham", dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        
    }
}
