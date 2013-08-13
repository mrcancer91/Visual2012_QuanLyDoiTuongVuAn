using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLDoiTuongVuAn.Util
{
    public static class KetNoiSQL
    {
        public static SqlConnection con = null;

        /// <summary>
        /// Phương thức này sẽ tạo connection đến SQL Server
        /// </summary>
        public static void getConnectToMSSQL()
        {
            /*
             * Chuỗi kết nối. Để chạy được project. Cần đặt tên database là QLDoiTuongVuAn, tên server lấy trong SQL
             * */
            string connectionString = "Data Source=.;Initial Catalog=QLDoiTuongVuAn;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
        }

        /// <summary>
        /// Phương thức này sẽ load tất cả dữ liệu từ bảng trong SQL lên datagridView trên form.
        /// </summary>
        /// <param name="tableName">biến này là tên bảng trong SQL</param>
        /// <param name="gridView">biến này là DataGridView trên form</param>
        public static void loadAllDataFromTableToDataGridView(string tableName, DataGridView gridView)
        {
            string sqlStr = "select * from " + tableName;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridView.DataSource = table;
        }

        /// <summary>
        /// Phương thức này sẽ lấy giá trị mã tiếp theo của bảng bất kỳ trong sqlserver với cột mã có thuộc tính tự tăng identity
        /// </summary>
        /// <param name="tableName">Tên bảng trong SQL</param>
        /// <returns>mã mới tự sinh</returns>
        public static string generateNewID(string tableName)
        {
            string strSql = "SELECT IDENT_CURRENT('" + tableName + "')+IDENT_INCR('" + tableName + "')"; //Lấy giá trị identity hiện thời của bảng
            //MessageBox.Show(strSql);
            SqlCommand cmd = new SqlCommand(strSql, con);
            Object ma = cmd.ExecuteScalar();
            return ma.ToString();
        }

    }
}
