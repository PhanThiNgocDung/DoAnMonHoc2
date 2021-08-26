namespace QL_TourDLPM
{
    partial class frmThongKeTour
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
            System.Windows.Forms.Label maDatTourLabel;
            System.Windows.Forms.Label tenTourLabel;
            System.Windows.Forms.Label tenKHLabel;
            System.Windows.Forms.Label ngayBDTourLabel;
            System.Windows.Forms.Label ngayKTTourLabel;
            System.Windows.Forms.Label sLNguoiLonLabel;
            System.Windows.Forms.Label sNTreEmLabel;
            System.Windows.Forms.Label thanhTienLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeTour));
            this.qL_TOURDLPMDataSet = new QL_TourDLPM.QL_TOURDLPMDataSet();
            this.tHONGKEDATTOURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHONGKEDATTOURTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.THONGKEDATTOURTableAdapter();
            this.tableAdapterManager = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager();
            this.tHONGKEDATTOURGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblDen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.denNgay = new DevExpress.XtraEditors.DateEdit();
            this.tuNgay = new DevExpress.XtraEditors.DateEdit();
            this.rdThangNam = new System.Windows.Forms.RadioButton();
            this.rdNgay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thanhTienLabel2 = new System.Windows.Forms.Label();
            this.sNTreEmSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sLNguoiLonSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ngayKTTourDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ngayBDTourDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenTourTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maDatTourTextEdit = new DevExpress.XtraEditors.TextEdit();
            maDatTourLabel = new System.Windows.Forms.Label();
            tenTourLabel = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            ngayBDTourLabel = new System.Windows.Forms.Label();
            ngayKTTourLabel = new System.Windows.Forms.Label();
            sLNguoiLonLabel = new System.Windows.Forms.Label();
            sNTreEmLabel = new System.Windows.Forms.Label();
            thanhTienLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGKEDATTOURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGKEDATTOURGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.denNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuNgay.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sNTreEmSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLNguoiLonSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKTTourDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKTTourDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBDTourDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBDTourDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTourTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maDatTourTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maDatTourLabel
            // 
            maDatTourLabel.AutoSize = true;
            maDatTourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maDatTourLabel.Location = new System.Drawing.Point(24, 50);
            maDatTourLabel.Name = "maDatTourLabel";
            maDatTourLabel.Size = new System.Drawing.Size(99, 20);
            maDatTourLabel.TabIndex = 0;
            maDatTourLabel.Text = "Mã đặt tour:";
            // 
            // tenTourLabel
            // 
            tenTourLabel.AutoSize = true;
            tenTourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenTourLabel.Location = new System.Drawing.Point(24, 86);
            tenTourLabel.Name = "tenTourLabel";
            tenTourLabel.Size = new System.Drawing.Size(76, 20);
            tenTourLabel.TabIndex = 2;
            tenTourLabel.Text = "Tên tour:";
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenKHLabel.Location = new System.Drawing.Point(24, 129);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(132, 20);
            tenKHLabel.TabIndex = 4;
            tenKHLabel.Text = "Tên khách hàng:";
            // 
            // ngayBDTourLabel
            // 
            ngayBDTourLabel.AutoSize = true;
            ngayBDTourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayBDTourLabel.Location = new System.Drawing.Point(450, 51);
            ngayBDTourLabel.Name = "ngayBDTourLabel";
            ngayBDTourLabel.Size = new System.Drawing.Size(146, 20);
            ngayBDTourLabel.TabIndex = 6;
            ngayBDTourLabel.Text = "Ngày bắt đầu tour:";
            // 
            // ngayKTTourLabel
            // 
            ngayKTTourLabel.AutoSize = true;
            ngayKTTourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayKTTourLabel.Location = new System.Drawing.Point(450, 86);
            ngayKTTourLabel.Name = "ngayKTTourLabel";
            ngayKTTourLabel.Size = new System.Drawing.Size(150, 20);
            ngayKTTourLabel.TabIndex = 8;
            ngayKTTourLabel.Text = "Ngày kết thúc tour:";
            // 
            // sLNguoiLonLabel
            // 
            sLNguoiLonLabel.AutoSize = true;
            sLNguoiLonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sLNguoiLonLabel.Location = new System.Drawing.Point(450, 126);
            sLNguoiLonLabel.Name = "sLNguoiLonLabel";
            sLNguoiLonLabel.Size = new System.Drawing.Size(151, 20);
            sLNguoiLonLabel.TabIndex = 10;
            sLNguoiLonLabel.Text = "Số lượng người lớn:";
            // 
            // sNTreEmLabel
            // 
            sNTreEmLabel.AutoSize = true;
            sNTreEmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sNTreEmLabel.Location = new System.Drawing.Point(779, 126);
            sNTreEmLabel.Name = "sNTreEmLabel";
            sNTreEmLabel.Size = new System.Drawing.Size(132, 20);
            sNTreEmLabel.TabIndex = 12;
            sNTreEmLabel.Text = "Số lượng trẻ em:";
            // 
            // thanhTienLabel1
            // 
            thanhTienLabel1.AutoSize = true;
            thanhTienLabel1.Location = new System.Drawing.Point(1119, 126);
            thanhTienLabel1.Name = "thanhTienLabel1";
            thanhTienLabel1.Size = new System.Drawing.Size(92, 20);
            thanhTienLabel1.TabIndex = 16;
            thanhTienLabel1.Text = "Thành tiền:";
            // 
            // qL_TOURDLPMDataSet
            // 
            this.qL_TOURDLPMDataSet.DataSetName = "QL_TOURDLPMDataSet";
            this.qL_TOURDLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHONGKEDATTOURBindingSource
            // 
            this.tHONGKEDATTOURBindingSource.DataMember = "THONGKEDATTOUR";
            this.tHONGKEDATTOURBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // tHONGKEDATTOURTableAdapter
            // 
            this.tHONGKEDATTOURTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHAULUCTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DATTOURTableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.DIEMDENTableAdapter = null;
            this.tableAdapterManager.HUONGDANVIENTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
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
            // tHONGKEDATTOURGridControl
            // 
            this.tHONGKEDATTOURGridControl.DataSource = this.tHONGKEDATTOURBindingSource;
            this.tHONGKEDATTOURGridControl.Location = new System.Drawing.Point(30, 380);
            this.tHONGKEDATTOURGridControl.MainView = this.gridView1;
            this.tHONGKEDATTOURGridControl.Name = "tHONGKEDATTOURGridControl";
            this.tHONGKEDATTOURGridControl.Size = new System.Drawing.Size(1498, 294);
            this.tHONGKEDATTOURGridControl.TabIndex = 2;
            this.tHONGKEDATTOURGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.tHONGKEDATTOURGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblDen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.denNgay);
            this.groupBox2.Controls.Add(this.tuNgay);
            this.groupBox2.Controls.Add(this.rdThangNam);
            this.groupBox2.Controls.Add(this.rdNgay);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(243, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1000, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(880, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 112);
            this.button2.TabIndex = 5;
            this.button2.Text = "Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(753, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 111);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thống Kê";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            this.imageList1.Images.SetKeyName(2, "trash.png");
            this.imageList1.Images.SetKeyName(3, "exit.png");
            this.imageList1.Images.SetKeyName(4, "payment-method.png");
            this.imageList1.Images.SetKeyName(5, "statistics (1).png");
            this.imageList1.Images.SetKeyName(6, "statistics (2).png");
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen.Location = new System.Drawing.Point(430, 76);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(39, 20);
            this.lblDen.TabIndex = 5;
            this.lblDen.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ";
            // 
            // denNgay
            // 
            this.denNgay.EditValue = null;
            this.denNgay.Location = new System.Drawing.Point(477, 72);
            this.denNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.denNgay.Name = "denNgay";
            this.denNgay.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denNgay.Properties.Appearance.Options.UseFont = true;
            this.denNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denNgay.Size = new System.Drawing.Size(220, 26);
            this.denNgay.TabIndex = 3;
            // 
            // tuNgay
            // 
            this.tuNgay.EditValue = null;
            this.tuNgay.Location = new System.Drawing.Point(120, 72);
            this.tuNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuNgay.Properties.Appearance.Options.UseFont = true;
            this.tuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tuNgay.Size = new System.Drawing.Size(220, 26);
            this.tuNgay.TabIndex = 2;
            // 
            // rdThangNam
            // 
            this.rdThangNam.AutoSize = true;
            this.rdThangNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThangNam.Location = new System.Drawing.Point(209, 22);
            this.rdThangNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdThangNam.Name = "rdThangNam";
            this.rdThangNam.Size = new System.Drawing.Size(116, 24);
            this.rdThangNam.TabIndex = 1;
            this.rdThangNam.TabStop = true;
            this.rdThangNam.Text = "Tháng/Năm";
            this.rdThangNam.UseVisualStyleBackColor = true;
            this.rdThangNam.CheckedChanged += new System.EventHandler(this.rdThangNam_CheckedChanged);
            // 
            // rdNgay
            // 
            this.rdNgay.AutoSize = true;
            this.rdNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNgay.Location = new System.Drawing.Point(85, 21);
            this.rdNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdNgay.Name = "rdNgay";
            this.rdNgay.Size = new System.Drawing.Size(68, 24);
            this.rdNgay.TabIndex = 0;
            this.rdNgay.TabStop = true;
            this.rdNgay.Text = "Ngày";
            this.rdNgay.UseVisualStyleBackColor = true;
            this.rdNgay.CheckedChanged += new System.EventHandler(this.rdNgay_CheckedChanged);
            this.rdNgay.Leave += new System.EventHandler(this.rdNgay_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(thanhTienLabel1);
            this.groupBox1.Controls.Add(this.thanhTienLabel2);
            this.groupBox1.Controls.Add(sNTreEmLabel);
            this.groupBox1.Controls.Add(this.sNTreEmSpinEdit);
            this.groupBox1.Controls.Add(sLNguoiLonLabel);
            this.groupBox1.Controls.Add(this.sLNguoiLonSpinEdit);
            this.groupBox1.Controls.Add(ngayKTTourLabel);
            this.groupBox1.Controls.Add(this.ngayKTTourDateEdit);
            this.groupBox1.Controls.Add(ngayBDTourLabel);
            this.groupBox1.Controls.Add(this.ngayBDTourDateEdit);
            this.groupBox1.Controls.Add(tenKHLabel);
            this.groupBox1.Controls.Add(this.tenKHTextEdit);
            this.groupBox1.Controls.Add(tenTourLabel);
            this.groupBox1.Controls.Add(this.tenTourTextEdit);
            this.groupBox1.Controls.Add(maDatTourLabel);
            this.groupBox1.Controls.Add(this.maDatTourTextEdit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(85, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1377, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // thanhTienLabel2
            // 
            this.thanhTienLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHONGKEDATTOURBindingSource, "ThanhTien", true));
            this.thanhTienLabel2.Enabled = false;
            this.thanhTienLabel2.Location = new System.Drawing.Point(1235, 123);
            this.thanhTienLabel2.Name = "thanhTienLabel2";
            this.thanhTienLabel2.Size = new System.Drawing.Size(100, 23);
            this.thanhTienLabel2.TabIndex = 17;
            this.thanhTienLabel2.Text = "label2";
            // 
            // sNTreEmSpinEdit
            // 
            this.sNTreEmSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHONGKEDATTOURBindingSource, "SNTreEm", true));
            this.sNTreEmSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sNTreEmSpinEdit.Enabled = false;
            this.sNTreEmSpinEdit.Location = new System.Drawing.Point(930, 126);
            this.sNTreEmSpinEdit.Name = "sNTreEmSpinEdit";
            this.sNTreEmSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNTreEmSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sNTreEmSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sNTreEmSpinEdit.Size = new System.Drawing.Size(100, 26);
            this.sNTreEmSpinEdit.TabIndex = 13;
            // 
            // sLNguoiLonSpinEdit
            // 
            this.sLNguoiLonSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHONGKEDATTOURBindingSource, "SLNguoiLon", true));
            this.sLNguoiLonSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sLNguoiLonSpinEdit.Enabled = false;
            this.sLNguoiLonSpinEdit.Location = new System.Drawing.Point(659, 126);
            this.sLNguoiLonSpinEdit.Name = "sLNguoiLonSpinEdit";
            this.sLNguoiLonSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLNguoiLonSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sLNguoiLonSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sLNguoiLonSpinEdit.Size = new System.Drawing.Size(100, 26);
            this.sLNguoiLonSpinEdit.TabIndex = 11;
            // 
            // ngayKTTourDateEdit
            // 
            this.ngayKTTourDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHONGKEDATTOURBindingSource, "NgayKTTour", true));
            this.ngayKTTourDateEdit.EditValue = null;
            this.ngayKTTourDateEdit.Enabled = false;
            this.ngayKTTourDateEdit.Location = new System.Drawing.Point(659, 83);
            this.ngayKTTourDateEdit.Name = "ngayKTTourDateEdit";
            this.ngayKTTourDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayKTTourDateEdit.Properties.Appearance.Options.UseFont = true;
            this.ngayKTTourDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKTTourDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKTTourDateEdit.Size = new System.Drawing.Size(370, 26);
            this.ngayKTTourDateEdit.TabIndex = 9;
            // 
            // ngayBDTourDateEdit
            // 
            this.ngayBDTourDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHONGKEDATTOURBindingSource, "NgayBDTour", true));
            this.ngayBDTourDateEdit.EditValue = null;
            this.ngayBDTourDateEdit.Enabled = false;
            this.ngayBDTourDateEdit.Location = new System.Drawing.Point(659, 44);
            this.ngayBDTourDateEdit.Name = "ngayBDTourDateEdit";
            this.ngayBDTourDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayBDTourDateEdit.Properties.Appearance.Options.UseFont = true;
            this.ngayBDTourDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBDTourDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBDTourDateEdit.Size = new System.Drawing.Size(370, 26);
            this.ngayBDTourDateEdit.TabIndex = 7;
            // 
            // tenKHTextEdit
            // 
            this.tenKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHONGKEDATTOURBindingSource, "TenKH", true));
            this.tenKHTextEdit.Enabled = false;
            this.tenKHTextEdit.Location = new System.Drawing.Point(202, 123);
            this.tenKHTextEdit.Name = "tenKHTextEdit";
            this.tenKHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tenKHTextEdit.Size = new System.Drawing.Size(205, 26);
            this.tenKHTextEdit.TabIndex = 5;
            // 
            // tenTourTextEdit
            // 
            this.tenTourTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHONGKEDATTOURBindingSource, "TenTour", true));
            this.tenTourTextEdit.Enabled = false;
            this.tenTourTextEdit.Location = new System.Drawing.Point(202, 83);
            this.tenTourTextEdit.Name = "tenTourTextEdit";
            this.tenTourTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTourTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tenTourTextEdit.Size = new System.Drawing.Size(205, 26);
            this.tenTourTextEdit.TabIndex = 3;
            // 
            // maDatTourTextEdit
            // 
            this.maDatTourTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHONGKEDATTOURBindingSource, "MaDatTour", true));
            this.maDatTourTextEdit.Enabled = false;
            this.maDatTourTextEdit.Location = new System.Drawing.Point(202, 45);
            this.maDatTourTextEdit.Name = "maDatTourTextEdit";
            this.maDatTourTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDatTourTextEdit.Properties.Appearance.Options.UseFont = true;
            this.maDatTourTextEdit.Size = new System.Drawing.Size(100, 26);
            this.maDatTourTextEdit.TabIndex = 1;
            // 
            // frmThongKeTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 756);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tHONGKEDATTOURGridControl);
            this.Name = "frmThongKeTour";
            this.Text = "frmThongKeTour";
            this.Load += new System.EventHandler(this.frmThongKeTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGKEDATTOURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGKEDATTOURGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.denNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuNgay.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sNTreEmSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLNguoiLonSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKTTourDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKTTourDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBDTourDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBDTourDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTourTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maDatTourTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QL_TOURDLPMDataSet qL_TOURDLPMDataSet;
        private System.Windows.Forms.BindingSource tHONGKEDATTOURBindingSource;
        private QL_TOURDLPMDataSetTableAdapters.THONGKEDATTOURTableAdapter tHONGKEDATTOURTableAdapter;
        private QL_TOURDLPMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl tHONGKEDATTOURGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit denNgay;
        private DevExpress.XtraEditors.DateEdit tuNgay;
        private System.Windows.Forms.RadioButton rdThangNam;
        private System.Windows.Forms.RadioButton rdNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label thanhTienLabel2;
        private DevExpress.XtraEditors.SpinEdit sNTreEmSpinEdit;
        private DevExpress.XtraEditors.SpinEdit sLNguoiLonSpinEdit;
        private DevExpress.XtraEditors.DateEdit ngayKTTourDateEdit;
        private DevExpress.XtraEditors.DateEdit ngayBDTourDateEdit;
        private DevExpress.XtraEditors.TextEdit tenKHTextEdit;
        private DevExpress.XtraEditors.TextEdit tenTourTextEdit;
        private DevExpress.XtraEditors.TextEdit maDatTourTextEdit;
        private System.Windows.Forms.ImageList imageList1;

    }
}