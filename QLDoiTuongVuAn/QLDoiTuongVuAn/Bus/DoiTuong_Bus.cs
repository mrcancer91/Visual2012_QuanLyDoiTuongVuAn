using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDoiTuongVuAn.Bus
{
    public partial class DoiTuong_Bus
    {
        private int _maDT;
        private string _hoTen;
        private DateTime _ngaySinh;
        private string _queQuan;
        private string _gioiTinh;


        public DoiTuong_Bus(Entity.DoiTuong dt)
        {
            _maDT = dt.MaDT;
            _hoTen = dt.HoTen;
            _ngaySinh = dt.NgaySinh;
            _queQuan = dt.QueQuan;
            _gioiTinh = dt.GioiTinh;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        public void Insert(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO DoiTuong (HoTen, NgaySinh, QueQuan, GioiTinh) VALUES (@HoTen, @NgaySinh, @QueQuan, @GioiTinh)";
           
            cmd.Parameters.AddWithValue("@HoTen", _hoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", _ngaySinh);
            cmd.Parameters.AddWithValue("@QueQuan", _queQuan);
            cmd.Parameters.AddWithValue("@GioiTinh", _gioiTinh);

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Load(System.Data.SqlClient.SqlConnection connection)
        {
            using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MaDT, HoTen, NgaySinh, QueQuan, GioiTinh FROM DoiTuong WHERE MaDT=@MaDT";
                cmd.Parameters.AddWithValue("@MaDT", _maDT);

                System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
                if (true == reader.Read())
                {
                    _maDT = reader.GetInt32(0);
                    _hoTen = reader.GetString(1);
                    _ngaySinh = reader.GetDateTime(2);
                    _queQuan = reader.GetString(3);
                    _gioiTinh = reader.GetString(4);

                }
                reader.Close();

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        public void Update(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE DoiTuong SET HoTen=@HoTen, NgaySinh=@NgaySinh, QueQuan=@QueQuan, GioiTinh=@GioiTinh WHERE MaDT=@MaDT";
            cmd.Parameters.AddWithValue("@MaDT", _maDT);
            cmd.Parameters.AddWithValue("@HoTen", _hoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", _ngaySinh);
            cmd.Parameters.AddWithValue("@QueQuan", _queQuan);
            cmd.Parameters.AddWithValue("@GioiTinh", _gioiTinh);

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        public void Delete(System.Data.SqlClient.SqlConnection connection)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM DoiTuong WHERE MaDT=@MaDT";
            cmd.Parameters.AddWithValue("@MaDT", _maDT);

            cmd.ExecuteNonQuery();



        }
    }
}
