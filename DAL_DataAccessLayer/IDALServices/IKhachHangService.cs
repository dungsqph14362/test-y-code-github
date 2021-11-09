using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface IKhachHangService
    {
        public List<KhachHang> GetLstKhachHang();
        public string ThemKhachHang(KhachHang KhachHang);
        public string SuaKhachHang(KhachHang KhachHang);
        public string XoaKhachHang(KhachHang KhachHang);
        public string LuuKhachHang();
    }
}
