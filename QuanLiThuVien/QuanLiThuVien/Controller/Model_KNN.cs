using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLiThuVien.Controller
{
    public class Model_KNN
    {
        //Khai báo 
        int m, n, k = 5;

        Model.ThongTin[] data = new Model.ThongTin[1000];
        Model.ThongTin[] data_khoangcach = new Model.ThongTin[1000];
        Model.ThongTin[] data_k = new Model.ThongTin[100];
        //Khởi tạo kết nối DB
        Connect_DB ketnoi = new Connect_DB();

        //Hàm lấy dữ liệu từ database
        public int load_data(Model.ThongTin[] data)
        {
            ketnoi.open_connect();
            n = 0;
            string str = "select * from thongtin";
            SqlCommand cmd = new SqlCommand(str, ketnoi.get_connect());
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Model.ThongTin a = new Model.ThongTin(Convert.ToInt32(rdr["tuoi"]), rdr["theloai"].ToString());
                data[n] = a;
                n++;
            }
            ketnoi.close_connect();
            return n;
        }

        //Hàm hiển thị dữ liệu
        public DataSet load_dgv()
        {
            ketnoi.open_connect();
            string str = "select * from thongtin";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, ketnoi.get_connect());
            da.Fill(ds, "thongtin");
            ketnoi.close_connect();
            return ds;
        }

        //Hàm tính khoảng cách
        public int tinhKhoangCach(Model.ThongTin data, Model.ThongTin input)
        {
            int tuoi;
            tuoi = (int)Math.Pow(data.Tuoi - input.Tuoi, 2);
            return (int)Math.Sqrt(tuoi);
        }

        //Hàm lấy lấy khoảng cách của từng dòng dữ liệu
        public void layGiaTri(Model.ThongTin[] data, Model.ThongTin input, Model.ThongTin[] output)
        {
            m = 0;
            for (int i = 0; i < n; i++)
            {
                Model.ThongTin a = new Model.ThongTin();
                a.Tuoi = tinhKhoangCach(data[i], input);
                a.Theloai = data[i].Theloai;
                output[m] = a;
                m++;
            }
        }

        //Hàm sắp xếp tăng
        public void sapxep_tang(Model.ThongTin[] output)
        {
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (output[j].Tuoi < output[i].Tuoi)
                    {
                        Model.ThongTin tam;
                        tam = output[i];
                        output[i] = output[j];
                        output[j] = tam;
                    }
                }
            }
        }

        //Hàm lấy k giá trị 
        public void lay_k_giatri(Model.ThongTin[] output, Model.ThongTin[] gt_output)
        {
            for (int i = 0; i < k; i++)
            {
                gt_output[i] = output[i];
            }
        }

        //Hàm đếm số lần xuất hiện của phần tử
        public int dem(Model.ThongTin[] gt_output, Model.ThongTin a)
        {
            int dem = 0;
            for (int i = 0; i < k; i++)
            {
                if (string.Compare(gt_output[i].Theloai, a.Theloai, true) == 0)
                {
                    dem++;
                }
            }
            return dem;
        }
        //Hàm kiểm tra nhãn dán
        public string kiemtra_nhan(Model.ThongTin[] gt_output)
        {
            int max = dem(gt_output, gt_output[0]), vt = 0;
            for (int i = 1; i < k; i++)
            {
                if (dem(gt_output, gt_output[i]) > max)
                {
                    max = dem(gt_output, gt_output[i]);
                    vt = i;
                }
            }
            return gt_output[vt].Theloai;
        }
    }
}
