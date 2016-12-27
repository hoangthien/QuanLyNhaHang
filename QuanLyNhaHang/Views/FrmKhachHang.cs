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
    public partial class FrmKhachHang : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        public static FrmKhachHang uctKH = new FrmKhachHang();
        int flag = 0;
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachKhachHang();
            bingding();
        }
        public void HienThiDanhSachKhachHang()
        {
            dgvDanhSachKH.DataSource = Models.KhachHangMod.FillDataSetKhachHang().Tables[0];
            dgvDanhSachKH.Dock = DockStyle.Fill;
            dgvDanhSachKH.RowHeadersVisible = false;
            dgvDanhSachKH.BorderStyle = BorderStyle.Fixed3D;
        }
        void bingding()
        {
            txtIdKhachHang.DataBindings.Clear();
            txtIdKhachHang.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "IdKhachHang");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "TenKhachHang");
            txtDienThoaiKH.DataBindings.Clear();
            txtDienThoaiKH.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "DienThoai");
            txtEmailKH.DataBindings.Clear();
            txtEmailKH.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "Email");
            txtDiaChiKH.DataBindings.Clear();
            txtDiaChiKH.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "DiaChi");

        }
        void clearData()
        {
            txtIdKhachHang.Text = Models.connection.ExcuteScalar(String.Format("select IdKhachHang= dbo.fcgetIdKhachHang()"));
            txtTenKH.Text = "";
            txtDienThoaiKH.Text = "";
            txtEmailKH.Text = "";
            txtDiaChiKH.Text = "";
        }
        void dis_end(bool e)
        {
            //txtIdKhachHang.Enabled = e;
            txtTenKH.Enabled = e;
            txtDienThoaiKH.Enabled = e;
            txtEmailKH.Enabled = e;
            txtDiaChiKH.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idKhachHang = "";
            try
            {
                _idKhachHang = txtIdKhachHang.Text;
            }
            catch { }
            string _tenKhachHang = "";
            try
            {
                _tenKhachHang = txtTenKH.Text;
            }
            catch { }
            string _dienthoai = "";
            try
            {
                _dienthoai = txtDienThoaiKH.Text;
            }
            catch { }
            string _email = "";
            try
            {
                _email = txtEmailKH.Text;
            }
            catch { }
            string _diachi = "";
            try
            {
                _diachi = txtDiaChiKH.Text;
            }
            catch { }
            if (flag == 0)
            {


                if (_idKhachHang == "" || _tenKhachHang == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.KhachHangCtrl.InSertKhachHang(_idKhachHang, _tenKhachHang, _dienthoai, _email, _diachi);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachKhachHang();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.KhachHangCtrl.UpdateKhachHang(_idKhachHang, _tenKhachHang, _dienthoai, _email, _diachi);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachKhachHang();
                    //FrmKhachHang_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            FrmKhachHang_Load(sender, e);

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idKhachHang = "";
            try
            {
                _idKhachHang = txtIdKhachHang.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.KhachHangCtrl.DeleteKhachHang(_idKhachHang);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachKhachHang();
                    FrmKhachHang_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmKhachHang_Load(sender, e);
            dis_end(false);
        }

        private void txtDienThoaiKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}