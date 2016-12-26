using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Models
{
    class NhanVienMod
    {
        protected String IdNhanVien { get; set; }

        protected String HoLot { get; set; }

        protected String Ten { get; set; }

        protected DateTime NgaySinh { get; set; }

        protected String GioiTinh { get; set; }

        protected String DienThoai { get; set; }

        protected String Email { get; set; }
    
        protected String DiaChi { get; set; }

        // Ham khoi tao
        public NhanVienMod(string _IdNhanVien)
        {
            IdNhanVien = _IdNhanVien;
        }

        public NhanVienMod() { }

        public NhanVienMod(string _idNhanVien, string _hoNhanVien, string _tenNhanVien, DateTime _NSNV, string _gioitinhNV, string _dtNV, string _emailNV, string _dichiNV)
        {
            IdNhanVien = _idNhanVien;
            HoLot = _hoNhanVien;
            Ten = _tenNhanVien;
            NgaySinh = _NSNV;
            GioiTinh = _gioitinhNV;
            DienThoai = _dtNV;
            Email = _emailNV;
            DiaChi = _dichiNV;
        }

        // Hàm thêm Nhân Viên
        public int InsertNhanVien()
        {
            int i = 0;
            // Các biến truyền vào phải giống các biến khai báo trong SQL
            string[] paras = new string[8] { "@IdNhanVien", "@HoLot", "@Ten", "@Ngaysinh","@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { IdNhanVien, HoLot, Ten, NgaySinh, GioiTinh, DienThoai, Email, DiaChi };
            // Gọi đúng tên thủ tục ta đã tạo trong SQL
            i = Models.connection.Excute_Sql("spInsertNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }

        // Hàm Update
        public int UpdateNhanVien()
        {
            int i = 0;
            // Các biến truyền vào phải giống các biến khai báo trong SQL
            string[] paras = new string[8] { "@IdNhanVien", "@HoLot", "@Ten", "@Ngaysinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { IdNhanVien, HoLot, Ten, NgaySinh, GioiTinh, DienThoai, Email, DiaChi };
            // Gọi đúng tên thủ tục ta đã tạo trong SQL
            i = Models.connection.Excute_Sql("spUpdateNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }

        // Hàm xóa chỉ cần truyền Id
        public int DeleteNhanVien()
        {
            int i = 0;
            // Các biến truyền vào phải giống các biến khai báo trong SQL
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { IdNhanVien };
            // Gọi đúng tên thủ tục ta đã tạo trong SQL
            i = Models.connection.Excute_Sql("spDeleteNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }

        // Khởi tạo hàm Dataset để Load Nhân viên lên
        public static DataSet FillDataSetNhanVien()
        {
            return Models.connection.FillDataSet("spgetNhanVien", CommandType.StoredProcedure);
        }

        // Tìm nhân viên theo Id
        public DataSet FillDataSet()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { IdNhanVien };
            ds = Models.connection.FillDataSet("spgetNhanVienByIdNhanVien", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
