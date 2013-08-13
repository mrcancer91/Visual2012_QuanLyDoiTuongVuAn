using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDoiTuongVuAn.Entity;
using QLDoiTuongVuAn.Bus;
using QLDoiTuongVuAn.Util;
namespace QLDoiTuongVuAn.projectForm
{
    public partial class DialogLoaiHinhViPham : Form
    {
        public DialogLoaiHinhViPham()
        {
            InitializeComponent();
            lbMaLH.Text = KetNoiSQL.generateNewID("LoaiHinhViPham");
        }
        public DialogLoaiHinhViPham(LoaiHinhViPham lh)
        {
            InitializeComponent();
            txtMoTa.Text = lh.MoTa;
            txtTenLH.Text = lh.TenLH;
            lbMaLH.Text = lh.MaLH.ToString();
            button1.Text = "Sửa";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoaiHinhViPham lh = new LoaiHinhViPham();
            lh.MaLH = Int32.Parse(lbMaLH.Text);
            lh.TenLH = txtTenLH.Text;
            lh.MoTa = txtMoTa.Text;
            LoaiHinhViPham_Bus bus = new LoaiHinhViPham_Bus(lh);
            try
            {
                if (button1.Text == "Thêm")
                {
                    bus.Insert(KetNoiSQL.con);
                }
                else
                {
                    bus.Update(KetNoiSQL.con);
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DialogLoaiHinhViPham_Load(object sender, EventArgs e)
        {

        }
    }
}
