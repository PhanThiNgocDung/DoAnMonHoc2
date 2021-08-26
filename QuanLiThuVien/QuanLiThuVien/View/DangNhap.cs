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
    public partial class DangNhap : Form
    {
        //Khai báo controller - model_dangnhap
        Controller.Model_DangNhap dn = new Controller.Model_DangNhap();
        public DangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
            rdo_nhanvien.Checked = true;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            DangKy dn = new DangKy();
            this.Visible = false;
            dn.ShowDialog();
            Application.Exit();
        }

        private void txt_taikhoan_Leave(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text.Length == 0)
            {
                errorProvider1.SetError(txt_taikhoan, "Vui lòng nhập tài khoản!");
            }
            else
                errorProvider1.SetError(txt_taikhoan, null);
        }

        private void txt_matkhau_Leave(object sender, EventArgs e)
        {
            if (txt_matkhau.Text.Length == 0)
            {
                errorProvider1.SetError(txt_matkhau, "Vui lòng nhập mật khẩu!");
            }
            else
                errorProvider1.SetError(txt_matkhau, null);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            Model.TK_DocGia docgia = new Model.TK_DocGia();
            Model.TK_ThuThu thuthu = new Model.TK_ThuThu();

            if (txt_taikhoan.Text.Length != 0 && txt_matkhau.Text.Length != 0)
            {
                //Quyền đọc giả
                if (rdo_sinhvien.Checked)
                {
                    docgia.Madg = txt_taikhoan.Text;
                    docgia.Matkhau = txt_matkhau.Text;
                    bool kiemtra = dn.kiemtra_docgia(docgia);
                    if (kiemtra)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        DocGia dg = new DocGia(txt_taikhoan.Text);
                        this.Visible = false;
                        dg.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mặt khẩu không chính xác!");
                        txt_matkhau.Clear();
                        txt_taikhoan.Clear();
                        txt_taikhoan.Focus();
                    }
                }

                //Quyền thủ thư
                else if (rdo_nhanvien.Checked)
                {
                    thuthu.Matt = txt_taikhoan.Text;
                    thuthu.Matkhau = txt_matkhau.Text;
                    bool kiemtra = dn.kiemtra_thuthu(thuthu);
                    if (kiemtra)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        TrangChu nv = new TrangChu();
                        this.Visible = false;
                        nv.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mặt khẩu không chính xác!");
                        txt_matkhau.Clear();
                        txt_taikhoan.Clear();
                        txt_taikhoan.Focus();
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn chức vụ!");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void btn_dangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap.PerformClick();
            }
        }
    }
}
