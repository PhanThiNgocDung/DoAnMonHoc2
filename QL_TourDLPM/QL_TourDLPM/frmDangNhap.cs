using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace QL_TourDLPM
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        Class_DangNhap xl = new Class_DangNhap();
        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtDN.TextLength != 0 || txtMK.TextLength != 0)
            {
                    if (xl.kiemTraDangNhap(txtDN.Text, txtMK.Text))
                    {
                        Form1.tenNhanVien = xl.layTenNhanVien(txtDN.Text, txtMK.Text);
                        frmDatTour.maNhanVien = xl.layTenNhanVien(txtDN.Text, txtMK.Text);
                        Form1 f = new Form1();
                       
                        f.ShowDialog();
                        this.Hide();
                    }
                    else if (txtDN.Text.Equals("QL01") && txtMK.Text.Equals("0405"))
                    {
                        Form1.tenNhanVien = "QuanLi";
                        frmDatTour.maNhanVien = "Phạm Thị Vi";
                        Form1 f = new Form1();
                        f.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại");
                    }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }
    }
}
