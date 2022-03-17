using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhucLong
{
    public partial class Form_Topping : Form
    {
        Entity DB = new Entity();
        ConvertMoney cv = new ConvertMoney();
        FormHome formHome;
        MainApp formMain;
        ImageList ImageLarge;
        string TPsize = "S";
        string TPduong = "100";
        string TPda = "100";
        Image ByteToImage(byte[] data)
        {
            using ( MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        public Form_Topping(FormHome formHome, MainApp formMain)
        {
            InitializeComponent();
            SizeS.Checked = true;
            duong100.Checked = true;
            da100.Checked = true;
            this.formHome = formHome;
            this.formMain = formMain;
            this.formHome.Enabled = false;
            this.formMain.Enabled = false;
            this.TopMost = true;
            SizeS.Click += RadioSize_Click;
            SizeL.Click += RadioSize_Click;
            duong0.Click += RadioDuong_Click;
            duong50.Click += RadioDuong_Click;
            duong75.Click += RadioDuong_Click;
            duong100.Click += RadioDuong_Click;
            _Load();
        }

        private void _Load()
        {
            lvTopping.Items.Clear();
            ImageLarge = new ImageList();
            ImageLarge.ImageSize = new Size(100, 100);
            ImageLarge.ColorDepth = ColorDepth.Depth32Bit;
            lvTopping.LargeImageList = ImageLarge;
            List<SanPham> ListSP = DB.SanPhams.ToList();
            int i = 0;
            foreach (SanPham sp in ListSP)
            {
                if (sp.loai == 1 && sp.trangthai == 0)
                {
                    string maSP = sp.maSP;
                    string Gia = sp.Gia.ToString();
                    string tenSP = sp.tenSP + "\n(" + cv._ConvertMoney( Gia) + "vnđ)";
                    byte[] photo = (byte[])sp.photo;
                    Image img = ByteToImage(photo);
                    ImageLarge.Images.Add(img);
                    String[] row = { tenSP, maSP, Gia };
                    ListViewItem item1 = new ListViewItem(row);
                    item1.ImageIndex = i;
                    lvTopping.Items.Add(item1);
                    i++;
                }
            }
        }

        public bool _CheckExistHoaDon(string maSP)
        {
            foreach (ListViewItem item in lvTop.Items)
            {
                if (maSP == item.SubItems[1].Text)
                {
                    return true;
                }

            }
            return false;
        }

        private void _BackHome()
        {
            this.formHome.Enabled = true;
            this.formMain.Enabled = true;
            this.Close();
        }

        private void RadioSize_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            TPsize = rb.Text;
        }

        private void RadioDuong_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            TPduong = rb.Text.Replace("%", "");
        }

        private void RadioDa_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            TPda = rb.Text.Replace("%", "");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _BackHome();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            _BackHome();
        }

        public DialogResult _ShowTopping(ref string size,ref string duong, ref string da,ref List<ChiTietTopping> topping)
        {
            if (size == "L")
            {
                SizeL.Checked = true;
                TPsize = "L";
            }
            else
            {
                SizeS.Checked = true;
                TPsize = "S";
            }
                
            switch (duong)
            {
                case "100":
                    duong100.Checked = true;
                    TPduong = "100";
                    break;
                case "70":
                    duong75.Checked = true;
                    TPduong = "70";
                    break;
                case "50":
                    duong50.Checked = true;
                    TPduong = "50";
                    break;
                case "0":
                    duong0.Checked = true;
                    TPduong = "0";
                    break;
                default:
                    break;
            }
            switch (da)
            {
                case "100":
                    da100.Checked = true;
                    TPda = "100";
                    break;
                case "70":
                    da70.Checked = true;
                    TPda = "70";
                    break;
                case "50":
                    da50.Checked = true;
                    TPda = "50";
                    break;
                case "0":
                    da0.Checked = true;
                    TPda = "0";
                    break;
                default:
                    break;
            }
            int count = lvTop.Items.Count;
            foreach (ChiTietTopping item in (List<ChiTietTopping>)topping)
            {
                count = (count + 1);
                SanPham sp = DB.SanPhams.FirstOrDefault(p => p.maSP == item.maSP);
                string[] row = { count.ToString(), item.maSP, sp.tenSP, sp.Gia.ToString(), item.SL.ToString() };
                lvTop.Items.Add(new ListViewItem(row));
            }
            //===============
            btnXacNhan.DialogResult = DialogResult.OK;
            btnHuy.DialogResult = DialogResult.Cancel;
            DialogResult dialogResult = this.ShowDialog();
            List<ChiTietTopping> ListTP = new List<ChiTietTopping>();
            foreach (ListViewItem item in lvTop.Items)
            {
                ChiTietTopping tp = new ChiTietTopping();
                tp.maSP = item.SubItems[1].Text;
                tp.SL = Int32.Parse(item.SubItems[4].Text);
                ListTP.Add(tp);
            }
            size = TPsize;
            duong = TPduong;
            da = TPda;
            topping = ListTP;
            return dialogResult;
        }

        private void lvTopping_MouseClick(object sender, MouseEventArgs e)
        {
            string maSP = lvTopping.SelectedItems[0].SubItems[1].Text;
            string tenSP = lvTopping.SelectedItems[0].SubItems[0].Text;
            int Gia = Int32.Parse(lvTopping.SelectedItems[0].SubItems[2].Text);
            int count = lvTop.Items.Count;
            if (!_CheckExistHoaDon(maSP))
            {
                ListViewItem item = new ListViewItem();
                count = (count + 1);
                item.Text = count.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = maSP });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tenSP });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Gia.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "1" }); 
                lvTop.Items.Add(item);
                Program.Alert("Chọn Topping " + tenSP, Form_Alert.enmType.Success);
            }
            else
            {
                foreach (ListViewItem item in lvTop.Items)
                {
                    if (maSP == item.SubItems[1].Text)
                    {
                        count = (Int32.Parse(item.SubItems[4].Text) + 1);
                        item.SubItems[3].Text = Gia.ToString();
                        item.SubItems[4].Text = count.ToString();
                        Program.Alert("Thêm Topping " + tenSP, Form_Alert.enmType.Success);
                    }
                }
            }
        }

        private void lvTop_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvTop.SelectedItems.Count > 0)
            {
                int SL = Int32.Parse(lvTop.SelectedItems[0].SubItems[4].Text) - 1;
                if (SL <= 0)
                    lvTop.Items.Remove(lvTop.SelectedItems[0]);
                else
                    lvTop.SelectedItems[0].SubItems[4].Text = SL.ToString();
            }       
        }
    }
}
