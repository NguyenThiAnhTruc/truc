﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var tenDaNang=txtTen.Text;
            MessageBox.Show($"Xin chào bạn {tenDaNang}.Rất vui được gặp bạn", "Thông điệp chào mừng");
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text=txtTen.Text;
        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
