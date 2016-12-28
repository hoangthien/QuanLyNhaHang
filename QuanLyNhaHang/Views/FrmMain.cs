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

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmKhachHang"))
            {
                Views.FrmKhachHang Frm = new Views.FrmKhachHang() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmKhachHang");
        }

        private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmKhachHang"))
            {
                Views.FrmKhachHang Frm = new Views.FrmKhachHang() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmKhachHang");
        }

        private void btnQLKhuVuc_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmKhuVuc"))
            {
                Views.FrmKhuVuc Frm = new Views.FrmKhuVuc() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmKhuVuc");
        }

        private void btnQLBanAn_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmBan"))
            {
                Views.FrmBan Frm = new Views.FrmBan() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmBan");
        }

        private void btnBanDangTrong_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmGoiMon"))
            {
                Views.FrmGoiMon Frm = new Views.FrmGoiMon() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmGoiMon");
        }

        private void btnBanDangPhucVu_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmGoiMon"))
            {
                Views.FrmGoiMon Frm = new Views.FrmGoiMon() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmGoiMon");
        }

        private void btnQLLoaiThucDon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmLoaiThucDon"))
            {
                Views.FrmLoaiThucDon Frm = new Views.FrmLoaiThucDon() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmLoaiThucDon");
        }

        private void btnQLThucDon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmThucDon"))
            {
                Views.FrmThucDon Frm = new Views.FrmThucDon() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmThucDon");
        }

        private void btnDSThucDon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmDanhSachTD"))
            {
                Views.FrmDanhSachTD Frm = new Views.FrmDanhSachTD() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmDanhSachTD");
        }

        private void btnQLGoiMon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmMonDaGoi"))
            {
                Views.FrmMonDaGoi Frm = new Views.FrmMonDaGoi() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmMonDaGoi");
        }

        private void btnQLTinhTien_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmGoiMon"))
            {
                Views.FrmGoiMon Frm = new Views.FrmGoiMon() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmGoiMon");
        }
    }
}