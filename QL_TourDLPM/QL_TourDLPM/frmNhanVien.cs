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
    public partial class frmNhanVien : Form
    {
        Class_NhanVien xl = new Class_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_TOURDLPMDataSet);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_TOURDLPMDataSet.NHANVIEN);

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
                this.nHANVIENBindingSource.AddNew();
                int? i = xl.layMaNV();
                if (i == null)
                {
                    i = 0;
                }
                i++;
                txt_MaNV.Text = "NV0" + i;
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

        private void button10_Click(object sender, EventArgs e)
        {
            string manv = txt_MaNV.Text;
            string tennv = txt_TenNhanVien.Text;
            DateTime? ngaysinh =DateTime.Parse(txt_NgaySinh.Text);
            string sdt = txt_SDT.Text;
            string email = txt_Email.Text;
            string diachi = txt_DiaChi.Text;
            string matkhau = txt_MatKhau.Text;
            string hinh = txt_HinhAnh.Text;
            string ngays = txt_NgaySinh.Text;
            if (DateTime.Now.Year - ngaysinh.Value.Year >= 18)
            {
                if (!xl.kiemtratontaiNV(manv))
                {
                    xl.ThemNhanVien(manv, tennv, ngaysinh, sdt, email, diachi, matkhau, hinh);
                    MessageBox.Show("Thêm thành công");
                    this.nHANVIENTableAdapter.Fill(this.qL_TOURDLPMDataSet.NHANVIEN);
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        xl.CapNhat(tennv, ngays, sdt, email, diachi, matkhau, hinh, manv);
                        MessageBox.Show("Sửa thành công");
                        this.nHANVIENTableAdapter.Fill(this.qL_TOURDLPMDataSet.NHANVIEN);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa đủ tuổi để làm");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    xl.XoaNhanVien(txt_MaNV.Text);
                    MessageBox.Show("Xóa thành công");
                    this.nHANVIENTableAdapter.Fill(this.qL_TOURDLPMDataSet.NHANVIEN);
                }
            }
        }
    }
}
