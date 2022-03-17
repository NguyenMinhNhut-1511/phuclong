using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhucLong
{
    public partial class Form_YesNo : Form
    {
        public Form_YesNo()
        {
            InitializeComponent();
        }

        public DialogResult ShowYesNo()
        {
            btn1.DialogResult = DialogResult.OK;
            btn2.DialogResult = DialogResult.Cancel;
            DialogResult dialogResult = this.ShowDialog();
            return dialogResult;
        }
    }
}
