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
    public class ChucVuService : IChucVuService
    {
        private DatabaseContext _DBContext;
        private List<ChucVu> _LstChucVu;

        public ChucVuService()
        {
            _DBContext = new DatabaseContext();
            _LstChucVu = new List<ChucVu>();
        }

        public List<ChucVu> GetLstChucVu()
        {
            return _LstChucVu = _DBContext.ChucVus.ToList();
        }

        public string LuuChucVu()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaChucVu(ChucVu ChucVu)
        {
            _DBContext.ChucVus.Update(ChucVu);
            return "Sửa Thành Công!";
        }

        public string ThemChucVu(ChucVu ChucVu)
        {
            _DBContext.ChucVus.Add(ChucVu);
            _LstChucVu.Add(ChucVu);
            return "Thêm Thành Công!";
        }

        public string XoaChucVu(ChucVu ChucVu)
        {
            _DBContext.ChucVus.Update(ChucVu);
            return "Xóa Thành Công!";
        }
    }
}
