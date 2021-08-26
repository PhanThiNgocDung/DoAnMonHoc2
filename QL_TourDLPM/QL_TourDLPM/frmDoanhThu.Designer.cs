namespace QL_TourDLPM
{
    partial class frmDoanhThu
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
            System.Windows.Forms.Label maThanhToanLabel;
            System.Windows.Forms.Label maDatTourLabel;
            System.Windows.Forms.Label ngayThanhToanLabel;
            System.Windows.Forms.Label thanhTienLabel;
            System.Windows.Forms.Label hinhThucThanhToanLabel;
            System.Windows.Forms.Label tienConLaiLabel;
            System.Windows.Forms.Label tienThanhToanLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.qL_TOURDLPMDataSet = new QL_TourDLPM.QL_TOURDLPMDataSet();
            this.tHANHTOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHANHTOANTableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.THANHTOANTableAdapter();
            this.tableAdapterManager = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager();
            this.tHANHTOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_TongDoanhThu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            this.tienThanhToanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tienConLaiLabel1 = new System.Windows.Forms.Label();
            this.hinhThucThanhToanComboBox = new System.Windows.Forms.ComboBox();
            this.thanhTienLabel1 = new System.Windows.Forms.Label();
            this.ngayThanhToanDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.maDatTourTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maThanhToanTextEdit = new DevExpress.XtraEditors.TextEdit();
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
            maThanhToanLabel = new System.Windows.Forms.Label();
            maDatTourLabel = new System.Windows.Forms.Label();
            ngayThanhToanLabel = new System.Windows.Forms.Label();
            thanhTienLabel = new System.Windows.Forms.Label();
            hinhThucThanhToanLabel = new System.Windows.Forms.Label();
            tienConLaiLabel = new System.Windows.Forms.Label();
            tienThanhToanLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHTOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHTOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tienThanhToanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThanhToanDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThanhToanDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maDatTourTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maThanhToanTextEdit.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.denNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maThanhToanLabel
            // 
            maThanhToanLabel.AutoSize = true;
            maThanhToanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maThanhToanLabel.Location = new System.Drawing.Point(32, 47);
            maThanhToanLabel.Name = "maThanhToanLabel";
            maThanhToanLabel.Size = new System.Drawing.Size(120, 20);
            maThanhToanLabel.TabIndex = 0;
            maThanhToanLabel.Text = "Mã thanh toán:";
            // 
            // maDatTourLabel
            // 
            maDatTourLabel.AutoSize = true;
            maDatTourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maDatTourLabel.Location = new System.Drawing.Point(32, 108);
            maDatTourLabel.Name = "maDatTourLabel";
            maDatTourLabel.Size = new System.Drawing.Size(99, 20);
            maDatTourLabel.TabIndex = 2;
            maDatTourLabel.Text = "Mã đặt tour:";
            // 
            // ngayThanhToanLabel
            // 
            ngayThanhToanLabel.AutoSize = true;
            ngayThanhToanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayThanhToanLabel.Location = new System.Drawing.Point(32, 162);
            ngayThanhToanLabel.Name = "ngayThanhToanLabel";
            ngayThanhToanLabel.Size = new System.Drawing.Size(135, 20);
            ngayThanhToanLabel.TabIndex = 4;
            ngayThanhToanLabel.Text = "Ngày thanh toán:";
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.AutoSize = true;
            thanhTienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            thanhTienLabel.Location = new System.Drawing.Point(428, 162);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new System.Drawing.Size(87, 20);
            thanhTienLabel.TabIndex = 6;
            thanhTienLabel.Text = "Thành tiền";
            // 
            // hinhThucThanhToanLabel
            // 
            hinhThucThanhToanLabel.AutoSize = true;
            hinhThucThanhToanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhThucThanhToanLabel.Location = new System.Drawing.Point(428, 40);
            hinhThucThanhToanLabel.Name = "hinhThucThanhToanLabel";
            hinhThucThanhToanLabel.Size = new System.Drawing.Size(169, 20);
            hinhThucThanhToanLabel.TabIndex = 8;
            hinhThucThanhToanLabel.Text = "Hình thức thanh toán:";
            // 
            // tienConLaiLabel
            // 
            tienConLaiLabel.AutoSize = true;
            tienConLaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tienConLaiLabel.Location = new System.Drawing.Point(871, 50);
            tienConLaiLabel.Name = "tienConLaiLabel";
            tienConLaiLabel.Size = new System.Drawing.Size(100, 20);
            tienConLaiLabel.TabIndex = 10;
            tienConLaiLabel.Text = "Tiền còn lại:";
            // 
            // tienThanhToanLabel
            // 
            tienThanhToanLabel.AutoSize = true;
            tienThanhToanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tienThanhToanLabel.Location = new System.Drawing.Point(428, 108);
            tienThanhToanLabel.Name = "tienThanhToanLabel";
            tienThanhToanLabel.Size = new System.Drawing.Size(129, 20);
            tienThanhToanLabel.TabIndex = 12;
            tienThanhToanLabel.Text = "Tiền thanh toán:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ghiChuLabel.Location = new System.Drawing.Point(871, 114);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(72, 20);
            ghiChuLabel.TabIndex = 14;
            ghiChuLabel.Text = "Ghi chú:";
            // 
            // qL_TOURDLPMDataSet
            // 
            this.qL_TOURDLPMDataSet.DataSetName = "QL_TOURDLPMDataSet";
            this.qL_TOURDLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHANHTOANBindingSource
            // 
            this.tHANHTOANBindingSource.DataMember = "THANHTOAN";
            this.tHANHTOANBindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // tHANHTOANTableAdapter
            // 
            this.tHANHTOANTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHUONGTIENTableAdapter = null;
            this.tableAdapterManager.SDDICHVUTableAdapter = null;
            this.tableAdapterManager.THANHTOANTableAdapter = this.tHANHTOANTableAdapter;
            this.tableAdapterManager.TOURTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tHANHTOANGridControl
            // 
            this.tHANHTOANGridControl.DataSource = this.tHANHTOANBindingSource;
            this.tHANHTOANGridControl.Location = new System.Drawing.Point(21, 461);
            this.tHANHTOANGridControl.MainView = this.gridView1;
            this.tHANHTOANGridControl.Name = "tHANHTOANGridControl";
            this.tHANHTOANGridControl.Size = new System.Drawing.Size(1596, 339);
            this.tHANHTOANGridControl.TabIndex = 1;
            this.tHANHTOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.tHANHTOANGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_TongDoanhThu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(ghiChuLabel);
            this.groupBox1.Controls.Add(this.ghiChuTextBox);
            this.groupBox1.Controls.Add(tienThanhToanLabel);
            this.groupBox1.Controls.Add(this.tienThanhToanTextEdit);
            this.groupBox1.Controls.Add(tienConLaiLabel);
            this.groupBox1.Controls.Add(this.tienConLaiLabel1);
            this.groupBox1.Controls.Add(hinhThucThanhToanLabel);
            this.groupBox1.Controls.Add(this.hinhThucThanhToanComboBox);
            this.groupBox1.Controls.Add(thanhTienLabel);
            this.groupBox1.Controls.Add(this.thanhTienLabel1);
            this.groupBox1.Controls.Add(ngayThanhToanLabel);
            this.groupBox1.Controls.Add(this.ngayThanhToanDateEdit);
            this.groupBox1.Controls.Add(maDatTourLabel);
            this.groupBox1.Controls.Add(this.maDatTourTextEdit);
            this.groupBox1.Controls.Add(maThanhToanLabel);
            this.groupBox1.Controls.Add(this.maThanhToanTextEdit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(102, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1365, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lb_TongDoanhThu
            // 
            this.lb_TongDoanhThu.AutoSize = true;
            this.lb_TongDoanhThu.Enabled = false;
            this.lb_TongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lb_TongDoanhThu.Location = new System.Drawing.Point(1017, 168);
            this.lb_TongDoanhThu.Name = "lb_TongDoanhThu";
            this.lb_TongDoanhThu.Size = new System.Drawing.Size(58, 20);
            this.lb_TongDoanhThu.TabIndex = 17;
            this.lb_TongDoanhThu.Text = "0 VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(871, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHANHTOANBindingSource, "GhiChu", true));
            this.ghiChuTextBox.Enabled = false;
            this.ghiChuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghiChuTextBox.Location = new System.Drawing.Point(1021, 108);
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(100, 27);
            this.ghiChuTextBox.TabIndex = 15;
            // 
            // tienThanhToanTextEdit
            // 
            this.tienThanhToanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHANHTOANBindingSource, "TienThanhToan", true));
            this.tienThanhToanTextEdit.Enabled = false;
            this.tienThanhToanTextEdit.Location = new System.Drawing.Point(618, 105);
            this.tienThanhToanTextEdit.Name = "tienThanhToanTextEdit";
            this.tienThanhToanTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienThanhToanTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tienThanhToanTextEdit.Size = new System.Drawing.Size(128, 26);
            this.tienThanhToanTextEdit.TabIndex = 13;
            // 
            // tienConLaiLabel1
            // 
            this.tienConLaiLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHANHTOANBindingSource, "TienConLai", true));
            this.tienConLaiLabel1.Enabled = false;
            this.tienConLaiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienConLaiLabel1.Location = new System.Drawing.Point(1017, 50);
            this.tienConLaiLabel1.Name = "tienConLaiLabel1";
            this.tienConLaiLabel1.Size = new System.Drawing.Size(100, 23);
            this.tienConLaiLabel1.TabIndex = 11;
            this.tienConLaiLabel1.Text = "0 VNĐ";
            // 
            // hinhThucThanhToanComboBox
            // 
            this.hinhThucThanhToanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHANHTOANBindingSource, "HinhThucThanhToan", true));
            this.hinhThucThanhToanComboBox.Enabled = false;
            this.hinhThucThanhToanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinhThucThanhToanComboBox.FormattingEnabled = true;
            this.hinhThucThanhToanComboBox.Location = new System.Drawing.Point(618, 37);
            this.hinhThucThanhToanComboBox.Name = "hinhThucThanhToanComboBox";
            this.hinhThucThanhToanComboBox.Size = new System.Drawing.Size(121, 28);
            this.hinhThucThanhToanComboBox.TabIndex = 9;
            // 
            // thanhTienLabel1
            // 
            this.thanhTienLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHANHTOANBindingSource, "ThanhTien", true));
            this.thanhTienLabel1.Enabled = false;
            this.thanhTienLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhTienLabel1.Location = new System.Drawing.Point(614, 162);
            this.thanhTienLabel1.Name = "thanhTienLabel1";
            this.thanhTienLabel1.Size = new System.Drawing.Size(100, 23);
            this.thanhTienLabel1.TabIndex = 7;
            this.thanhTienLabel1.Text = "0 VNĐ";
            // 
            // ngayThanhToanDateEdit
            // 
            this.ngayThanhToanDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHANHTOANBindingSource, "NgayThanhToan", true));
            this.ngayThanhToanDateEdit.EditValue = null;
            this.ngayThanhToanDateEdit.Enabled = false;
            this.ngayThanhToanDateEdit.Location = new System.Drawing.Point(227, 159);
            this.ngayThanhToanDateEdit.Name = "ngayThanhToanDateEdit";
            this.ngayThanhToanDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayThanhToanDateEdit.Properties.Appearance.Options.UseFont = true;
            this.ngayThanhToanDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayThanhToanDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayThanhToanDateEdit.Size = new System.Drawing.Size(100, 26);
            this.ngayThanhToanDateEdit.TabIndex = 5;
            // 
            // maDatTourTextEdit
            // 
            this.maDatTourTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHANHTOANBindingSource, "MaDatTour", true));
            this.maDatTourTextEdit.Enabled = false;
            this.maDatTourTextEdit.Location = new System.Drawing.Point(227, 105);
            this.maDatTourTextEdit.Name = "maDatTourTextEdit";
            this.maDatTourTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDatTourTextEdit.Properties.Appearance.Options.UseFont = true;
            this.maDatTourTextEdit.Size = new System.Drawing.Size(100, 26);
            this.maDatTourTextEdit.TabIndex = 3;
            // 
            // maThanhToanTextEdit
            // 
            this.maThanhToanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHANHTOANBindingSource, "MaThanhToan", true));
            this.maThanhToanTextEdit.Enabled = false;
            this.maThanhToanTextEdit.Location = new System.Drawing.Point(227, 41);
            this.maThanhToanTextEdit.Name = "maThanhToanTextEdit";
            this.maThanhToanTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maThanhToanTextEdit.Properties.Appearance.Options.UseFont = true;
            this.maThanhToanTextEdit.Size = new System.Drawing.Size(100, 26);
            this.maThanhToanTextEdit.TabIndex = 1;
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
            this.groupBox2.Location = new System.Drawing.Point(286, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1000, 168);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(888, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 104);
            this.button2.TabIndex = 5;
            this.button2.Text = "Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(757, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 104);
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
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 821);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tHANHTOANGridControl);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHTOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHTOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tienThanhToanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThanhToanDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThanhToanDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maDatTourTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maThanhToanTextEdit.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.denNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QL_TOURDLPMDataSet qL_TOURDLPMDataSet;
        private System.Windows.Forms.BindingSource tHANHTOANBindingSource;
        private QL_TOURDLPMDataSetTableAdapters.THANHTOANTableAdapter tHANHTOANTableAdapter;
        private QL_TOURDLPMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl tHANHTOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit denNgay;
        private DevExpress.XtraEditors.DateEdit tuNgay;
        private System.Windows.Forms.RadioButton rdThangNam;
        private System.Windows.Forms.RadioButton rdNgay;
        private System.Windows.Forms.Label lb_TongDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ghiChuTextBox;
        private DevExpress.XtraEditors.TextEdit tienThanhToanTextEdit;
        private System.Windows.Forms.Label tienConLaiLabel1;
        private System.Windows.Forms.ComboBox hinhThucThanhToanComboBox;
        private System.Windows.Forms.Label thanhTienLabel1;
        private DevExpress.XtraEditors.DateEdit ngayThanhToanDateEdit;
        private DevExpress.XtraEditors.TextEdit maDatTourTextEdit;
        private DevExpress.XtraEditors.TextEdit maThanhToanTextEdit;
    }
}