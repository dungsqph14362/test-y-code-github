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
    public class HopDongService : IHopDongService
    {
        private DatabaseContext _DBContext;
        private List<HopDong> _LstHopDong;

        public HopDongService()
        {
            _DBContext = new DatabaseContext();
            _LstHopDong = new List<HopDong>();
        }

        public List<HopDong> GetLstHopDong()
        {
            return _LstHopDong = _DBContext.HopDongs.ToList();
        }

        public string LuuHopDong()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaHopDong(HopDong HopDong)
        {
            _DBContext.HopDongs.Update(HopDong);
            return "Sửa Thành Công!";
        }

        public string ThemHopDong(HopDong HopDong)
        {
            _DBContext.HopDongs.Add(HopDong);
            _LstHopDong.Add(HopDong);
            return "Thêm Thành Công!";
        }

        public string XoaHopDong(HopDong HopDong)
        {
            _DBContext.HopDongs.Update(HopDong);
            return "Xóa Thành Công!";
        }
    }
}
