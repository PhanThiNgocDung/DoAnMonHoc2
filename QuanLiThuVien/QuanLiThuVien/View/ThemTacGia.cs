using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.View
{
    public partial class ThemTacGia : Form
    {
        public ThemTacGia()
        {
            InitializeComponent();
            this.CenterToScreen();
            txt_MaTG_Them.Focus();
        }
        Controller.Model_NhanVien_Sach sach = new Controller.Model_NhanVien_Sach();
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (sach.KT_KhoaChinh_TacGia(txt_MaTG_Them.Text) != 0)
            {
                MessageBox.Show("Đã tồn tại");
                return;
            }
            else
            {
                string gioitinh = "";
                if (rdo_nam_Them_TG.Checked == true)
                    gioitinh = "NAM";
                else if (rdo_nu_Them_TG.Checked == true)
                    gioitinh = "NỮ";
                else if (rdo_khac_Them_TG.Checked == true)
                    gioitinh = "KHÁC";
                Model.TacGia a = new Model.TacGia();
                a.Matg = txt_MaTG_Them.Text;
                a.Tentg = txt_TenTG_Them.Text;
                a.Ngaysinh = dt_NgaySinh_Them.Value.ToShortDateString();
                a.Gioitinh = gioitinh;
                a.Quequan = txt_QueQuan_TG.Text;
                if (sach.ThemTacGia(a) != 0)
                {
                    MessageBox.Show("Thêm tác giả thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm tác giả không thành công!");
                }
                txt_MaTG_Them.ResetText();
                txt_TenTG_Them.ResetText();
                dt_NgaySinh_Them.Value = DateTime.Today;
                rdo_nam_Them_TG.Enabled = true;
                txt_QueQuan_TG.ResetText();
            }
        }
    }
}
