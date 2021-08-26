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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }
        Class_ThanhToan xl = new Class_ThanhToan();
        int tongTien = 0;
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_SDTKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.kHACHDATTOURTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHDATTOUR,txt_SDTKH.Text);
            }
            catch {
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }

        private void txt_MaDatTour_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.dATTOURDVTableAdapter.Fill(this.qL_TOURDLPMDataSet.DATTOURDV, txt_MaDatTour.Text);
                this.tHANHTOANTableAdapter.FillBy(this.qL_TOURDLPMDataSet.THANHTOAN, txt_MaDatTour.Text);
                tongTien = Convert.ToInt32(xl.tongTien(txt_MaDatTour.Text));
                int tienTour = Convert.ToInt32(xl.tienDatTour(txt_MaDatTour.Text));
                lb_TongTien.Text = (tongTien/1000) +".000 VNĐ";
                lb_TienTour.Text = (tienTour / 1000) + ".000 VNĐ";
               

            }
            catch {
            }
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
                // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.THANHTOAN' table. You can move, or remove it, as needed.
              

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bn_ThemDV_Click(object sender, EventArgs e)
        {
            try
            {
                int? i = xl.layMaThanhToan();
                if (i == null)
                {
                    i = 0;
                }
                i++;
                txt_MaThanhToan.Text = "TT" + i;
                cb_HinhThucTT.SelectedIndex = 0;
                txt_TienThanhToan.Text = "";
                txt_GhiChu.Text = "";
                txt_MaTour.Text = txt_MaDatTour.Text;
                if (xl.soLanThanhToan(txt_MaDatTour.Text))
                {
                    lb_TienConlai.Text = tongTien.ToString();
                }
            }
            catch
            {
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal? tienThanhToan = decimal.Parse(txt_TienThanhToan.Text);
            decimal? tienConLai = decimal.Parse(lb_TienConlai.Text);
            tienConLai = tienConLai - tienThanhToan;
            decimal? tongTien2 = decimal.Parse(tongTien.ToString() + "");
            DateTime ngayTT =DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            try
            {
                xl.themMaThanhToan(txt_MaThanhToan.Text, txt_MaTour.Text, ngayTT, cb_HinhThucTT.SelectedItem.ToString(), tienConLai, tienThanhToan, tongTien2, txt_GhiChu.Text);
                MessageBox.Show("Thanh toán thành công");
                this.tHANHTOANTableAdapter.FillBy(this.qL_TOURDLPMDataSet.THANHTOAN, txt_MaDatTour.Text);
            }
            catch
            {
            }
        }

        private void txt_TienThanhToan_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_TienThanhToan_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int tienThanhToan = 0;
            //    if (txt_TienThanhToan.Text == string.Empty)
            //    {
            //        tienThanhToan = 0;
            //    }
            //    else
            //    {
            //        decimal tien = decimal.Parse(txt_TienThanhToan.Text);
            //        tienThanhToan = Convert.ToInt32(tien);
            //    }
            //    decimal tien2 = decimal.Parse(lb_TienConlai.Text);
            //    int tiencl2 = Convert.ToInt32(tien2);
            //    int tienConLai = tiencl2 - tienThanhToan;
            //    lb_TienConlai.Text = tienConLai + "";
            //    // decimal? tongTien2 = decimal.Parse(tongTien.ToString() + "");
            //}
            //catch
            //{
            //}
          
            

        }
        ExcelExport excel = new ExcelExport();
        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            List<HoaDonExportInfor> ls = new List<HoaDonExportInfor>()
            {
                new HoaDonExportInfor(){STT="1",MaHD=txt_MaThanhToan.Text,NgayBD="",NgayKT="",SLNguoiLon=gridView1.GetRowCellValue(0,"SLNguoiLon").ToString(),SLTreEm=gridView1.GetRowCellValue(0,"SNTreEm").ToString(),TenKH=gridView1.GetRowCellValue(0,"TenKH").ToString(),TenTour=gridView1.GetRowCellValue(0,"TenTour").ToString() },

            };
            string path = string.Empty;
            excel.ThongKeGame(ls, ref path, false, lb_TongTien.Text,"");
            System.Diagnostics.Process.Start(path);
        }
    }
}
