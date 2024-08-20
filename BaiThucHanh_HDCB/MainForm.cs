using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh_HDCB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var tenDaNamg=txtTen.Text;
            MessageBox.Show($"Xin chào bạn{tenDaNamg}.Rất vui được gặp bạn)","Thông điệp chào mừng");


        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            //txtSaochep.Text=txtTen.Text;
        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
            btnSaoChep.Text = txtTen.Text;

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            btnSaoChep.Text = txtTen.Text;
        }
    }
}
