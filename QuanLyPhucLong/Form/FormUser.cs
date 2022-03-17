using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhucLong
{
    public partial class FormUser : Form
    {
        Entity DB = new Entity();
        bool IsHoTen = false;
        bool IsEmail = false;
        bool IsSDT = false;
        bool IsDiaChi = false;
        public FormUser()
        {
            InitializeComponent();
            _Enable(false);
            _Load();
        }

        void _Enable(bool e)
        {
            txtHoten.ReadOnly = !e;
            txtEmail.ReadOnly = !e;
            cbGioitinh.Enabled = e;
            dtNgaySInh.Enabled = e;
            txtSodt.ReadOnly = !e;
            txtDiachi.ReadOnly = !e;
        }

        private void _Load()
        {
            txtHoten.Text = MainApp.hoTen;
            txtEmail.Text = MainApp.email;
            switch (MainApp.gioiTinh)
            {
                case "Nam":
                    cbGioitinh.SelectedIndex = 0;
                    break;
                case "Nữ":
                    cbGioitinh.SelectedIndex = 1;
                    break;
                default:
                    cbGioitinh.SelectedIndex = 2;
                    break;
            }
            dtNgaySInh.Value = Convert.ToDateTime(MainApp.ngaySinh);
            txtSodt.Text = MainApp.sDT;
            txtDiachi.Text = MainApp.diaCh;
        }

        public string MD5Hash(string input)
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

        private string _DefaultText(string name)
        {
            switch (name)
            {
                case "txtPassOld":
                    return "Mật khẩu cũ";
                case "txtPassNew":
                    return "Mật khẩu mới";
                case "txtPassNew2":
                    return "Nhập lại mật khẩu mới";
                default:
                    return "";
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == _DefaultText(txt.Name))
            {
                txt.Text = "";
                if ((txt.Name == "txtPassOld") || (txt.Name == "txtPassNew") || (txt.Name == "txtPassNew2")) txt.UseSystemPasswordChar = true;
                txt.ForeColor = Color.White;
                txt.Font = new Font("Segoe UI", 18, FontStyle.Bold); ;
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == "")
            {
                txt.Text = _DefaultText(txt.Name);
                if ((txt.Name == "txtPassOld") || (txt.Name == "txtPassNew") || (txt.Name == "txtPassNew2")) txt.UseSystemPasswordChar = false;
                txt.ForeColor = Color.Silver;
                txt.Font = new Font("Segoe UI", 18, FontStyle.Italic); ;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtPassOld.TextLength == 0 || txtPassNew.TextLength == 0 || txtPassNew2.TextLength == 0 || txtPassOld.ForeColor == Color.Silver || txtPassNew.ForeColor == Color.Silver || txtPassNew2.ForeColor == Color.Silver)
            {
                Program.Alert("Vui lòng nhập thông tin!!", Form_Alert.enmType.Error);
                return;
            }

            if (String.Compare(txtPassNew.Text, txtPassNew2.Text, false) == 0)
            {
                if (txtPassNew.TextLength <= 15)
                {
                    if (String.Compare(MD5Hash(txtPassOld.Text), MainApp.password, false) == 0)
                    {
                        string passHash = MD5Hash(txtPassOld.Text);
                        NhanVien nv = DB.NhanViens.FirstOrDefault(p => p.username == MainApp.username && p.matKhau == passHash);
                        nv.matKhau = MD5Hash(txtPassNew.Text);
                        DB.SaveChanges();
                        Program.Alert("Bạn đã đổi mật khẩu thành công!!", Form_Alert.enmType.Success);
                        MessageBox.Show("Bạn vui lòng đăng nhập lại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    } else Program.Alert("Mật khẩu cũ không đúng!!", Form_Alert.enmType.Error);
                }else Program.Alert("Mật khẩu dài quá 15 ký tự!!", Form_Alert.enmType.Error);
            }else Program.Alert("Mật khẩu không khớp!!", Form_Alert.enmType.Error);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.IconChar == FontAwesome.Sharp.IconChar.UserEdit)
            {
                btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnLuu.Text = "Lưu";
                btnHuy.IconChar = FontAwesome.Sharp.IconChar.Trash;
                btnHuy.Text = "Hủy Bỏ";
                btnHuy.Visible = true;
                IsHoTen = true;
                IsEmail = true;
                IsSDT = true;
                IsDiaChi = true;
                _Enable(true);           
            }
            else
            {
                if (IsHoTen && IsEmail && IsSDT && IsDiaChi)
                {
                    btnLuu.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
                    btnLuu.Text = "Sửa";
                    btnHuy.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                    btnHuy.Text = "Xóa Tài Khoản";
                    _Enable(false);
                    //-------------------------------------------------
                    string Username = MainApp.username;
                    string Password = MainApp.password;
                    string HoTen = txtHoten.Text;
                    string GioiTinh = cbGioitinh.SelectedItem.ToString();
                    DateTime NgaySinh = dtNgaySInh.Value;
                    string SDT = txtSodt.Text;
                    string DiaChi = txtDiachi.Text;
                    string Email = txtEmail.Text;
                    NhanVien nv = DB.NhanViens.FirstOrDefault(p => p.username == Username && p.matKhau == Password);
                    nv.hoTen = HoTen;
                    nv.gioiTinh = GioiTinh;
                    nv.namSinh = NgaySinh;
                    nv.sdt = SDT;
                    nv.diaChi = DiaChi;
                    nv.email = Email;
                    DB.SaveChanges();
                    MainApp.hoTen = HoTen;
                    MainApp.gioiTinh = GioiTinh;
                    MainApp.ngaySinh = NgaySinh.ToShortDateString();
                    MainApp.sDT = SDT;
                    MainApp.diaCh = DiaChi;
                    MainApp.email = Email;
                    DB.SaveChanges();
                    _Load();
                    //----------------------------------------------
                    IsHoTen = false;
                    IsEmail = false;
                    IsSDT = false;
                    IsDiaChi = false;
                }
                else Program.Alert("Vui lòng nhập đúng thông tin", Form_Alert.enmType.Error);

                //----------------------------------
               
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnLuu.Text = "Sửa";
            _Enable(false);
            IsHoTen = false;
            IsEmail = false;
            IsSDT = false;
            IsDiaChi = false;
            btnHuy.Visible = false;
            errorEmail.SetError(txtEmail, null);
            errorDiaChi.SetError(txtDiachi, null);
            errorHoTen.SetError(txtHoten, null);
            errorSDT.SetError(txtSodt, null);
            _Load();
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
            if (txtHoten.TextLength > 50 || txtHoten.TextLength == 0)
            {
                errorHoTen.SetError(txtHoten, "Họ và Tên Quá 50 ký tự");
                IsHoTen = false;
                return;
            }
            errorHoTen.SetError(txtHoten, null);
            IsHoTen = true;
        }
        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            if (txtSodt.TextLength > 15 || txtSodt.TextLength == 0)
            {
                errorSDT.SetError(txtSodt, "Số Điện Thoại Quá 15 ký Tự");
                IsSDT = false;
                return;
            }
            errorSDT.SetError(txtSodt, null);
            IsSDT = true;
        }
        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiachi.TextLength > 60 || txtDiachi.TextLength == 0)
            {
                errorDiaChi.SetError(txtDiachi, "Số Điện Thoại Quá 15 ký Tự");
                IsDiaChi = false;
                return;
            }
            errorDiaChi.SetError(txtDiachi, null);
            IsDiaChi = true;
        }

        private void z(object sender, EventArgs e)
        {

        }
    }
}
