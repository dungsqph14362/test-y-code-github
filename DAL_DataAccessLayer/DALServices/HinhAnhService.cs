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
    public class HinhAnhService : IHinhAnhService
    {
        private DatabaseContext _DBContext;
        private List<HinhAnh> _LstHinhAnh;

        public HinhAnhService()
        {
            _DBContext = new DatabaseContext();
            _LstHinhAnh = new List<HinhAnh>();
        }

        public List<HinhAnh> GetLstHinhAnh()
        {
            return _LstHinhAnh = _DBContext.HinhAnhs.ToList();
        }

        public string LuuHinhAnh()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaHinhAnh(HinhAnh HinhAnh)
        {
            _DBContext.HinhAnhs.Update(HinhAnh);
            return "Sửa Thành Công!";
        }

        public string ThemHinhAnh(HinhAnh HinhAnh)
        {
            _DBContext.HinhAnhs.Add(HinhAnh);
            _LstHinhAnh.Add(HinhAnh);
            return "Thêm Thành Công!";
        }

        public string XoaHinhAnh(HinhAnh HinhAnh)
        {
            _DBContext.HinhAnhs.Update(HinhAnh);
            return "Xóa Thành Công!";
        }
    }
}
