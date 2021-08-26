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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            TrangChu tt = new TrangChu();
            this.Visible = false;
            tt.ShowDialog();
            Application.Exit();
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            myreport rpt = new myreport();
            rpt.SetDatabaseLogon("sa", "123", "DESKTOP-V3IJJH5\\SQLEXPRESS", "dbLibrary");
            rpt.SetParameterValue("locdocgia", txt_tendg.Text.ToString());
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
