using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiThuVien.Controller
{
    public class Model_ThongKe
    {
        Connect_DB ketnoi = new Connect_DB();

        //Tính tổng số sách
        public int tongsosach()
        {
            try
            {
                int a = 0;
                ketnoi.open_connect();
                string str = "tongsosach";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                a = (int)cmd.ExecuteScalar();
                ketnoi.close_connect();
                return a;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Tính tổng số sách đang được mượn
        public int tongsosachdangmuon()
        {
            try
            {
                int a = 0;
                ketnoi.open_connect();
                string str = "tongsosachdangmuon";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                a = (int)cmd.ExecuteScalar();
                ketnoi.close_connect();
                return a;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Tổng số phiếu mượn đã được lập
        public int tongsophieumuon()
        {
            try
            {
                int a = 0;
                ketnoi.open_connect();
                string str = "tongsophieumuon";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                a = (int)cmd.ExecuteScalar();
                ketnoi.close_connect();
                return a;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Tổng số đọc giả
        public int tongsodocgia()
        {
            try
            {
                int a = 0;
                ketnoi.open_connect();
                string str = "tongsodocgia";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                a = (int)cmd.ExecuteScalar();
                ketnoi.close_connect();
                return a;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Tổng số phiếu mượn trả quá hạn
        public int tongsophieuquahan()
        {
            try
            {
                int a = 0;
                ketnoi.open_connect();
                string str = "tongsophieuquahan";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                a = (int)cmd.ExecuteScalar();
                ketnoi.close_connect();
                return a;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
