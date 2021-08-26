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
    public partial class frmThongKeTour : Form
    {
        public frmThongKeTour()
        {
            InitializeComponent();
        }

        private void dATTOURBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void frmThongKeTour_Load(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdThangNam.Checked)
            {
                try
                {
                    this.tHONGKEDATTOURTableAdapter.Fill(this.qL_TOURDLPMDataSet.THONGKEDATTOUR, tuNgay.Text, denNgay.Text);
                }
                catch
                {
                }
            }
            else
            {
              
                try
                {
                    this.tHONGKEDATTOURTableAdapter.FillBy(this.qL_TOURDLPMDataSet.THONGKEDATTOUR, tuNgay.Text);
                }
                catch
                {
                }
            }
        }

        private void rdNgay_Leave(object sender, EventArgs e)
        {
          
           
        }

        private void rdThangNam_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdNgay.Checked)
            {
                denNgay.Enabled = true;
            }
        }

        private void rdNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNgay.Checked)
            {
                denNgay.Enabled = false;
            }
        }
    }
}
