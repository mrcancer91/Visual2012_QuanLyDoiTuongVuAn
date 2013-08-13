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
using System.Data.SqlClient;
namespace QLDoiTuongVuAn.projectForm
{
    public partial class FrmHoSoVuAn : Form
    {
        //3 DataTable này dùng để load dữ liệu lên các combobox trong form DialogHoSoVuAn phục vụ sửa, xóa
        public static DataTable canBo_data = new DataTable();
        public static DataTable doiTuong_data = new DataTable();
        public static DataTable loaiHinh_data = new DataTable();

        //Hàm khởi tạo
        public FrmHoSoVuAn()
        {
            InitializeComponent();

            //Đổ dữ liệu vào 3 DataTable
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaCB,hoTen FROM CanBo", KetNoiSQL.con);
            adapter.Fill(canBo_data);
            adapter = new SqlDataAdapter("SELECT MaDT,hoTen FROM DoiTuong", KetNoiSQL.con);
            adapter.Fill(doiTuong_data);
            adapter = new SqlDataAdapter("SELECT MaLH,TenLH FROM LoaiHinhViPham", KetNoiSQL.con);
            adapter.Fill(loaiHinh_data);
        }

        private void FrmHoSoVuAn_Load(object sender, EventArgs e)
        {
            KetNoiSQL.loadAllDataFromTableToDataGridView("HoSoVuAn", dataGridView1); //Load dữ liệu lên dataGridview
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Khi bấm nút thêm, mở form DialogHoSoVuAn để thêm mới
            DialogHoSoVuAn dialog = new DialogHoSoVuAn();
            dialog.ShowDialog();
            KetNoiSQL.loadAllDataFromTableToDataGridView("HoSoVuAn", dataGridView1); //Load lại datagridView sau khi thêm
        }
        int rowIndex = -1;// biến này là hàng hiện tại
        private void button3_Click(object sender, EventArgs e)
        {
            //Khi bấm nút sửa, tạo mới 1 hồ sơ vụ án mới. điền thông tin cho hồ sơ này
            HoSoVuAn hs = new HoSoVuAn();

            #region lấy dữ liệu từ datagridview cho vào hồ sơ vừa tạo
            hs.MaHoSo = Int32.Parse(dataGridView1[0, rowIndex].Value.ToString());
            hs.MaCB = Int32.Parse(dataGridView1[1, rowIndex].Value.ToString());
            hs.MaDT = Int32.Parse(dataGridView1[2, rowIndex].Value.ToString());
            hs.MaLH = Int32.Parse(dataGridView1[3, rowIndex].Value.ToString());

            string[] temp = dataGridView1[4, rowIndex].Value.ToString().Split(' ')[0].Split('/'); //Phải có dòng này để tách dateTime vì dữ liệu có dạng 17/04/1991 12:00:00AM
            hs.NgayXayRa = new DateTime(Int32.Parse(temp[2]),
                                        Int32.Parse(temp[1]),
                                        Int32.Parse(temp[0]));

            temp = dataGridView1[5, rowIndex].Value.ToString().Split(' ')[0].Split('/');
            hs.NgayLap = new DateTime(Int32.Parse(temp[2]),
                                       Int32.Parse(temp[1]),
                                       Int32.Parse(temp[0]));

            hs.DiaDiem = dataGridView1[6, rowIndex].Value.ToString();
            hs.ToiDanh = dataGridView1[7, rowIndex].Value.ToString();
            hs.NguoiBiHai = dataGridView1[8, rowIndex].Value.ToString();
            hs.ThietHai = dataGridView1[9, rowIndex].Value.ToString();
            hs.HinhThucXuLy = dataGridView1[10, rowIndex].Value.ToString();

            temp = dataGridView1[11, rowIndex].Value.ToString().Split(' ')[0].Split('/');
            hs.NgayXuLy = new DateTime(Int32.Parse(temp[2]),
                                       Int32.Parse(temp[1]),
                                       Int32.Parse(temp[0]));

            hs.GhiChu = dataGridView1[12, rowIndex].Value.ToString();
            #endregion

            //Mở dialog với tham số truyền vào là hồ sơ vừa tạp để thực hiện thao tác sửa
            DialogHoSoVuAn dialog = new DialogHoSoVuAn(hs);
            dialog.ShowDialog();
            KetNoiSQL.loadAllDataFromTableToDataGridView("HoSoVuAn", dataGridView1); // Cập nhật bảng sau khi sửa
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    HoSoVuAn lh = new HoSoVuAn();
                    lh.MaHoSo = Int32.Parse(dataGridView1[0, rowIndex].Value.ToString());
                    HoSoVuAn_Bus bus = new HoSoVuAn_Bus(lh);
                    bus.Delete(KetNoiSQL.con);
                    KetNoiSQL.loadAllDataFromTableToDataGridView("HoSoVuAn", dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
        }
    }
}
