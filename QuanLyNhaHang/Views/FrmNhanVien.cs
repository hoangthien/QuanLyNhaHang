using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.Views
{
    public partial class FrmNhanVien : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        public static FrmNhanVien frmNV = new FrmNhanVien();

        public void HienThiDanhSachNhanVien()
        {
            dgvDSNhanVien.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            dgvDSNhanVien.Dock = DockStyle.Fill;
            dgvDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
        }

        void bingding()
        {

        }
    }
}
