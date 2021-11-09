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
    public class HopDongChiTietService : IHopDongChiTietService
    {
        private DatabaseContext _DBContext;
        private List<HopDongChiTiet> _LstHopDongChiTiet;

        public HopDongChiTietService()
        {
            _DBContext = new DatabaseContext();
            _LstHopDongChiTiet = new List<HopDongChiTiet>();
        }

        public List<HopDongChiTiet> GetLstHopDongChiTiet()
        {
            return _LstHopDongChiTiet = _DBContext.HopDongChiTiets.ToList();
        }

        public string LuuHopDongChiTiet()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaHopDongChiTiet(HopDongChiTiet HopDongChiTiet)
        {
            _DBContext.HopDongChiTiets.Update(HopDongChiTiet);
            return "Sửa Thành Công!";
        }

        public string ThemHopDongChiTiet(HopDongChiTiet HopDongChiTiet)
        {
            _DBContext.HopDongChiTiets.Add(HopDongChiTiet);
            _LstHopDongChiTiet.Add(HopDongChiTiet);
            return "Thêm Thành Công!";
        }

        public string XoaHopDongChiTiet(HopDongChiTiet HopDongChiTiet)
        {
            _DBContext.HopDongChiTiets.Update(HopDongChiTiet);
            return "Xóa Thành Công!";
        }
    }
}
