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
    public partial class frmSuDungDichVu : Form
    {
        Class_SuDungDV xl = new Class_SuDungDV();
        int giaDV;
        public frmSuDungDichVu()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void frmSuDungDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHHANG);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.qL_TOURDLPMDataSet.DICHVU);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.SDDICHVU' table. You can move, or remove it, as needed.
            this.sDDICHVUTableAdapter.Fill(this.qL_TOURDLPMDataSet.SDDICHVU);

        }

        private void txt_SDTKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cb_TenKH.Text = xl.tenKhachHang(txt_SDTKH.Text).ToString();
                this.kHACHDATTOURTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHDATTOUR, txt_SDTKH.Text);
            }
            catch 
            {
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
            }
            catch
            {
               
            }
        }
       
        private void tenDVComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 giaDV =Convert.ToInt32(xl.layGiaDichVu(cb_TenDV.SelectedValue.ToString()));
                lb_DonGia.Text = (giaDV / 1000) + ".000 VNĐ";
                lb_ThanhTien.Text = (giaDV / 1000) * txt_SL.Value + ".000 VNĐ";
            }
            catch
            {
            }
        }

        private void soLuongSpinEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lb_ThanhTien.Text = (giaDV / 1000) * txt_SL.Value + ".000 VNĐ";
            }
            catch
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                cb_TenDV.SelectedIndex = 0;
                txt_SL.Value = 0;
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!xl.KTKhoaChinh(cb_TenDV.SelectedValue.ToString(), txt_MaDatTour.Text))
                {
                    int? SL = int.Parse(txt_SL.Value.ToString());
                    decimal? thanhTien = decimal.Parse(giaDV * SL + "");
                    xl.themSDDICHVu(cb_TenDV.SelectedValue.ToString(), txt_MaDatTour.Text, SL, thanhTien);
                    MessageBox.Show("Thêm dịch vụ thành công");
                    this.dATTOURDVTableAdapter.Fill(this.qL_TOURDLPMDataSet.DATTOURDV, txt_MaDatTour.Text);
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (txt_MaDatTour.Text == string.Empty || cb_TenDV.SelectedValue.ToString() == string.Empty)
                        {
                            MessageBox.Show("Mời bạn click vào bảng");
                        }
                        else
                        {
                            int? SL = int.Parse(txt_SL.Value.ToString());
                            decimal? thanhTien = decimal.Parse(giaDV * SL + "");
                            xl.suaDichVu(cb_TenDV.SelectedValue.ToString(), txt_MaDatTour.Text, SL, thanhTien);
                            MessageBox.Show("Sửa thành công");
                            this.dATTOURDVTableAdapter.Fill(this.qL_TOURDLPMDataSet.DATTOURDV, txt_MaDatTour.Text);
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}
