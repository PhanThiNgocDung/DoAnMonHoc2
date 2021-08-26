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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            this.CenterToScreen();
            rdo_nam.Checked = true;
        }

        Controller.Model_DangKy dangky = new Controller.Model_DangKy();

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Visible = false;
            dn.ShowDialog();
            Application.Exit();
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

        private void txt_hoten_Leave(object sender, EventArgs e)
        {
            if (txt_hoten.Text.Length == 0)
            {
                errorProvider1.SetError(txt_hoten, "Vui lòng nhập thông tin!");
            }
            else if (txt_hoten.Text.Length > 50)
                errorProvider1.SetError(txt_hoten, "Vui lòng không nhập quá 50 kí tự!");
            else
                errorProvider1.SetError(txt_hoten, null);
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rdo_nam.Checked)
            {
                gt = "Nam";
            }
            else if (rdo_nu.Checked)
            {
                gt = "Nữ";
            }
            else
                gt = "Khác";
            if (txt_diachi.Text.Length != 0 && txt_matkhau.Text.Length != 0 && txt_hoten.Text.Length != 0 && txt_diachi.Text.Length != 0 && dtp_ngaybd.Text.Length != 0 && dtp_ngaybd.Text.Length != 0)
            {
                bool kiemtra = dangky.kiemtra_tenDN(txt_tendn.Text.ToString());
                if (kiemtra)
                {
                    Model.DocGia dg = new Model.DocGia();
                    Model.TK_DocGia tkdg = new Model.TK_DocGia();

                    tkdg.Madg = txt_tendn.Text;
                    tkdg.Matkhau = txt_matkhau.Text;

                    dg.Madg = txt_tendn.Text;
                    dg.Tendg = txt_hoten.Text;
                    dg.Gioitinh = gt;
                    dg.Diachi = txt_diachi.Text;
                    dg.Ngaybd = dtp_ngaybd.Value.ToShortDateString();
                    dg.Ngaykt = dtp_ngaykt.Value.ToShortDateString();
                    dg.Phicoc = "300000";

                    int check = dangky.them_DocGia(tkdg, dg);
                    if (check == 2)
                    {
                        MessageBox.Show("Thêm thành công!");
                        DangNhap dn = new DangNhap();
                        this.Visible = false;
                        dn.ShowDialog();
                        Application.Exit();

                    }
                    else
                        MessageBox.Show("Thêm không thành công!");
                }
                else
                    MessageBox.Show("Đã tồn tại tên đăng nhập này");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void btn_dangky_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangky.PerformClick();
            }
        }
    }
}
