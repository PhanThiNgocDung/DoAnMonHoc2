namespace QL_TourDLPM
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.qL_TOURDLPMDataSet = new QL_TourDLPM.QL_TOURDLPMDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new QL_TourDLPM.QL_TOURDLPMDataSetTableAdapters.TableAdapterManager();
            this.dataTable1GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_ThoiLuong = new System.Windows.Forms.RadioButton();
            this.radioButton_Gia = new System.Windows.Forms.RadioButton();
            this.radioButton_TenTour = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_HinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_TOURDLPMDataSet
            // 
            this.qL_TOURDLPMDataSet.DataSetName = "QL_TOURDLPMDataSet";
            this.qL_TOURDLPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.qL_TOURDLPMDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
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
            // dataTable1GridControl
            // 
            this.dataTable1GridControl.DataSource = this.dataTable1BindingSource;
            this.dataTable1GridControl.Location = new System.Drawing.Point(12, 310);
            this.dataTable1GridControl.MainView = this.gridView1;
            this.dataTable1GridControl.Name = "dataTable1GridControl";
            this.dataTable1GridControl.Size = new System.Drawing.Size(1584, 478);
            this.dataTable1GridControl.TabIndex = 1;
            this.dataTable1GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dataTable1GridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_ThoiLuong);
            this.groupBox1.Controls.Add(this.radioButton_Gia);
            this.groupBox1.Controls.Add(this.radioButton_TenTour);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(551, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // radioButton_ThoiLuong
            // 
            this.radioButton_ThoiLuong.AutoSize = true;
            this.radioButton_ThoiLuong.Location = new System.Drawing.Point(654, 44);
            this.radioButton_ThoiLuong.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_ThoiLuong.Name = "radioButton_ThoiLuong";
            this.radioButton_ThoiLuong.Size = new System.Drawing.Size(107, 24);
            this.radioButton_ThoiLuong.TabIndex = 16;
            this.radioButton_ThoiLuong.TabStop = true;
            this.radioButton_ThoiLuong.Text = "Thời lượng";
            this.radioButton_ThoiLuong.UseVisualStyleBackColor = true;
            // 
            // radioButton_Gia
            // 
            this.radioButton_Gia.AutoSize = true;
            this.radioButton_Gia.Location = new System.Drawing.Point(384, 44);
            this.radioButton_Gia.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Gia.Name = "radioButton_Gia";
            this.radioButton_Gia.Size = new System.Drawing.Size(56, 24);
            this.radioButton_Gia.TabIndex = 15;
            this.radioButton_Gia.TabStop = true;
            this.radioButton_Gia.Text = "Giá";
            this.radioButton_Gia.UseVisualStyleBackColor = true;
            // 
            // radioButton_TenTour
            // 
            this.radioButton_TenTour.AutoSize = true;
            this.radioButton_TenTour.Location = new System.Drawing.Point(67, 44);
            this.radioButton_TenTour.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_TenTour.Name = "radioButton_TenTour";
            this.radioButton_TenTour.Size = new System.Drawing.Size(97, 24);
            this.radioButton_TenTour.TabIndex = 14;
            this.radioButton_TenTour.TabStop = true;
            this.radioButton_TenTour.Text = "Tên Tour";
            this.radioButton_TenTour.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(672, 34);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(600, 43);
            this.txt_Search.TabIndex = 10;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(81, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 223);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataTable1BindingSource, "HinhAnh", true));
            this.txt_HinhAnh.Location = new System.Drawing.Point(1370, 47);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(10, 22);
            this.txt_HinhAnh.TabIndex = 13;
            this.txt_HinhAnh.TextChanged += new System.EventHandler(this.hinhAnhTextEdit_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1339, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 821);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_HinhAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataTable1GridControl);
            this.Name = "frmTimKiem";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_TOURDLPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_TOURDLPMDataSet qL_TOURDLPMDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private QL_TOURDLPMDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private QL_TOURDLPMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dataTable1GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_ThoiLuong;
        private System.Windows.Forms.RadioButton radioButton_Gia;
        private System.Windows.Forms.RadioButton radioButton_TenTour;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txt_HinhAnh;
        private System.Windows.Forms.Button button1;
    }
}