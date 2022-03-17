using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace QuanLyPhucLong
{
    public partial class GUI_Login : Form
    {
        Entity DB = new Entity();
        public GUI_Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width, Height, 30, 30)); // bo tròn form
            if (Properties.Settings.Default.checkbox) chkLuu.Checked = true;
            if (Properties.Settings.Default.username != string.Empty)
            {
                txtUser.ForeColor = Color.White;
                txtUser.Font = new Font("Segoe UI", 12, FontStyle.Bold); ;
                txtUser.Text = Properties.Settings.Default.username;
                txtPass.Focus();
            } 
        }
        //co cung dc
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

        private void _Enable(bool e)
        {
            btnLogin.Enabled = e;
            btnForget.Enabled = e;
            txtUser.Enabled = e;
            txtPass.Enabled = e;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _Enable(false);
            if (txtUser.TextLength == 0)
            {
                _Enable(true);
                Program.Alert("Vui lòng nhập tài khoản", Form_Alert.enmType.Error);
                return;
            }
            else if (txtPass.TextLength == 0)
            {
                _Enable(true);
                Program.Alert("Vui lòng nhập mật khẩu", Form_Alert.enmType.Error);
                return;
            }
            //txtUser.Text, NV.MD5Hash(txtPass.Text)
            string passHash = MD5Hash(txtPass.Text);
            NhanVien ListNV = DB.NhanViens.FirstOrDefault(p => (p.username == txtUser.Text) && (p.matKhau == passHash));
            if (ListNV != null)
            {
                if (ListNV.trangthai != 0)
                {
                    _Enable(true);
                    Program.Alert("Tài khoản bạn đã bị khóa!", Form_Alert.enmType.Error);
                    return;
                }
                Program.Alert("Đăng nhập thành công!", Form_Alert.enmType.Success);
                if (chkLuu.Checked)
                {
                    Properties.Settings.Default.username = txtUser.Text;
                    Properties.Settings.Default.checkbox = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.username = "";
                    Properties.Settings.Default.checkbox = false;
                    Properties.Settings.Default.Save();
                }
                MainApp form = new MainApp(txtUser.Text, MD5Hash(txtPass.Text),this);
                form.Show();
                this.Hide();
                _Enable(true);
            }
            else
            {
                _Enable(true);
                Program.Alert("Sai tài khoản hoặc mật khẩu!", Form_Alert.enmType.Error);
            } 
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            new GUI_Forget(this).Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult obj = new Form_YesNo().ShowYesNo();
            if (obj == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        // ham di chuyen form custom băng panel
        private void mix(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HTCAPTION, 0);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 btnLogin_Click(sender,e);
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
                txtUser.Font = new Font("Segoe UI", 12, FontStyle.Bold); ;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Silver;
                txtUser.Font = new Font("Segoe UI", 12, FontStyle.Italic); ;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                txtPass.ForeColor = Color.White;
                txtPass.Font = new Font("Segoe UI", 12, FontStyle.Bold); ;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.Silver;
                txtPass.Font = new Font("Segoe UI", 12, FontStyle.Italic); ;
            }
        }
    }
}
