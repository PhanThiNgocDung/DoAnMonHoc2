namespace QL_TourDLPM
{
    partial class frmSuDungDichVu
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
            System.Windows.Forms.Label tenKHLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label tenDVLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label thanhtienLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuDungDichVu));
            this.qL_TOURDLPMDataSet = new QL_TourDLPM.QL_TOURDLPMDataSet();
            this.kHACHDATTOURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHDATTOURTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.KHACHDATTOURTableAdapter();
            this.tableAdapterManager = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager();
            this.dICHVUTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.DICHVUTableAdapter();
            this.kHACHHANGTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.KHACHHANGTableAdapter();
            this.sDDICHVUTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.SDDICHVUTableAdapter();
            this.kHACHDATTOURGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_TenKH = new System.Windows.Forms.ComboBox();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_SDTKH = new System.Windows.Forms.TextBox();
            this.sDDICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bn_ThemDV = new System.Windows.Forms.Button();
            this.bn_XoaDV = new System.Windows.Forms.Button();
            this.txt_MaDatTour = new DevExpress.XtraEditors.TextEdit();
            this.bn_Luu = new System.Windows.Forms.Button();
            this.dATTOURDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATTOURDVTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.DATTOURDVTableAdapter();
            this.dATTOURDVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cb_TenDV = new System.Windows.Forms.ComboBox();
            this.dICHVUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SL = new DevExpress.XtraEditors.SpinEdit();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.lb_ThanhTien = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tenDVLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            thanhtienLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHDATTOURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHDATTOURGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDDICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaDatTour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTOURDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTOURDVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenKHLabel.Location = new System.Drawing.Point(16, 112);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(132, 20);
            tenKHLabel.TabIndex = 9;
            tenKHLabel.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(16, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(201, 20);
            label1.TabIndex = 8;
            label1.Text = "Số điện thoại khách hàng:";
            // 
            // tenDVLabel
            // 
            tenDVLabel.AutoSize = true;
            tenDVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenDVLabel.Location = new System.Drawing.Point(40, 116);
            tenDVLabel.Name = "tenDVLabel";
            tenDVLabel.Size = new System.Drawing.Size(100, 20);
            tenDVLabel.TabIndex = 205;
            tenDVLabel.Text = "Tên dịch vụ:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongLabel.Location = new System.Drawing.Point(40, 190);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(79, 20);
            soLuongLabel.TabIndex = 207;
            soLuongLabel.Text = "Số lượng:";
            // 
            // thanhtienLabel
            // 
            thanhtienLabel.AutoSize = true;
            thanhtienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            thanhtienLabel.Location = new System.Drawing.Point(462, 249);
            thanhtienLabel.Name = "thanhtienLabel";
            thanhtienLabel.Size = new System.Drawing.Size(111, 25);
            thanhtienLabel.TabIndex = 208;
            thanhtienLabel.Text = "Thành tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(42, 249);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 25);
            label3.TabIndex = 210;
            label3.Text = "Đơn giá: ";
            // 
            // qL_TOURDLPMDataSet
            // 
            this.qL_TOURDLPMDataSet.DataSetName = "QL_TOURDLPMDataSet";
            this.qL_TOURDLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHDATTOURBindingSource
            // 
            this.kHACHDATTOURBindingSource.DataMember = "KHACHDATTOUR";
            this.kHACHDATTOURBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // kHACHDATTOURTableAdapter
            // 
            this.kHACHDATTOURTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHAULUCTableAdapter = null;
            this.tableAdapterManager.DATTOURTableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = this.dICHVUTableAdapter;
            this.tableAdapterManager.DIEMDENTableAdapter = null;
            this.tableAdapterManager.HUONGDANVIENTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.KHACHSANTableAdapter = null;
            this.tableAdapterManager.LOAIPHUONGTIENTableAdapter = null;
            this.tableAdapterManager.MIENTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHUONGTIENTableAdapter = null;
            this.tableAdapterManager.SDDICHVUTableAdapter = this.sDDICHVUTableAdapter;
            this.tableAdapterManager.THANHTOANTableAdapter = null;
            this.tableAdapterManager.TOURTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // sDDICHVUTableAdapter
            // 
            this.sDDICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // kHACHDATTOURGridControl
            // 
            this.kHACHDATTOURGridControl.DataSource = this.kHACHDATTOURBindingSource;
            this.kHACHDATTOURGridControl.Location = new System.Drawing.Point(33, 320);
            this.kHACHDATTOURGridControl.MainView = this.gridView1;
            this.kHACHDATTOURGridControl.Name = "kHACHDATTOURGridControl";
            this.kHACHDATTOURGridControl.Size = new System.Drawing.Size(988, 336);
            this.kHACHDATTOURGridControl.TabIndex = 2;
            this.kHACHDATTOURGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.kHACHDATTOURGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_TenKH);
            this.groupBox1.Controls.Add(tenKHLabel);
            this.groupBox1.Controls.Add(this.txt_SDTKH);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1038, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 182);
            this.groupBox1.TabIndex = 196;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cb_TenKH
            // 
            this.cb_TenKH.DataSource = this.kHACHHANGBindingSource;
            this.cb_TenKH.DisplayMember = "TenKH";
            this.cb_TenKH.Enabled = false;
            this.cb_TenKH.FormattingEnabled = true;
            this.cb_TenKH.Location = new System.Drawing.Point(274, 109);
            this.cb_TenKH.Name = "cb_TenKH";
            this.cb_TenKH.Size = new System.Drawing.Size(216, 28);
            this.cb_TenKH.TabIndex = 10;
            this.cb_TenKH.ValueMember = "MaKH";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // txt_SDTKH
            // 
            this.txt_SDTKH.Location = new System.Drawing.Point(274, 34);
            this.txt_SDTKH.Name = "txt_SDTKH";
            this.txt_SDTKH.Size = new System.Drawing.Size(216, 27);
            this.txt_SDTKH.TabIndex = 9;
            this.txt_SDTKH.TextChanged += new System.EventHandler(this.txt_SDTKH_TextChanged);
            // 
            // sDDICHVUBindingSource
            // 
            this.sDDICHVUBindingSource.DataMember = "SDDICHVU";
            this.sDDICHVUBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.qL_TOURDLPMDataSet;
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
            // bn_ThemDV
            // 
            this.bn_ThemDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bn_ThemDV.ImageIndex = 1;
            this.bn_ThemDV.ImageList = this.imageList1;
            this.bn_ThemDV.Location = new System.Drawing.Point(478, 99);
            this.bn_ThemDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_ThemDV.Name = "bn_ThemDV";
            this.bn_ThemDV.Size = new System.Drawing.Size(105, 94);
            this.bn_ThemDV.TabIndex = 200;
            this.bn_ThemDV.Text = "Thêm ";
            this.bn_ThemDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bn_ThemDV.UseVisualStyleBackColor = true;
            this.bn_ThemDV.Click += new System.EventHandler(this.button9_Click);
            // 
            // bn_XoaDV
            // 
            this.bn_XoaDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bn_XoaDV.ImageIndex = 2;
            this.bn_XoaDV.ImageList = this.imageList1;
            this.bn_XoaDV.Location = new System.Drawing.Point(695, 99);
            this.bn_XoaDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_XoaDV.Name = "bn_XoaDV";
            this.bn_XoaDV.Size = new System.Drawing.Size(105, 94);
            this.bn_XoaDV.TabIndex = 202;
            this.bn_XoaDV.Text = "Xóa ";
            this.bn_XoaDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bn_XoaDV.UseVisualStyleBackColor = true;
            // 
            // txt_MaDatTour
            // 
            this.txt_MaDatTour.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHDATTOURBindingSource, "MaDatTour", true));
            this.txt_MaDatTour.Location = new System.Drawing.Point(957, 134);
            this.txt_MaDatTour.Name = "txt_MaDatTour";
            this.txt_MaDatTour.Size = new System.Drawing.Size(10, 22);
            this.txt_MaDatTour.TabIndex = 203;
            this.txt_MaDatTour.EditValueChanged += new System.EventHandler(this.txt_MaDatTour_EditValueChanged);
            // 
            // bn_Luu
            // 
            this.bn_Luu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bn_Luu.ImageIndex = 0;
            this.bn_Luu.ImageList = this.imageList1;
            this.bn_Luu.Location = new System.Drawing.Point(903, 99);
            this.bn_Luu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_Luu.Name = "bn_Luu";
            this.bn_Luu.Size = new System.Drawing.Size(105, 94);
            this.bn_Luu.TabIndex = 204;
            this.bn_Luu.Text = "Lưu";
            this.bn_Luu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bn_Luu.UseVisualStyleBackColor = true;
            this.bn_Luu.Click += new System.EventHandler(this.button1_Click);
            // 
            // dATTOURDVBindingSource
            // 
            this.dATTOURDVBindingSource.DataMember = "DATTOURDV";
            this.dATTOURDVBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // dATTOURDVTableAdapter
            // 
            this.dATTOURDVTableAdapter.ClearBeforeFill = true;
            // 
            // dATTOURDVGridControl
            // 
            this.dATTOURDVGridControl.DataSource = this.dATTOURDVBindingSource;
            this.dATTOURDVGridControl.Location = new System.Drawing.Point(1038, 366);
            this.dATTOURDVGridControl.MainView = this.gridView2;
            this.dATTOURDVGridControl.Name = "dATTOURDVGridControl";
            this.dATTOURDVGridControl.Size = new System.Drawing.Size(551, 252);
            this.dATTOURDVGridControl.TabIndex = 205;
            this.dATTOURDVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dATTOURDVGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // cb_TenDV
            // 
            this.cb_TenDV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dATTOURDVBindingSource, "TenDV", true));
            this.cb_TenDV.DataSource = this.dICHVUBindingSource1;
            this.cb_TenDV.DisplayMember = "TenDV";
            this.cb_TenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenDV.FormattingEnabled = true;
            this.cb_TenDV.Location = new System.Drawing.Point(166, 113);
            this.cb_TenDV.Name = "cb_TenDV";
            this.cb_TenDV.Size = new System.Drawing.Size(205, 28);
            this.cb_TenDV.TabIndex = 206;
            this.cb_TenDV.ValueMember = "MaDV";
            this.cb_TenDV.TextChanged += new System.EventHandler(this.tenDVComboBox_TextChanged);
            // 
            // dICHVUBindingSource1
            // 
            this.dICHVUBindingSource1.DataMember = "DICHVU";
            this.dICHVUBindingSource1.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(522, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 51);
            this.label2.TabIndex = 207;
            this.label2.Text = "Thông Tin Sử Dụng Dịch Vụ";
            // 
            // txt_SL
            // 
            this.txt_SL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dATTOURDVBindingSource, "SoLuong", true));
            this.txt_SL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_SL.Location = new System.Drawing.Point(166, 187);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Properties.Appearance.Options.UseFont = true;
            this.txt_SL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_SL.Size = new System.Drawing.Size(205, 26);
            this.txt_SL.TabIndex = 208;
            this.txt_SL.TextChanged += new System.EventHandler(this.soLuongSpinEdit_TextChanged);
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonGia.Location = new System.Drawing.Point(177, 249);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(70, 25);
            this.lb_DonGia.TabIndex = 211;
            this.lb_DonGia.Text = "0 VNĐ";
            // 
            // lb_ThanhTien
            // 
            this.lb_ThanhTien.AutoSize = true;
            this.lb_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhTien.Location = new System.Drawing.Point(653, 249);
            this.lb_ThanhTien.Name = "lb_ThanhTien";
            this.lb_ThanhTien.Size = new System.Drawing.Size(70, 25);
            this.lb_ThanhTien.TabIndex = 212;
            this.lb_ThanhTien.Text = "0 VNĐ";
            // 
            // frmSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 692);
            this.Controls.Add(this.lb_ThanhTien);
            this.Controls.Add(this.lb_DonGia);
            this.Controls.Add(label3);
            this.Controls.Add(thanhtienLabel);
            this.Controls.Add(soLuongLabel);
            this.Controls.Add(this.txt_SL);
            this.Controls.Add(this.label2);
            this.Controls.Add(tenDVLabel);
            this.Controls.Add(this.cb_TenDV);
            this.Controls.Add(this.dATTOURDVGridControl);
            this.Controls.Add(this.bn_Luu);
            this.Controls.Add(this.txt_MaDatTour);
            this.Controls.Add(this.bn_XoaDV);
            this.Controls.Add(this.bn_ThemDV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kHACHDATTOURGridControl);
            this.Name = "frmSuDungDichVu";
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.frmSuDungDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHDATTOURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHDATTOURGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDDICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaDatTour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTOURDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTOURDVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_TOURDLPMDataSet qL_TOURDLPMDataSet;
        private System.Windows.Forms.BindingSource kHACHDATTOURBindingSource;
        private QL_TOURDLPMDataSetTableAdapters.KHACHDATTOURTableAdapter kHACHDATTOURTableAdapter;
        private QL_TOURDLPMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl kHACHDATTOURGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_TenKH;
        private System.Windows.Forms.TextBox txt_SDTKH;
        private QL_TOURDLPMDataSetTableAdapters.SDDICHVUTableAdapter sDDICHVUTableAdapter;
        private System.Windows.Forms.BindingSource sDDICHVUBindingSource;
        private QL_TOURDLPMDataSetTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bn_ThemDV;
        private System.Windows.Forms.Button bn_XoaDV;
        private QL_TOURDLPMDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private DevExpress.XtraEditors.TextEdit txt_MaDatTour;
        private System.Windows.Forms.Button bn_Luu;
        private System.Windows.Forms.BindingSource dATTOURDVBindingSource;
        private QL_TOURDLPMDataSetTableAdapters.DATTOURDVTableAdapter dATTOURDVTableAdapter;
        private DevExpress.XtraGrid.GridControl dATTOURDVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ComboBox cb_TenDV;
        private System.Windows.Forms.BindingSource dICHVUBindingSource1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SpinEdit txt_SL;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.Label lb_ThanhTien;
    }
}