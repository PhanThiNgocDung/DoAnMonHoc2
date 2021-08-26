namespace QuanLiThuVien.View
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_trangchu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_loc = new System.Windows.Forms.Button();
            this.txt_tendg = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(568, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORT";
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangchu.Image = ((System.Drawing.Image)(resources.GetObject("btn_trangchu.Image")));
            this.btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangchu.Location = new System.Drawing.Point(1297, -1);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Size = new System.Drawing.Size(161, 57);
            this.btn_trangchu.TabIndex = 19;
            this.btn_trangchu.Text = "Trang chủ";
            this.btn_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_trangchu.UseVisualStyleBackColor = true;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 57);
            this.panel1.TabIndex = 48;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 104);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1458, 641);
            this.crystalReportViewer1.TabIndex = 49;
            // 
            // btn_loc
            // 
            this.btn_loc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_loc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loc.Location = new System.Drawing.Point(402, 62);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(108, 35);
            this.btn_loc.TabIndex = 50;
            this.btn_loc.Text = "LỌC";
            this.btn_loc.UseVisualStyleBackColor = false;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // txt_tendg
            // 
            this.txt_tendg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendg.Location = new System.Drawing.Point(547, 65);
            this.txt_tendg.Multiline = true;
            this.txt_tendg.Name = "txt_tendg";
            this.txt_tendg.Size = new System.Drawing.Size(289, 30);
            this.txt_tendg.TabIndex = 52;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1458, 750);
            this.Controls.Add(this.txt_tendg);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_trangchu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Report";
            this.Text = "Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Report_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_trangchu;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.TextBox txt_tendg;
    }
}