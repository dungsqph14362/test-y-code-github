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
    public class LoaiPhongService : ILoaiPhongService
    {
        private DatabaseContext _DBContext;
        private List<LoaiPhong> _LstLoaiPhong;

        public LoaiPhongService()
        {
            _DBContext = new DatabaseContext();
            _LstLoaiPhong = new List<LoaiPhong>();
        }

        public List<LoaiPhong> GetLstLoaiPhong()
        {
            return _LstLoaiPhong = _DBContext.LoaiPhongs.ToList();
        }

        public string LuuLoaiPhong()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaLoaiPhong(LoaiPhong LoaiPhong)
        {
            _DBContext.LoaiPhongs.Update(LoaiPhong);
            return "Sửa Thành Công!";
        }

        public string ThemLoaiPhong(LoaiPhong LoaiPhong)
        {
            _DBContext.LoaiPhongs.Add(LoaiPhong);
            _LstLoaiPhong.Add(LoaiPhong);
            return "Thêm Thành Công!";
        }

        public string XoaLoaiPhong(LoaiPhong LoaiPhong)
        {
            _DBContext.LoaiPhongs.Update(LoaiPhong);
            return "Xóa Thành Công!";
        }
    }
}
