using QuanLyPhucLong.Properties;
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
    public partial class FormAdd : Form
    {
        Entity DB = new Entity();
        ImageList ImageLarge;
        bool cothem = false;
        bool IsMaSP = false;
        bool IsTenSP = false;
        bool clickanh = false;
        public FormAdd()
        {
            InitializeComponent();
            cbLoai.Text = "Thực Phẩm";
            ButtonEnable(true);  
            _Load();
        }

        Image ByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private byte[] ConvertImage(Image img)
        {
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            return arr;
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
                if  (sp.trangthai == 0)
                {
                    string ID = sp.ID.ToString();
                    string maSP = sp.maSP;
                    string tenSP = sp.tenSP;
                    string Gia = sp.Gia.ToString();
                    byte[] photo = (byte[])sp.photo;
                    Image img = ByteToImage(photo);
                    ImageLarge.Images.Add(img);
                    String[] row = { tenSP, ID, maSP, Gia };
                    ListViewItem item1 = new ListViewItem(row);
                    item1.ImageIndex = i;
                    lvSP.Items.Add(item1);
                    i++;
                }  
            }
        }

        private void ButtonEnable(bool e)
        {
            btnThem.Enabled = e; btnThem.Visible = e;
            btnSua.Enabled = e; btnSua.Visible = e;
            btnXoa.Enabled = e; btnXoa.Visible = e;
            btnAnh.Enabled = !e;
            txtTenSP.ReadOnly = e;
            txtMaSP.ReadOnly = e;
            txtGia.ReadOnly = e;
            cbLoai.Enabled = !e;
            btnLuu.Enabled = !e; btnLuu.Visible = !e;
            btnKLuu.Enabled = !e; btnKLuu.Visible = !e;
        }

        private bool HasSpecialChars(string yourString)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (regexItem.IsMatch(yourString))
            {
                return false;
            }
            return true;
        }

        public static bool HasSpecialChars_VN(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_," + "\"";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        private void SetNull()
        {
            lbID.Text = "ID: Chưa Có";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGia.Text = "";
            cbLoai.Text = "Thực Phẩm";
            pbAnh.Image = Resources._default;
            IsMaSP = false;
            IsTenSP = false;
            cothem = false;
            clickanh = false;
            txtMaSP.Focus();
        }

        private void lvSP_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvSP.SelectedItems.Count > 0)
            {
                ButtonEnable(true);
                SetNull();
                string ID = lvSP.SelectedItems[0].SubItems[1].Text;
                string maSP = lvSP.SelectedItems[0].SubItems[2].Text;
                string tenSP = lvSP.SelectedItems[0].SubItems[0].Text;
                string Gia = lvSP.SelectedItems[0].SubItems[3].Text;
                // Click hien thong tin
                int id = Int32.Parse(ID);
                SanPham sp = DB.SanPhams.FirstOrDefault(p => p.ID == id);
                lbID.Text = "ID: " + ID;
                txtMaSP.Text = maSP;
                txtTenSP.Text = tenSP;
                txtGia.Text = Gia;
                cbLoai.Text = sp.loai == 0 ? "Thực Phẩm" : "Topping";              
                pbAnh.Image = ByteToImage((byte[])sp.photo);
                pbAnh.Tag = (byte[])sp.photo;
                Program.Alert("Đã chọn " + tenSP, Form_Alert.enmType.Success);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ButtonEnable(false);
            SetNull();
            cothem = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lbID.Text != "ID: Chưa Có") {
                ButtonEnable(false);
                IsMaSP = true;
                IsTenSP = true;
                cothem = false;
            }
            else
            {
                Program.Alert("Vui lòng chọn 1 Sản Phẩm", Form_Alert.enmType.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lbID.Text != "ID: Chưa Có")
            {
                ButtonEnable(true);
                SetNull();
                int id = Int32.Parse(lvSP.SelectedItems[0].SubItems[1].Text);
                string tenSP = lvSP.SelectedItems[0].SubItems[0].Text;
                SanPham sp = DB.SanPhams.FirstOrDefault(p => p.ID == id);
                sp.trangthai = 1;
                DB.SaveChanges();
                _Load();
                Program.Alert("Đã Xóa " + tenSP, Form_Alert.enmType.Success);
            }
            else
            {
                Program.Alert("Vui lòng chọn 1 Sản Phẩm", Form_Alert.enmType.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (IsMaSP && IsTenSP && txtGia.TextLength > 0)
            {
                ButtonEnable(true);
                if (cothem)
                {
                    // THEM
                    string maSP = txtMaSP.Text;
                    string tenSP = txtTenSP.Text;
                    string giaSP = txtGia.Text;
                    Image anh = pbAnh.Image;
                    SanPham sp = new SanPham();
                    sp.maSP = maSP;
                    sp.tenSP = tenSP;
                    sp.Gia = Int32.Parse(giaSP);
                    sp.photo = ConvertImage(anh);
                    sp.loai = cbLoai.SelectedItem.ToString() == "Thực Phẩm" ? 0 : 1;
                    DB.SanPhams.Add(sp);
                    Program.Alert("Đã thêm " + tenSP, Form_Alert.enmType.Success);
                }
                else
                {
                    // SUA
                    string ID = lbID.Text.Replace("ID: ", string.Empty);
                    string maSP = txtMaSP.Text;
                    string tenSP = txtTenSP.Text;
                    string giaSP = txtGia.Text;
                    Image anh = pbAnh.Image;
                    int id = Int32.Parse(ID);
                    SanPham sp = DB.SanPhams.FirstOrDefault(p => p.ID == id);
                    sp.maSP = maSP;
                    sp.tenSP = tenSP;
                    sp.Gia = Int32.Parse(giaSP);
                    if (clickanh)
                        sp.photo = ConvertImage(anh);
                    else
                        sp.photo = (byte[])pbAnh.Tag;
                    sp.loai = cbLoai.SelectedItem.ToString() == "Thực Phẩm" ? 0 : 1;
                    Program.Alert("Đã Sửa " + tenSP, Form_Alert.enmType.Success);
                }
                DB.SaveChanges();
                _Load();
                SetNull();
                cothem = false;
            }
            else
            {
                Program.Alert("Vui lòng nhập đúng:)", Form_Alert.enmType.Error);
            }
        }

        private bool _CheckSP(string MaSP)
        {
            SanPham sp = DB.SanPhams.FirstOrDefault(p=>p.maSP == MaSP);
            if (sp == null) return false;
            return true;
        }

        private void btnKLuu_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            SetNull();
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.bmp)|*.png; *.jpg; *.jpeg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbAnh.Image = Bitmap.FromFile(open.FileName);
                clickanh = true;
            }
        }

        private void txtMaSP_Validating(object sender, CancelEventArgs e)
        {
            if (txtMaSP.TextLength == 0) IsMaSP = false;
            if (txtMaSP.TextLength > 5)
            {
                errorMaSP.SetError(txtMaSP, "Mã Sản Phẩm Quá 5 Ký Tự");
                IsMaSP = false;
            }
            else if (HasSpecialChars(txtMaSP.Text))
            {
                errorMaSP.SetError(txtMaSP, "Mã Sản Phẩm Có Ký Tự Đặc Biệt");
                IsMaSP = false;
            }
            else if (_CheckSP(txtMaSP.Text))
            {
                errorMaSP.SetError(txtMaSP, "Mã Sản Phẩm Đã Tồn Tại");
                IsMaSP = false;
            }
            else
            {
                errorMaSP.SetError(txtMaSP, null);
                IsMaSP = true;
            }
        }

        private void txtTenSP_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenSP.TextLength == 0) IsTenSP = false;
            if (txtTenSP.TextLength > 30)
            {
                errorTenSP.SetError(txtTenSP, "Tên Sản Phẩm Quá 30 Ký Tự");
                IsTenSP = false;
            }
            else if (HasSpecialChars_VN(txtTenSP.Text))
            {
                errorTenSP.SetError(txtTenSP, "Tên Sản Phẩm Có Ký Tự Đặc Biệt");
                IsTenSP = false;
            }
            else
            {
                errorTenSP.SetError(txtTenSP, null);
                IsTenSP = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            Form_MonAn frm = new Form_MonAn();
            frm.Show();
        }
    }
}
