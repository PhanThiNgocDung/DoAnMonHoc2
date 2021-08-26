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
    public partial class DocGia : Form
    {
        //Khai báo
        Controller.Model_DocGia docgia = new Controller.Model_DocGia();
        DataSet ds_muontra = new DataSet();
        DataSet ds_docgia = new DataSet();
        DataSet ds_sach = new DataSet();
        DataTable dt_lau = new DataTable();
        DataTable dt_ke = new DataTable();
        public DocGia()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        string madg = "";
        //Lấy dữ mã đọc giả từ form đăng nhập
        public DocGia(string giatrinhan) : this()
        {
            madg = giatrinhan;
            txt_tendn.Text = madg;
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Visible = false;
            dn.ShowDialog();
            Application.Exit();
        }

        //Đổ dữ liệu lên cbx_ke
        public void set_cbx_lau()
        {
            dt_lau = docgia.lay_Data_Cbx_Lau();
            cbx_lau.DataSource = dt_lau;
            cbx_lau.DisplayMember = "lau";
            cbx_lau.ValueMember = "makv";
            cbx_lau.SelectedIndex = 0;
        }

        //Đổ dữ liệu lên cbx_ke
        public void set_cbx_ke()
        {
            dt_ke = docgia.lay_Data_Cbx_Ke();
            DataView dv = new DataView(dt_ke);
            dv.RowFilter = "makv like '%" + cbx_lau.SelectedValue.ToString() + "%'";
            cbx_tenkesach.DataSource = dv.ToTable();
            cbx_tenkesach.DisplayMember = "tenkesach";
            cbx_tenkesach.ValueMember = "make";
        }

        //Hiển thị thông tin lên textbox
        void databinding(DataTable b)
        {
            txt_diachi.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            dtP_ngaybd.DataBindings.Clear();
            dtP_ngaykt.DataBindings.Clear();
            txt_phicoc.DataBindings.Clear();

            txt_diachi.DataBindings.Add("Text", b, "DIACHI");
            txt_hoten.DataBindings.Add("Text", b, "gioitinh");
            string c = txt_hoten.Text;
            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", b, "tendg");
            txt_phicoc.DataBindings.Add("Text", b, "phicoc");
            dtP_ngaybd.DataBindings.Add("Text", b, "ngaybd");
            dtP_ngaykt.DataBindings.Add("Text", b, "ngaykt");

            if (String.Compare(c, "Nam", true) == 0)
            {
                rdo_nam.Checked = true;
            }
            else if (String.Compare(c, "Nữ", true) == 0)
            {
                rdo_nu.Checked = true;
            }
            else
                rdo_khac.Checked = true;
        }

        //Đổ dữ liệu lên dgv_sach khi lọc bằng combobox
        public void setdata_grv_sach_loc()
        {
            DataView dv1 = new DataView(ds_sach.Tables[0]);
            dv1.RowFilter = "make like '%" + cbx_tenkesach.SelectedValue.ToString() + "%'";
            dgv_sach.DataSource = dv1;

        }

        //Đổ dữ liệu lên dgv_sach
        public void setdata_grv_sach()
        {
            dgv_sach.DataSource = ds_sach.Tables[0];
        }

        //Load dữ liệu
        public void load()
        {
            //Xoá dòng trống cuối cùng, chỉ đọc
            dgv_muontra.ReadOnly = true;
            dgv_muontra.AllowUserToAddRows = false;

            dgv_sach.ReadOnly = true;
            dgv_sach.AllowUserToAddRows = false;

            //Lấy dữ liệu từ database           
            ds_muontra = docgia.load_dulieuDGV_muontra(madg);
            ds_docgia = docgia.load_dulieuDocGia(madg);

            //Đổ dữ liệu lên datagridview
            dgv_muontra.DataSource = ds_muontra.Tables[0];
            //Set định dạng ngày cho cột
            dgv_muontra.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_muontra.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_muontra.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";

            databinding(ds_docgia.Tables[0]);

            set_cbx_lau();
            ds_sach = docgia.load_dulieuDGV_sach();
            setdata_grv_sach();
        }

        //Tìm kiếm sách
        public void timkiem_sach()
        {
            DataView dv = new DataView(ds_sach.Tables[0]);
            dv.RowFilter = "tensh like '%" + txt_timkiem.Text.ToString() + "%' or tentg like '%" +txt_timkiem.Text.ToString()+ "%' or mash like '%" + txt_timkiem.Text.ToString() + "%' or nxb like '%" + txt_timkiem.Text.ToString() + "%' or make like '%" + txt_timkiem.Text.ToString() + "%' or theloai like '%" + txt_timkiem.Text.ToString() + "%'";
            dgv_sach.DataSource = dv;
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_datlaimk_Click(object sender, EventArgs e)
        {
            DatLai_MatKhau reset = new DatLai_MatKhau(madg);
            reset.ShowDialog();
        }

        private void DocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rdo_khac.Checked == true)
            {
                gt = "Khác";
            }
            else if (rdo_nu.Checked == true)
            {
                gt = "Nữ";
            }
            else
                gt = "Nam";

            if (txt_diachi.Text.Length != 0 || txt_hoten.Text.Length != 0 || gt != null)
            {
                int check = 0;
                Model.DocGia a = new Model.DocGia();
                a.Madg = madg;
                a.Diachi = txt_diachi.Text;
                a.Tendg = txt_hoten.Text;
                a.Gioitinh = gt;

                check = docgia.capnhat_ThongTinDG(a);

                if (check != 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                    MessageBox.Show("Cập nhật không thành công!");
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin cập nhật!");
        }

        private void cbx_lau_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_cbx_ke();
        }

        private void cbx_tenkesach_SelectedIndexChanged(object sender, EventArgs e)
        {
            setdata_grv_sach_loc();
        }

        private void btn_moi_Click(object sender, EventArgs e)
        {
            txt_timkiem.Clear();
            txt_timkiem.Focus();
            setdata_grv_sach();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            timkiem_sach();
        }

        private void txt_phicoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_tuvan_Click(object sender, EventArgs e)
        {
            GoiY dn = new GoiY();
            dn.ShowDialog();
        }
    }
}
