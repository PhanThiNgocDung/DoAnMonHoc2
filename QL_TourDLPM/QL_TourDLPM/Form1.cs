using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_TourDLPM
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string tenNhanVien = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private Form KiemTraTon(Type ftype)
        {
            panel1.Visible = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(frmTour));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmTour f = new frmTour();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tenNhanVien.Equals("QuanLi"))
            {
                txt_TenDN.Text = "Quản lí: Phạm Thị Vi";
               
            }
            else
            {
                txt_TenDN.Text = "Xin chào: " + tenNhanVien;
                gr_QuanLy.Visible = false;
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(frmDatTour));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmDatTour f = new frmDatTour();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(frmSuDungDichVu));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmSuDungDichVu f = new frmSuDungDichVu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(frmThanhToan));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmThanhToan f = new frmThanhToan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form dn = this.KiemTraTon(typeof(frmKhachHang));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(frmCoSoHaTang));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmCoSoHaTang f = new frmCoSoHaTang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(frmNhanVien));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(frmTimKiem));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmTimKiem f = new frmTimKiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
            this.Hide();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(frmThongKeTour));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmThongKeTour f = new frmThongKeTour();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(frmDoanhThu));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                frmDoanhThu f = new frmDoanhThu();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
