using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace QuanLyPhucLong
{
    public partial class GUI_Forget : Form
    {
        Entity DB;
        private Form formLogin;

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

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void _return()
        {
            formLogin.Show();
            this.Close();
        }

        public GUI_Forget(Form form)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));//bo vien
            DB = new Entity();
            formLogin = form;
            form.Hide();
        }

        private void mix(object sender, MouseEventArgs e)//move
        {
            Program.ReleaseCapture();
            Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HTCAPTION, 0);
        }

        private void CancelX_Click(object sender, EventArgs e)
        {
            _return();
        }
        private string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void _SendSMS(string gmail, string passwordnew)
        {
            try
            {
                MailMessage message = new MailMessage("phuclongofficial@gmail.com", gmail);
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("phuclongofficial@gmail.com", "phuclong0402");
                message.Subject = "Khôi Phục Mật Khẩu Của Quản Lý Phúc Long";
                message.Body = "Mật khẩu khôi phục của bạn là: " + passwordnew;
                mailclient.Send(message);
                _return();
                Program.Alert("Mật khẩu khôi phục đã gửi qua Mail", Form_Alert.enmType.Success);
            }
            catch (Exception ex)
            {
                Program.Alert("Lỗi Khôi Phục", Form_Alert.enmType.Success);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
                txtEmail.Font = new Font("Segoe UI", 12, FontStyle.Italic); ;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.White;
                txtEmail.Font = new Font("Segoe UI", 12, FontStyle.Bold); ;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Tên tài khoản";
                txtUser.ForeColor = Color.Silver;
                txtUser.Font = new Font("Segoe UI", 12, FontStyle.Italic); ;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Tên tài khoản")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
                txtUser.Font = new Font("Segoe UI", 12, FontStyle.Bold); ;
            }
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            if (txtUser.TextLength == 0 || txtEmail.TextLength == 0 || txtEmail.ForeColor == Color.Silver || txtUser.ForeColor == Color.Silver)
            {
                Program.Alert("Vui lòng nhập thông tin!!", Form_Alert.enmType.Error);
                return;
            }
            NhanVien nv = DB.NhanViens.FirstOrDefault(p => p.username == txtUser.Text && p.email == txtEmail.Text);
            if (nv != null)
            {
                string pass = CreatePassword(6);
                nv.matKhau = MD5Hash(pass);
                DB.SaveChanges();
                _SendSMS(txtEmail.Text, pass);
            }
            else
            {
                Program.Alert("Tài khoản và Mail Không Khớp", Form_Alert.enmType.Error);
            }
        }
    }
}
