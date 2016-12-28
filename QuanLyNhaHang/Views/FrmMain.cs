using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyNhaHang
{
    public partial class FrmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void fullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
            if (key != null)
            {
                try
                {
                    string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                    if (layout != "" && layout != null)
                        ribbonControl1.QatLayout = layout;
                }
                finally
                {
                    key.Close();
                }
            }
            fullscreen();

            applicationButton1.Pulse(11);
        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChild(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmNhanVien"))
            {
                Views.FrmNhanVien Frm = new Views.FrmNhanVien() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmNhanVien");
        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmSearchNhanVien"))
            {
                Views.FrmSearchNhanVien Frm = new Views.FrmSearchNhanVien() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmSearchNhanVien");
        }

        private void btnPhanQuyenNhanVien_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmPhanQuyen"))
            {
                Views.FrmPhanQuyen Frm = new Views.FrmPhanQuyen() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmPhanQuyen");
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {

        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {

        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {

        }
    }
}