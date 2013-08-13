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
    public partial class DialogDoiTuong : Form
    {
        public DialogDoiTuong()
        {
            InitializeComponent();
            for (int i = 2013; i > 1900; i--)
            {
                cbbNam.Items.Add(i.ToString());
            }
            lbMaDoiTuong.Text = KetNoiSQL.generateNewID("DoiTuong");
            this.Text = "Thêm mới đối tượng";
        }
        public DialogDoiTuong(DoiTuong dt)
        {
            InitializeComponent();
            for (int i = 2013; i > 1900; i--)
            {
                cbbNam.Items.Add(i.ToString());
            }
            cbbNam.Text = dt.NgaySinh.Year.ToString();
            cbbThang.Text = dt.NgaySinh.Month.ToString();
            cbbNgay.Text = dt.NgaySinh.Day.ToString();
            lbMaDoiTuong.Text = dt.MaDT.ToString();
            txtHoTen.Text = dt.HoTen;
            txtQueQuan.Text = dt.QueQuan;
            if (dt.GioiTinh == "Nam") 
                rdbNam.Checked = true;
            else rdbNu.Checked = true;
            button1.Text = "Sửa";
            this.Text = "Sửa thông tin đối tượng";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DialogDoiTuong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoiTuong dt = new DoiTuong();
            dt.MaDT = Int32.Parse(lbMaDoiTuong.Text);
            dt.HoTen = txtHoTen.Text;
            dt.GioiTinh = rdbNu.Checked == true ? "Nữ" : "Nam";
            try
            {
                dt.NgaySinh = new DateTime(Int32.Parse(cbbNam.Text),
                                            Int32.Parse(cbbThang.Text),
                                            Int32.Parse(cbbNgay.Text)
                                          );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày không đúng!");
                return;
            }
            dt.QueQuan = txtQueQuan.Text;
            DoiTuong_Bus bus = new DoiTuong_Bus(dt);
            try {
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
    }
}
