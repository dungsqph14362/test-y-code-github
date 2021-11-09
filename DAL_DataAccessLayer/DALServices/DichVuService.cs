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
    public class DichVuService : IDichVuService
    {

        private DatabaseContext _DBContext;
        private List<DichVu> _LstDichVu;

        public DichVuService()
        {
            _DBContext = new DatabaseContext();
            _LstDichVu = new List<DichVu>();
        }

        public List<DichVu> GetLstDichVu()
        {
            return _LstDichVu = _DBContext.DichVus.ToList();
        }

        public string luuDichVu()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaDichVu(DichVu DichVu)
        {
            _DBContext.DichVus.Update(DichVu);
            return "Sửa Thành Công!";
        }

        public string ThemDichVu(DichVu DichVu)
        {
            _DBContext.DichVus.Add(DichVu);
            _LstDichVu.Add(DichVu);
            return "Thêm Thành Công!";
        }

        public string XoaDichVu(DichVu DichVu)
        {
            _DBContext.DichVus.Update(DichVu);
            return "Xóa Thành Công!";
        }
    }
}
