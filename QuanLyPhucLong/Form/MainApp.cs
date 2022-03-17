using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QuanLyPhucLong
{
    public partial class MainApp : Form
    {
        Entity DB = new Entity();
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        GUI_Login frmlogin;
        //============================================
        public static string username;
        public static string password;
        public static string email;
        public static string diaCh;
        public static string hoTen;
        public static string sDT;
        public static string gioiTinh;
        public static string ngaySinh;
        public static string chucvu;

        //=============================================
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        public MainApp(string user, string pass, GUI_Login frmlogin)
        {

            NhanVien nv = DB.NhanViens.FirstOrDefault(p => p.username == user && p.matKhau == pass);
            username = nv.username;
            password = nv.matKhau;
            email = nv.email;
            diaCh = nv.diaChi;
            hoTen = nv.hoTen;
            sDT = nv.sdt;
            gioiTinh = nv.gioiTinh;
            ngaySinh = nv.namSinh.ToString();
            chucvu = nv.chucvu;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            btnHoTen.Text = hoTen;
            if (chucvu == "admin")
            {
                btnAddFood.Enabled = true; btnAddFood.Visible = true;
                btnQLNS.Enabled = true; btnQLNS.Visible = true;
            }
            this.frmlogin = frmlogin;
            timer.Start();
        }

        public MainApp()
        {
            InitializeComponent();
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(23, 80, 57);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(23, 105, 57);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult obj = new Form_YesNo().ShowYesNo();
            if (obj == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormHome(this));
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormHistory());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormUser());
        }

        
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormAdd());
        }
        
        private void btnQLNS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormQLNS());
        }
        
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Giới Thiệu Phúc Long";
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private string _FormatDayOfWeek(string thu)
        {
            switch (thu.ToLower())
            {
                case "monday":
                    return "Thứ Hai";
                case "tuesday":
                    return "Thứ Ba";
                case "wednesday":
                    return "Thứ Tư";
                case "thursday":
                    return "Thứ Năm";
                case "friday":
                    return "Thứ Sáu";
                case "saturday":
                    return "Thứ Bảy";
                case "sunday":
                    return "Chủ Nhật";
                default:
                    return "";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbtime.Text = date.ToString("HH:mm:ss");
            string thu = date.ToString("dddd");
            string ngay = date.ToString("dd");
            string thang = date.ToString("MM");
            string nam = date.ToString("yyyy");
            lbdate.Text = string.Format("{0}, Ngày {1}, Tháng {2}, Năm {3}", _FormatDayOfWeek(thu), ngay,thang,nam);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.Alert("Bạn đã đăng xuất", Form_Alert.enmType.Success);
            frmlogin.Show();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://"+Application.StartupPath+ "\\FileHelp.chm");
        }
    }
}
