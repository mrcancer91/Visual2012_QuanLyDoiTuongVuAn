using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDoiTuongVuAn.Bus
{
    public class LoaiHinhViPham_Bus
    {
        private int _maLH;
        private string _tenLH;
        private string _moTa;

        public LoaiHinhViPham_Bus(Entity.LoaiHinhViPham lh)
        {
            _maLH = lh.MaLH;
            _tenLH = lh.TenLH;
            _moTa = lh.MoTa;
        }

        public void Insert(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO LoaiHinhViPham (TenLH, MoTa) VALUES (@TenLH, @MoTa)";
            cmd.Parameters.AddWithValue("@TenLH", _tenLH);
            cmd.Parameters.AddWithValue("@MoTa", _moTa);
            cmd.ExecuteNonQuery();
        }

        public void Load(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT MaLH, TenLH, MoTa FROM LoaiHinhViPham WHERE MaLH=@MaLH";
            cmd.Parameters.AddWithValue("@MaLH", _maLH);

            System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();

            if (true == reader.Read())
            {
                _maLH = reader.GetInt32(0);
                _tenLH = reader.GetString(1);
                _moTa = reader.GetString(2);

            }
            reader.Close();

        }

        public void Update(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE LoaiHinhViPham SET TenLH=@TenLH , MoTa=@MoTa  WHERE MaLH=@MaLH ";
            cmd.Parameters.AddWithValue("@MaLH", _maLH);
            cmd.Parameters.AddWithValue("@TenLH", _tenLH);
            cmd.Parameters.AddWithValue("@MoTa", _moTa);
            cmd.ExecuteNonQuery();
        }

        public void Delete(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM LoaiHinhViPham WHERE MaLH=@MaLH";
            cmd.Parameters.AddWithValue("@MaLH", _maLH);
            cmd.ExecuteNonQuery();
        }
    }
}
