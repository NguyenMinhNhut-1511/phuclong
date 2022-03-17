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
    public partial class Form_RPDSNV : Form
    {
        public Form_RPDSNV()
        {
            InitializeComponent();
        }

        private void Form_RPDSNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.DataSet1.NhanVien);
            rpNhanVien.LocalReport.Refresh();
            rpNhanVien.RefreshReport();
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
            SaveImage(rpNhanVien, FilePath);
            Program.Alert("Xuất File PNG Thành Công", Form_Alert.enmType.Success);
        }
    }
}
