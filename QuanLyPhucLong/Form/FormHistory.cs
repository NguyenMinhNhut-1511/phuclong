using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhucLong
{
    public partial class FormHistory : Form
    {
        Entity DB = new Entity();
        ConvertMoney cv = new ConvertMoney();
        public FormHistory()
        {
            InitializeComponent();
            cbChon.SelectedIndex = 0;
        }

        private void _Reset()
        {
            lbTenNV.Text = "Tên Nhân Viên: ";
            lbMaHD.Text = "Mã Hóa Đơn:  ";
            lbGiamGia.Text = "Giảm Giá: ";
            lbThanhToan.Text = "Thanh Toán: ";
            lbTienNhan.Text = "Tiền Nhận:  ";
            lbTienThua.Text = "Tiền Thừa:  ";
            lbNgayXuat.Text = "Ngày Xuất Hóa Đơn: ";
            lvCTHoaDon.Items.Clear();
        }
        
        private void _Load()
        {
            lvHoaDon.Items.Clear();
            List<PhieuXuat> listpx = DB.PhieuXuats.ToList();
            foreach (PhieuXuat px in listpx)
            {
                string maHD = px.maPhieuXuat.ToString();
                string hoTen = px.NhanVien.hoTen;
                string ngayXuat = Convert.ToDateTime(px.ngayXuat.ToString()).ToString("dd/MM/yyyy - HH:mm:ss");
                string thanhToan = cv._ConvertMoney(px.thanhToan.ToString());
                string tienThu = cv._ConvertMoney(px.tienThu.ToString());
                string tienTra = cv._ConvertMoney(px.tienTra.ToString());
                string uuDai = px.uuDai.ToString();
                String[] row = { maHD, hoTen, ngayXuat, thanhToan, tienThu, tienTra, uuDai };
                ListViewItem item1 = new ListViewItem(row);
                lvHoaDon.Items.Add(item1);
            }
        }

        private void cbChon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbChon.SelectedItem.ToString() != string.Empty)
            {
                if (cbChon.SelectedItem.ToString() == "Tìm kiếm ngày")
                {
                    dtNgay.Enabled = true; dtNgay.Visible = true;
                    gachchan.Enabled = false; gachchan.Visible = false;
                    txtMaHoaDon.Enabled = false; txtMaHoaDon.Visible = false;
                    iconPictureBox2.Enabled = false; iconPictureBox2.Visible = false;

                    label1.Enabled = true; label1.Visible = true;
                    dtNgay1.Enabled = true; dtNgay1.Visible = true;
                }
                else
                {
                    dtNgay.Enabled = false; dtNgay.Visible = false;

                    gachchan.Enabled = true; gachchan.Visible = true;
                    txtMaHoaDon.Enabled = true; txtMaHoaDon.Visible = true;
                    iconPictureBox2.Enabled = true; iconPictureBox2.Visible = true;
                    txtMaHoaDon.Text = "Tìm kiếm Mã Hóa Đơn";
                    txtMaHoaDon.ForeColor = Color.Silver;
                    txtMaHoaDon.Font = new Font("Segoe UI", 12, FontStyle.Italic);

                    label1.Enabled = false; label1.Visible = false;
                    dtNgay1.Enabled = false; dtNgay1.Visible = false;

                }
                _Load();
                _Reset();
            }    
        }

        private void _TimKiemNgay()
        {
            lvHoaDon.Items.Clear();
            List<PhieuXuat> ListPX = DB.PhieuXuats.ToList();
            foreach (PhieuXuat px in ListPX)
            {
                DateTime Time = px.ngayXuat.Value.Date;
                if (Time >= dtNgay.Value.Date && Time <= dtNgay1.Value.Date)
                {
                    string maHD = px.maPhieuXuat.ToString();
                    string hoTen = px.NhanVien.hoTen;
                    string ngayXuat = Convert.ToDateTime(px.ngayXuat).ToString("dd/MM/yyy - HH:mm:ss");
                    string thanhToan = cv._ConvertMoney(px.thanhToan.ToString());
                    string tienThu = cv._ConvertMoney(px.tienThu.ToString());
                    string tienTra = cv._ConvertMoney(px.tienTra.ToString());
                    string uuDai = px.uuDai.ToString();
                    String[] row = { maHD, hoTen, ngayXuat, thanhToan, tienThu, tienTra, uuDai };
                    ListViewItem item1 = new ListViewItem(row);
                    lvHoaDon.Items.Add(item1);
                }
            }
        }

        private void ChangeDateTimePicker(object sender, EventArgs e)
        {
            _TimKiemNgay();
        }

        private void _TimKiemMa()
        {
            if (txtMaHoaDon.Text == string.Empty)
            {
                _Load();
            }
            else
            {
                lvHoaDon.Items.Clear();
                try
                {
                    int ID = Int32.Parse(txtMaHoaDon.Text);
                    PhieuXuat px = DB.PhieuXuats.FirstOrDefault(p => p.maPhieuXuat == ID);
                    if (px.maPhieuXuat > -1)
                    {
                        string maHD = px.maPhieuXuat.ToString();
                        string hoTen = px.NhanVien.hoTen;
                        string ngayXuat = Convert.ToDateTime(px.ngayXuat.ToString()).ToString("dd/MM/yyy - HH:mm:ss");
                        string thanhToan = cv._ConvertMoney(px.thanhToan.ToString());
                        string tienThu = cv._ConvertMoney(px.tienThu.ToString());
                        string tienTra = cv._ConvertMoney(px.tienTra.ToString());
                        string uuDai = px.uuDai.ToString();
                        String[] row = { maHD, hoTen, ngayXuat, thanhToan, tienThu, tienTra, uuDai };
                        ListViewItem item1 = new ListViewItem(row);
                        lvHoaDon.Items.Add(item1);
                    }
                    else Program.Alert("Không Tìm Thấy Mã Hóa Đơn", Form_Alert.enmType.Error);
                }catch(Exception ex){
                    _Load();
                }
            }
        }

        private void txtMaHoaDon_Enter(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "Tìm kiếm Mã Hóa Đơn")
            {
                txtMaHoaDon.Text = "";
                txtMaHoaDon.ForeColor = Color.White;
                txtMaHoaDon.Font = new Font("Segoe UI", 12, FontStyle.Bold); ;
            }
        }

        private void txtMaHoaDon_Leave(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "")
            {
                txtMaHoaDon.Text = "Tìm kiếm Mã Hóa Đơn";
                txtMaHoaDon.ForeColor = Color.Silver;
                txtMaHoaDon.Font = new Font("Segoe UI", 12, FontStyle.Italic); ;
            }
        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count > 0)
            {
                lvCTHoaDon.Items.Clear();
                lbTenNV.Text = "Tên Nhân Viên: " + lvHoaDon.SelectedItems[0].SubItems[1].Text;
                lbMaHD.Text = "Mã Hóa Đơn:  " + lvHoaDon.SelectedItems[0].SubItems[0].Text;
                lbGiamGia.Text = "Giảm Giá: " + lvHoaDon.SelectedItems[0].SubItems[6].Text + "%";
                lbThanhToan.Text = "Thanh Toán: " + lvHoaDon.SelectedItems[0].SubItems[3].Text;
                lbTienNhan.Text = "Tiền Nhận:  " + lvHoaDon.SelectedItems[0].SubItems[4].Text;
                lbTienThua.Text = "Tiền Thừa:  " + lvHoaDon.SelectedItems[0].SubItems[5].Text;
                lbNgayXuat.Text = "Ngày Xuất Hóa Đơn: " + lvHoaDon.SelectedItems[0].SubItems[2].Text;
                int ID = Int32.Parse(lvHoaDon.SelectedItems[0].SubItems[0].Text);
                List<CTPhieuXuat> ListCTPX = DB.CTPhieuXuats.Where(p => p.maPhieuXuat == ID).ToList();
                if (ListCTPX.Count > 0)
                {
                    foreach (CTPhieuXuat ctpx in ListCTPX)
                    {
                        string maSP = ctpx.maSP.ToString();
                        string tenSP = ctpx.SanPham.tenSP;
                        string soLuong = ctpx.soLuong.ToString();
                        string Gia = cv._ConvertMoney(ctpx.SanPham.Gia.ToString());
                        string TongGia = cv._ConvertMoney(cv._ConvertInt(soLuong) * cv._ConvertInt(Gia));
                        String[] row = { maSP, tenSP, soLuong, Gia, TongGia};
                        ListViewItem item1 = new ListViewItem(row);
                        lvCTHoaDon.Items.Add(item1);
                        int TongCong = cv._ConvertInt(soLuong) * cv._ConvertInt(Gia);
                        lvCTHoaDon.Items.Add(new ListViewItem(new String[] { "+", string.Concat("Size: ", ctpx.size, ", Đường: ", ctpx.duong, ", Đá: ", ctpx.da), "0", "0", "0" }));
                        foreach (ChiTietTopping item2 in ctpx.ChiTietToppings)
                        {
                            TongCong += (int)(item2.SL * item2.SanPham.Gia);
                            lvCTHoaDon.Items.Add(new ListViewItem(new String[] {"+", item2.SanPham.tenSP, item2.SL.ToString(), item2.SanPham.Gia.ToString(), cv._ConvertMoney((item2.SL * item2.SanPham.Gia).ToString()) }));
                        }
                        ListViewItem item3 = lvCTHoaDon.Items.Add(new ListViewItem(new String[] { "Tổng Cộng", "", "", "", cv._ConvertMoney(TongCong.ToString()) }));
                        item3.BackColor = Color.FromArgb(23, 125, 57);
                        item3.ForeColor = Color.White;
                        lvCTHoaDon.Items.Add(new ListViewItem());
                    }
                }
                else
                {
                    Program.Alert("Hóa Đơn Không Có Sản Phẩm", Form_Alert.enmType.Error);
                }    
            }
            else
            {
                _Reset();
            }
        }
        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHoaDon.ForeColor == Color.White)
                _TimKiemMa();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (lvHoaDon.Items.Count > 0)
                new Form_Bill_History().ShowBill(lvHoaDon);
            else
                Program.Alert("Không Có Hóa Đơn Để In", Form_Alert.enmType.Error);
        }
    }
}
