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
    public class DichVuChiTietService : IDichVuChiTietService
    {
        private DatabaseContext _DBContext;
        private List<DichVuChiTiet> _LstDichVuChiTiet;

        public DichVuChiTietService()
        {
            _DBContext = new DatabaseContext();
            _LstDichVuChiTiet = new List<DichVuChiTiet>();
        }

        public List<DichVuChiTiet> GetLstDichVuChiTiet()
        {
            return _LstDichVuChiTiet = _DBContext.DichVuChiTiets.ToList();
        }

        public string LuuDichVuChiTiet()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaDichVuChiTiet(DichVuChiTiet DichVuChiTiet)
        {
            _DBContext.DichVuChiTiets.Update(DichVuChiTiet);
            return "Sửa Thành Công!";
        }

        public string ThemDichVuChiTiet(DichVuChiTiet DichVuChiTiet)
        {
            _DBContext.DichVuChiTiets.Add(DichVuChiTiet);
            _LstDichVuChiTiet.Add(DichVuChiTiet);
            return "Thêm Thành Công!";
        }

        public string XoaDichVuChiTiet(DichVuChiTiet DichVuChiTiet)
        {
            _DBContext.DichVuChiTiets.Update(DichVuChiTiet);
            return "Xóa Thành Công!";
        }
    }
}
