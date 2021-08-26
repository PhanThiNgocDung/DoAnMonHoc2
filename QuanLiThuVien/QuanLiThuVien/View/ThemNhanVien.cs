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
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        Controller.Model_NhanVien nhanvien = new Controller.Model_NhanVien();

        public ThemNhanVien(string a) : this()
        {
            txt_tendn.Text = a;
        }

        private void btn_taotaikhoan_Click(object sender, EventArgs e)
        {
            if (nhanvien.KT_KhoaChinh_NV(txt_tendn.Text) != 0)
            {
                MessageBox.Show("Đã tồn tại");
                return;
            }
            else
            {
                Model.TK_ThuThu tktt = new Model.TK_ThuThu(txt_tendn.Text, txt_matkhau.Text);
                nhanvien.ThemTKNV(tktt);
                this.Close();
            }
        }

        private void txt_tendn_Leave(object sender, EventArgs e)
        {
            if (txt_tendn.Text.Length == 0)
            {
                errorProvider1.SetError(txt_tendn, "Vui lòng nhập thông tin!");
            }
            else if (txt_tendn.Text.Length > 10)
                errorProvider1.SetError(txt_tendn, "Vui lòng không nhập quá 10 kí tự!");
            else
                errorProvider1.SetError(txt_tendn, null);
        }

        private void txt_matkhau_Leave(object sender, EventArgs e)
        {
            if (txt_matkhau.Text.Length == 0)
            {
                errorProvider1.SetError(txt_matkhau, "Vui lòng nhập mật khẩu!");
            }
            else if (txt_matkhau.Text.Length > 15)
                errorProvider1.SetError(txt_matkhau, "Vui lòng không nhập quá 15 kí tự!");
            else
                errorProvider1.SetError(txt_matkhau, null);
        }

        private void txt_nhaplaimk_Leave(object sender, EventArgs e)
        {
            if (txt_nhaplaimk.Text.Length == 0)
            {
                errorProvider1.SetError(txt_nhaplaimk, "Vui lòng nhập lại mật khẩu!");
            }
            else if (!txt_nhaplaimk.Text.Equals(txt_matkhau.Text))
                errorProvider1.SetError(txt_nhaplaimk, "Mật khẩu nhập lại không đúng!");
            else
                errorProvider1.SetError(txt_nhaplaimk, null);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
