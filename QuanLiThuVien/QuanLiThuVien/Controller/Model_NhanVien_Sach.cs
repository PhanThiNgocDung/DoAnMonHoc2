using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiThuVien.Controller
{
    public class Model_NhanVien_Sach
    {
        Controller.Connect_DB ketnoi = new Controller.Connect_DB();

        //Load dữ liệu sách lên datagridview
        public DataSet load_dulieuDGV_Sach()
        {
            ketnoi.open_connect();
            string str = "Select SACH.*,TENTG, TENKESACH from Sach,TacGia,CTKHUVUC where Sach.MATG=TACGIA.MATG and Sach.MAKE = CTKHUVUC.MAKE";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds);
            ketnoi.close_connect();
            return ds;

        }

        //Lấy dữ liệu lên combobox Sách
        public DataTable lay_Data_Cbx_Lau()
        {
            ketnoi.open_connect();
            string str = "Select * from KHUVUC";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds);
            ketnoi.close_connect();
            return ds;

        }

        //Lấy dữ liệu lên combobox Kệ
        public DataTable lay_Data_Cbx_Ke()
        {
            ketnoi.open_connect();
            string str = "Select * from CTKHUVUC";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds);
            ketnoi.close_connect();
            return ds;

        }

        //Lấy dữ liệu lên combobox Tác giả
        public DataTable lay_Data_Cbx_TacGia()
        {
            ketnoi.open_connect();
            string str = "Select * from TACGIA";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds);
            ketnoi.close_connect();
            return ds;

        }

        //Kiểm tra khóa chính bảng sách
        public int KT_KhoaChinh(string pMa)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from sach where mash ='" + pMa + "'";
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

        //Hàm thêm dữ liệu sách xuống sql
        public int ThemSach(Model.Sach sach)
        {
            try
            {
                ketnoi.open_connect();
                string str = "insert into SACH values ('" + sach.Mash + "','" + sach.Matg + "',N'" + sach.Tensh + "','" + sach.Soluong + "','" + sach.Ngaynhap + "',N'" + sach.Theloai + "',N'" + sach.Nhaxuatban + "','" + sach.Nxb + "','" + sach.Phidenbu + "','" + sach.Make + "')";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                return cmd.ExecuteNonQuery();
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //hàm cập nhật dữ liệu sách xuống sql
        public int capNhatSach(Model.Sach sach)
        {
            try
            {
                ketnoi.open_connect();
                string str = "update SACH set MATG = '" + sach.Matg + "', TENSH = N'" + sach.Tensh + "',SOLUONG= " + sach.Soluong + ", NGAYNHAPSACH ='" + Convert.ToDateTime(sach.Ngaynhap) + "',THELOAI=N'" + sach.Theloai + "',NXB=N'" + sach.Nhaxuatban + "', NAMXB='" + Convert.ToDateTime(sach.Nxb) + "',PHIDENBU= " + sach.Phidenbu + ",MAKE= '" + sach.Make + "' where MASH='" + sach.Mash + "' ";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());

                return cmd.ExecuteNonQuery();
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Kiểm tra sách có đang được sử dụng không ?
        public int KT_SachDangSD(string pMa)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from MUONTRA where mash ='" + pMa + "'";
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

        //Hàm xóa dữ liệu sách khỏi sql
        public int xoaSach(Model.Sach sach)
        {
            try
            {
                ketnoi.open_connect();
                string str = "delete from SACH where MASH='" + sach.Mash + "' ";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());

                return cmd.ExecuteNonQuery();
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Kiểm tra khóa chính bảng tác giả
        public int KT_KhoaChinh_TacGia(string pMa)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from TacGia where MATG ='" + pMa + "'";
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

        //Thêm dữ liệu tác giả xuống sql
        public int ThemTacGia(Model.TacGia tg)
        {
            try
            {
                ketnoi.open_connect();
                string str = "insert into TACGIA values ('" + tg.Matg + "',N'" + tg.Tentg + "','" + Convert.ToDateTime(tg.Ngaysinh) + "',N'" + tg.Gioitinh + "',N'" + tg.Quequan + "')";
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
