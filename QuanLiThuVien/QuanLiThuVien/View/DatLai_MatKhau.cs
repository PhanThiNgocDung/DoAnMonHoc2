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
    public partial class DatLai_MatKhau : Form
    {
        public DatLai_MatKhau()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        Controller.Model_DocGia docgia = new Controller.Model_DocGia();

        //Lấy mã độc giả từ form DocGia
        public DatLai_MatKhau(string giatrinhan): this()  
        {
            txt_tendn.Text = giatrinhan;
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

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (txt_tendn.Text.Length != 0 && txt_matkhau.Text.Length != 0)
            {
                if (docgia.kiemtra_tenDN(txt_tendn.Text))
                {
                    Model.TK_DocGia a = new Model.TK_DocGia();
                    a.Madg = txt_tendn.Text;
                    a.Matkhau = txt_matkhau.Text;
                    int check = docgia.capnhat_MatKhau(a);
                    if (check != 0)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!");
                    }
                    else
                        MessageBox.Show("Cập nhật mật khẩu không thành công!");
                }
                else
                    MessageBox.Show("Tên đăng nhập không hợp lệ");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void txt_matkhaucu_Leave(object sender, EventArgs e)
        {
            Model.TK_DocGia a = new Model.TK_DocGia();
            a.Madg = txt_tendn.Text;
            a.Matkhau = txt_matkhaucu.Text;
            if (txt_tendn.Text.Length == 0)
            {
                errorProvider1.SetError(txt_matkhaucu, "Vui lòng nhập thông tin!");
            }
            else if (txt_tendn.Text.Length > 10)
                errorProvider1.SetError(txt_matkhaucu, "Vui lòng không nhập quá 10 kí tự!");
            else
                errorProvider1.SetError(txt_matkhaucu, null);

            if (!docgia.kiemtra_MatKhau(a))
            {
                errorProvider1.SetError(txt_matkhaucu, "Mật khẩu cũ không chính xác!");
            }
            else
                errorProvider1.SetError(txt_matkhaucu, null);
        }

        private void DatLai_MatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Application.Exit();
        }
    }
}
