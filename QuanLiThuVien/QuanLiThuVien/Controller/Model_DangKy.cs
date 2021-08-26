using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiThuVien.Controller
{
    public class Model_DangKy
    {
        Controller.Connect_DB ketnoi = new Controller.Connect_DB();

        //Kiểm tra mã độc giả tồn tại
        public bool kiemtra_tenDN(string tendn)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from tkdocgia where madg = '" + tendn + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                int a = (int)cmd.ExecuteScalar();
                if (a == 0)
                {
                    return true;
                }
                ketnoi.close_connect();
                return false;
            }
            catch (Exception)
            {

                return false;
            }           
        }

        //Thêm đọc giả mới
        public int them_DocGia(Model.TK_DocGia tk_docgia, Model.DocGia docgia)
        {
            try
            {
                ketnoi.open_connect();
                string str = "insert into tkdocgia values ('" + tk_docgia.Madg + "','" + tk_docgia.Matkhau + "')";
                string str1 = "insert into docgia values ('" + docgia.Madg + "', N'" + docgia.Tendg + "',N'" + docgia.Gioitinh + "',N'" + docgia.Diachi + "','" + docgia.Ngaybd + "','" + docgia.Ngaykt + "','" + docgia.Phicoc + "')";

                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                SqlCommand cmd1 = new SqlCommand(str1, ketnoi.get_connect());

                int a = cmd.ExecuteNonQuery() + cmd1.ExecuteNonQuery();
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
