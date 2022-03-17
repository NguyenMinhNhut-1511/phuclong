namespace QuanLyPhucLong
{
    partial class FormHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnin = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgay1 = new System.Windows.Forms.DateTimePicker();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.cbChon = new System.Windows.Forms.ComboBox();
            this.gachchan = new System.Windows.Forms.Panel();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.colMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhToan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTienNhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTienThua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiamGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvCTHoaDon = new System.Windows.Forms.ListView();
            this.colMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongGiaTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNgayXuat = new System.Windows.Forms.Label();
            this.lbThanhToan = new System.Windows.Forms.Label();
            this.lbGiamGia = new System.Windows.Forms.Label();
            this.lbTienThua = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTienNhan = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtNgay1);
            this.panel1.Controls.Add(this.dtNgay);
            this.panel1.Controls.Add(this.cbChon);
            this.panel1.Controls.Add(this.gachchan);
            this.panel1.Controls.Add(this.txtMaHoaDon);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1702, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnin
            // 
            this.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.Color.White;
            this.btnin.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnin.IconColor = System.Drawing.Color.White;
            this.btnin.IconSize = 25;
            this.btnin.Location = new System.Drawing.Point(826, 45);
            this.btnin.Name = "btnin";
            this.btnin.Rotation = 0D;
            this.btnin.Size = new System.Drawing.Size(105, 30);
            this.btnin.TabIndex = 84;
            this.btnin.Text = "In Hóa Đơn";
            this.btnin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(522, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "~";
            // 
            // dtNgay1
            // 
            this.dtNgay1.CustomFormat = "dd/MM/yyyy";
            this.dtNgay1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay1.Location = new System.Drawing.Point(551, 23);
            this.dtNgay1.Name = "dtNgay1";
            this.dtNgay1.Size = new System.Drawing.Size(226, 29);
            this.dtNgay1.TabIndex = 82;
            this.dtNgay1.ValueChanged += new System.EventHandler(this.ChangeDateTimePicker);
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd/MM/yyyy";
            this.dtNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(296, 24);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(226, 29);
            this.dtNgay.TabIndex = 81;
            this.dtNgay.ValueChanged += new System.EventHandler(this.ChangeDateTimePicker);
            // 
            // cbChon
            // 
            this.cbChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChon.FormattingEnabled = true;
            this.cbChon.Items.AddRange(new object[] {
            "Tìm kiếm ngày",
            "Tìm kiếm Mã Hóa Đơn"});
            this.cbChon.Location = new System.Drawing.Point(44, 25);
            this.cbChon.Name = "cbChon";
            this.cbChon.Size = new System.Drawing.Size(246, 28);
            this.cbChon.TabIndex = 80;
            this.cbChon.SelectedValueChanged += new System.EventHandler(this.cbChon_SelectedValueChanged);
            // 
            // gachchan
            // 
            this.gachchan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gachchan.BackColor = System.Drawing.Color.White;
            this.gachchan.Location = new System.Drawing.Point(297, 48);
            this.gachchan.Name = "gachchan";
            this.gachchan.Size = new System.Drawing.Size(228, 2);
            this.gachchan.TabIndex = 77;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(125)))), ((int)(((byte)(57)))));
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.Color.Silver;
            this.txtMaHoaDon.Location = new System.Drawing.Point(331, 26);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(192, 20);
            this.txtMaHoaDon.TabIndex = 76;
            this.txtMaHoaDon.Text = "Tìm kiếm";
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.txtMaHoaDon_TextChanged);
            this.txtMaHoaDon.Enter += new System.EventHandler(this.txtMaHoaDon_Enter);
            this.txtMaHoaDon.Leave += new System.EventHandler(this.txtMaHoaDon_Leave);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(125)))), ((int)(((byte)(57)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(296, 21);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(29, 25);
            this.iconPictureBox2.TabIndex = 78;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 912);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(47, 944);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1655, 47);
            this.panel3.TabIndex = 2;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHD,
            this.colTenNV,
            this.colNgayXuat,
            this.colThanhToan,
            this.colTienNhan,
            this.colTienThua,
            this.colGiamGia});
            this.lvHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(47, 79);
            this.lvHoaDon.MultiSelect = false;
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(885, 865);
            this.lvHoaDon.TabIndex = 3;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            this.lvHoaDon.SelectedIndexChanged += new System.EventHandler(this.lvHoaDon_SelectedIndexChanged);
            // 
            // colMaHD
            // 
            this.colMaHD.Text = "Mã HĐ";
            this.colMaHD.Width = 50;
            // 
            // colTenNV
            // 
            this.colTenNV.Text = "Tên Nhân Viên";
            this.colTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenNV.Width = 250;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Text = "Ngày Xuất Hóa Đơn";
            this.colNgayXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNgayXuat.Width = 200;
            // 
            // colThanhToan
            // 
            this.colThanhToan.Text = "Thanh Toán";
            this.colThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colThanhToan.Width = 110;
            // 
            // colTienNhan
            // 
            this.colTienNhan.Text = "Tiền Nhận";
            this.colTienNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTienNhan.Width = 90;
            // 
            // colTienThua
            // 
            this.colTienThua.Text = "Tiền Thừa";
            this.colTienThua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTienThua.Width = 90;
            // 
            // colGiamGia
            // 
            this.colGiamGia.Text = "Giảm Giá (%)";
            this.colGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGiamGia.Width = 90;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1655, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 865);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(932, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 865);
            this.panel5.TabIndex = 5;
            // 
            // lvCTHoaDon
            // 
            this.lvCTHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSP,
            this.colTenSP,
            this.colSL,
            this.colGiaTien,
            this.colTongGiaTien});
            this.lvCTHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvCTHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCTHoaDon.FullRowSelect = true;
            this.lvCTHoaDon.GridLines = true;
            this.lvCTHoaDon.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCTHoaDon.HideSelection = false;
            this.lvCTHoaDon.Location = new System.Drawing.Point(1028, 371);
            this.lvCTHoaDon.MultiSelect = false;
            this.lvCTHoaDon.Name = "lvCTHoaDon";
            this.lvCTHoaDon.Size = new System.Drawing.Size(627, 573);
            this.lvCTHoaDon.TabIndex = 6;
            this.lvCTHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvCTHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // colMaSP
            // 
            this.colMaSP.Text = "Mã Sản Phẩm";
            this.colMaSP.Width = 100;
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "Tên Sản Phẩm";
            this.colTenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenSP.Width = 250;
            // 
            // colSL
            // 
            this.colSL.Text = "Số Lượng";
            this.colSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSL.Width = 80;
            // 
            // colGiaTien
            // 
            this.colGiaTien.Text = "Giá Tiền";
            this.colGiaTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGiaTien.Width = 90;
            // 
            // colTongGiaTien
            // 
            this.colTongGiaTien.Text = "Tổng Giá Tiền";
            this.colTongGiaTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTongGiaTien.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNgayXuat);
            this.groupBox1.Controls.Add(this.lbThanhToan);
            this.groupBox1.Controls.Add(this.lbGiamGia);
            this.groupBox1.Controls.Add(this.lbTienThua);
            this.groupBox1.Controls.Add(this.lbMaHD);
            this.groupBox1.Controls.Add(this.lbTienNhan);
            this.groupBox1.Controls.Add(this.lbTenNV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(1028, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 284);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lbNgayXuat
            // 
            this.lbNgayXuat.AutoSize = true;
            this.lbNgayXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayXuat.ForeColor = System.Drawing.Color.White;
            this.lbNgayXuat.Location = new System.Drawing.Point(80, 225);
            this.lbNgayXuat.Name = "lbNgayXuat";
            this.lbNgayXuat.Size = new System.Drawing.Size(157, 21);
            this.lbNgayXuat.TabIndex = 7;
            this.lbNgayXuat.Text = "Ngày Xuất Hóa Đơn:";
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.AutoSize = true;
            this.lbThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhToan.ForeColor = System.Drawing.Color.White;
            this.lbThanhToan.Location = new System.Drawing.Point(79, 128);
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(96, 21);
            this.lbThanhToan.TabIndex = 6;
            this.lbThanhToan.Text = "Thanh Toán:";
            // 
            // lbGiamGia
            // 
            this.lbGiamGia.AutoSize = true;
            this.lbGiamGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiamGia.ForeColor = System.Drawing.Color.White;
            this.lbGiamGia.Location = new System.Drawing.Point(79, 96);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.Size = new System.Drawing.Size(78, 21);
            this.lbGiamGia.TabIndex = 5;
            this.lbGiamGia.Text = "Giảm Giá:";
            // 
            // lbTienThua
            // 
            this.lbTienThua.AutoSize = true;
            this.lbTienThua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienThua.ForeColor = System.Drawing.Color.White;
            this.lbTienThua.Location = new System.Drawing.Point(80, 193);
            this.lbTienThua.Name = "lbTienThua";
            this.lbTienThua.Size = new System.Drawing.Size(89, 21);
            this.lbTienThua.TabIndex = 5;
            this.lbTienThua.Text = "Tiền Thừa: ";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.ForeColor = System.Drawing.Color.White;
            this.lbMaHD.Location = new System.Drawing.Point(79, 65);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(109, 21);
            this.lbMaHD.TabIndex = 4;
            this.lbMaHD.Text = "Mã Hóa Đơn: ";
            // 
            // lbTienNhan
            // 
            this.lbTienNhan.AutoSize = true;
            this.lbTienNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienNhan.ForeColor = System.Drawing.Color.White;
            this.lbTienNhan.Location = new System.Drawing.Point(80, 160);
            this.lbTienNhan.Name = "lbTienNhan";
            this.lbTienNhan.Size = new System.Drawing.Size(91, 21);
            this.lbTienNhan.TabIndex = 3;
            this.lbTienNhan.Text = "Tiền Nhận: ";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.ForeColor = System.Drawing.Color.White;
            this.lbTenNV.Location = new System.Drawing.Point(79, 36);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(121, 21);
            this.lbTenNV.TabIndex = 2;
            this.lbTenNV.Text = "Tên Nhân Viên: ";
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(125)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1702, 991);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvCTHoaDon);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormHistory";
            this.Text = "Lịch Sử Giao Dịch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.ComboBox cbChon;
        private System.Windows.Forms.Panel gachchan;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lvCTHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbThanhToan;
        private System.Windows.Forms.Label lbGiamGia;
        private System.Windows.Forms.Label lbTienThua;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTienNhan;
        private System.Windows.Forms.Label lbNgayXuat;
        private System.Windows.Forms.ColumnHeader colMaHD;
        private System.Windows.Forms.ColumnHeader colTenNV;
        private System.Windows.Forms.ColumnHeader colNgayXuat;
        private System.Windows.Forms.ColumnHeader colThanhToan;
        private System.Windows.Forms.ColumnHeader colTienNhan;
        private System.Windows.Forms.ColumnHeader colTienThua;
        private System.Windows.Forms.ColumnHeader colGiamGia;
        private System.Windows.Forms.ColumnHeader colMaSP;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colSL;
        private System.Windows.Forms.ColumnHeader colGiaTien;
        private System.Windows.Forms.ColumnHeader colTongGiaTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgay1;
        private FontAwesome.Sharp.IconButton btnin;
    }
}