using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_TourDLPM
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.qL_TOURDLPMDataSet.DataTable1);

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.FillByTheoTen1(this.qL_TOURDLPMDataSet.DataTable1, txt_Search.Text);
                if (radioButton_Gia.Checked)
                {
                    this.dataTable1TableAdapter.FillByTheoGia1(this.qL_TOURDLPMDataSet.DataTable1,decimal.Parse(txt_Search.Text));
                }
                else if (radioButton_TenTour.Checked)
                {
                    this.dataTable1TableAdapter.FillByTheoTen1(this.qL_TOURDLPMDataSet.DataTable1, txt_Search.Text);
                }
                else if (radioButton_ThoiLuong.Checked)
                {
                    this.dataTable1TableAdapter.FillByTheoThoiLuong1(this.qL_TOURDLPMDataSet.DataTable1, txt_Search.Text);
                }

            }
            catch
            {
            }
        }

        private void hinhAnhTextEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile("D:\\DoAnNam3\\CNPM_Thu4_Tiet123_2001181417_PhamThiVi_TimHieuCongNgheFlutter\\QL_TourDLPM\\ImageData\\" + txt_HinhAnh.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
            }
        }
    }
}
