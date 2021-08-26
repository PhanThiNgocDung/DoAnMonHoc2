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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void tHANHTOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHANHTOANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_TOURDLPMDataSet);

        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TOURDLPMDataSet.THANHTOAN' table. You can move, or remove it, as needed.
            this.tHANHTOANTableAdapter.Fill(this.qL_TOURDLPMDataSet.THANHTOAN);

        }

        private void rdNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNgay.Checked)
            {
                denNgay.Enabled = false;
            }
        }

        private void rdThangNam_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdNgay.Checked)
            {
                denNgay.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdThangNam.Checked)
            {
                try
                {
                    this.tHANHTOANTableAdapter.FillBy1(this.qL_TOURDLPMDataSet.THANHTOAN, tuNgay.Text, denNgay.Text);
                    DateTime denNgay2 = DateTime.Parse(denNgay.Text);
                    DateTime tuNgay2 = DateTime.Parse(tuNgay.Text);
                    object tien = this.tHANHTOANTableAdapter.ThanhToanTuNgayDenNgay(tuNgay2,denNgay2);
                    lb_TongDoanhThu.Text = tien + "VNĐ";
                }
                catch
                {
                }
            }
            else
            {

                try
                {
                    this.tHANHTOANTableAdapter.FillBy2(this.qL_TOURDLPMDataSet.THANHTOAN, tuNgay.Text);
                    object tien = this.tHANHTOANTableAdapter.TongTienTheo1Ngay(tuNgay.Text);
                    lb_TongDoanhThu.Text = tien + "VNĐ";
                }
                catch
                {
                }
            }
        }
    }
}
