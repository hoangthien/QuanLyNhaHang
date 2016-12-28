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

        private void btnInfomation_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmTTNV"))
            {
                FrmTTNV Frm = new FrmTTNV() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmTTNV");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDSNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmNhanVien"))
            {
                Views.FrmNhanVienDemo Frm = new Views.FrmNhanVienDemo() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmNhanVien");
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmKhuVuc"))
            {
                Views.FrmKhuVuc Frm = new Views.FrmKhuVuc() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmKhuVuc");
        }

        private void btnQLGoiMon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmKhachHang"))
            {
                Views.FrmKhachHang Frm = new Views.FrmKhachHang() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmKhachHang");
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmBan"))
            {
                Views.FrmBan Frm = new Views.FrmBan() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmBan");
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmGoiMon"))
            {
                Views.FrmGoiMon Frm = new Views.FrmGoiMon() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmGoiMon");
        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmLoaiThucDon"))
            {
                Views.FrmLoaiThucDon Frm = new Views.FrmLoaiThucDon() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmLoaiThucDon");
            
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmThucDon"))
            {
                Views.FrmThucDon Frm = new Views.FrmThucDon() { MdiParent = this, WindowState = FormWindowState.Maximized };
                Frm.Show();
            }
            else
                ActiveChild("FrmThucDon");
            
        }
    }
}