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
    public partial class frmKhachHang : Form
    {
        Class_KhachHang xl = new Class_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_TOURDLPMDataSet);

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHHANG);

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
            try
            {
                this.kHACHHANGBindingSource.AddNew();
                int? i = xl.layMaKH();
                if (i == null)
                {
                    i = 0;
                }
                i++;
                txt_MaKH.Text = "KH0" + i;
            }
            catch
            {
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime? ngaysinh = DateTime.Parse(txt_NgaySinh.Text);
            if (!xl.kiemtratontaiKH(txt_MaKH.Text))
            {

                xl.themKH(txt_MaKH.Text, txt_TenKH.Text, ngaysinh, txt_SDT.Text, txt_Email.Text, txt_DiaChi.Text, txt_HinhAnh.Text);
                MessageBox.Show("Thêm thành công");
                this.kHACHHANGTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHHANG);
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txt_MaKH.Text == string.Empty)
                    {
                        MessageBox.Show("Mời bạn click vào bảng");
                    }
                    else
                    {
                        string makh = txt_MaKH.Text;
                        string tenkh = txt_TenKH.Text;
                        string sdt = txt_SDT.Text;
                        string ngaysinh1 = txt_NgaySinh.Text;
                        string email = txt_Email.Text;
                        string diachi = txt_DiaChi.Text;
                        string hinhanh = txt_HinhAnh.Text;
                        xl.UpdateKH(tenkh, ngaysinh1, sdt, email, diachi, hinhanh, makh);
                        this.kHACHHANGTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHHANG);
                      
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txt_MaKH.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        xl.DeleteKH(txt_MaKH.Text);
                        MessageBox.Show("Xóa Thành Công");
                        this.kHACHHANGTableAdapter.Fill(this.qL_TOURDLPMDataSet.KHACHHANG);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa khách hàng");
                    }
                }
            }
        }
    }
}
