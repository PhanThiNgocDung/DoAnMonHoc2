using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiThuVien.Controller
{
    public class Model_DangNhap
    {
        Controller.Connect_DB ketnoi = new Controller.Connect_DB();
        
        //Kiểm tra đăng nhập đọc giả
        public bool kiemtra_docgia(Model.TK_DocGia docgia)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select * from tkdocgia";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (docgia.Madg.Equals(rdr["madg"]) && docgia.Matkhau.Equals(rdr["matkhau"]))
                    {
                        return true;
                    }
                }
                ketnoi.close_connect();
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Kiểm tra đăng nhập thủ thư
        public bool kiemtra_thuthu(Model.TK_ThuThu thuthu)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select * from tkthuthu";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (thuthu.Matt.Equals(rdr["matt"]) && thuthu.Matkhau.Equals(rdr["matkhau"]))
                    {
                        return true;
                    }
                }
                ketnoi.close_connect();
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
