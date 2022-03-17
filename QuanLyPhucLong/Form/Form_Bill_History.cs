using Microsoft.Reporting.WinForms;
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
    public partial class Form_Bill_History : Form
    {
        public Form_Bill_History()
        {
            InitializeComponent();
            this.TopMost = true; 
        }

        private void Form_Bill_History_Load(object sender, EventArgs e)
        {
            this.rpBill.RefreshReport();
        }

        public void ShowBill(ListView lvHistory)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHD"); 
            dt.Columns.Add("TenNV");
            dt.Columns.Add("NgayXuat");
            dt.Columns.Add("ThanhToan");
            dt.Columns.Add("TienNhan");
            dt.Columns.Add("TienThua");
            dt.Columns.Add("GiamGia");
            foreach (ListViewItem item in lvHistory.Items)
            {
                string MaHD = item.SubItems[0].Text;
                string TenNV = item.SubItems[1].Text;
                string NgayXuat = item.SubItems[2].Text;
                string ThanhToan = item.SubItems[3].Text;
                string TienNhan = item.SubItems[4].Text;
                string TienThua = item.SubItems[5].Text;
                string GiamGia = item.SubItems[6].Text;
                dt.Rows.Add(MaHD,TenNV,NgayXuat,ThanhToan,TienNhan,TienThua,GiamGia);
                rpBill.LocalReport.DataSources.Add(new ReportDataSource("historytable", dt));
                rpBill.LocalReport.Refresh();
                rpBill.RefreshReport();
                this.Show();
            }

            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SaveImage(ReportViewer viewer, string savePath)
        {
            byte[] bytes = viewer.LocalReport.Render("image", null);
            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(bytes, 0, bytes.Length);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string FilePath = string.Empty;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save PNG Files";
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.Filter = "PNG File (*.png)|*.png";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                FilePath = saveFileDialog1.FileName;
            else
            {
                Program.Alert("Hủy Xuất File PNG", Form_Alert.enmType.Error);

                return;
            }
            SaveImage(rpBill, FilePath);
            Program.Alert("Xuất File PNG Thành Công", Form_Alert.enmType.Success);
        }
    }
}
