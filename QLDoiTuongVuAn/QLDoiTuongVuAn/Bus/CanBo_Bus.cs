using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDoiTuongVuAn.Bus
{
    public partial class CanBo_Bus
    {
        private int _maCB;
        private string _hoTen;
        private string _chucVu;
        private string _diaChi;
        private string _dienThoai;

        public CanBo_Bus(Entity.CanBo cb)
        {
            _maCB = cb.MaCB;
            _hoTen = cb.HoTen;
            _chucVu = cb.ChucVu;
            _diaChi = cb.DiaChi;
            _dienThoai = cb.DienThoai;
        }
       
        public void Insert(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO CanBo (HoTen, ChucVu, DiaChi, DienThoai) VALUES (@HoTen, @ChucVu, @DiaChi, @DienThoai)";
            cmd.Parameters.AddWithValue("@HoTen", _hoTen);
            cmd.Parameters.AddWithValue("@ChucVu", _chucVu);
            cmd.Parameters.AddWithValue("@DiaChi", _diaChi);
            cmd.Parameters.AddWithValue("@DienThoai", _dienThoai);
            cmd.ExecuteNonQuery();
        }

        
        public void Load(System.Data.SqlClient.SqlConnection connection)
        {
            using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MaCB, HoTen, ChucVu, DiaChi, DienThoai FROM CanBo WHERE MaCB=@MaCB";
                cmd.Parameters.AddWithValue("@MaCB", _maCB);

                System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();

                if (true == reader.Read())
                {
                    _maCB = reader.GetInt32(0);
                    _hoTen = reader.GetString(1);
                    _chucVu = reader.GetString(2);
                    _diaChi = reader.GetString(3);
                    _dienThoai = reader.GetString(4);

                }
                reader.Close();
            }

        }

       
        public void Update(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE CanBo SET HoTen=@HoTen, ChucVu=@ChucVu, DiaChi=@DiaChi, DienThoai=@DienThoai WHERE MaCB=@MaCB";
            cmd.Parameters.AddWithValue("@MaCB", _maCB);
            cmd.Parameters.AddWithValue("@HoTen", _hoTen);
            cmd.Parameters.AddWithValue("@ChucVu", _chucVu);
            cmd.Parameters.AddWithValue("@DiaChi", _diaChi);
            cmd.Parameters.AddWithValue("@DienThoai", _dienThoai);

            cmd.ExecuteNonQuery();
        }


        public void Delete(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM CanBo WHERE MaCB=@MaCB";
            cmd.Parameters.AddWithValue("@MaCB", _maCB);

            cmd.ExecuteNonQuery();



        }
    }
}
