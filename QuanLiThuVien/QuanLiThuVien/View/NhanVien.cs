using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QuanLiThuVien.View
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        //Biến tạm lưu mã thủ thư
        string matt = "";
        //Khởi tạo controler Muon tra + NhanVien
        Controller.Model_NhanVien nhanvien = new Controller.Model_NhanVien();
        Controller.Model_DocGia docgia = new Controller.Model_DocGia();
        DataSet dsMT;
        DataSet dsNV;
        DataTable dtDG;
        DataTable dtTT;
        DataTable dtSH;
        DataColumn[] key = new DataColumn[1];

        //Khởi tạo controler Sach + DocGia
        Controller.Model_NhanVien_Sach sach = new Controller.Model_NhanVien_Sach();
        Controller.Model_NhanVien_DocGia docgia1 = new Controller.Model_NhanVien_DocGia();
        //Biến bên from sách        
        DataSet ds_Sach;
        DataTable dt_Lau;
        DataTable dt_Ke;
        DataTable dt_TacGia;

        //Biến bên from đọc giả
        DataSet ds_DocGia;
        public void load()
        {
            dsMT = new DataSet();
            dsMT = docgia.load_dulieuDGV();
            dgv_muontra.DataSource = dsMT.Tables["Muontra"];

            dsNV = new DataSet();
            dsNV = nhanvien.load_dulieuNV();
            dgv_nhanvien.DataSource = dsNV.Tables["THUTHU"];

            dgv_nhanvien.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_muontra.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_muontra.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_muontra.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";

            loadTenDG();
            loadTenSH();
            loadTenTT();

            dgv_nhanvien.ReadOnly = true;
            dgv_nhanvien.AllowUserToAddRows = false;
            dgv_muontra.ReadOnly = true;
            dgv_muontra.AllowUserToAddRows = false;
        }

        public void loadTenDG()
        {
            dtDG = nhanvien.load_cbbTenDG();
            cbx_tendg.DataSource = dtDG;
            cbx_tendg.DisplayMember = "TENDG";
            cbx_tendg.ValueMember = "MADG";
        }

        public void loadTenSH()
        {
            dtSH = nhanvien.load_cbbTenSH();
            cbx_tensach_muontra.DataSource = dtSH;
            cbx_tensach_muontra.DisplayMember = "TENSH";
            cbx_tensach_muontra.ValueMember = "MASH";
        }
        public void loadTenTT()
        {
            dtTT = nhanvien.load_cbbTenTT();
            cbx_nguoilap.DataSource = dtTT;
            cbx_nguoilap.DisplayMember = "HOTEN";
            cbx_nguoilap.ValueMember = "MATT";
        }

        void timkiemNV()
        {
            DataView dv = new DataView(dsNV.Tables[0]);
            dv.RowFilter = "HOTEN LIKE '%" + txt_timkiem_nhanvien.Text.ToString() + "%' OR MATT LIKE '%" + txt_timkiem_nhanvien.Text.ToString() + "%' OR GIOITINH LIKE '%" + txt_timkiem_nhanvien.Text.ToString() + "%' OR EMAIL LIKE '%" + txt_timkiem_nhanvien.Text.ToString() + "%' OR DIACHI LIKE '%" + txt_timkiem_nhanvien.Text.ToString() + "%'";
            dgv_nhanvien.DataSource = dv;
        }

        void timkiemMT()
        {
            DataView dv = new DataView(dsMT.Tables[0]);
            dv.RowFilter = "TENDG LIKE '%" + txt_timkiem_muontra.Text.ToString() + "%' OR MAMT LIKE '%" + txt_timkiem_muontra.Text.ToString() + "%' OR HOTEN LIKE '%" + txt_timkiem_muontra.Text.ToString() + "%' OR TENSH LIKE '%" + txt_timkiem_muontra.Text.ToString() + "%' OR TINHTRANG LIKE '%" + txt_timkiem_muontra.Text.ToString() + "%'";
            dgv_muontra.DataSource = dv;
        }

        //Load Docgia + Sach
        public void load1()
        {
            //from datagridview sách
            load_DVG_Sach();
            dgv_sach.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_sach.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";

            //from datagridview đọc giả
            loadDataGridView_DocGia();
            dgv_docgia.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_docgia.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";

            //Gọi hàm load data lên combobox kệ
            set_Cbx_Lau();

            //Load dữ liệu lên cbx ke
            dt_Ke = sach.lay_Data_Cbx_Ke();
            DataView dv = new DataView(dt_Ke);
            cbx_sach_ke.DataSource = dv.ToTable();


            set_Cbx_TacGia();

            //để datagridview chỉ ở chế độ đọc và bỏ dòng thừa ở cuối
            dgv_sach.ReadOnly = true;
            dgv_sach.AllowUserToAddRows = false;

            //from load đọc giả
            loadDataGridView_DocGia();
            dgv_docgia.ReadOnly = true;
            dgv_docgia.AllowUserToAddRows = false;
        }

        //Hàm Load dữ liệu lên DataGridview Sách
        public void load_DVG_Sach()
        {
            ds_Sach = sach.load_dulieuDGV_Sach();
            dgv_sach.DataSource = ds_Sach.Tables[0];
        }

        //Hàm Load dữ liệu lên DataGridview Đọc giả
        public void loadDataGridView_DocGia()
        {
            ds_DocGia = docgia1.load_dulieuDGV_DocGia();
            dgv_docgia.DataSource = ds_DocGia.Tables[0];
        }

        //Lấy data cho combobox lầu từ database
        public void set_Cbx_Lau()
        {
            dt_Lau = sach.lay_Data_Cbx_Lau();
            cbx_sach_lau.DataSource = dt_Lau;
            cbx_sach_lau.DisplayMember = "LAU";
            cbx_sach_lau.ValueMember = "MAKV";
            cbx_sach_lau.SelectedIndex = 0;
        }

        //Lấy data cho combobox kệ từ database
        public void set_Cbx_Ke()
        {
            dt_Ke = sach.lay_Data_Cbx_Ke();
            DataView dv = new DataView(dt_Ke);
            dv.RowFilter = "MAKV like '%" + cbx_sach_lau.SelectedValue.ToString() + "%'";
            cbx_sach_ke.DataSource = dv;
            cbx_sach_ke.DisplayMember = "TENKESACH";
            cbx_sach_ke.ValueMember = "MAKE";
        }

        //Lấy data cho combobox tác giả từ database
        public void set_Cbx_TacGia()
        {
            dt_TacGia = sach.lay_Data_Cbx_TacGia();
            cbx_TacGia.DataSource = dt_TacGia;
            cbx_TacGia.DisplayMember = "TENTG";
            cbx_TacGia.ValueMember = "MATG";
            cbx_TacGia.SelectedIndex = 0;
        }

        //Hàm load data vào combobox kệ
        public void setdata_grv_cbxSach_Ke()
        {
            try
            {
                DataView dv_Sach = new DataView(ds_Sach.Tables[0]);
                dv_Sach.RowFilter = "MAKE like '%" + cbx_sach_ke.SelectedValue.ToString() + "%'";
                dgv_sach.DataSource = dv_Sach;
            }
            catch
            {
                return;
            }
        }

        //Tìm kiếm sách theo tên sách hoặc tên tác giả
        public void setdata_grv_txtSearch()
        {
            DataView dv_Sach = new DataView(ds_Sach.Tables[0]);
            dv_Sach.RowFilter = "tensh like '%" + txt_timkiem_sach.Text.ToString() + "%' or tentg like '%" + txt_timkiem_sach.Text.ToString() + "%' or MASH like '%" + txt_timkiem_sach.Text.ToString() + "%' or THELOAI like '%" + txt_timkiem_sach.Text.ToString() + "%' or NXB like '%" + txt_timkiem_sach.Text.ToString() + "%' or TENKESACH like '%" + txt_timkiem_sach.Text.ToString() + "%'";
            dgv_sach.DataSource = dv_Sach;
        }
        //Tìm kiếm đọc giả theo tên đọc giả
        public void setdata_grv_txtSearch_DocGia()
        {
            DataView dv_DocGia = new DataView(ds_DocGia.Tables[0]);
            dv_DocGia.RowFilter = "TenDG like '%" + txt_timkiem_docgia.Text.ToString() + "%' or MADG like '%" + txt_timkiem_docgia.Text.ToString() + "%' or GIOITINH like '%" + txt_timkiem_docgia.Text.ToString() + "%'";
            dgv_docgia.DataSource = dv_DocGia;
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            TrangChu tt = new TrangChu();
            this.Visible = false;
            tt.ShowDialog();
            Application.Exit();
        }

        private void btn_timkiem_muontra_Click(object sender, EventArgs e)
        {
            timkiemMT();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            load();
            load1();
        }

        private void dgv_muontra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_muontra.Rows[e.RowIndex];
            txt_mamuontra.Text = row.Cells["mamt"].Value.ToString();
            cbx_tendg.Text = row.Cells["tendg"].Value.ToString();
            cbx_nguoilap.Text = row.Cells["hoten"].Value.ToString();
            cbx_tensach_muontra.Text = row.Cells["tensh"].Value.ToString();
            dtp_ngaymuon.Text = row.Cells["ngaymuon"].Value.ToString();
            dtp_ngaytradukien.Text = row.Cells["ngaytradukien"].Value.ToString();
            dtp_ngaytrathucte.Text = row.Cells["ngaytrathucte"].Value.ToString();
            txt_tinhtrang.Text = row.Cells["tinhtrang"].Value.ToString();
        }

        private void btn_moi_muontra_Click(object sender, EventArgs e)
        {
            txt_mamuontra.Clear();
            cbx_tendg.ResetText();
            cbx_nguoilap.ResetText();
            cbx_tensach_muontra.ResetText();
            dtp_ngaymuon.ResetText();
            txt_tinhtrang.Clear();
            dtp_ngaytradukien.ResetText();
            dtp_ngaytrathucte.ResetText();
            txt_timkiem_muontra.Focus();
        }

        private void btn_them_muontra_Click(object sender, EventArgs e)
        {
            
            if (nhanvien.KT_KhoaChinh_MT(txt_mamuontra.Text) != 0)
            {
                MessageBox.Show("Đã tồn tại phiếu mượn trả...!");
                return;
            }
            else
            {
                txt_tinhtrang.Text = "ĐANG MƯỢN";
                dtp_ngaytrathucte.Value = DateTime.Today;
                Model.MuonTra mt = new Model.MuonTra(txt_mamuontra.Text, cbx_tendg.SelectedValue.ToString(), cbx_nguoilap.SelectedValue.ToString(), cbx_tensach_muontra.SelectedValue.ToString(), dtp_ngaymuon.Value.ToShortDateString(), txt_tinhtrang.Text, dtp_ngaytradukien.Value.ToShortDateString(), dtp_ngaytrathucte.Value.ToShortDateString());
                if (nhanvien.ThemMT(mt) != 0)
                {
                    dsMT = new DataSet();
                    dsMT = docgia.load_dulieuDGV();
                    dgv_muontra.DataSource = dsMT.Tables[0];

                    MessageBox.Show("Thêm phiếu mượn trả thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm phiếu mượn trả không thành công!");
                }
            }
        }

        private void btn_capnhat_muontra_Click(object sender, EventArgs e)
        {
            dtp_ngaytrathucte.Value = DateTime.Today;
            Model.MuonTra mt = new Model.MuonTra(txt_mamuontra.Text, cbx_tendg.SelectedValue.ToString(), cbx_nguoilap.SelectedValue.ToString(), cbx_tensach_muontra.SelectedValue.ToString(), dtp_ngaymuon.Value.ToShortDateString(), txt_tinhtrang.Text, dtp_ngaytradukien.Value.ToShortDateString(), dtp_ngaytrathucte.Value.ToShortDateString());
            if (nhanvien.SuaMT(mt) != 0)
            {
                dsMT = new DataSet();
                dsMT = docgia.load_dulieuDGV();
                dgv_muontra.DataSource = dsMT.Tables[0];

                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }

        private void btn_timkiem_nhanvien_Click(object sender, EventArgs e)
        {
            timkiemNV();
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_nhanvien.Rows[e.RowIndex];
            txt_manv.Text = row.Cells["MATT"].Value.ToString();
            txt_tennv.Text = row.Cells["HOTEN"].Value.ToString();
            dtp_ngaysinh.Text = row.Cells["NGAYSINH"].Value.ToString();
            txt_sdt.Text = row.Cells["SDT"].Value.ToString();
            txt_email.Text = row.Cells["EMAIL"].Value.ToString();
            txt_diachi_nv.Text = row.Cells["DIACHI"].Value.ToString();
            if (String.Compare(row.Cells["GIOITINH"].Value.ToString(), "NAM", true) == 0)
                rdo_nam_nv.Checked = true;
            if (String.Compare(row.Cells["GIOITINH"].Value.ToString(), "NỮ", true) == 0)
                rdo_nu_nv.Checked = true;
            if (String.Compare(row.Cells["GIOITINH"].Value.ToString(), "KHÁC", true) == 0)
                rdo_khac_nv.Checked = true;
        }

        private void btn_sua_nhanvien_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (rdo_nam_nv.Checked == true)
                gioitinh = "NAM";
            else if (rdo_nu_nv.Checked == true)
                gioitinh = "NỮ";
            else if (rdo_khac_nv.Checked == true)
                gioitinh = "KHÁC";
            Model.ThuThu tt = new Model.ThuThu(txt_manv.Text, txt_tennv.Text, gioitinh, dtp_ngaysinh.Value.ToShortDateString(), txt_sdt.Text, txt_email.Text, txt_diachi_nv.Text);
            if (nhanvien.SuaNV(tt) != 0)
            {
                dsNV = new DataSet();
                dsNV = nhanvien.load_dulieuNV();
                dgv_nhanvien.DataSource = dsNV.Tables[0];

                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void btn_them_nhanvien_Click(object sender, EventArgs e)
        {
            matt = txt_manv.Text;
            ThemNhanVien them = new ThemNhanVien(matt);
            them.ShowDialog();

            string gioitinh = "";
            if (rdo_nam_nv.Checked == true)
                gioitinh = "NAM";
            else if (rdo_nu_nv.Checked == true)
                gioitinh = "NỮ";
            else if (rdo_khac_nv.Checked == true)
                gioitinh = "KHÁC";
            Model.ThuThu tt = new Model.ThuThu(txt_manv.Text, txt_tennv.Text, gioitinh, dtp_ngaysinh.Value.ToShortDateString(), txt_sdt.Text, txt_email.Text, txt_diachi_nv.Text);
            if (nhanvien.ThemNV(tt) != 0)
            {
                dsNV = new DataSet();
                dsNV = nhanvien.load_dulieuNV();
                dgv_nhanvien.DataSource = dsNV.Tables[0];

                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void btn_xoa_nhanvien_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (rdo_nam_nv.Checked == true)
                gioitinh = "NAM";
            else if (rdo_nu_nv.Checked == true)
                gioitinh = "NỮ";
            else if (rdo_khac_nv.Checked == true)
                gioitinh = "KHÁC";
            Model.ThuThu tt = new Model.ThuThu(txt_manv.Text, txt_tennv.Text, gioitinh, dtp_ngaysinh.Value.ToShortDateString(), txt_sdt.Text, txt_email.Text, txt_diachi_nv.Text);
            if (nhanvien.XoaNV(tt) != 0)
            {
                dsNV = new DataSet();
                dsNV = nhanvien.load_dulieuNV();
                dgv_nhanvien.DataSource = dsNV.Tables[0];

                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btn_moi_nhanvien_Click(object sender, EventArgs e)
        {
            txt_manv.Clear();
            txt_sdt.Clear();
            txt_diachi_dg.Clear();
            txt_email.Clear();
            dtp_ngaysinh.ResetText();
            txt_timkiem_nhanvien.Focus();
        }

        private void btn_timkiem_docgia_Click(object sender, EventArgs e)
        {
            setdata_grv_txtSearch_DocGia();
        }

        private void btn_timkiem_sach_Click(object sender, EventArgs e)
        {
            setdata_grv_txtSearch();
        }

        private void cbx_sach_lau_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_Cbx_Ke();
        }

        private void cbx_sach_ke_SelectedIndexChanged(object sender, EventArgs e)
        {
            setdata_grv_cbxSach_Ke();
        }

        private void dgv_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masach.DataBindings.Clear();
            txt_tensach.DataBindings.Clear();
            txt_soluong.DataBindings.Clear();
            txt_theloai.DataBindings.Clear();
            dtp_ngaynhap.DataBindings.Clear();
            txt_nxb.DataBindings.Clear();
            dtp_namxuatban.DataBindings.Clear();
            txt_PhiDenBu.DataBindings.Clear();

            DataGridViewRow row = this.dgv_sach.Rows[e.RowIndex];
            txt_masach.Text = row.Cells["mash"].Value.ToString();
            cbx_TacGia.Text = row.Cells["TENTG"].Value.ToString();
            txt_tensach.Text = row.Cells["TENSH"].Value.ToString();
            txt_soluong.Text = row.Cells["SOLUONG"].Value.ToString();
            txt_theloai.Text = row.Cells["THELOAI"].Value.ToString();
            dtp_ngaynhap.Value = Convert.ToDateTime(row.Cells["NGAYNHAPSACH"].Value.ToString());
            txt_nxb.Text = row.Cells["NXB"].Value.ToString();
            dtp_namxuatban.Value = Convert.ToDateTime(row.Cells["NAMXB"].Value.ToString());
            txt_PhiDenBu.Text = row.Cells["PHIDENBU"].Value.ToString();
        }

        private void btn_them_tacgia_Click(object sender, EventArgs e)
        {
            ThemTacGia a = new ThemTacGia();
            a.ShowDialog();
            set_Cbx_TacGia();
        }

        private void btn_sua_sach_Click(object sender, EventArgs e)
        {
            if (sach.KT_KhoaChinh(txt_masach.Text) == 0)
            {
                MessageBox.Show("Không tồn tại");
                return;
            }
            else
            {
                Model.Sach a = new Model.Sach();
                a.Mash = txt_masach.Text;
                a.Matg = cbx_TacGia.SelectedValue.ToString();
                a.Tensh = txt_tensach.Text;
                a.Soluong = txt_soluong.Text;
                a.Ngaynhap = dtp_ngaynhap.Value.ToShortDateString();
                a.Theloai = txt_theloai.Text;
                a.Nhaxuatban = txt_nxb.Text;
                a.Nxb = dtp_namxuatban.Value.ToShortDateString();
                a.Phidenbu = txt_PhiDenBu.Text;
                a.Make = cbx_sach_ke.SelectedValue.ToString();
                if (sach.capNhatSach(a) != 0)
                {
                    load_DVG_Sach();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
        }

        private void btn_them_sach_Click(object sender, EventArgs e)
        {
            if (sach.KT_KhoaChinh(txt_masach.Text) != 0)
            {
                MessageBox.Show("Đã tồn tại");
                return;
            }
            else
            {
                Model.Sach a = new Model.Sach();
                a.Mash = txt_masach.Text;
                a.Matg = cbx_TacGia.SelectedValue.ToString();
                a.Tensh = txt_tensach.Text;
                a.Soluong = txt_soluong.Text;
                a.Ngaynhap = dtp_ngaynhap.Value.ToShortDateString();
                a.Theloai = txt_theloai.Text;
                a.Nhaxuatban = txt_nxb.Text;
                a.Nxb = dtp_namxuatban.Value.ToShortDateString();
                a.Phidenbu = txt_PhiDenBu.Text;
                a.Make = cbx_sach_ke.SelectedValue.ToString();
                if (sach.ThemSach(a) != 0)
                {
                    load_DVG_Sach();
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }

        private void btn_xoa_sach_Click(object sender, EventArgs e)
        {
            if (sach.KT_KhoaChinh(txt_masach.Text) == 0)
            {
                MessageBox.Show("Sách không tồn tại");
                return;
            }

            if (sach.KT_SachDangSD(txt_masach.Text) != 0)
            {
                MessageBox.Show("Sách đang được sử dụng không xóa được");
                return;
            }

            if (MessageBox.Show("Bạn Chắn chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            Model.Sach a = new Model.Sach();
            a.Mash = txt_masach.Text;
            if (sach.xoaSach(a) != 0)
            {
                load_DVG_Sach();
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btn_moi_sach_Click(object sender, EventArgs e)
        {
            cbx_sach_lau.SelectedIndex = 0;
            cbx_TacGia.SelectedIndex = 0;
            txt_masach.ResetText();
            txt_tensach.ResetText();
            txt_soluong.ResetText();
            txt_theloai.ResetText();
            dtp_ngaynhap.Value = DateTime.Today;
            txt_nxb.ResetText();
            dtp_namxuatban.Value = DateTime.Today;
            txt_PhiDenBu.ResetText();
            txt_timkiem_sach.ResetText();
            txt_timkiem_sach.Focus();
            load_DVG_Sach();
        }

        private void dgv_docgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tendn.DataBindings.Clear();
            txt_matkhau.DataBindings.Clear();
            txt_mkMoi.DataBindings.Clear();
            txt_nhaplaimk.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            txt_diachi_dg.DataBindings.Clear();
            dtp_ngaybd.DataBindings.Clear();
            dtp_ngaykt.DataBindings.Clear();

            DataGridViewRow row = this.dgv_docgia.Rows[e.RowIndex];
            if (String.Compare(row.Cells["GIOITINH"].Value.ToString(), "NAM", true) == 0)
                rdo_nam.Checked = true;
            if (String.Compare(row.Cells["GIOITINH"].Value.ToString(), "NỮ", true) == 0)
                rdo_nu.Checked = true;
            if (String.Compare(row.Cells["GIOITINH"].Value.ToString(), "KHÁC", true) == 0)
                rdo_khac.Checked = true;

            txt_tendn.Text = row.Cells["MADG"].Value.ToString();
            txt_matkhau.Text = row.Cells["MATKHAU"].Value.ToString();
            txt_hoten.Text = row.Cells["TENDG"].Value.ToString();
            txt_diachi_dg.Text = row.Cells["DIACHI"].Value.ToString();
            dtp_ngaybd.Value = Convert.ToDateTime(row.Cells["NGAYBD"].Value.ToString());
            dtp_ngaykt.Value = Convert.ToDateTime(row.Cells["NGAYKT"].Value.ToString());
        }

        private void btn_sua_docgia_Click(object sender, EventArgs e)
        {
            if (docgia1.KT_KhoaChinh(txt_tendn.Text) == 0)
            {
                MessageBox.Show("Không tồn tại");
                return;
            }
            else
            {
                string gioitinh = "";
                if (rdo_nam.Checked == true)
                    gioitinh = "NAM";
                else if (rdo_nu.Checked == true)
                    gioitinh = "NỮ";
                else if (rdo_khac.Checked == true)
                    gioitinh = "KHÁC";
                Model.DocGia a = new Model.DocGia();
                Model.TK_DocGia b = new Model.TK_DocGia();
                a.Madg = txt_tendn.Text;
                a.Tendg = txt_hoten.Text;
                a.Gioitinh = gioitinh;
                a.Diachi = txt_diachi_dg.Text;
                a.Ngaybd = dtp_ngaybd.Value.ToShortDateString();
                a.Ngaykt = dtp_ngaykt.Value.ToShortDateString();
                a.Phicoc = "300000";
                b.Madg = txt_tendn.Text;
                b.Matkhau = txt_mkMoi.Text;
                if (txt_mkMoi.Text.Length != 0)
                {
                    if (docgia1.capNhatTKDocGia(b) != 0)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu không thành công!");
                    }
                }

                if (docgia1.capNhatDocGia(a) != 0)
                {
                    loadDataGridView_DocGia();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
        }

        private void btn_them_docgia_Click(object sender, EventArgs e)
        {
            if (docgia1.KT_KhoaChinh(txt_tendn.Text) != 0)
            {
                MessageBox.Show("Đã tồn tại");
                return;
            }
            else
            {
                string gioitinh = "";
                if (rdo_nam.Checked == true)
                    gioitinh = "NAM";
                else if (rdo_nu.Checked == true)
                    gioitinh = "NỮ";
                else if (rdo_khac.Checked == true)
                    gioitinh = "KHÁC";
                Model.DocGia a = new Model.DocGia();
                Model.TK_DocGia b = new Model.TK_DocGia();
                a.Madg = txt_tendn.Text;
                a.Tendg = txt_hoten.Text;
                a.Gioitinh = gioitinh;
                a.Diachi = txt_diachi_dg.Text;
                a.Ngaybd = dtp_ngaybd.Value.ToString();
                a.Ngaykt = dtp_ngaykt.Value.ToString();
                b.Madg = txt_tendn.Text;
                b.Matkhau = txt_matkhau.Text;
                a.Phicoc = "3000000";
                if (docgia1.ThemTKDocGia(b) != 0 && docgia1.ThemDocGia(a) != 0)
                {
                    loadDataGridView_DocGia();
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }

        private void btn_xoa_docgia_Click(object sender, EventArgs e)
        {
            if (docgia1.KT_KhoaChinh(txt_tendn.Text) == 0)
            {
                MessageBox.Show("Đọc giả không tồn tại!!!");
                return;
            }

            if (docgia1.KT_DocGiaDangSD(txt_tendn.Text) != 0)
            {
                MessageBox.Show("Đọc giả đang mượn sách không xóa được!!!");
                return;
            }

            if (MessageBox.Show("Bạn Chắn chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            Model.DocGia a = new Model.DocGia();
            a.Madg = txt_tendn.Text;
            if (docgia1.xoaDocGia(a) != 0)
            {
                loadDataGridView_DocGia();
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btn_moi_docgia_Click(object sender, EventArgs e)
        {
            txt_tendn.ResetText();
            txt_matkhau.ResetText();
            txt_mkMoi.ResetText();
            txt_nhaplaimk.ResetText();
            txt_hoten.ResetText();
            txt_diachi_dg.ResetText();
            dtp_ngaybd.Value = DateTime.Today;
            dtp_ngaybd.Value = DateTime.Today;
            rdo_nam.Checked = true;
            rdo_nu.Checked = false;
            rdo_khac.Checked = false;
            txt_timkiem_docgia.ResetText();
            loadDataGridView_DocGia();
            txt_timkiem_docgia.Focus();
        }

        private void txt_mkMoi_Leave(object sender, EventArgs e)
        {
            if (txt_matkhau.Text.Length > 15)
                errorProvider1.SetError(txt_matkhau, "Vui lòng không nhập quá 15 kí tự!");
            else
                errorProvider1.SetError(txt_matkhau, null);
        }

        private void txt_nhaplaimk_Leave(object sender, EventArgs e)
        {
            if (!txt_nhaplaimk.Text.Equals(txt_mkMoi.Text))
                errorProvider1.SetError(txt_nhaplaimk, "Mật khẩu nhập lại không đúng!");
            else
                errorProvider1.SetError(txt_nhaplaimk, null);
        }

        private void txt_tendn_Leave(object sender, EventArgs e)
        {
            if (txt_tendn.Text.Length > 10)
                errorProvider1.SetError(txt_tendn, "Vui lòng không nhập quá 10 kí tự!");
            else
                errorProvider1.SetError(txt_tendn, null);
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_PhiDenBu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
