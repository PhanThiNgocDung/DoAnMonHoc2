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
    public partial class GoiY : Form
    {
        public GoiY()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgv_data.ReadOnly = true;
            dgv_data.AllowUserToAddRows = false;
        }
        //Khai báo
        Controller.Model_KNN knn = new Controller.Model_KNN();
        DataSet ds = new DataSet();

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Application.Exit();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_tuoi.Clear();
            txt_tuoi.Focus();
            lbl_ketqua.Text = "......................";
        }

        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            Model.ThongTin[] data = new Model.ThongTin[1000];
            Model.ThongTin[] data_out = new Model.ThongTin[1000];
            Model.ThongTin[] data_k = new Model.ThongTin[100];

            try
            {
                if (txt_tuoi.Text.Length != 0)
                {
                    int tuoi = Convert.ToInt32(txt_tuoi.Text);
                    Model.ThongTin input = new Model.ThongTin();
                    input.Tuoi = tuoi;

                    knn.load_data(data);
                    knn.layGiaTri(data, input, data_out);
                    knn.sapxep_tang(data_out);
                    knn.lay_k_giatri(data_out, data_k);
                    string a = knn.kiemtra_nhan(data_k);

                    lbl_ketqua.Text = a.ToString();
                }
                else
                    MessageBox.Show("Vui lòng nhập độ tuổi...!");
            }
            catch (Exception)
            {

                lbl_ketqua.Text = "error";
            }
        }

        private void GoiY_Load(object sender, EventArgs e)
        {
            ds = knn.load_dgv();
            dgv_data.DataSource = ds.Tables[0];
        }

        private void txt_tuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
