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
    public partial class FrmMainDemo : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrmMainDemo()
        {
            InitializeComponent();
        }

        private void FrmMainDemo_Load(object sender, EventArgs e)
        {

        }

        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(Form uct, byte typeControl, string tenTab)
        {
            // Kiểm tra tồn tại trang này chưa
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }


        private void btnInfomation_Click(object sender, EventArgs e)
        {
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

        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
  
        }

        private void btnQLGoiMon_Click(object sender, EventArgs e)
        {


        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {

        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {


        }

        private void btnKM_Click(object sender, EventArgs e)
        {
   

        }

        private void btnResgusti_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.FrmGoiMon.uctGM, 4, "Danh mục gọi món ");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
   
        }
    }
}