using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhucLong
{
    public partial class FormHome : Form
    {
        Entity DB = new Entity();
        ConvertMoney cv = new ConvertMoney();
        ImageList ImageLarge;
        int Sale = 0;
        MainApp mainapp;
        Image ByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void _Load()
        {
            lvSP.Items.Clear();
            ImageLarge = new ImageList();
            ImageLarge.ImageSize = new Size(191, 191);
            ImageLarge.ColorDepth = ColorDepth.Depth32Bit;
            lvSP.LargeImageList = ImageLarge;
            List<SanPham> ListSP = DB.SanPhams.ToList();
            int i = 0;
            foreach (SanPham sp in ListSP)
            {
                if (sp.loai == 0 && sp.trangthai == 0) {
                    string maSP = sp.maSP;
                    string tenSP = sp.tenSP  + "\n( "+ cv._ConvertMoney(sp.Gia.ToString())+ "vnđ )";
                    string Gia = sp.Gia.ToString();
                    byte[] photo = (byte[])sp.photo;
                    Image img = ByteToImage(photo);
                    ImageLarge.Images.Add(img);
                    String[] row = { tenSP, maSP, Gia };
                    ListViewItem item1 = new ListViewItem(row);
                    item1.ImageIndex = i;
                    item1.Tag = sp.loai;
                    lvSP.Items.Add(item1);
                    i++;
                }
            }
        }

        private int _GetGiaTien(string maSP)
        {
            foreach (ListViewItem item in lvSP.Items)
            {
                if (maSP == item.SubItems[1].Text)
                {
                    return Int32.Parse(item.SubItems[2].Text);
                }
            }
            return -1;
        }

        public FormHome(MainApp mainapp)
        {  
            InitializeComponent();
            this.mainapp = mainapp;
            txtSL.Enabled = false;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            btnThanhToan.Enabled = false;
            btnHuy.Enabled = false;
            _Load();
        }

        public bool _CheckExistHoaDon(string maSP)
        {
            foreach (ListViewItem item in lvHoaDon.Items)
            {
                if (maSP == item.SubItems[1].Text)
                {
                    return true;
                }
                
            }
            return false;
        }

        private void _ThanhToan()
        {
            int Tong = 0;
            foreach (ListViewItem item in lvHoaDon.Items)
            {
                Tong += Int32.Parse(item.SubItems[4].Text);
            }
            lbTongTamTinh.Text = cv._ConvertMoney(Tong) + " đ";
            if (Sale > 0)
            {
                lbGiamGia.Text = "-" + cv._ConvertMoney(Sale * Tong / 100) + " đ";
            }
            lbTongCong.Text = cv._ConvertMoney(Tong - (Sale * Tong / 100)) + " đ";
            if ((Tong - (Sale * Tong / 100)) > 0)
            {
                btnThanhToan.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void _Reset()
        {
            lbTongTamTinh.Text = "0 đ";
            lbGiamGia.Text = "0 đ";
            lbTongCong.Text = "0 đ";
            Sale = 0;
            lvHoaDon.Items.Clear();
            lbMaSP.Text = "Mã Sản Phẩm: ";
            lbTenSP.Text = "Tên Sản Phẩm: ";
            lbGia.Text = "Giá Tiền: ";
            txtSL.Text = "";
            txtTienNhan.Text = "0";
            lbTienThua.Text = "0 đ";
            txtSL.Enabled = false;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            btnThanhToan.Enabled = false;
            btnHuy.Enabled = false;
            txtGiamGia.Text = "Phần trăm giảm giá";
            txtGiamGia.ForeColor = Color.Silver;
            txtGiamGia.Font = new Font("Segoe UI", 12, FontStyle.Italic); ;
        }

        private int _ConvertInt(string text)
        {
            string StrNew = "";
            foreach (char item in text)
            {
                var regex = new Regex(@"[^0-9]");
                if (!regex.IsMatch(item.ToString()))
                {
                    StrNew += item.ToString();
                }
            }
            return Int32.Parse(StrNew);
        }

        void _TinhTienThua()
        {
            if (txtTienNhan.Text == "0" || txtTienNhan.Text == string.Empty)
            {
                lbTienThua.Text = "0 đ";
                return;
            }
            int tienthua = _ConvertInt(txtTienNhan.Text) - _ConvertInt(lbTongCong.Text);
            if (tienthua > 0)
                lbTienThua.Text = cv._ConvertMoney(tienthua) + " đ";
            else
                lbTienThua.Text = "0 đ";
        }

        private void lvSP_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Topping frm = new Form_Topping(this, this.mainapp);
            string size = "";
            string duong = "";
            string da = "";
            List<ChiTietTopping> ListTP = new List<ChiTietTopping>();
            if (frm._ShowTopping(ref size, ref duong, ref da, ref ListTP) == DialogResult.Cancel)
            {
                Program.Alert("Hủy Thao Tác", Form_Alert.enmType.Error);
                return;
            }
            string maSP = lvSP.SelectedItems[0].SubItems[1].Text;
            string tenSP = lvSP.SelectedItems[0].SubItems[0].Text;
            int GiaTopping = 0;
            foreach (ChiTietTopping item1 in ListTP)
            {
                GiaTopping += (int)DB.SanPhams.FirstOrDefault(p => p.maSP == item1.maSP).Gia * (int)item1.SL;
            }

            int Gia = Int32.Parse(lvSP.SelectedItems[0].SubItems[2].Text);
            int count = lvHoaDon.Items.Count;

            String[] row = {(count + 1).ToString(), maSP, tenSP, "1", (Gia + GiaTopping).ToString(), size, duong, da };
            ListViewItem item = new ListViewItem(row);
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Tag = ListTP});
            lvHoaDon.Items.Add(item); 
                
            Program.Alert("Chọn " + tenSP, Form_Alert.enmType.Success);

            _ThanhToan();
            _TinhTienThua();
            lbMaSP.Text = "Mã Sản Phẩm: ";
            lbTenSP.Text = "Tên Sản Phẩm: ";
            lbGia.Text = "Giá Tiền: ";
            txtSL.Text = "";
            txtSL.Enabled = false;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void lvHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count > 0)
            {
                string stt = lvHoaDon.SelectedItems[0].SubItems[0].Text;
                string maSP = lvHoaDon.SelectedItems[0].SubItems[1].Text;
                string tenSP = lvHoaDon.SelectedItems[0].SubItems[2].Text;
                string SL = lvHoaDon.SelectedItems[0].SubItems[3].Text;
                string Gia = lvHoaDon.SelectedItems[0].SubItems[4].Text;
                lbMaSP.Text = "Mã Sản Phẩm: " + maSP;
                lbTenSP.Text = "Tên Sản Phẩm: " + tenSP;
                lbGia.Text = "Giá Tiền: " + Gia;
                txtSL.Text = SL;
                txtSL.Enabled = true;
                btnRemove.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count == 0)
            {
                lbMaSP.Text = "Mã Sản Phẩm: ";
                lbTenSP.Text = "Tên Sản Phẩm: ";
                lbGia.Text = "Giá Tiền: ";
                txtSL.Text = "";
                txtSL.Enabled = false;
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSL.Text == string.Empty)
            {
                Program.Alert("Vui Lòng Nhập Số Lượng", Form_Alert.enmType.Error);
                return;
            }
            if (lvHoaDon.SelectedItems.Count > 0)
            {

                if (lbMaSP.Text == "Mã Sản Phẩm: " + lvHoaDon.SelectedItems[0].SubItems[1].Text)
                {
                    int gia = _GetGiaTien(lvHoaDon.SelectedItems[0].SubItems[1].Text);
                    int GiaTopping = 0;
                    foreach (ChiTietTopping item1 in (List<ChiTietTopping>)lvHoaDon.SelectedItems[0].SubItems[8].Tag)
                    {
                        GiaTopping += (int)DB.SanPhams.FirstOrDefault(p => p.maSP == item1.maSP).Gia * (int)item1.SL;
                    }
                    if (gia != -1)
                    {
                        if (Int32.Parse(txtSL.Text) > 0)
                        {
                            lvHoaDon.SelectedItems[0].SubItems[3].Text = txtSL.Text;
                            lvHoaDon.SelectedItems[0].SubItems[4].Text = (Int32.Parse(txtSL.Text) * (gia + GiaTopping)).ToString();
                            lbMaSP.Text = "Mã Sản Phẩm: ";
                            lbTenSP.Text = "Tên Sản Phẩm: ";
                            lbGia.Text = "Giá Tiền: ";
                            txtSL.Text = "";
                            txtSL.Enabled = false;
                            btnRemove.Enabled = false;
                            btnEdit.Enabled = false;
                            Program.Alert("Đã Chỉnh Sửa Sản Phẩm", Form_Alert.enmType.Success);
                            
                        }
                        else
                        {
                            lvHoaDon.Items.Remove(lvHoaDon.SelectedItems[0]);
                        }
                        _ThanhToan();
                        _TinhTienThua();
                    }
                    else
                    {
                        Program.Alert("Lỗi Giá Sản Phẩm", Form_Alert.enmType.Error);
                    }
                }
                else
                {
                    Program.Alert("Mã Sản Phẩm Không Khớp", Form_Alert.enmType.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count > 0)
            {
                lvHoaDon.Items.Remove(lvHoaDon.SelectedItems[0]);
                lbMaSP.Text = "Mã Sản Phẩm: ";
                lbTenSP.Text = "Tên Sản Phẩm: ";
                lbGia.Text = "Giá Tiền: ";
                txtSL.Text = "";
                txtSL.Enabled = false;
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
                Program.Alert("Đã Xóa Sản Phẩm", Form_Alert.enmType.Success);
                _ThanhToan();
                _TinhTienThua();
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtGiamGia_Leave(object sender, EventArgs e)
        {
            if (txtGiamGia.Text == "")
            {
                txtGiamGia.ForeColor = Color.Silver;
                txtGiamGia.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                txtGiamGia.Text = "Phần trăm giảm giá";
            }
        }

        private void txtGiamGia_Enter(object sender, EventArgs e)
        {
            if (txtGiamGia.Text == "Phần trăm giảm giá")
            {
                txtGiamGia.ForeColor = Color.White;
                txtGiamGia.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                txtGiamGia.Text = "";
            }
        }
        
        private void btnApDung_Click(object sender, EventArgs e)
        {
            int result;
            if (Int32.TryParse(txtGiamGia.Text, out result))
            {
                if (result < 0 || result > 100){
                    Program.Alert("Không thể áp dụng", Form_Alert.enmType.Error);
                }
                else
                {
                    lbKhuyenMai.Text = "Khuyễn Mãi: (" + result.ToString() + "%)";
                    Sale = result;
                    _ThanhToan();
                    _TinhTienThua();
                }
            }
            else
            {
                Program.Alert("Không thể áp dụng", Form_Alert.enmType.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _Reset();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // THANH TOAN HOA DON VAO DATABASE
            PhieuXuat px = new PhieuXuat();
            px.username = MainApp.username;
            px.thanhToan = _ConvertInt(lbTongCong.Text);
            px.tienThu = _ConvertInt(txtTienNhan.Text);
            px.tienTra = _ConvertInt(lbTienThua.Text);
            px.uuDai = Sale;
            px.ngayXuat = DateTime.Now;
            DB.PhieuXuats.Add(px);
            DB.SaveChanges();
            int maPhieuXuat = px.maPhieuXuat;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SL", typeof(string));
            dt.Columns.Add("Gia", typeof(string));
            int index = 0;
            int Gia = 0;
            foreach (ListViewItem item in lvHoaDon.Items)
            {
                index += 1;
                string maSP = item.SubItems[1].Text;
                int SL = Int32.Parse(item.SubItems[3].Text);
                CTPhieuXuat ctpx = new CTPhieuXuat();
                ctpx.maPhieuXuat = maPhieuXuat;
                ctpx.maSP = maSP;
                ctpx.soLuong = SL;
                ctpx.size = item.SubItems[5].Text == "S" ? 0 : 1;
                ctpx.duong = Int32.Parse(item.SubItems[6].Text);
                ctpx.da = Int32.Parse(item.SubItems[7].Text);
                DB.CTPhieuXuats.Add(ctpx);
                dt.Rows.Add(index.ToString(), ctpx.SanPham.tenSP, cv._ConvertMoney(ctpx.soLuong.ToString()), cv._ConvertMoney((ctpx.soLuong * ctpx.SanPham.Gia).ToString()));
                Gia += (int)(ctpx.soLuong * ctpx.SanPham.Gia);
                dt.Rows.Add("+", string.Concat("Size: ", ctpx.size, ", Đường: ", ctpx.duong, ", Đá: ", ctpx.da), "0", "0");
                foreach (ChiTietTopping item1 in (List<ChiTietTopping>)item.SubItems[8].Tag)
                {
                    ChiTietTopping cttp = new ChiTietTopping();
                    cttp.ID = ctpx.ID;
                    cttp.maSP = item1.maSP;
                    cttp.SL = item1.SL;
                    DB.ChiTietToppings.Add(cttp);
                    dt.Rows.Add("+",cttp.SanPham.tenSP, cv._ConvertMoney(cttp.SL.ToString()), cv._ConvertMoney((cttp.SL * cttp.SanPham.Gia).ToString()));
                    Gia += (int)(cttp.SL * cttp.SanPham.Gia);
                }
                DB.SaveChanges();
            } 
            Program.Alert("Đã Thanh Toán", Form_Alert.enmType.Success);
            // IN BILL
                new Form_Bill().ShowBill(dt,"Nhân Viên: " + MainApp.hoTen, "Mã Hóa Đơn: #" +px.maPhieuXuat.ToString(),"Ngày Xuất HĐ: " + px.ngayXuat.Value.ToString("dd/MM/yyyy - HH:mm:ss"),lbTongTamTinh.Text,lbKhuyenMai.Text,lbTongCong.Text,txtTienNhan.Text,lbTienThua.Text);
            //
            _Reset();
        }

        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtTienNhan.Text == string.Empty)
            {
                txtTienNhan.Text = "0";
                return;
            }
            txtTienNhan.Text = cv._ConvertMoney(txtTienNhan.Text);
            txtTienNhan.Select(txtTienNhan.Text.Length, 0);
            _TinhTienThua();
        }

        private void lvHoaDon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem item = lvHoaDon.SelectedItems[0];

                Form_Topping frm = new Form_Topping(this, this.mainapp);
                string size = item.SubItems[5].Text;
                string duong = item.SubItems[6].Text;
                string da = item.SubItems[7].Text;
                List<ChiTietTopping> ListTP = (List<ChiTietTopping>)item.SubItems[8].Tag;
                if (frm._ShowTopping(ref size, ref duong, ref da, ref ListTP) == DialogResult.Cancel)
                {
                    Program.Alert("Hủy Thao Tác", Form_Alert.enmType.Error);
                    return;
                }
                int gia = _GetGiaTien(lvHoaDon.SelectedItems[0].SubItems[1].Text);
                int GiaTopping = 0;
                foreach (ChiTietTopping item1 in ListTP)
                {
                    GiaTopping += (int)DB.SanPhams.FirstOrDefault(p => p.maSP == item1.maSP).Gia * (int)item1.SL;
                }
                item.SubItems[4].Text = (gia + GiaTopping).ToString();
                item.SubItems[5].Text = size;
                item.SubItems[6].Text = duong;
                item.SubItems[7].Text = da;
                item.SubItems[8].Tag = ListTP;
                Program.Alert("Sửa đơn hàng thành công!", Form_Alert.enmType.Success);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbTenSP_Click(object sender, EventArgs e)
        {

        }
    }
}
