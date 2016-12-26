using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Controllers
{
    class NhanVienCtrl
    {
        //public static DataSet FillDataSet_getNhanVienByIdNhanVien(string _idNhanVien)
        //{
        //    try
        //    {
        //        Models.NhanVienMod nvien = new Models.NhanVienMod(_idNhanVien);
        //        return nvien.FillDataSet_getNhanVienByIdNhanVien();
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        // Hàm add
        public static int InsertNhanVien(string _idNhanVien, string _hoNhanVien, string _tenNhanVien, DateTime _NSNV, string _gioitinhNV, string _dtNV, string _emailNV, string _dichiNV)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_idNhanVien, _hoNhanVien, _tenNhanVien, _NSNV, _gioitinhNV, _dtNV,_emailNV, _dichiNV);
                return _nhanVien.InsertNhanVien();
            }
            catch
            {
                return 0;
            }
        }

        // Hàm Cập nhật
        public static int UpdateNhanVien(string _idNhanVien, string _hoNhanVien, string _tenNhanVien, DateTime _NSNV, string _gioitinhNV, string _dtNV, string _emailNV, string _dichiNV)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_idNhanVien, _hoNhanVien, _tenNhanVien, _NSNV, _gioitinhNV, _dtNV, _emailNV, _dichiNV);
                return _nhanVien.UpdateNhanVien();
            }
            catch
            {
                return 0;
            }
        }

        // Hàm xóa
        public static int DeleteNhanVien(string _idNhanVien)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_idNhanVien);
                return _nhanVien.DeleteNhanVien();
            }
            catch
            {
                return 0;
            }
        }
    }
}
