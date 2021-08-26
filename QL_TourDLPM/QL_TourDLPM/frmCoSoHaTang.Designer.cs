namespace QL_TourDLPM
{
    partial class frmCoSoHaTang
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
            System.Windows.Forms.Label maDVLabel;
            System.Windows.Forms.Label tenDVLabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label maKSLabel;
            System.Windows.Forms.Label tenKSLabel;
            System.Windows.Forms.Label giaLabel1;
            System.Windows.Forms.Label hinhAnhKSLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoSoHaTang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_GiaDV = new DevExpress.XtraEditors.TextEdit();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_TOURDLPMDataSet = new QL_TourDLPM.QL_TOURDLPMDataSet();
            this.txt_TenDV = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaDV = new DevExpress.XtraEditors.TextEdit();
            this.dICHVUTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.DICHVUTableAdapter();
            this.tableAdapterManager = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager();
            this.kHACHSANTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.KHACHSANTableAdapter();
            this.dICHVUGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.kHACHSANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHSANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bn_File = new System.Windows.Forms.Button();
            this.txt_HinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.txt_GiaKS = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenKS = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaKS = new DevExpress.XtraEditors.TextEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_KhachSan = new System.Windows.Forms.RadioButton();
            this.rd_DichVu = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            maDVLabel = new System.Windows.Forms.Label();
            tenDVLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            maKSLabel = new System.Windows.Forms.Label();
            tenKSLabel = new System.Windows.Forms.Label();
            giaLabel1 = new System.Windows.Forms.Label();
            hinhAnhKSLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaKS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKS.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // maDVLabel
            // 
            maDVLabel.AutoSize = true;
            maDVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maDVLabel.Location = new System.Drawing.Point(19, 67);
            maDVLabel.Name = "maDVLabel";
            maDVLabel.Size = new System.Drawing.Size(95, 20);
            maDVLabel.TabIndex = 0;
            maDVLabel.Text = "Mã dịch vụ:";
            // 
            // tenDVLabel
            // 
            tenDVLabel.AutoSize = true;
            tenDVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenDVLabel.Location = new System.Drawing.Point(19, 146);
            tenDVLabel.Name = "tenDVLabel";
            tenDVLabel.Size = new System.Drawing.Size(100, 20);
            tenDVLabel.TabIndex = 2;
            tenDVLabel.Text = "Tên dịch vụ:";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaLabel.Location = new System.Drawing.Point(19, 215);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(40, 20);
            giaLabel.TabIndex = 4;
            giaLabel.Text = "Giá:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(321, 215);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 20);
            label1.TabIndex = 6;
            label1.Text = "VNĐ";
            // 
            // maKSLabel
            // 
            maKSLabel.AutoSize = true;
            maKSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKSLabel.Location = new System.Drawing.Point(37, 45);
            maKSLabel.Name = "maKSLabel";
            maKSLabel.Size = new System.Drawing.Size(64, 20);
            maKSLabel.TabIndex = 0;
            maKSLabel.Text = "Mã KS:";
            // 
            // tenKSLabel
            // 
            tenKSLabel.AutoSize = true;
            tenKSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenKSLabel.Location = new System.Drawing.Point(37, 102);
            tenKSLabel.Name = "tenKSLabel";
            tenKSLabel.Size = new System.Drawing.Size(69, 20);
            tenKSLabel.TabIndex = 2;
            tenKSLabel.Text = "Tên KS:";
            // 
            // giaLabel1
            // 
            giaLabel1.AutoSize = true;
            giaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaLabel1.Location = new System.Drawing.Point(37, 230);
            giaLabel1.Name = "giaLabel1";
            giaLabel1.Size = new System.Drawing.Size(40, 20);
            giaLabel1.TabIndex = 4;
            giaLabel1.Text = "Giá:";
            // 
            // hinhAnhKSLabel
            // 
            hinhAnhKSLabel.AutoSize = true;
            hinhAnhKSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhAnhKSLabel.Location = new System.Drawing.Point(37, 168);
            hinhAnhKSLabel.Name = "hinhAnhKSLabel";
            hinhAnhKSLabel.Size = new System.Drawing.Size(81, 20);
            hinhAnhKSLabel.TabIndex = 6;
            hinhAnhKSLabel.Text = "Hình ảnh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(320, 230);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 20);
            label2.TabIndex = 8;
            label2.Text = "VNĐ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(giaLabel);
            this.groupBox1.Controls.Add(this.txt_GiaDV);
            this.groupBox1.Controls.Add(tenDVLabel);
            this.groupBox1.Controls.Add(this.txt_TenDV);
            this.groupBox1.Controls.Add(maDVLabel);
            this.groupBox1.Controls.Add(this.txt_MaDV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // txt_GiaDV
            // 
            this.txt_GiaDV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dICHVUBindingSource, "Gia", true));
            this.txt_GiaDV.Location = new System.Drawing.Point(165, 212);
            this.txt_GiaDV.Name = "txt_GiaDV";
            this.txt_GiaDV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaDV.Properties.Appearance.Options.UseFont = true;
            this.txt_GiaDV.Size = new System.Drawing.Size(131, 26);
            this.txt_GiaDV.TabIndex = 5;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // qL_TOURDLPMDataSet
            // 
            this.qL_TOURDLPMDataSet.DataSetName = "QL_TOURDLPMDataSet";
            this.qL_TOURDLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_TenDV
            // 
            this.txt_TenDV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dICHVUBindingSource, "TenDV", true));
            this.txt_TenDV.Location = new System.Drawing.Point(165, 143);
            this.txt_TenDV.Name = "txt_TenDV";
            this.txt_TenDV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDV.Properties.Appearance.Options.UseFont = true;
            this.txt_TenDV.Size = new System.Drawing.Size(251, 26);
            this.txt_TenDV.TabIndex = 3;
            // 
            // txt_MaDV
            // 
            this.txt_MaDV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dICHVUBindingSource, "MaDV", true));
            this.txt_MaDV.Enabled = false;
            this.txt_MaDV.Location = new System.Drawing.Point(165, 64);
            this.txt_MaDV.Name = "txt_MaDV";
            this.txt_MaDV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDV.Properties.Appearance.Options.UseFont = true;
            this.txt_MaDV.Size = new System.Drawing.Size(251, 26);
            this.txt_MaDV.TabIndex = 1;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHAULUCTableAdapter = null;
            this.tableAdapterManager.DATTOURTableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = this.dICHVUTableAdapter;
            this.tableAdapterManager.DIEMDENTableAdapter = null;
            this.tableAdapterManager.HUONGDANVIENTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHACHSANTableAdapter = this.kHACHSANTableAdapter;
            this.tableAdapterManager.LOAIPHUONGTIENTableAdapter = null;
            this.tableAdapterManager.MIENTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHUONGTIENTableAdapter = null;
            this.tableAdapterManager.SDDICHVUTableAdapter = null;
            this.tableAdapterManager.THANHTOANTableAdapter = null;
            this.tableAdapterManager.TOURTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHACHSANTableAdapter
            // 
            this.kHACHSANTableAdapter.ClearBeforeFill = true;
            // 
            // dICHVUGridControl
            // 
            this.dICHVUGridControl.DataSource = this.dICHVUBindingSource;
            this.dICHVUGridControl.Location = new System.Drawing.Point(25, 435);
            this.dICHVUGridControl.MainView = this.gridView1;
            this.dICHVUGridControl.Name = "dICHVUGridControl";
            this.dICHVUGridControl.Size = new System.Drawing.Size(703, 299);
            this.dICHVUGridControl.TabIndex = 2;
            this.dICHVUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dICHVUGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // kHACHSANBindingSource
            // 
            this.kHACHSANBindingSource.DataMember = "KHACHSAN";
            this.kHACHSANBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // kHACHSANGridControl
            // 
            this.kHACHSANGridControl.DataSource = this.kHACHSANBindingSource;
            this.kHACHSANGridControl.Location = new System.Drawing.Point(795, 435);
            this.kHACHSANGridControl.MainView = this.gridView2;
            this.kHACHSANGridControl.Name = "kHACHSANGridControl";
            this.kHACHSANGridControl.Size = new System.Drawing.Size(799, 299);
            this.kHACHSANGridControl.TabIndex = 3;
            this.kHACHSANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.kHACHSANGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.Bn_File);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(hinhAnhKSLabel);
            this.groupBox2.Controls.Add(this.txt_HinhAnh);
            this.groupBox2.Controls.Add(giaLabel1);
            this.groupBox2.Controls.Add(this.txt_GiaKS);
            this.groupBox2.Controls.Add(tenKSLabel);
            this.groupBox2.Controls.Add(this.txt_TenKS);
            this.groupBox2.Controls.Add(maKSLabel);
            this.groupBox2.Controls.Add(this.txt_MaKS);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(936, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 280);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách sạn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(432, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 183);
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // Bn_File
            // 
            this.Bn_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bn_File.Location = new System.Drawing.Point(353, 163);
            this.Bn_File.Name = "Bn_File";
            this.Bn_File.Size = new System.Drawing.Size(52, 31);
            this.Bn_File.TabIndex = 169;
            this.Bn_File.Text = "File";
            this.Bn_File.UseVisualStyleBackColor = true;
            this.Bn_File.Click += new System.EventHandler(this.Bn_File_Click);
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHSANBindingSource, "HinhAnhKS", true));
            this.txt_HinhAnh.Enabled = false;
            this.txt_HinhAnh.Location = new System.Drawing.Point(154, 165);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HinhAnh.Properties.Appearance.Options.UseFont = true;
            this.txt_HinhAnh.Size = new System.Drawing.Size(176, 26);
            this.txt_HinhAnh.TabIndex = 7;
            this.txt_HinhAnh.EditValueChanged += new System.EventHandler(this.hinhAnhKSTextEdit_EditValueChanged);
            this.txt_HinhAnh.TextChanged += new System.EventHandler(this.txt_HinhAnh_TextChanged);
            // 
            // txt_GiaKS
            // 
            this.txt_GiaKS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHSANBindingSource, "Gia", true));
            this.txt_GiaKS.Location = new System.Drawing.Point(153, 227);
            this.txt_GiaKS.Name = "txt_GiaKS";
            this.txt_GiaKS.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaKS.Properties.Appearance.Options.UseFont = true;
            this.txt_GiaKS.Size = new System.Drawing.Size(145, 26);
            this.txt_GiaKS.TabIndex = 5;
            // 
            // txt_TenKS
            // 
            this.txt_TenKS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHSANBindingSource, "TenKS", true));
            this.txt_TenKS.Location = new System.Drawing.Point(154, 99);
            this.txt_TenKS.Name = "txt_TenKS";
            this.txt_TenKS.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKS.Properties.Appearance.Options.UseFont = true;
            this.txt_TenKS.Size = new System.Drawing.Size(210, 26);
            this.txt_TenKS.TabIndex = 3;
            // 
            // txt_MaKS
            // 
            this.txt_MaKS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHSANBindingSource, "MaKS", true));
            this.txt_MaKS.Enabled = false;
            this.txt_MaKS.Location = new System.Drawing.Point(154, 42);
            this.txt_MaKS.Name = "txt_MaKS";
            this.txt_MaKS.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKS.Properties.Appearance.Options.UseFont = true;
            this.txt_MaKS.Size = new System.Drawing.Size(100, 26);
            this.txt_MaKS.TabIndex = 1;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(577, 117);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(328, 309);
            this.groupBox3.TabIndex = 170;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_KhachSan);
            this.groupBox4.Controls.Add(this.rd_DichVu);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(594, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 60);
            this.groupBox4.TabIndex = 171;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trên ";
            // 
            // rd_KhachSan
            // 
            this.rd_KhachSan.AutoSize = true;
            this.rd_KhachSan.Location = new System.Drawing.Point(170, 27);
            this.rd_KhachSan.Name = "rd_KhachSan";
            this.rd_KhachSan.Size = new System.Drawing.Size(109, 24);
            this.rd_KhachSan.TabIndex = 1;
            this.rd_KhachSan.TabStop = true;
            this.rd_KhachSan.Text = "Khách sạn";
            this.rd_KhachSan.UseVisualStyleBackColor = true;
            // 
            // rd_DichVu
            // 
            this.rd_DichVu.AutoSize = true;
            this.rd_DichVu.Location = new System.Drawing.Point(28, 27);
            this.rd_DichVu.Name = "rd_DichVu";
            this.rd_DichVu.Size = new System.Drawing.Size(87, 24);
            this.rd_DichVu.TabIndex = 0;
            this.rd_DichVu.TabStop = true;
            this.rd_DichVu.Text = "Dịch vụ";
            this.rd_DichVu.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCoSoHaTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 756);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.kHACHSANGridControl);
            this.Controls.Add(this.dICHVUGridControl);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCoSoHaTang";
            this.Text = "Cơ sở hạ tầng";
            this.Load += new System.EventHandler(this.frmCoSoHaTang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaKS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKS.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private QL_TOURDLPMDataSet qL_TOURDLPMDataSet;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private QL_TOURDLPMDataSetTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private QL_TOURDLPMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txt_GiaDV;
        private DevExpress.XtraEditors.TextEdit txt_TenDV;
        private DevExpress.XtraEditors.TextEdit txt_MaDV;
        private QL_TOURDLPMDataSetTableAdapters.KHACHSANTableAdapter kHACHSANTableAdapter;
        private DevExpress.XtraGrid.GridControl dICHVUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource kHACHSANBindingSource;
        private DevExpress.XtraGrid.GridControl kHACHSANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txt_HinhAnh;
        private DevExpress.XtraEditors.TextEdit txt_GiaKS;
        private DevExpress.XtraEditors.TextEdit txt_TenKS;
        private DevExpress.XtraEditors.TextEdit txt_MaKS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bn_File;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rd_KhachSan;
        private System.Windows.Forms.RadioButton rd_DichVu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}