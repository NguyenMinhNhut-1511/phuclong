namespace QuanLyPhucLong
{
    partial class Form_Bill_History
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnXuatAnh = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch Sử Giao Dịch";
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
            this.btnCancel.Location = new System.Drawing.Point(584, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(34, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 35);
            this.panel1.TabIndex = 1;
            // 
            // rpBill
            // 
            this.rpBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpBill.DocumentMapWidth = 3;
            this.rpBill.LocalReport.ReportEmbeddedResource = "QuanLyPhucLong.Report.historybill.rdlc";
            this.rpBill.Location = new System.Drawing.Point(0, 35);
            this.rpBill.Margin = new System.Windows.Forms.Padding(0);
            this.rpBill.Name = "rpBill";
            this.rpBill.ServerReport.BearerToken = null;
            this.rpBill.ShowBackButton = false;
            this.rpBill.ShowExportButton = false;
            this.rpBill.ShowFindControls = false;
            this.rpBill.ShowRefreshButton = false;
            this.rpBill.ShowStopButton = false;
            this.rpBill.Size = new System.Drawing.Size(620, 669);
            this.rpBill.TabIndex = 2;
            // 
            // btnXuatAnh
            // 
            this.btnXuatAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatAnh.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXuatAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatAnh.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnXuatAnh.IconColor = System.Drawing.Color.Black;
            this.btnXuatAnh.IconSize = 18;
            this.btnXuatAnh.Location = new System.Drawing.Point(354, 36);
            this.btnXuatAnh.Name = "btnXuatAnh";
            this.btnXuatAnh.Rotation = 0D;
            this.btnXuatAnh.Size = new System.Drawing.Size(105, 24);
            this.btnXuatAnh.TabIndex = 3;
            this.btnXuatAnh.Text = "Xuất Ảnh";
            this.btnXuatAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatAnh.UseVisualStyleBackColor = true;
            this.btnXuatAnh.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Form_Bill_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 704);
            this.Controls.Add(this.btnXuatAnh);
            this.Controls.Add(this.rpBill);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Bill_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "historyrp";
            this.Load += new System.EventHandler(this.Form_Bill_History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpBill;
        private FontAwesome.Sharp.IconButton btnXuatAnh;
    }
}