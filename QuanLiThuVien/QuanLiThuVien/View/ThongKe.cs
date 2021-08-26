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
    public partial class ThongKe : Form
    {
        //Khai báo
        Controller.Model_ThongKe thongke = new Controller.Model_ThongKe();
        public ThongKe()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            View.TrangChu tt = new TrangChu();
            this.Visible = false;
            tt.ShowDialog();
            Application.Exit();
        }

        private void ThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        void load()
        {
            tongsosach.Text = thongke.tongsosach().ToString();
            sosachdangmuon.Text = thongke.tongsosachdangmuon().ToString();
            tongphieumuon.Text = thongke.tongsophieumuon().ToString();
            tongdocgia.Text = thongke.tongsodocgia().ToString();
            sachquahan.Text = thongke.tongsophieuquahan().ToString();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            load();
        }


    }
}
