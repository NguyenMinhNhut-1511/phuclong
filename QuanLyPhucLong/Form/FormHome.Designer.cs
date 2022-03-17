namespace QuanLyPhucLong
{
    partial class FormHome
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
            this.lvSP = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTienNhan = new System.Windows.Forms.TextBox();
            this.lbTienThua = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbTongCong = new System.Windows.Forms.Label();
            this.lbGiamGia = new System.Windows.Forms.Label();
            this.lbTongTamTinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApDung = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lbKhuyenMai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSP
            // 
            this.lvSP.BackColor = System.Drawing.SystemColors.Window;
            this.lvSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSP.HideSelection = false;
            this.lvSP.Location = new System.Drawing.Point(0, 0);
            this.lvSP.MultiSelect = false;
            this.lvSP.Name = "lvSP";
            this.lvSP.ShowItemToolTips = true;
            this.lvSP.Size = new System.Drawing.Size(709, 991);
            this.lvSP.TabIndex = 1;
            this.lvSP.UseCompatibleStateImageBehavior = false;
            this.lvSP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSP_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(709, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 991);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1467, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 991);
            this.panel3.TabIndex = 4;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colMaSP,
            this.colTenSP,
            this.colSoLuong,
            this.colGia});
            this.lvHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(944, 0);
            this.lvHoaDon.MultiSelect = false;
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(523, 483);
            this.lvHoaDon.TabIndex = 5;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            this.lvHoaDon.SelectedIndexChanged += new System.EventHandler(this.lvHoaDon_SelectedIndexChanged);
            this.lvHoaDon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvHoaDon_MouseClick);
            this.lvHoaDon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvHoaDon_MouseDoubleClick);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 45;
            // 
            // colMaSP
            // 
            this.colMaSP.Text = "Mã Sản Phẩm";
            this.colMaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaSP.Width = 90;
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "Tên Sản Phẩm";
            this.colTenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenSP.Width = 254;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "SL";
            this.colSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoLuong.Width = 40;
            // 
            // colGia
            // 
            this.colGia.Text = "Giá Tiền";
            this.colGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGia.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.lbGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbMaSP);
            this.groupBox1.Controls.Add(this.lbTenSP);
            this.groupBox1.Location = new System.Drawing.Point(944, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnRemove.IconColor = System.Drawing.Color.White;
            this.btnRemove.IconSize = 30;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(409, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Rotation = 0D;
            this.btnRemove.Size = new System.Drawing.Size(100, 42);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconSize = 30;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(409, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Rotation = 0D;
            this.btnEdit.Size = new System.Drawing.Size(100, 42);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Chỉnh Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(93, 43);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(46, 23);
            this.txtSL.TabIndex = 4;
            this.txtSL.Text = "0";
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.Color.White;
            this.lbGia.Location = new System.Drawing.Point(171, 48);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(58, 15);
            this.lbGia.TabIndex = 3;
            this.lbGia.Text = "Giá Tiền: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng: x";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSP.ForeColor = System.Drawing.Color.White;
            this.lbMaSP.Location = new System.Drawing.Point(21, 16);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(87, 15);
            this.lbMaSP.TabIndex = 1;
            this.lbMaSP.Text = "Mã Sản Phẩm: ";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.ForeColor = System.Drawing.Color.White;
            this.lbTenSP.Location = new System.Drawing.Point(171, 16);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(90, 15);
            this.lbTenSP.TabIndex = 0;
            this.lbTenSP.Text = "Tên Sản Phẩm: ";
            this.lbTenSP.Click += new System.EventHandler(this.lbTenSP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.txtTienNhan);
            this.groupBox2.Controls.Add(this.lbTienThua);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.lbTongCong);
            this.groupBox2.Controls.Add(this.lbGiamGia);
            this.groupBox2.Controls.Add(this.lbTongTamTinh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnApDung);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.txtGiamGia);
            this.groupBox2.Controls.Add(this.iconPictureBox2);
            this.groupBox2.Controls.Add(this.lbKhuyenMai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(944, 624);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 367);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(361, 220);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 2);
            this.panel5.TabIndex = 82;
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(125)))), ((int)(((byte)(57)))));
            this.txtTienNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienNhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNhan.ForeColor = System.Drawing.Color.White;
            this.txtTienNhan.Location = new System.Drawing.Point(363, 199);
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.Size = new System.Drawing.Size(111, 20);
            this.txtTienNhan.TabIndex = 81;
            this.txtTienNhan.Text = "0";
            this.txtTienNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienNhan.TextChanged += new System.EventHandler(this.txtTienNhan_TextChanged);
            this.txtTienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienNhan_KeyPress);
            // 
            // lbTienThua
            // 
            this.lbTienThua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienThua.ForeColor = System.Drawing.Color.White;
            this.lbTienThua.Location = new System.Drawing.Point(230, 232);
            this.lbTienThua.Name = "lbTienThua";
            this.lbTienThua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTienThua.Size = new System.Drawing.Size(264, 21);
            this.lbTienThua.TabIndex = 80;
            this.lbTienThua.Text = "0 đ";
            this.lbTienThua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(475, 199);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 79;
            this.label6.Text = "đ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 78;
            this.label5.Text = "Tiền Thừa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tiền Nhận: ";
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnHuy.IconColor = System.Drawing.Color.White;
            this.btnHuy.IconSize = 30;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(296, 304);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Rotation = 0D;
            this.btnHuy.Size = new System.Drawing.Size(100, 42);
            this.btnHuy.TabIndex = 76;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnThanhToan.IconColor = System.Drawing.Color.White;
            this.btnThanhToan.IconSize = 30;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(116, 304);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Rotation = 0D;
            this.btnThanhToan.Size = new System.Drawing.Size(100, 42);
            this.btnThanhToan.TabIndex = 75;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(25, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(468, 3);
            this.panel4.TabIndex = 74;
            // 
            // lbTongCong
            // 
            this.lbTongCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongCong.ForeColor = System.Drawing.Color.White;
            this.lbTongCong.Location = new System.Drawing.Point(230, 147);
            this.lbTongCong.Name = "lbTongCong";
            this.lbTongCong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTongCong.Size = new System.Drawing.Size(264, 21);
            this.lbTongCong.TabIndex = 73;
            this.lbTongCong.Text = "0 đ";
            this.lbTongCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGiamGia
            // 
            this.lbGiamGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiamGia.ForeColor = System.Drawing.Color.White;
            this.lbGiamGia.Location = new System.Drawing.Point(230, 108);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbGiamGia.Size = new System.Drawing.Size(264, 21);
            this.lbGiamGia.TabIndex = 72;
            this.lbGiamGia.Text = "0 đ";
            this.lbGiamGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTongTamTinh
            // 
            this.lbTongTamTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTamTinh.ForeColor = System.Drawing.Color.White;
            this.lbTongTamTinh.Location = new System.Drawing.Point(230, 66);
            this.lbTongTamTinh.Name = "lbTongTamTinh";
            this.lbTongTamTinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTongTamTinh.Size = new System.Drawing.Size(264, 21);
            this.lbTongTamTinh.TabIndex = 71;
            this.lbTongTamTinh.Text = "0 đ";
            this.lbTongTamTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Tổng Cộng: ";
            // 
            // btnApDung
            // 
            this.btnApDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApDung.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnApDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDung.ForeColor = System.Drawing.Color.White;
            this.btnApDung.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnApDung.IconColor = System.Drawing.Color.White;
            this.btnApDung.IconSize = 25;
            this.btnApDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApDung.Location = new System.Drawing.Point(420, 14);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Rotation = 0D;
            this.btnApDung.Size = new System.Drawing.Size(97, 29);
            this.btnApDung.TabIndex = 69;
            this.btnApDung.Text = "Áp Dụng";
            this.btnApDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApDung.UseVisualStyleBackColor = true;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(188, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 2);
            this.panel2.TabIndex = 67;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiamGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(125)))), ((int)(((byte)(57)))));
            this.txtGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.ForeColor = System.Drawing.Color.Silver;
            this.txtGiamGia.Location = new System.Drawing.Point(222, 19);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(192, 20);
            this.txtGiamGia.TabIndex = 66;
            this.txtGiamGia.Text = "Phần trăm giảm giá";
            this.txtGiamGia.Enter += new System.EventHandler(this.txtGiamGia_Enter);
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            this.txtGiamGia.Leave += new System.EventHandler(this.txtGiamGia_Leave);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(125)))), ((int)(((byte)(57)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Percent;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(187, 14);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(29, 25);
            this.iconPictureBox2.TabIndex = 68;
            this.iconPictureBox2.TabStop = false;
            // 
            // lbKhuyenMai
            // 
            this.lbKhuyenMai.AutoSize = true;
            this.lbKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.lbKhuyenMai.Location = new System.Drawing.Point(20, 100);
            this.lbKhuyenMai.Name = "lbKhuyenMai";
            this.lbKhuyenMai.Size = new System.Drawing.Size(109, 21);
            this.lbKhuyenMai.TabIndex = 3;
            this.lbKhuyenMai.Text = "Khuyến Mãi: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng Tạm Tính:";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(125)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1702, 991);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvSP);
            this.Controls.Add(this.panel3);
            this.Name = "FormHome";
            this.Text = "Đặt Hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colMaSP;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox txtSL;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbKhuyenMai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGiamGia;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton btnApDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTongCong;
        private System.Windows.Forms.Label lbGiamGia;
        private System.Windows.Forms.Label lbTongTamTinh;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTienNhan;
        private System.Windows.Forms.Label lbTienThua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}