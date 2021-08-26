using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;
using System.IO;

namespace QL_TourDLPM
{
    public partial class frmTour : Form
    {
        Class_Tour xl = new Class_Tour();
        public frmTour()
        {
            InitializeComponent();
        }

        private void frmTour_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.CHAULUC' table. You can move, or remove it, as needed.
            this.cHAULUCTableAdapter.Fill(this.qL_TOURDLPMDataSet.CHAULUC);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.MIEN' table. You can move, or remove it, as needed.
            this.mIENTableAdapter.Fill(this.qL_TOURDLPMDataSet.MIEN);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.DIEMDEN' table. You can move, or remove it, as needed.
            this.dIEMDENTableAdapter.Fill(this.qL_TOURDLPMDataSet.DIEMDEN);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.PHUONGTIEN' table. You can move, or remove it, as needed.
            this.pHUONGTIENTableAdapter.Fill(this.qL_TOURDLPMDataSet.PHUONGTIEN);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.qL_TOURDLPMDataSet.DataTable1);
        }

        private void txt_HinhAnh_EditValueChanged(object sender, EventArgs e)
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
        RichTextBox richtex = new RichTextBox();
        private void Bn_File_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txt_HinhAnh.Text = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("\\") + 1);
                    StreamReader f = new StreamReader(openFileDialog1.FileName);
                    richtex.Text = f.ReadToEnd();
                    f.Close();
                }
                pictureBox1.Image = Image.FromFile("D:\\DoAnNam3\\CNPM_Thu4_Tiet123_2001181417_PhamThiVi_TimHieuCongNgheFlutter\\QL_TourDLPM\\ImageData\\" + txt_HinhAnh.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.dataTable1BindingSource.AddNew();
                cb_ChauLuc.SelectedIndex = 0;
                cb_DiaDiem.SelectedIndex = 0;
                cb_Mien.SelectedIndex = 0;
                txt_TenPT.SelectedIndex = 0;
                int? i = xl.LayMaTour();
                i++;
                txt_MaTour.Text = "Tour0" + i;
                txt_NgayBD.Text = DateTime.Now.Date.ToShortDateString();
                txt_NgayKT.Text = DateTime.Now.Date.ToShortDateString();
              
            }
            catch
            {
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int? SLton = int.Parse(txt_SoLuong.Text);
            DateTime? ngayBD = DateTime.Parse(txt_NgayBD.Text);
            DateTime? ngayKT = DateTime.Parse(txt_NgayKT.Text);
            Decimal? giaTour = Decimal.Parse(txt_Gia.Text);
            if (xl.kTTonTaiTour(txt_MaTour.Text) == 0)
            {
                xl.ThemTour(txt_MaTour.Text, txt_TenTour.Text, txt_TenPT.SelectedValue.ToString(), cb_DiaDiem.SelectedValue.ToString(), cb_Mien.SelectedValue.ToString(), cb_ChauLuc.SelectedValue.ToString(), giaTour, SLton, txt_ThoiLuong.Text, txt_HinhAnh.Text, ngayBD, ngayKT);
                this.dataTable1TableAdapter.Fill(this.qL_TOURDLPMDataSet.DataTable1);
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txt_MaTour.Text == string.Empty)
                    {
                        MessageBox.Show("Mời bạn click vào bảng");
                    }
                    else
                    {
                        xl.suaTour(txt_MaTour.Text, txt_TenTour.Text, txt_TenPT.SelectedValue.ToString(), cb_DiaDiem.SelectedValue.ToString(), cb_Mien.SelectedValue.ToString(), cb_ChauLuc.SelectedValue.ToString(), giaTour, SLton, txt_ThoiLuong.Text, txt_HinhAnh.Text, txt_NgayBD.Text, txt_NgayKT.Text); 
                        this.dataTable1TableAdapter.Fill(this.qL_TOURDLPMDataSet.DataTable1);
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txt_MaTour.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    xl.XoaTour(txt_MaTour.Text);
                    this.dataTable1TableAdapter.Fill(this.qL_TOURDLPMDataSet.DataTable1);
                }
            }
        }
    }
}
