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
    public partial class DialogCanBo : Form
    {
        public DialogCanBo()
        {
            InitializeComponent();
            lbMa.Text = KetNoiSQL.generateNewID("CanBo");
            this.Text = "Thêm mới thông tin cán bộ";
        }

        public DialogCanBo(CanBo cb)
        {
            InitializeComponent();
            lbMa.Text = cb.MaCB.ToString();
            txtHoTen.Text = cb.HoTen;
            txtChucVu.Text = cb.ChucVu;
            txtDiaChi.Text = cb.DiaChi;
            txtDienThoai.Text = cb.DienThoai;
            this.Text = "Sửa thông tin cán bộ";
            button1.Text = "Sửa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CanBo lh = new CanBo();
            lh.MaCB = Int32.Parse(lbMa.Text);
            lh.HoTen = txtHoTen.Text;
            lh.ChucVu = txtChucVu.Text;
            lh.DiaChi = txtDiaChi.Text;
            try
            {
                lh.DienThoai = txtDienThoai.Text;
                Int32.Parse(lh.DienThoai);
            }
            catch(Exception ex) {
                MessageBox.Show("Số điện thoại không đúng");
                return;
            }
            CanBo_Bus bus = new CanBo_Bus(lh);
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
    }
}
