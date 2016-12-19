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
    }
}