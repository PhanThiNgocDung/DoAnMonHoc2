namespace QL_TourDLPM
{
    partial class frmKhachHang
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
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label tenKHLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label hinhAnhKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.qL_TOURDLPMDataSet = new QL_TourDLPM.QL_TOURDLPMDataSet();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager();
            this.kHACHHANGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bn_File = new System.Windows.Forms.Button();
            this.txt_HinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_NgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaKH = new DevExpress.XtraEditors.TextEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            maKHLabel = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            hinhAnhKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKHLabel.Location = new System.Drawing.Point(12, 61);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(127, 20);
            maKHLabel.TabIndex = 0;
            maKHLabel.Text = "Mã khách hàng:";
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenKHLabel.Location = new System.Drawing.Point(12, 124);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(132, 20);
            tenKHLabel.TabIndex = 2;
            tenKHLabel.Text = "Tên khách hàng:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.Location = new System.Drawing.Point(485, 61);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(88, 20);
            ngaySinhLabel.TabIndex = 4;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(485, 124);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(47, 20);
            sDTLabel.TabIndex = 6;
            sDTLabel.Text = "SĐT:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(12, 186);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 20);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.Location = new System.Drawing.Point(12, 250);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(66, 20);
            diaChiLabel.TabIndex = 10;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // hinhAnhKHLabel
            // 
            hinhAnhKHLabel.AutoSize = true;
            hinhAnhKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhAnhKHLabel.Location = new System.Drawing.Point(416, 194);
            hinhAnhKHLabel.Name = "hinhAnhKHLabel";
            hinhAnhKHLabel.Size = new System.Drawing.Size(171, 20);
            hinhAnhKHLabel.TabIndex = 12;
            hinhAnhKHLabel.Text = "Hình ảnh khách hàng:";
            // 
            // qL_TOURDLPMDataSet
            // 
            this.qL_TOURDLPMDataSet.DataSetName = "QL_TOURDLPMDataSet";
            this.qL_TOURDLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHAULUCTableAdapter = null;
            this.tableAdapterManager.DATTOURTableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.DIEMDENTableAdapter = null;
            this.tableAdapterManager.HUONGDANVIENTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.KHACHSANTableAdapter = null;
            this.tableAdapterManager.LOAIPHUONGTIENTableAdapter = null;
            this.tableAdapterManager.MIENTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHUONGTIENTableAdapter = null;
            this.tableAdapterManager.SDDICHVUTableAdapter = null;
            this.tableAdapterManager.THANHTOANTableAdapter = null;
            this.tableAdapterManager.TOURTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHACHHANGGridControl
            // 
            this.kHACHHANGGridControl.DataSource = this.kHACHHANGBindingSource;
            this.kHACHHANGGridControl.Location = new System.Drawing.Point(12, 397);
            this.kHACHHANGGridControl.MainView = this.gridView1;
            this.kHACHHANGGridControl.Name = "kHACHHANGGridControl";
            this.kHACHHANGGridControl.Size = new System.Drawing.Size(1540, 347);
            this.kHACHHANGGridControl.TabIndex = 1;
            this.kHACHHANGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.kHACHHANGGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Bn_File);
            this.groupBox1.Controls.Add(hinhAnhKHLabel);
            this.groupBox1.Controls.Add(this.txt_HinhAnh);
            this.groupBox1.Controls.Add(diaChiLabel);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(ngaySinhLabel);
            this.groupBox1.Controls.Add(this.txt_NgaySinh);
            this.groupBox1.Controls.Add(tenKHLabel);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(maKHLabel);
            this.groupBox1.Controls.Add(this.txt_MaKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 311);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(871, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 208);
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // Bn_File
            // 
            this.Bn_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bn_File.Location = new System.Drawing.Point(795, 189);
            this.Bn_File.Name = "Bn_File";
            this.Bn_File.Size = new System.Drawing.Size(52, 31);
            this.Bn_File.TabIndex = 167;
            this.Bn_File.Text = "File";
            this.Bn_File.UseVisualStyleBackColor = true;
            this.Bn_File.Click += new System.EventHandler(this.Bn_File_Click);
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "HinhAnhKH", true));
            this.txt_HinhAnh.Enabled = false;
            this.txt_HinhAnh.Location = new System.Drawing.Point(616, 191);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HinhAnh.Properties.Appearance.Options.UseFont = true;
            this.txt_HinhAnh.Size = new System.Drawing.Size(173, 26);
            this.txt_HinhAnh.TabIndex = 13;
            this.txt_HinhAnh.TextChanged += new System.EventHandler(this.txt_HinhAnh_TextChanged);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "DiaChi", true));
            this.txt_DiaChi.Location = new System.Drawing.Point(158, 247);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(589, 26);
            this.txt_DiaChi.TabIndex = 11;
            // 
            // txt_Email
            // 
            this.txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "Email", true));
            this.txt_Email.Location = new System.Drawing.Point(158, 186);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Properties.Appearance.Options.UseFont = true;
            this.txt_Email.Size = new System.Drawing.Size(243, 26);
            this.txt_Email.TabIndex = 9;
            // 
            // txt_SDT
            // 
            this.txt_SDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "SDT", true));
            this.txt_SDT.Location = new System.Drawing.Point(616, 121);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SDT.Size = new System.Drawing.Size(173, 26);
            this.txt_SDT.TabIndex = 7;
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "NgaySinh", true));
            this.txt_NgaySinh.EditValue = null;
            this.txt_NgaySinh.Location = new System.Drawing.Point(616, 58);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgaySinh.Properties.Appearance.Options.UseFont = true;
            this.txt_NgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgaySinh.Size = new System.Drawing.Size(173, 26);
            this.txt_NgaySinh.TabIndex = 5;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "TenKH", true));
            this.txt_TenKH.Location = new System.Drawing.Point(180, 121);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Properties.Appearance.Options.UseFont = true;
            this.txt_TenKH.Size = new System.Drawing.Size(261, 26);
            this.txt_TenKH.TabIndex = 3;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "MaKH", true));
            this.txt_MaKH.Enabled = false;
            this.txt_MaKH.Location = new System.Drawing.Point(180, 58);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.Properties.Appearance.Options.UseFont = true;
            this.txt_MaKH.Size = new System.Drawing.Size(100, 26);
            this.txt_MaKH.TabIndex = 1;
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
            this.groupBox2.Location = new System.Drawing.Point(1198, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(328, 309);
            this.groupBox2.TabIndex = 169;
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
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 756);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kHACHHANGGridControl);
            this.Name = "frmKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QL_TOURDLPMDataSet qL_TOURDLPMDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QL_TOURDLPMDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private QL_TOURDLPMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl kHACHHANGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txt_HinhAnh;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.DateEdit txt_NgaySinh;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private DevExpress.XtraEditors.TextEdit txt_MaKH;
        private System.Windows.Forms.Button Bn_File;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}