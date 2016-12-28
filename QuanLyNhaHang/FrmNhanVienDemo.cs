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
    public partial class FrmNhanVienDemo : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmNhanVienDemo()
        {
            InitializeComponent();
        }

        // Biến phân biệt lcs thêm và sửa
        int flag = 0;

        public static FrmNhanVienDemo frmNV = new FrmNhanVienDemo();

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

        // Hàm trỏ đến dữ liệu trên DataGridViews
        void bingding()
        {
            // Trỏ đến đúng tên control đã khai báo
            txtIDNV.DataBindings.Clear();
            txtIDNV.DataBindings.Add("Text", dgvDSNhanVien.DataSource, " IdNhanVien");
            txtHo.DataBindings.Clear();
            txtHo.DataBindings.Add("Text", dgvDSNhanVien.DataSource, " IdNhanVien");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvDSNhanVien.DataSource, " IdNhanVien");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, " IdNhanVien");
            cmbGioiTinh.DataBindings.Clear();
            cmbGioiTinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, " IdNhanVien");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgvDSNhanVien.DataSource, " IdNhanVien");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDSNhanVien.DataSource, " IdNhanVien");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSNhanVien.DataSource, " IdNhanVien");
        }

        // Hàm ẩn các control khi load dữ liệu lên
        void dis_end(bool e)
        {
            txtDiaChi.Enabled = e;
            txtDienThoai.Enabled = e;
            txtEmail.Enabled = e;
            txtHo.Enabled = e;
            txtIDNV.Enabled = e;
            txtTen.Enabled = e;
            dtpNgaySinh.Enabled = e;
            cmbGioiTinh.Enabled = e;
            btnAdd.Enabled = e;
            btnDelete.Enabled = e;
            btnEdit.Enabled = e;
            btnSave.Enabled = e;
            btnHuy.Enabled = e;
        }

        // Hàm hiển thị giới tính cho nhân viên
        void loadControl()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");
        }

        // Xóa dữ liệu ở textbox lúc nhấn vào button
        void clearData()
        {
            //txtIDNV.Text = Models.connection.ExcuteScalar(""); // ID tự động tăng
            txtHo.Text = "";
            txtTen.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            loadControl(); //Load giới tính vào
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Load lại
            FrmNhanVien_Load(sender, e);
            dis_end(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true); //Ẩn thêm, xóa, sửa, hiện nút lưu và hủy
            loadControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _idNhanVien = "";
            try
            {
                _idNhanVien = txtIDNV.Text;
            }
            catch { }
            string _ho = "";
            try
            {
                _ho = txtHo.Text;
            }
            catch { }
            string _ten = "";
            try
            {
                _ten = txtTen.Text;
            }
            catch { }
            string _diaChi = "";
            try
            {
                _diaChi = txtDiaChi.Text;
            }
            catch { }
            string _dienThoai = "";
            try
            {
                _dienThoai = txtDienThoai.Text;
            }
            catch { }
            string _email = "";
            try
            {
                _email = txtEmail.Text;
            }
            catch { }
            DateTime _ngaySinh = dtpNgaySinh.Value;
            try
            {
                _ngaySinh = dtpNgaySinh.Value;
            }
            catch { }
            string _gioiTinh = "";
            try
            {
                _gioiTinh = cmbGioiTinh.Text;
            }
            catch { }

            if(flag == 0)
            {
                // Thêm mới
                if (_idNhanVien == "" || _ten == "" || _ho == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    //i = Controllers.NhanVienCtrl.InsertNhanVien(_idNhanVien, _ho, _ten, _ngaySinh, _gioiTinh, _dienThoai, _email, _diaChi);
                    if( i> 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại!!!");
                    }
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.NhanVienCtrl.UpdateNhanVien(_idNhanVien, _ho, _ten, _ngaySinh, _gioiTinh, _dienThoai, _email, _diaChi);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    HienThiDanhSachNhanVien();
                }
                else
                    MessageBox.Show("Sửa thất bại!!!");
            }
            FrmNhanVien_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string _idNhanVien = "";
            try
            {
                _idNhanVien = txtIDNV.Text;
            }
            catch
            { }
            DialogResult dr = MessageBox.Show("Bạn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.DeleteNhanVien(_idNhanVien);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    HienThiDanhSachNhanVien();
                    FrmNhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa bị lỗi!!");
            }
            else
                return;
        }
    }
}
