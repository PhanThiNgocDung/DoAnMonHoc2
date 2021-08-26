using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace QL_TourDLPM
{
    public partial class frmDatTour : Form
    {
        Class_DatTour xl = new Class_DatTour();
        decimal? tongtien;
        public static string maNhanVien = string.Empty;
        public frmDatTour()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHHANG);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.TOUR' table. You can move, or remove it, as needed.
            this.tOURTableAdapter.Fill(this.qL_TOURDLPMDataSet.TOUR);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_TOURDLPMDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.HUONGDANVIEN' table. You can move, or remove it, as needed.
            this.hUONGDANVIENTableAdapter.Fill(this.qL_TOURDLPMDataSet.HUONGDANVIEN);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.KHACHSAN' table. You can move, or remove it, as needed.
            this.kHACHSANTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHSAN);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.qL_TOURDLPMDataSet.DataTable1);
            txt_NgayMuonDi.Text = DateTime.Now.Date.ToShortDateString();
            this.dataTable1TableAdapter.FillBy(this.qL_TOURDLPMDataSet.DataTable1, txt_NgayMuonDi.Text);
            cb_TenNhanVien.Text = maNhanVien;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                txt_NgayDatTour.Text = DateTime.Now.Date.ToShortDateString();
                int? i = xl.laymaDatTour();
                i++;
                txt_MaDT.Text = "DT0" + i;
                txt_NgayMuonDi.Text = DateTime.Now.Date.ToShortDateString();
                string s = cb_tenTour.SelectedValue.ToString();
                s = "";
            }
            catch
            {
            }
        }

        private void txt_SDTKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cb_TenKH.Text = xl.tenKhachHang(txt_SDTKH.Text).ToString();

            }
            catch
            {
            }
        }

        private void txt_NgayMuonDi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.FillBy(this.qL_TOURDLPMDataSet.DataTable1, txt_NgayMuonDi.Text);
            }
            catch
            {
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int? soluongTreEm = Convert.ToInt16(txt_SLTreEm.Value);
            int? soLuongNgLon = Convert.ToInt16(txt_SLNLon.Value);
            DateTime? ngaydattour = DateTime.Parse(txt_NgayDatTour.Text);
            decimal? giaTour = decimal.Parse(txt_Gia.Text);
            if (xl.LuuTour(txt_MaDT.Text, cb_tenTour.SelectedValue.ToString(), cb_KhachSan.SelectedValue.ToString(), cb_TenKH.SelectedValue.ToString(), cb_HuongDanVien.SelectedValue.ToString().Trim(), cb_TenNhanVien.SelectedValue.ToString().Trim(), soluongTreEm, soLuongNgLon, ngaydattour, giaTour, tongtien))
            {
                MessageBox.Show("Bạn Đặt tour thành công");

            }
            else
            {
                MessageBox.Show("Đặt tour thất bại");
            }    
        }

        private void txt_Gia_TextChanged(object sender, EventArgs e)
        {
            double t = 0;
            if (!txt_Gia.Text.Equals(""))
            {
                t = double.Parse(txt_Gia.Text);

            }
            try
            {
                lb_GiaTour.Text = (Convert.ToInt32(t) / 1000) + ".000 VNĐ";
                int? soluongTreEm = Convert.ToInt16(txt_SLTreEm.Value);
                int? soLuongNgLon = Convert.ToInt16(txt_SLNLon.Value);
                int dongia = Convert.ToInt32(t);
                tongtien = soluongTreEm * dongia * Convert.ToDecimal(0.7) + soLuongNgLon * dongia;
                int tongtien2 = Convert.ToInt32(tongtien / 1000);
                txt_ThanhTien.Text = tongtien2.ToString() + ".000 VNĐ";
            }
            catch
            {
            }
        }
    }
}
