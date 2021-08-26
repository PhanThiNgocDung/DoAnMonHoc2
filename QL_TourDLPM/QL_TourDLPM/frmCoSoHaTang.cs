using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BLL_DAL;

namespace QL_TourDLPM
{
    public partial class frmCoSoHaTang : Form
    {
        public frmCoSoHaTang()
        {
            InitializeComponent();
        }
        Class_CoSoHaTang xl = new Class_CoSoHaTang();
        private void dICHVUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dICHVUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_TOURDLPMDataSet);

        }

        private void frmCoSoHaTang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.KHACHSAN' table. You can move, or remove it, as needed.
            this.kHACHSANTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHSAN);
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.qL_TOURDLPMDataSet.DICHVU);

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

        private void hinhAnhKSTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_HinhAnh_TextChanged(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (rd_DichVu.Checked == true)
            {
                try
                {
                    this.dICHVUBindingSource.AddNew();
                    int? i = xl.TaoMaDV();
                    if (i == null)
                    {
                        i = 0;
                    }
                    i++;
                    txt_MaDV.Text = "DV0" + i;
                }
                catch
                {
                }
            }
            else if (rd_KhachSan.Checked == true)
            {
                try
                {
                    this.kHACHSANBindingSource.AddNew();
                    int? i = xl.LayMaKhachSan();
                    if (i == null)
                    {
                        i = 0;
                    }
                    i++;
                    txt_MaKS.Text = "KS0" + i;
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thao tác trên đâu");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (rd_DichVu.Checked == true)
            {
                if (!xl.kiemtratonDV(txt_MaDV.Text))
                {

                    if (txt_TenDV.Text.Length != 0 && txt_GiaDV.Text.Length != 0)
                    {
                        xl.themDV(txt_MaDV.Text, txt_TenDV.Text, Convert.ToDecimal(txt_GiaDV.Text));
                        MessageBox.Show("Thêm thành công");
                        this.dICHVUTableAdapter.Fill(this.qL_TOURDLPMDataSet.DICHVU);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (txt_TenKS.Text.Length != 0 && txt_GiaDV.Text.Length != 0)
                        {
                            xl.suaDV(txt_TenDV.Text, Convert.ToDecimal(txt_GiaDV.Text), txt_MaDV.Text);
                            MessageBox.Show("Sửa thành công");
                            this.dICHVUTableAdapter.Fill(this.qL_TOURDLPMDataSet.DICHVU);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                            return;
                        }
                    }
                }
            }
            else if (rd_KhachSan.Checked == true)
            {
                if (!xl.kiemtraton(txt_MaKS.Text))
                {

                    if (txt_TenKS.Text.Length != 0 && txt_GiaKS.Text.Length != 0)
                    {
                        string maks = txt_MaKS.Text;
                        string tenKS = txt_TenKS.Text;
                        Decimal? gia = Convert.ToDecimal(txt_GiaKS.Text);
                        string hinh = txt_HinhAnh.Text;
                        xl.ThemKhachSan(maks, tenKS, gia, hinh);
                        MessageBox.Show("Thêm thành công");
                        this.kHACHSANTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHSAN);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (txt_TenKS.Text.Length != 0 && txt_GiaKS.Text.Length != 0)
                        {
                            string maks = txt_MaKS.Text;
                            string tenKS = txt_TenKS.Text;
                            Decimal? gia = Convert.ToDecimal(txt_GiaKS.Text);
                            string hinh = txt_HinhAnh.Text;
                            xl.CapNhat(tenKS, gia, hinh, maks);
                            MessageBox.Show("Sửa thành công");
                            this.kHACHSANTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHSAN);
                         
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thao tác trên đâu");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (rd_DichVu.Checked == true)
            {
                if (txt_MaKS.Text == string.Empty)
                {
                    MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {

                            xl.xoaDV(txt_MaDV.Text);
                            this.dICHVUTableAdapter.Fill(this.qL_TOURDLPMDataSet.DICHVU);
                            MessageBox.Show("Xóa Thành Công");
                        }
                        catch
                        {
                            MessageBox.Show("Không thể xóa");
                        }
                    }
                }
            }
            else if (rd_KhachSan.Checked == true)
            {
                if (txt_MaKS.Text == string.Empty)
                {
                    MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            string maks = txt_MaKS.Text;
                            xl.Xoa(maks);
                            this.kHACHSANTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHSAN);
                            MessageBox.Show("Xóa Thành Công");
                        }
                        catch
                        {
                            MessageBox.Show("Không thể xóa");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thao tác trên đâu");
            }
        }
    }
}
