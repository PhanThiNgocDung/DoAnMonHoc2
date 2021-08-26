using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiThuVien.Controller
{
    class Model_NhanVien
    {
        Controller.Connect_DB ketnoi = new Controller.Connect_DB();
        //Load dữ liệu mượn trả lên datagridview
        public DataSet load_dulieuNV()
        {
            ketnoi.open_connect();
            string str = "select * from THUTHU";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds, "THUTHU");
            return ds;
        }

        public DataTable load_cbbTenDG()
        {
            ketnoi.open_connect();
            string str = "Select * from DOCGIA";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds);
            return ds;
        }
        public DataTable load_cbbTenSH()
        {
            ketnoi.open_connect();
            string str = "Select * from SACH";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds);
            return ds;

        }
        public DataTable load_cbbTenTT()
        {
            ketnoi.open_connect();
            string str = "Select * from THUTHU";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds);
            return ds;

        }
        public int KT_KhoaChinh_NV(string pMa)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from THUTHU where MATT ='" + pMa + "'";
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

        public int ThemNV(Model.ThuThu tt)
        {
            try
            {
                ketnoi.open_connect();
                string str = "insert into THUTHU values ('" + tt.Matt + "',N'" + tt.Hoten + "',N'" + tt.Gioitinh + "','" + tt.Ngaysinh + "','" + tt.Sdt + "','" + tt.Email + "',N'" + tt.Diachi + "')";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());

                return cmd.ExecuteNonQuery();
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public void ThemTKNV(Model.TK_ThuThu tktt)
        {
            ketnoi.open_connect();
            string str = "insert into TKTHUTHU values ('" + tktt.Matt + "','" + tktt.Matkhau + "')";
            SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());

            cmd.ExecuteNonQuery();
            ketnoi.close_connect();
        }

        public int XoaNV(Model.ThuThu tt)
        {
            try
            {
                ketnoi.open_connect();
                string str = "delete THUTHU where MATT='" + tt.Matt + "'";
                string str1 = "delete TKTHUTHU where MATT='" + tt.Matt + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                SqlCommand cmd1 = new SqlCommand(str1, ketnoi.get_connect());
                int a = cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                return a;
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public int SuaNV(Model.ThuThu tt)
        {
            try
            {
                ketnoi.open_connect();
                string str = "update THUTHU set HOTEN=N'" + tt.Hoten + "',GIOITINH=N'" + tt.Gioitinh + "',NGAYSINH='" + tt.Ngaysinh + "',SDT='" + tt.Sdt + "',EMAIL='" + tt.Email + "',DIACHI=N'" + tt.Diachi + "' where MATT='" + tt.Matt + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                return cmd.ExecuteNonQuery();
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public int KT_KhoaChinh_MT(string pMa)
        {
            try
            {
                ketnoi.open_connect();
                string str = "select count(*) from MUONTRA where MAMT ='" + pMa + "'";
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

        public int ThemMT(Model.MuonTra mt)
        {
            try
            {
                ketnoi.open_connect();
                string str = "insert into MUONTRA values ('" + mt.Mamt + "','" + mt.Madg + "','" + mt.Matt + "','" + mt.Mash + "','" + mt.Ngaymuon + "',N'" + mt.Tinhtrang + "','" + mt.Ngaytradukien + "',NULL)";
                string str1 = "update SACH set SOLUONG=SOLUONG - 1" + " where MASH='" + mt.Mash + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                SqlCommand cmd1 = new SqlCommand(str1, ketnoi.get_connect());
                int a = cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                return a;
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public int SuaMT(Model.MuonTra mt)
        {
            try
            {
                ketnoi.open_connect();
                string str = "update MUONTRA set TINHTRANG=N'ĐÃ TRẢ" + "',NGAYTRATHUCTE=N'" + mt.Ngaytrathucte + "' where MAMT='" + mt.Mamt + "'";
                string str1 = "update SACH set SOLUONG=SOLUONG + 1" + " where MASH='" + mt.Mash + "'";
                SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
                SqlCommand cmd1 = new SqlCommand(str1, ketnoi.get_connect());
                int a = cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                return a;
                ketnoi.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
