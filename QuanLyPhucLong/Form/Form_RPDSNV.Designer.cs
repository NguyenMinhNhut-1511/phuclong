namespace QuanLyPhucLong
{
    partial class Form_RPDSNV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QuanLyPhucLong.DataSet.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnin = new FontAwesome.Sharp.IconButton();
            this.rpNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhanVienTableAdapter = new QuanLyPhucLong.DataSet.DataSet1TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Nhân Viên ";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(57)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconSize = 25;
            this.btnCancel.Location = new System.Drawing.Point(509, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(34, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnin
            // 
            this.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnin.IconColor = System.Drawing.Color.Black;
            this.btnin.IconSize = 18;
            this.btnin.Location = new System.Drawing.Point(354, 36);
            this.btnin.Name = "btnin";
            this.btnin.Rotation = 0D;
            this.btnin.Size = new System.Drawing.Size(105, 24);
            this.btnin.TabIndex = 5;
            this.btnin.Text = "Xuất Ảnh";
            this.btnin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // rpNhanVien
            // 
            this.rpNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpNhanVien.DocumentMapWidth = 3;
            reportDataSource1.Name = "NhanVien";
            reportDataSource1.Value = this.NhanVienBindingSource;
            this.rpNhanVien.LocalReport.DataSources.Add(reportDataSource1);
            this.rpNhanVien.LocalReport.ReportEmbeddedResource = "QuanLyPhucLong.Report.RPDSNv.rdlc";
            this.rpNhanVien.Location = new System.Drawing.Point(0, 35);
            this.rpNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.rpNhanVien.Name = "rpNhanVien";
            this.rpNhanVien.ServerReport.BearerToken = null;
            this.rpNhanVien.ShowBackButton = false;
            this.rpNhanVien.ShowExportButton = false;
            this.rpNhanVien.ShowFindControls = false;
            this.rpNhanVien.ShowRefreshButton = false;
            this.rpNhanVien.ShowStopButton = false;
            this.rpNhanVien.Size = new System.Drawing.Size(545, 527);
            this.rpNhanVien.TabIndex = 4;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // Form_RPDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 562);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.rpNhanVien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RPDSNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_RPDSNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnin;
        private Microsoft.Reporting.WinForms.ReportViewer rpNhanVien;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private DataSet.DataSet1 DataSet1;
        private DataSet.DataSet1TableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
    }
}