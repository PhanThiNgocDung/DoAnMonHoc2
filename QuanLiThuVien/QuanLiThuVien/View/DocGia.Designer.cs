namespace QuanLiThuVien.View
{
    partial class DocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocGia));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_tuvan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_sach = new System.Windows.Forms.DataGridView();
            this.cbx_tenkesach = new System.Windows.Forms.ComboBox();
            this.cbx_lau = new System.Windows.Forms.ComboBox();
            this.btn_dangxuat1 = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_moi = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_phicoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtP_ngaykt = new System.Windows.Forms.DateTimePicker();
            this.dtP_ngaybd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_datlaimk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdo_khac = new System.Windows.Forms.RadioButton();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tendn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_muontra = new System.Windows.Forms.DataGridView();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muontra)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.btn_tuvan);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dgv_sach);
            this.tabPage3.Controls.Add(this.cbx_tenkesach);
            this.tabPage3.Controls.Add(this.cbx_lau);
            this.tabPage3.Controls.Add(this.btn_dangxuat1);
            this.tabPage3.Controls.Add(this.txt_timkiem);
            this.tabPage3.Controls.Add(this.btn_moi);
            this.tabPage3.Controls.Add(this.btn_timkiem);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1371, 594);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tìm kiếm";
            // 
            // btn_tuvan
            // 
            this.btn_tuvan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_tuvan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tuvan.Location = new System.Drawing.Point(1193, 77);
            this.btn_tuvan.Name = "btn_tuvan";
            this.btn_tuvan.Size = new System.Drawing.Size(148, 46);
            this.btn_tuvan.TabIndex = 13;
            this.btn_tuvan.Text = "TƯ VẤN";
            this.btn_tuvan.UseVisualStyleBackColor = false;
            this.btn_tuvan.Click += new System.EventHandler(this.btn_tuvan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(705, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kệ sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lầu";
            // 
            // dgv_sach
            // 
            this.dgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sach.Location = new System.Drawing.Point(59, 161);
            this.dgv_sach.Name = "dgv_sach";
            this.dgv_sach.RowTemplate.Height = 24;
            this.dgv_sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sach.Size = new System.Drawing.Size(1236, 383);
            this.dgv_sach.TabIndex = 10;
            // 
            // cbx_tenkesach
            // 
            this.cbx_tenkesach.FormattingEnabled = true;
            this.cbx_tenkesach.Location = new System.Drawing.Point(793, 97);
            this.cbx_tenkesach.Name = "cbx_tenkesach";
            this.cbx_tenkesach.Size = new System.Drawing.Size(239, 31);
            this.cbx_tenkesach.TabIndex = 9;
            this.cbx_tenkesach.SelectedIndexChanged += new System.EventHandler(this.cbx_tenkesach_SelectedIndexChanged);
            // 
            // cbx_lau
            // 
            this.cbx_lau.FormattingEnabled = true;
            this.cbx_lau.Location = new System.Drawing.Point(408, 97);
            this.cbx_lau.Name = "cbx_lau";
            this.cbx_lau.Size = new System.Drawing.Size(239, 31);
            this.cbx_lau.TabIndex = 8;
            this.cbx_lau.SelectedIndexChanged += new System.EventHandler(this.cbx_lau_SelectedIndexChanged);
            // 
            // btn_dangxuat1
            // 
            this.btn_dangxuat1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat1.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat1.Image")));
            this.btn_dangxuat1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat1.Location = new System.Drawing.Point(1193, 6);
            this.btn_dangxuat1.Name = "btn_dangxuat1";
            this.btn_dangxuat1.Size = new System.Drawing.Size(148, 45);
            this.btn_dangxuat1.TabIndex = 7;
            this.btn_dangxuat1.Text = "Đăng xuất";
            this.btn_dangxuat1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangxuat1.UseVisualStyleBackColor = true;
            this.btn_dangxuat1.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(513, 33);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(376, 33);
            this.txt_timkiem.TabIndex = 6;
            this.txt_timkiem.Text = "Tên sách hoặc tên tác giả";
            this.txt_timkiem.TextChanged += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_moi
            // 
            this.btn_moi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moi.Image = ((System.Drawing.Image)(resources.GetObject("btn_moi.Image")));
            this.btn_moi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_moi.Location = new System.Drawing.Point(934, 24);
            this.btn_moi.Name = "btn_moi";
            this.btn_moi.Size = new System.Drawing.Size(98, 49);
            this.btn_moi.TabIndex = 5;
            this.btn_moi.Text = "Mới";
            this.btn_moi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_moi.UseVisualStyleBackColor = true;
            this.btn_moi.Click += new System.EventHandler(this.btn_moi_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(322, 24);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(144, 49);
            this.btn_timkiem.TabIndex = 4;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_dangxuat);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1371, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(15, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 44);
            this.panel1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(515, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "THÔNG TIN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_phicoc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtP_ngaykt);
            this.groupBox2.Controls.Add(this.dtP_ngaybd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_datlaimk);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_diachi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_capnhat);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txt_hoten);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_tendn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(882, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 474);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đọc giả";
            // 
            // txt_phicoc
            // 
            this.txt_phicoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phicoc.Location = new System.Drawing.Point(190, 367);
            this.txt_phicoc.Multiline = true;
            this.txt_phicoc.Name = "txt_phicoc";
            this.txt_phicoc.Size = new System.Drawing.Size(250, 31);
            this.txt_phicoc.TabIndex = 44;
            this.txt_phicoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phicoc_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(36, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "PHÍ CỌC";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtP_ngaykt
            // 
            this.dtP_ngaykt.CustomFormat = "dd/MM/yyyy";
            this.dtP_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP_ngaykt.Location = new System.Drawing.Point(191, 320);
            this.dtP_ngaykt.Name = "dtP_ngaykt";
            this.dtP_ngaykt.Size = new System.Drawing.Size(249, 34);
            this.dtP_ngaykt.TabIndex = 43;
            this.dtP_ngaykt.Value = new System.DateTime(2020, 11, 24, 0, 0, 0, 0);
            // 
            // dtP_ngaybd
            // 
            this.dtP_ngaybd.CustomFormat = "dd/MM/yyyy";
            this.dtP_ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP_ngaybd.Location = new System.Drawing.Point(191, 274);
            this.dtP_ngaybd.Name = "dtP_ngaybd";
            this.dtP_ngaybd.Size = new System.Drawing.Size(249, 34);
            this.dtP_ngaybd.TabIndex = 42;
            this.dtP_ngaybd.Value = new System.DateTime(2020, 11, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(36, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "GIỚI TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_datlaimk
            // 
            this.btn_datlaimk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_datlaimk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datlaimk.Location = new System.Drawing.Point(208, 411);
            this.btn_datlaimk.Name = "btn_datlaimk";
            this.btn_datlaimk.Size = new System.Drawing.Size(216, 45);
            this.btn_datlaimk.TabIndex = 8;
            this.btn_datlaimk.Text = "ĐẶT LẠI MẬT KHẨU";
            this.btn_datlaimk.UseVisualStyleBackColor = false;
            this.btn_datlaimk.Click += new System.EventHandler(this.btn_datlaimk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "NGÀY KẾT THÚC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(36, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "NGÀY BẮT ĐẦU";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(193, 219);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(247, 31);
            this.txt_diachi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "ĐỊA CHỈ";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.White;
            this.btn_capnhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.Location = new System.Drawing.Point(38, 411);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(128, 45);
            this.btn_capnhat.TabIndex = 7;
            this.btn_capnhat.Text = "CẬP NHẬT";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdo_khac);
            this.groupBox3.Controls.Add(this.rdo_nu);
            this.groupBox3.Controls.Add(this.rdo_nam);
            this.groupBox3.Location = new System.Drawing.Point(170, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // rdo_khac
            // 
            this.rdo_khac.AutoSize = true;
            this.rdo_khac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_khac.Location = new System.Drawing.Point(186, 22);
            this.rdo_khac.Name = "rdo_khac";
            this.rdo_khac.Size = new System.Drawing.Size(68, 24);
            this.rdo_khac.TabIndex = 2;
            this.rdo_khac.TabStop = true;
            this.rdo_khac.Text = "Khác";
            this.rdo_khac.UseVisualStyleBackColor = true;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nu.Location = new System.Drawing.Point(106, 22);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(51, 24);
            this.rdo_nu.TabIndex = 1;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nam.Location = new System.Drawing.Point(21, 22);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(65, 24);
            this.rdo_nam.TabIndex = 0;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(193, 83);
            this.txt_hoten.Multiline = true;
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(247, 31);
            this.txt_hoten.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(34, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "HỌ VÀ TÊN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_tendn
            // 
            this.txt_tendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendn.Location = new System.Drawing.Point(191, 29);
            this.txt_tendn.Multiline = true;
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(249, 31);
            this.txt_tendn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(34, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "TÊN ĐĂNG NHẬP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_muontra);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 474);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mượn trả";
            // 
            // dgv_muontra
            // 
            this.dgv_muontra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muontra.Location = new System.Drawing.Point(23, 41);
            this.dgv_muontra.Name = "dgv_muontra";
            this.dgv_muontra.RowTemplate.Height = 24;
            this.dgv_muontra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_muontra.Size = new System.Drawing.Size(820, 415);
            this.dgv_muontra.TabIndex = 0;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat.Image")));
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(1214, 6);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(148, 45);
            this.btn_dangxuat.TabIndex = 9;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1379, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1379, 629);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DocGia";
            this.Text = "DocGia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocGia_FormClosing);
            this.Load += new System.EventHandler(this.DocGia_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muontra)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_dangxuat1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_moi;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_muontra;
        private System.Windows.Forms.Button btn_datlaimk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdo_khac;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tendn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_sach;
        private System.Windows.Forms.ComboBox cbx_tenkesach;
        private System.Windows.Forms.ComboBox cbx_lau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtP_ngaykt;
        private System.Windows.Forms.DateTimePicker dtP_ngaybd;
        private System.Windows.Forms.TextBox txt_phicoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_tuvan;
    }
}