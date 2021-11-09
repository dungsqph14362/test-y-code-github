using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Context;
using DAL_DataAccessLayer.IDALServices;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.DALServices
{
    public class KhachHangService : IKhachHangService
    {
        private DatabaseContext _DBContext;
        private List<KhachHang> _LstKhachHang;

        public KhachHangService()
        {
            _DBContext = new DatabaseContext();
            _LstKhachHang = new List<KhachHang>();
        }

        public List<KhachHang> GetLstKhachHang()
        {
            return _LstKhachHang = _DBContext.KhachHangs.ToList();
        }

        public string LuuKhachHang()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaKhachHang(KhachHang KhachHang)
        {
            _DBContext.KhachHangs.Update(KhachHang);
            return "Sửa Thành Công!";
        }

        public string ThemKhachHang(KhachHang KhachHang)
        {
            _DBContext.KhachHangs.Add(KhachHang);
            _LstKhachHang.Add(KhachHang);
            return "Thêm Thành Công!";
        }

        public string XoaKhachHang(KhachHang KhachHang)
        {
            _DBContext.KhachHangs.Update(KhachHang);
            return "Xóa Thành Công!";
        }
    }
}
