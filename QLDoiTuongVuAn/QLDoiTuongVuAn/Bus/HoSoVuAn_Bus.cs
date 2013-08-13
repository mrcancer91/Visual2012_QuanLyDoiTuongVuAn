using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDoiTuongVuAn.Bus
{
    public partial class HoSoVuAn_Bus
    {
        private int _maHoSo;
        private int _maCB;
        private int _maDT;
        private int _maLH;
        private DateTime _ngayXayRa;
        private DateTime _ngayLap;
        private string _diaDiem;
        private string _toiDanh;
        private string _nguoiBiHai;
        private string _thietHai;
        private string _hinhThucXuLy;
        private DateTime _ngayXuLy;
        private string _ghiChu;

        public HoSoVuAn_Bus(Entity.HoSoVuAn hs)
        {
            _maHoSo = hs.MaHoSo;
            _maCB = hs.MaCB;
            _maDT = hs.MaDT;
            _maLH = hs.MaLH;
            _ngayXayRa = hs.NgayXayRa;
            _ngayLap = hs.NgayLap;
            _diaDiem = hs.DiaDiem;
            _toiDanh = hs.ToiDanh;
            _nguoiBiHai = hs.NguoiBiHai;
            _thietHai = hs.ThietHai;
            _hinhThucXuLy = hs.HinhThucXuLy;
            _ngayXuLy = hs.NgayXuLy;
            _ghiChu = hs.GhiChu;
        }

        public void Insert(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO HoSoVuAn (MaCB, MaDT, MaLH, NgayXayRa, NgayLap, DiaDiem, ToiDanh, NguoiBiHai, ThietHai, HinhThucXuLy, NgayXuLy, GhiChu) VALUES (@MaCB, @MaDT, @MaLH, @NgayXayRa, @NgayLap, @DiaDiem, @ToiDanh, @NguoiBiHai, @ThietHai, @HinhThucXuLy, @NgayXuLy, @GhiChu)";

            cmd.Parameters.AddWithValue("@MaCB", _maCB);
            cmd.Parameters.AddWithValue("@MaDT", _maDT);
            cmd.Parameters.AddWithValue("@MaLH", _maLH);
            cmd.Parameters.AddWithValue("@NgayXayRa", _ngayXayRa);
            cmd.Parameters.AddWithValue("@NgayLap", _ngayLap);
            cmd.Parameters.AddWithValue("@DiaDiem", _diaDiem);
            cmd.Parameters.AddWithValue("@ToiDanh", _toiDanh);
            cmd.Parameters.AddWithValue("@NguoiBiHai", _nguoiBiHai);
            cmd.Parameters.AddWithValue("@ThietHai", _thietHai);
            cmd.Parameters.AddWithValue("@HinhThucXuLy", _hinhThucXuLy);
            cmd.Parameters.AddWithValue("@NgayXuLy", _ngayXuLy);
            cmd.Parameters.AddWithValue("@GhiChu", _ghiChu);

            cmd.ExecuteNonQuery();
        }

        public void Load(System.Data.SqlClient.SqlConnection connection)
        {
            using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MaHoSo, MaCB, MaDT, MaLH, NgayXayRa, NgayLap, DiaDiem, ToiDanh, NguoiBiHai, ThietHai, HinhThucXuLy, NgayXuLy, GhiChu FROM HoSoVuAn WHERE MaHoSo=@MaHoSo";
                cmd.Parameters.AddWithValue("@MaHoSo", _maHoSo);

                System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();

                if (true == reader.Read())
                {
                    _maHoSo = reader.GetInt32(0);
                    _maCB = reader.GetInt32(1);
                    _maDT = reader.GetInt32(2);
                    _maLH = reader.GetInt32(3);
                    _ngayXayRa = reader.GetDateTime(4);
                    _ngayLap = reader.GetDateTime(5);
                    _diaDiem = reader.GetString(6);
                    _toiDanh = reader.GetString(7);
                    _nguoiBiHai = reader.GetString(8);
                    _thietHai = reader.GetString(9);
                    _hinhThucXuLy = reader.GetString(10);
                    _ngayXuLy = reader.GetDateTime(11);
                    _ghiChu = reader.GetString(12);

                }

                reader.Close();

            }

        }

        public void Update(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE HoSoVuAn SET  MaCB=@MaCB, MaDT=@MaDT, MaLH=@MaLH, NgayXayRa=@NgayXayRa, NgayLap=@NgayLap, DiaDiem=@DiaDiem, ToiDanh=@ToiDanh, NguoiBiHai=@NguoiBiHai, ThietHai=@ThietHai, HinhThucXuLy=@HinhThucXuLy, NgayXuLy=@NgayXuLy, GhiChu=@GhiChu WHERE MaHoSo=@MaHoSo";
            cmd.Parameters.AddWithValue("@MaHoSo", _maHoSo);
            cmd.Parameters.AddWithValue("@MaCB", _maCB);
            cmd.Parameters.AddWithValue("@MaDT", _maDT);
            cmd.Parameters.AddWithValue("@MaLH", _maLH);
            cmd.Parameters.AddWithValue("@NgayXayRa", _ngayXayRa);
            cmd.Parameters.AddWithValue("@NgayLap", _ngayLap);
            cmd.Parameters.AddWithValue("@DiaDiem", _diaDiem);
            cmd.Parameters.AddWithValue("@ToiDanh", _toiDanh);
            cmd.Parameters.AddWithValue("@NguoiBiHai", _nguoiBiHai);
            cmd.Parameters.AddWithValue("@ThietHai", _thietHai);
            cmd.Parameters.AddWithValue("@HinhThucXuLy", _hinhThucXuLy);
            cmd.Parameters.AddWithValue("@NgayXuLy", _ngayXuLy);
            cmd.Parameters.AddWithValue("@GhiChu", _ghiChu);

            cmd.ExecuteNonQuery();
        }

        public void Delete(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM HoSoVuAn WHERE MaHoSo=@MaHoSo";
            cmd.Parameters.AddWithValue("@MaHoSo", _maHoSo);

            cmd.ExecuteNonQuery();



        }
    }
}
