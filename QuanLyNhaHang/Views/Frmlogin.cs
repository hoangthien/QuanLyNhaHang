using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class FrmLogIn : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "1234")
            {
                var mainForm = new FrmMain();
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Sai user và mật khẩu. Nhập lại!");
                txtUserName.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}