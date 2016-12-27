using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Views
{
    public partial class FrmDanhSachTD : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmDanhSachTD()
        {
            InitializeComponent();
        }
        public void HienThiDanhSachTD()
        {
            dgvDanhsachTD.DataSource = Models.ThucDonMod.FillDataSetThucDonNotTTT().Tables[0];
            dgvDanhsachTD.Dock = DockStyle.Fill;
            dgvDanhsachTD.RowHeadersVisible = false;
            dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;
        }
        private void FrmDanhSachTD_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTD();

        }
    }
}