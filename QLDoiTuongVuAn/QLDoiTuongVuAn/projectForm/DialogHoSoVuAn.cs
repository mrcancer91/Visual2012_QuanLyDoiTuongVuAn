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
    public partial class DialogHoSoVuAn : Form
    {
        /*
         * Constructor mặc định, sử dụng khi muốn thêm mới
         * */
        public DialogHoSoVuAn()
        {
            InitializeComponent();

            init();//thêm dữ liệu cho các combobox

            lbMa.Text = KetNoiSQL.generateNewID("HoSoVuAn");
        }

        /*
        * Constructor sử dụng cho việc sửa, với tham số truyền vào là 1 hồ sơ vụ án
        * */
        public DialogHoSoVuAn(HoSoVuAn va)
        {
            InitializeComponent();
            init();//thêm dữ liệu cho các combobox

            button1.Text = "Sửa";

            #region gán giá trị
            //Gán giá trị cho các texbox, label
            lbMa.Text = va.MaHoSo.ToString();
            txtDiaDiem.Text = va.DiaDiem;
            txtGhiChu.Text = va.GhiChu;
            txtHinhThucXuLy.Text = va.HinhThucXuLy;
            txtNgBiHai.Text = va.NguoiBiHai;
            txtToiDanh.Text = va.ToiDanh;
            txtThietHai.Text = va.ThietHai;
            dtpNgayLapHoSo.Value = va.NgayLap;
            dtpNgayPhamToi.Value = va.NgayXayRa;
            dtpNgayXuLy.Value = va.NgayXuLy;

            //gán giá trị cho các combobox
            for (int i = 0; i < cbbCanBo.Items.Count; i++)
            {
                if (cbbCanBo.Items[i].ToString().Contains(va.MaCB.ToString()))
                {
                    cbbCanBo.SelectedIndex = i;
                    i = 1000000;//ngặt vòng lặp
                }

            }
            for (int i = 0; i < cbbDoiTuong.Items.Count; i++)
            {
                if (cbbDoiTuong.Items[i].ToString().Contains(va.MaDT.ToString()))
                {
                    cbbDoiTuong.SelectedIndex = i;
                    i = 1000000;//ngặt vòng lặp
                }

            }
            for (int i = 0; i < cbbLoaiHinh.Items.Count; i++)
            {
                if (cbbLoaiHinh.Items[i].ToString().Contains(va.MaLH.ToString()))
                {
                    cbbLoaiHinh.SelectedIndex = i;
                    i = 1000000;//ngặt vòng lặp
                }

            }
            #endregion
        }

        /*
         * Hàm này sẽ lấy các giá trị tên và mã của cán bộ, đối tượng và loại hình phạm tội từ các dataTable bên form Hồ Sơ Vụ Án
         * */
        public void init()
        {
            for (int i = 0; i < FrmHoSoVuAn.canBo_data.Rows.Count; i++)
            {
                cbbCanBo.Items.Add(FrmHoSoVuAn.canBo_data.Rows[i][0].ToString() + " - " + FrmHoSoVuAn.canBo_data.Rows[i][1].ToString());
            }
            for (int i = 0; i < FrmHoSoVuAn.doiTuong_data.Rows.Count; i++)
            {
                cbbDoiTuong.Items.Add(FrmHoSoVuAn.doiTuong_data.Rows[i][0].ToString() + " - " + FrmHoSoVuAn.doiTuong_data.Rows[i][1].ToString());
            }
            for (int i = 0; i < FrmHoSoVuAn.loaiHinh_data.Rows.Count; i++)
            {
                cbbLoaiHinh.Items.Add(FrmHoSoVuAn.loaiHinh_data.Rows[i][0].ToString() + " - " + FrmHoSoVuAn.loaiHinh_data.Rows[i][1].ToString());
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Đây là hàm thêm mới
        private void button1_Click(object sender, EventArgs e)
        {
            HoSoVuAn hs = new HoSoVuAn();//Tạo mới hồ sơ vụ án


            //Gán giá trị cho hồ sơ
            hs.MaHoSo = Int32.Parse(lbMa.Text);
            hs.GhiChu = txtGhiChu.Text;
            hs.HinhThucXuLy = txtHinhThucXuLy.Text;
            hs.MaCB = Int32.Parse(cbbCanBo.Text.Split('-')[0].Trim());
            hs.MaDT = Int32.Parse(cbbDoiTuong.Text.Split('-')[0].Trim());
            hs.MaLH = Int32.Parse(cbbLoaiHinh.Text.Split('-')[0].Trim());
            hs.NgayLap = dtpNgayLapHoSo.Value;
            hs.NgayXayRa = dtpNgayPhamToi.Value;
            hs.NgayXuLy = dtpNgayXuLy.Value;
            hs.NguoiBiHai = txtNgBiHai.Text;
            hs.ToiDanh = txtToiDanh.Text;
            hs.ThietHai = txtThietHai.Text;
            hs.DiaDiem = txtDiaDiem.Text;


            /*Tạo mới dối tượng Bussines để thực hiện thêm hoặc sửa
             * Việc thêm hay sửa phụ thuộc vào text của nút, nếu là Thêm thì thực hiện thêm mới, nếu là sửa thì gọi hàm Update
             * Lưu ý: Không sửa mã
             * 
             * */
            HoSoVuAn_Bus bus = new HoSoVuAn_Bus(hs);
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
                MessageBox.Show("Lỗi: " + ex.Message);//Nếu xảy ra lỗi thì hiện ra thông báo
            }

        }
    }
}
