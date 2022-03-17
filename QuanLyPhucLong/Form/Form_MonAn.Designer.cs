﻿namespace QuanLyPhucLong
{
    partial class Form_MonAn
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
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QuanLyPhucLong.DataSet.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SanPhamTableAdapter = new QuanLyPhucLong.DataSet.DataSet1TableAdapters.SanPhamTableAdapter();
            this.btnXuatAnh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.DataSet1;
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
            this.panel1.Size = new System.Drawing.Size(486, 35);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Món Ăn";
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
            this.btnCancel.Location = new System.Drawing.Point(450, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(34, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "SanPham";
            reportDataSource1.Value = this.SanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyPhucLong.Report.RP_MonAN.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 34);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(486, 489);
            this.reportViewer1.TabIndex = 2;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // btnXuatAnh
            // 
            this.btnXuatAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatAnh.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXuatAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatAnh.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnXuatAnh.IconColor = System.Drawing.Color.Black;
            this.btnXuatAnh.IconSize = 18;
            this.btnXuatAnh.Location = new System.Drawing.Point(354, 35);
            this.btnXuatAnh.Name = "btnXuatAnh";
            this.btnXuatAnh.Rotation = 0D;
            this.btnXuatAnh.Size = new System.Drawing.Size(105, 24);
            this.btnXuatAnh.TabIndex = 4;
            this.btnXuatAnh.Text = "Xuất Ảnh";
            this.btnXuatAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatAnh.UseVisualStyleBackColor = true;
            this.btnXuatAnh.Click += new System.EventHandler(this.btnXuatAnh_Click);
            // 
            // Form_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 522);
            this.Controls.Add(this.btnXuatAnh);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MonAn";
            this.Load += new System.EventHandler(this.Form_MonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private DataSet.DataSet1 DataSet1;
        private DataSet.DataSet1TableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
        private FontAwesome.Sharp.IconButton btnXuatAnh;
    }
}