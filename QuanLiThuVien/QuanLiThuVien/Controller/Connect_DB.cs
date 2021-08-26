using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLiThuVien.Controller
{
    public class Connect_DB
    {
        SqlConnection conn = new SqlConnection("");
        public Connect_DB()
        {
            string connect_str = "Data Source=DESKTOP-1QJLQ4P;Initial Catalog=dbLibrary;Integrated Security=True";
            conn.ConnectionString = connect_str;
        }

        public SqlConnection get_connect()
        {
            return conn;
        }

        public void open_connect()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
        }

        public void close_connect()
        {
            if (conn.State.ToString() == "Open")
            {
                conn.Close();
            }
        }
    }
}
