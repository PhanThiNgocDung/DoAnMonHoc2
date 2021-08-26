using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiThuVien.Controller
{
    public class Model_NhanVien_DocGia
    {
        Controller.Connect_DB ketnoi = new Controller.Connect_DB();

        //Load dữ liệu đọc giả lên datagridview
        SqlDataAdapter da_Sach;
        DataSet ds_Sach;
        //Load dữ liệu đọc giả lên datagridview
        public DataSet load_dulieuDGV_DocGia()
        {
            ketnoi.open_connect();
            string str = "Select DOCGIA.*, MATKHAU from DOCGIA,TKDOCGIA where DOCGIA.MADG = TKDOCGIA.MADG";
            ds_Sach = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds_Sach);
            ketnoi.close_connect();
            return ds_Sach;
        }

        //Kiểm tra xem đọc giả đã nhật đúng mật khẩu hiện tại trước khi muốn đổi mật khẩu mới
        public int KT_MatKhau(string pMa, string mk)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from TKDOCGIA where MADG ='" + pMa + "' and MATKHAU = '" + mk + "' ";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());

                int a = (int)cmd.ExecuteScalar();
                ketnoi.close_connect();
                return a;
            }
            catch (Exception)
            {

                return 0;
            }
        }


        //Kiểm tra khóa chính bảng tài khoản đọc giả
        public int KT_KhoaChinh(string pMa)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from TKDOCGIA where MADG ='" + pMa + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());

                int a = (int)cmd.ExecuteScalar();
                ketnoi.close_connect();
                return a;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Hàm thêm dữ liệu tài khoản đọc giả xuống sql
        public int ThemTKDocGia(Model.TK_DocGia tkdocgia)
        {
            try
            {
                ketnoi.open_connect();
                string str = "insert into TKDOCGIA values ('" + tkdocgia.Madg + "','" + tkdocgia.Matkhau + "')";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                return cmd.ExecuteNonQuery();
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Hàm thêm dữ liệu đọc giả xuống sql
        public int ThemDocGia(Model.DocGia docgia)
        {
            try
            {
                ketnoi.open_connect();
                string str = "insert into DOCGIA values ('" + docgia.Madg + "',N'" + docgia.Tendg + "',N'" + docgia.Gioitinh + "',N'" + docgia.Diachi + "','" + Convert.ToDateTime(docgia.Ngaybd) + "','" + Convert.ToDateTime(docgia.Ngaykt) + "','" + docgia.Phicoc + "')";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                return cmd.ExecuteNonQuery();
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Hàm kiểm tra đọc giả có đang mượn sách không
        public int KT_DocGiaDangSD(string pMa)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from MUONTRA where MADG ='" + pMa + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());

                int a = (int)cmd.ExecuteScalar();
                ketnoi.close_connect();
                return a;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Hàm xóa dữ liệu đọc giả và tài khoản đọc giả khỏi sql
        public int xoaDocGia(Model.DocGia docgia)
        {
            try
            {
                ketnoi.open_connect();
                string str = "delete from DOCGIA where MADG = '" + docgia.Madg + "' ";
                string str1 = "delete from TKDOCGIA where MADG = '" + docgia.Madg + "' ";

                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                SqlCommand cmd1 = new SqlCommand(str1, ketnoi.get_connect());
                int a = cmd.ExecuteNonQuery() + cmd1.ExecuteNonQuery();
                return a;
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Hàm cập nhật dữ liệu tài khoản đọc giả xuống sql
        public int capNhatTKDocGia(Model.TK_DocGia tkdocgia)
        {
            try
            {
                ketnoi.open_connect();
                string str = "update TKDOCGIA set MATKHAU ='" + tkdocgia.Matkhau + "' where MADG = '" + tkdocgia.Madg + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());

                return cmd.ExecuteNonQuery();
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Hàm cập nhật dữ liệu đọc giả xuống sql
        public int capNhatDocGia(Model.DocGia docgia)
        {
            try
            {
                ketnoi.open_connect();
                string str = "update DOCGIA set TENDG = N'" + docgia.Tendg + "', GIOITINH = N'" + docgia.Gioitinh + "',DIACHI= N'" + docgia.Diachi + "', NGAYBD ='" + Convert.ToDateTime(docgia.Ngaybd) + "',NGAYKT=N'" + Convert.ToDateTime(docgia.Ngaykt) + "' where MADG = '" + docgia.Madg + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());

                return cmd.ExecuteNonQuery();
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
