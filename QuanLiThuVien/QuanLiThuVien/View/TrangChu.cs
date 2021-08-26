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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult r;
            //r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (r == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            e.Cancel = true;
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            View.NhanVien nv = new NhanVien();
            this.Visible = false;
            nv.ShowDialog();
            Application.Exit();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            View.ThongKe tk = new ThongKe();
            this.Visible = false;
            tk.ShowDialog();
            Application.Exit();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            View.Report rp = new Report();
            this.Visible = false;
            rp.ShowDialog();
            Application.Exit();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            View.DangNhap dn = new DangNhap();
            this.Visible = false;
            dn.ShowDialog();
            Application.Exit();
        }
    }
}
