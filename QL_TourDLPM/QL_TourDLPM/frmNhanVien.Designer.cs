namespace QL_TourDLPM
{
    partial class frmNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label tenNVLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label hinhAnhNVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.qL_TOURDLPMDataSet = new QL_TourDLPM.QL_TOURDLPMDataSet();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager();
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bn_File = new System.Windows.Forms.Button();
            this.txt_HinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.txt_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_NgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txt_TenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaNV = new DevExpress.XtraEditors.TextEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            maNVLabel = new System.Windows.Forms.Label();
            tenNVLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            hinhAnhNVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNVLabel.Location = new System.Drawing.Point(36, 51);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(113, 20);
            maNVLabel.TabIndex = 0;
            maNVLabel.Text = "Mã nhân viên:";
            // 
            // tenNVLabel
            // 
            tenNVLabel.AutoSize = true;
            tenNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenNVLabel.Location = new System.Drawing.Point(36, 114);
            tenNVLabel.Name = "tenNVLabel";
            tenNVLabel.Size = new System.Drawing.Size(118, 20);
            tenNVLabel.TabIndex = 2;
            tenNVLabel.Text = "Tên nhân viên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.Location = new System.Drawing.Point(468, 51);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(88, 20);
            ngaySinhLabel.TabIndex = 4;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(468, 115);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(47, 20);
            sDTLabel.TabIndex = 6;
            sDTLabel.Text = "SĐT:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(36, 172);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 20);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.Location = new System.Drawing.Point(36, 229);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(66, 20);
            diaChiLabel.TabIndex = 10;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matKhauLabel.Location = new System.Drawing.Point(467, 176);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(82, 20);
            matKhauLabel.TabIndex = 12;
            matKhauLabel.Text = "Mật khẩu:";
            // 
            // hinhAnhNVLabel
            // 
            hinhAnhNVLabel.AutoSize = true;
            hinhAnhNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhAnhNVLabel.Location = new System.Drawing.Point(468, 232);
            hinhAnhNVLabel.Name = "hinhAnhNVLabel";
            hinhAnhNVLabel.Size = new System.Drawing.Size(81, 20);
            hinhAnhNVLabel.TabIndex = 14;
            hinhAnhNVLabel.Text = "Hình ảnh:";
            // 
            // qL_TOURDLPMDataSet
            // 
            this.qL_TOURDLPMDataSet.DataSetName = "QL_TOURDLPMDataSet";
            this.qL_TOURDLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHAULUCTableAdapter = null;
            this.tableAdapterManager.DATTOURTableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.DIEMDENTableAdapter = null;
            this.tableAdapterManager.HUONGDANVIENTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHACHSANTableAdapter = null;
            this.tableAdapterManager.LOAIPHUONGTIENTableAdapter = null;
            this.tableAdapterManager.MIENTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.PHUONGTIENTableAdapter = null;
            this.tableAdapterManager.SDDICHVUTableAdapter = null;
            this.tableAdapterManager.THANHTOANTableAdapter = null;
            this.tableAdapterManager.TOURTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(22, 365);
            this.nHANVIENGridControl.MainView = this.gridView1;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(1570, 379);
            this.nHANVIENGridControl.TabIndex = 1;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.nHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Bn_File);
            this.groupBox1.Controls.Add(hinhAnhNVLabel);
            this.groupBox1.Controls.Add(this.txt_HinhAnh);
            this.groupBox1.Controls.Add(matKhauLabel);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(diaChiLabel);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(ngaySinhLabel);
            this.groupBox1.Controls.Add(this.txt_NgaySinh);
            this.groupBox1.Controls.Add(tenNVLabel);
            this.groupBox1.Controls.Add(this.txt_TenNhanVien);
            this.groupBox1.Controls.Add(maNVLabel);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(919, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 208);
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // Bn_File
            // 
            this.Bn_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bn_File.Location = new System.Drawing.Point(817, 227);
            this.Bn_File.Name = "Bn_File";
            this.Bn_File.Size = new System.Drawing.Size(52, 31);
            this.Bn_File.TabIndex = 169;
            this.Bn_File.Text = "File";
            this.Bn_File.UseVisualStyleBackColor = true;
            this.Bn_File.Click += new System.EventHandler(this.Bn_File_Click);
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "HinhAnhNV", true));
            this.txt_HinhAnh.Enabled = false;
            this.txt_HinhAnh.Location = new System.Drawing.Point(616, 229);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HinhAnh.Properties.Appearance.Options.UseFont = true;
            this.txt_HinhAnh.Size = new System.Drawing.Size(175, 26);
            this.txt_HinhAnh.TabIndex = 15;
            this.txt_HinhAnh.TextChanged += new System.EventHandler(this.txt_HinhAnh_TextChanged);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "MatKhau", true));
            this.txt_MatKhau.Location = new System.Drawing.Point(616, 173);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Properties.Appearance.Options.UseFont = true;
            this.txt_MatKhau.Size = new System.Drawing.Size(175, 26);
            this.txt_MatKhau.TabIndex = 13;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "DiaChi", true));
            this.txt_DiaChi.Location = new System.Drawing.Point(191, 226);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(246, 26);
            this.txt_DiaChi.TabIndex = 11;
            // 
            // txt_Email
            // 
            this.txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "Email", true));
            this.txt_Email.Location = new System.Drawing.Point(191, 172);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Properties.Appearance.Options.UseFont = true;
            this.txt_Email.Size = new System.Drawing.Size(246, 26);
            this.txt_Email.TabIndex = 9;
            // 
            // txt_SDT
            // 
            this.txt_SDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "SDT", true));
            this.txt_SDT.Location = new System.Drawing.Point(616, 115);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SDT.Size = new System.Drawing.Size(175, 26);
            this.txt_SDT.TabIndex = 7;
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "NgaySinh", true));
            this.txt_NgaySinh.EditValue = null;
            this.txt_NgaySinh.Location = new System.Drawing.Point(616, 51);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgaySinh.Properties.Appearance.Options.UseFont = true;
            this.txt_NgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgaySinh.Size = new System.Drawing.Size(175, 26);
            this.txt_NgaySinh.TabIndex = 5;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "TenNV", true));
            this.txt_TenNhanVien.Location = new System.Drawing.Point(191, 114);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNhanVien.Size = new System.Drawing.Size(246, 26);
            this.txt_TenNhanVien.TabIndex = 3;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "MaNV", true));
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(191, 51);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Properties.Appearance.Options.UseFont = true;
            this.txt_MaNV.Size = new System.Drawing.Size(100, 26);
            this.txt_MaNV.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            this.imageList1.Images.SetKeyName(2, "trash.png");
            this.imageList1.Images.SetKeyName(3, "exit.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1264, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(328, 309);
            this.groupBox2.TabIndex = 170;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // button9
            // 
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.ImageIndex = 1;
            this.button9.ImageList = this.imageList1;
            this.button9.Location = new System.Drawing.Point(28, 37);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 105);
            this.button9.TabIndex = 20;
            this.button9.Text = "Thêm";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button12
            // 
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.ImageIndex = 3;
            this.button12.ImageList = this.imageList1;
            this.button12.Location = new System.Drawing.Point(191, 176);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(105, 113);
            this.button12.TabIndex = 22;
            this.button12.Text = "Thoát";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.ImageIndex = 2;
            this.button11.ImageList = this.imageList1;
            this.button11.Location = new System.Drawing.Point(28, 178);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 111);
            this.button11.TabIndex = 21;
            this.button11.Text = "Xóa ";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.ImageIndex = 0;
            this.button10.ImageList = this.imageList1;
            this.button10.Location = new System.Drawing.Point(191, 37);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 105);
            this.button10.TabIndex = 23;
            this.button10.Text = "Lưu";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 756);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nHANVIENGridControl);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QL_TOURDLPMDataSet qL_TOURDLPMDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QL_TOURDLPMDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private QL_TOURDLPMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txt_HinhAnh;
        private DevExpress.XtraEditors.TextEdit txt_MatKhau;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.DateEdit txt_NgaySinh;
        private DevExpress.XtraEditors.TextEdit txt_TenNhanVien;
        private DevExpress.XtraEditors.TextEdit txt_MaNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bn_File;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}