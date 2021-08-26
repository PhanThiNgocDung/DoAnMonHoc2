using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiThuVien.Controller
{
    public class Model_DocGia
    {
        Controller.Connect_DB ketnoi = new Controller.Connect_DB();

        //Load dữ liệu mượn trả lên datagridview
        public DataSet load_dulieuDGV()
        {
            ketnoi.open_connect();
            string str = "select mamt, tendg, hoten, tensh, ngaymuon, ngaytradukien, ngaytrathucte, tinhtrang from muontra, docgia, thuthu, sach where muontra.madg = docgia.madg and muontra.matt = thuthu.matt and muontra.mash = sach.mash";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds, "Muontra");
            return ds;
        }

        //Load dữ liệu mượn trả lên datagridview
        public DataSet load_dulieuDGV_muontra(string madg)
        {
            ketnoi.open_connect();
            string str = "select mamt, tendg, hoten, docgia.diachi, tensh, ngaymuon, ngaytradukien, ngaytrathucte, tinhtrang from muontra, docgia, thuthu, sach where muontra.madg = docgia.madg and muontra.matt = thuthu.matt and muontra.mash = sach.mash and docgia.madg = '" + madg + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds, "Muontra");
            ketnoi.close_connect();
            return ds;
        }

        //Lấy dữ liệu đọc giả
        public DataSet load_dulieuDocGia(string madg)
        {
            ketnoi.open_connect();
            string str = "select * from docgia where madg = '" + madg + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds, "Docgia");
            ketnoi.close_connect();
            return ds;
        }

        //Kiểm tra tên đăng nhập
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
                    return false;
                }
                ketnoi.close_connect();
                return true;
            }
            catch (Exception)
            {

                return true;
            }
        }

        //Kiểm tra mật khẩu cũ
        public bool kiemtra_MatKhau(Model.TK_DocGia docgia)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from tkdocgia where matkhau = '" + docgia.Matkhau + "' and madg = '" + docgia.Madg + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                int a = (int)cmd.ExecuteScalar();
                if (a == 0)
                {
                    return false;
                }
                ketnoi.close_connect();
                return true;
            }
            catch (Exception)
            {

                return true;
            }
        }

        //Cập nhật mật khẩu
        public int capnhat_MatKhau(Model.TK_DocGia docgia)
        {
            try
            {
                ketnoi.open_connect();
                string str = "update tkdocgia set matkhau = '" + docgia.Matkhau + "' where madg = '" + docgia.Madg + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Cập nhật thông tin đọc giả
        public int capnhat_ThongTinDG(Model.DocGia docgia)
        {
            try
            {
                ketnoi.open_connect();
                int check = 0;
                ketnoi.open_connect();
                string str = "update docgia set tendg = N'" + docgia.Tendg + "' where madg = '" + docgia.Madg + "'";
                string str1 = "update docgia set gioitinh = N'" + docgia.Gioitinh + "' where madg = '" + docgia.Madg + "'";
                string str2 = "update docgia set diachi = N'" + docgia.Diachi + "' where madg = '" + docgia.Madg + "'";

                if (docgia.Tendg != null)
                {
                    SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                    check = cmd.ExecuteNonQuery();
                }
                if (docgia.Gioitinh != null)
                {
                    SqlCommand cmd = new SqlCommand(str1, ketnoi.get_connect());
                    check += cmd.ExecuteNonQuery();
                }
                if (docgia.Diachi != null)
                {
                    SqlCommand cmd = new SqlCommand(str2, ketnoi.get_connect());
                    check += cmd.ExecuteNonQuery();
                }
                ketnoi.close_connect();
                return check;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Lấy dữ liệu lên cbx_lau
        public DataTable lay_Data_Cbx_Lau()
        {
            ketnoi.open_connect();
            string str = "Select * from khuvuc";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds);
            ketnoi.close_connect();
            return ds;
        }

        //Lấy dữ liệu lên cbx_ke
        public DataTable lay_Data_Cbx_Ke()
        {
            ketnoi.open_connect();
            string str = "Select * from ctkhuvuc";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds);
            ketnoi.close_connect();
            return ds;
        }

        //Lấy dữ liệu lên dgv_sach
        public DataSet load_dulieuDGV_sach()
        {
            ketnoi.open_connect();
            string str = "select mash, tentg, tensh, soluong, theloai, nxb, namxb, phidenbu, make from sach, tacgia where sach.matg = tacgia.matg";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds, "Muontra");
            ketnoi.close_connect();
            return ds;
        }
    }
}
