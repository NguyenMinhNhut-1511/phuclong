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
    public partial class Form_Bill : Form
    {
        public Form_Bill()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Bill_Load(object sender, EventArgs e)
        {
            this.rpBill.RefreshReport();           
        }

        private void Para(string name, string data)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter(name, data));
            rpBill.LocalReport.SetParameters(reportParameters);
        }

        public void ShowBill(DataTable dt, string NhanVien, string maHD, string date,string TongTamTinh, string KhuyenMai, string TongCong, string TienNhan, string TienThua)
        {
            rpBill.LocalReport.DataSources.Clear();
            Para("txtNhanVien", NhanVien);
            Para("txtMaHD", maHD);
            Para("txtDate", date);
            Para("txtTongTamTinh", "Tổng Tạm Tính: " + TongTamTinh);
            Para("txtKhuyenMai", KhuyenMai);
            Para("txtTongCong", "Tổng Cộng: " + TongCong);
            Para("txtTienNhan", "Tiền Nhận: " + TienNhan + " đ");
            Para("txtTienThua", "Tiền Thừa: " + TienThua);
            rpBill.LocalReport.DataSources.Add(new ReportDataSource("billtable", dt));
            rpBill.LocalReport.Refresh();
            rpBill.RefreshReport();
            this.Show();
        }

        public void SavePDF(ReportViewer viewer, string savePath)
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
            SavePDF(rpBill, FilePath);
            Program.Alert("Xuất File PNG Thành Công", Form_Alert.enmType.Success);
        }
    }
}
