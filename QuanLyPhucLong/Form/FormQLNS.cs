using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhucLong
{
    public partial class FormQLNS : Form
    {
        Entity DB = new Entity();
        private bool IsUser = false;
        private bool IsEmail = false;
        private bool IsPass = false;
        private bool IsHoTen = false;
        private bool IsSDT = false;
        private bool IsDiaChi = false;
        private bool cothem = false;
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public void _Enable(bool e)
        {
            txtUser.ReadOnly = !e;
            txtPass.ReadOnly = !e;
            txtPass2.ReadOnly = !e;
            txtEmail.ReadOnly = !e;
            txtDiaChi.ReadOnly = !e;
            txtHoTen.ReadOnly = !e;
            txtSDT.ReadOnly = !e;
            cbGioiTinh.Enabled = e;
            cbChucVu.Enabled = e;
            Date_NS.Enabled = e;
            btnLuu.Enabled = e; btnLuu.Visible = e;
            btnKLuu.Enabled = e; btnKLuu.Visible = e;
            btnThem.Enabled = !e; btnThem.Visible = !e;
            btnXoa.Enabled = !e; btnXoa.Visible = !e;
            btnSua.Enabled = !e; btnSua.Visible = !e;
        }
        public FormQLNS()
        {
            InitializeComponent();
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.SelectedIndex = 2;
            cbChucVu.SelectedIndex = 0;
            _Enable(false);
            _DangKy(false);
            _Load();
        }
        private void _Load()
        {
            lvNV.Items.Clear();
            //DataTable dt = NV._GetDSNV();
            List<NhanVien> ListNV = DB.NhanViens.ToList();
            foreach (NhanVien nv in ListNV)
            {
                if (nv.trangthai == 0)
                {
                    string ID = nv.ID.ToString();
                    string username = nv.username;
                    string email = nv.email;
                    string hoTen = nv.hoTen;
                    string gioiTinh = nv.gioiTinh;
                    string namSinh = Convert.ToDateTime(nv.namSinh.ToString()).ToString("dd/MM/yyyy");
                    string sdt = nv.sdt;
                    string diaChi = nv.diaChi;
                    string chucvu = nv.chucvu;
                    chucvu = chucvu == "admin" ? "Quản Lý" : "Nhân Viên";
                    String[] row = { ID, username, email, hoTen, gioiTinh, namSinh, sdt, diaChi, chucvu };
                    ListViewItem item1 = new ListViewItem(row);
                    lvNV.Items.Add(item1);
                }     
            }
        }
        private void SetNull()
        {
            txtUser.Text = "Tên tài khoản";
            txtPass.Text = "Mật khẩu";
            txtPass2.Text = "Xác nhận mật khẩu";
            txtEmail.Text = "Email";
            txtDiaChi.Text = "Địa chỉ";
            txtHoTen.Text = "Họ và tên";
            txtSDT.Text = "Số điện thoại";
            txtUser.Text = "Tên tài khoản";
            ID.Text = "";
            cbGioiTinh.SelectedIndex = 2;
            cbChucVu.SelectedIndex = 0;
            Date_NS.Value = DateTime.Now;
            _DangKy(false);
            _ChangeAllTxt(false);
            IsUser = false;
            IsEmail = false;
            IsPass = false;
            IsHoTen = false;
            IsSDT = false;
            IsDiaChi = false;
            cothem = false;
            errorDiaChi.SetError(txtDiaChi, null);
            errorEmail.SetError(txtEmail, null);
            errorHoTen.SetError(txtHoTen, null);
            errorPass.SetError(txtPass, null);
            errorPass2.SetError(txtPass2, null);
            errorSDT.SetError(txtSDT, null);
            errorUser.SetError(txtUser, null);
        }
        private void _ChangeAllTxt(bool e)
        {
            foreach (var item in panel.Controls)
            {
                if (item is TextBox)
                {
                    _ChangeTxt((TextBox)item, e);
                }      
            }
        }
        private bool HasSpecialChars(string yourString)
        {
            var regexItem = new Regex("^[a-zA-Z0-9]*$");

            if (regexItem.IsMatch(yourString))
            {
                return false;
            }
            return true;
        }
        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (txtUser.TextLength > 15)
            {
                errorUser.SetError(txtUser, "Tên tài khoản quá 15 ký tự");
                IsUser = false;
                return;
            }
            List<NhanVien> ListNV = DB.NhanViens.Where(p => p.username == txtUser.Text).ToList();
            if (ListNV.Count > 0 && cothem == true)
            {
                errorUser.SetError(txtUser, "Tên Đăng Nhập Đã Có Người Sử Dụng!");
                IsUser = false;
            }
            else
            {
                errorUser.SetError(txtUser, null);
                IsUser = true;
            }
            if (txtUser.ForeColor == Color.Silver)
            {
                errorUser.SetError(txtUser, null);
                IsUser = false;
            }
            else
            {
                if (HasSpecialChars(txtUser.Text))
                {
                    errorUser.SetError(txtUser, "Tên tài khoản có ký tự đặc biệt!");
                    IsUser = false;
                    return;
                }
            }
        }
        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass.TextLength < 6 || txtPass2.TextLength < 6)
            {
                errorPass.SetError(txtPass, "Mật khẩu ít nhất 6 ký tự");
                IsPass = false;
                return;
            }
            if (txtPass.TextLength != 0 && txtPass2.TextLength != 0)
            {
                if ((String.Compare(txtPass.Text, txtPass2.Text, false) == 0) && (txtPass.ForeColor == Color.White) && (txtPass2.ForeColor == Color.White))
                {
                    errorPass.SetError(txtPass, null);
                    errorPass2.SetError(txtPass2, null);
                    IsPass = true;
                }
                else
                {
                    errorPass.SetError(txtPass, "Mật Khẩu Không Khớp!!");
                    errorPass2.SetError(txtPass2, "Mật Khẩu Không Khớp!!");
                    IsPass = false;
                }
            }
            else
            {
                errorPass.SetError(txtPass, null);
                errorPass2.SetError(txtPass2, null);
                IsPass = false;
            }
            if (txtPass.ForeColor == Color.Silver)
            {
                errorPass.SetError(txtPass, null);
                errorPass2.SetError(txtPass2, null);
                IsPass = false;
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.TextLength > 50 || txtEmail.TextLength == 0)
            {
                errorEmail.SetError(txtEmail, "Email Quá 50 Ký Tự");
                IsEmail = false;
                return;
            }

            if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
            {
                errorEmail.SetError(txtEmail, null);
                IsEmail = true;
            }
            else
            {
                errorEmail.SetError(txtEmail, "Địa Chỉ Email Không Đúng");
                IsEmail = false;
            }
            if (txtEmail.ForeColor == Color.Silver)
            {
                errorEmail.SetError(txtEmail, null);
                IsEmail = false;
            }
        }
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (txtHoTen.TextLength > 50 || txtHoTen.TextLength == 0)
            {
                errorHoTen.SetError(txtHoTen, "Họ và Tên Quá 50 ký tự");
                IsHoTen = false;
                return;
            }
            IsHoTen = true;
            errorHoTen.SetError(txtHoTen, null);
        }
        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            if (txtSDT.TextLength > 15 || txtSDT.TextLength == 0)
            {
                errorSDT.SetError(txtSDT, "Số Điện Thoại Quá 15 ký Tự");
                IsSDT = false;
                return;
            }
            IsSDT = true;
            errorSDT.SetError(txtSDT, null);
        }
        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiaChi.TextLength > 60 || txtDiaChi.TextLength == 0)
            {
                errorDiaChi.SetError(txtDiaChi, "Số Điện Thoại Quá 60 ký Tự");
                IsDiaChi = false;
                return;
            }
            IsDiaChi = true;
            errorDiaChi.SetError(txtDiaChi, null);
        }
        private string _DefaultText(string name)
        {
            switch (name)
            {
                case "txtUser":
                    return "Tên tài khoản";
                case "txtPass":
                    return "Mật khẩu";
                case "txtPass2":
                    return "Xác nhận mật khẩu";
                case "txtEmail":
                    return "Email";
                case "txtDiaChi":
                    return "Địa chỉ";
                case "txtHoTen":
                    return "Họ và tên";
                case "txtSDT":
                    return "Số điện thoại";
                default:
                    return "";
            }
        }
        private void _DangKy(bool e)
        {
            label2.Text = e ? "Đăng Ký Nhân Viên" : "Thông Tin Nhân Viên";
            iconPictureBox2.Visible = e;
            txtPass.Enabled = e; txtPass.Visible = e;
            panel10.Visible = e;

            iconPictureBox3.Visible = e;
            txtPass2.Enabled = e; txtPass2.Visible = e;
            panel9.Visible = e;
        }
        private void _ChangeTxt(TextBox txt,bool e)
        {
            if (e)
            {
                if ((txt.Name == "txtPass") || (txt.Name == "txtPass2")) txt.UseSystemPasswordChar = true;
                txt.ForeColor = Color.White;
                txt.Font = new Font("Segoe UI", 12, FontStyle.Bold); ;
            }
            else
            {
                if ((txt.Name == "txtPass") || (txt.Name == "txtPass2")) txt.UseSystemPasswordChar = false;
                txt.ForeColor = Color.Silver;
                txt.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            }
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == _DefaultText(txt.Name))
            {
                txt.Text = "";
                _ChangeTxt(txt, true);
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == "")
            {
                txt.Text = _DefaultText(txt.Name);
                _ChangeTxt(txt, false);
            }
        }
        private void _Edit()
        {
            if (lvNV.SelectedItems.Count > 0)
            {
                if (!IsPass || !IsEmail || !IsHoTen || !IsSDT || !IsDiaChi)
                {
                    Program.Alert("Vui Lòng Nhập Đúng Thông Tin!!", Form_Alert.enmType.Error);
                    return;
                }
                string Email = txtEmail.Text;
                string DiaChi = txtDiaChi.Text;
                string HoTen = txtHoTen.Text;
                string SDT = txtSDT.Text;
                string GioiTinh = cbGioiTinh.SelectedItem.ToString();
                DateTime NgaySinh = Date_NS.Value;
                string ChucVu = (cbChucVu.SelectedItem.ToString() == "Quản Lý") ? "admin" : "mod";
                //NV._Edit_QL(HoTen, GioiTinh, NgaySinh, SDT, DiaChi, Email, ChucVu, );
                int id = Int32.Parse(ID.Text);
                NhanVien nv = DB.NhanViens.FirstOrDefault(p => p.ID == id);
                nv.hoTen = HoTen;
                nv.gioiTinh = GioiTinh;
                nv.namSinh = NgaySinh;
                nv.sdt = SDT;
                nv.diaChi = DiaChi;
                nv.email = Email;
                nv.chucvu = ChucVu;
                DB.SaveChanges();
                _Load();
            }
            else Program.Alert("Vui lòng chọn 1 nhân viên", Form_Alert.enmType.Error);
        }
        private void _Reg()
        {
            if (!IsUser || !IsPass || !IsEmail || !IsHoTen || !IsSDT || !IsDiaChi)
            {
                Program.Alert("Vui Lòng Nhập Đúng Thông Tin!!", Form_Alert.enmType.Error);
                _Enable(true);
                return;
            }
            string Username = txtUser.Text;
            if (DB.NhanViens.Where(p => p.username == Username).ToList().Count > 0) return;
            string Password = txtPass.Text;
            string Email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            string HoTen = txtHoTen.Text;
            string SDT = txtSDT.Text;
            string GioiTinh = cbGioiTinh.SelectedItem.ToString();
            DateTime NgaySinh = Date_NS.Value;
            string ChucVu = (cbChucVu.SelectedItem.ToString() == "Quản Lý") ? "admin" : "mod";
            NhanVien nv = new NhanVien();
            nv.username = Username;
            nv.matKhau = MD5Hash(Password);
            nv.hoTen = HoTen;
            nv.gioiTinh = GioiTinh;
            nv.namSinh = NgaySinh;
            nv.sdt = SDT;
            nv.diaChi = DiaChi;
            nv.email = Email;
            nv.chucvu = ChucVu;
            DB.NhanViens.Add(nv);
            DB.SaveChanges();
            _Load();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _Enable(true);
            SetNull();
            cothem = true;
            _DangKy(true);
            _ChangeAllTxt(false);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvNV.SelectedItems.Count > 0 && txtUser.Text != "Tên tài khoản")
            {
                _Enable(true);
                _ChangeAllTxt(true);
                IsUser = true;
                IsEmail = true;
                IsPass = true;
                IsHoTen = true;
                IsSDT = true;
                IsDiaChi = true;
                txtUser.ReadOnly = true;
                cothem = false;
            }
            else Program.Alert("Vui lòng chọn 1 nhân viên", Form_Alert.enmType.Error);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNV.SelectedItems.Count > 0)
            {
                string user = lvNV.SelectedItems[0].SubItems[1].Text;
                NhanVien nv = DB.NhanViens.FirstOrDefault(p => p.username == user);
                nv.trangthai = 1;
                DB.SaveChanges();
                _Load();
            }
            else Program.Alert("Vui lòng chọn 1 nhân viên", Form_Alert.enmType.Error);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cothem)
            {
                _Reg();
            }
            else
            {
                _Edit();
            }
            _Enable(false);
            SetNull();
        }
        private void btnKLuu_Click(object sender, EventArgs e)
        {
            cothem = false;
            _Enable(false);
            SetNull();
        }
        private void lvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNV.SelectedItems.Count > 0)
            {
                ID.Text = lvNV.SelectedItems[0].SubItems[0].Text;
                txtUser.Text = lvNV.SelectedItems[0].SubItems[1].Text;
                txtEmail.Text = lvNV.SelectedItems[0].SubItems[2].Text;
                txtHoTen.Text = lvNV.SelectedItems[0].SubItems[3].Text;
                string GioiTinh = lvNV.SelectedItems[0].SubItems[4].Text;
                cbGioiTinh.SelectedIndex = (GioiTinh == "Nam") ? 0 : (GioiTinh == "Nữ") ? 1 : (GioiTinh == "Khác") ? 2 : 0;
                Date_NS.Value = DateTime.ParseExact(lvNV.SelectedItems[0].SubItems[5].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                txtSDT.Text = lvNV.SelectedItems[0].SubItems[6].Text;
                txtDiaChi.Text = lvNV.SelectedItems[0].SubItems[7].Text;
                cbChucVu.SelectedIndex = (lvNV.SelectedItems[0].SubItems[8].Text == "Quản Lý") ? 1 : 0;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            new Form_RPDSNV().Show();
        }
    }
}

