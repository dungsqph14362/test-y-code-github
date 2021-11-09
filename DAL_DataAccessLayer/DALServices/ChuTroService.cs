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
    public class ChuTroService : IChuTroService
    {
        private DatabaseContext _DBContext;
        private List<ChuTro> _LstChuTro;

        public ChuTroService()
        {
            _DBContext = new DatabaseContext();
            _LstChuTro = new List<ChuTro>();
        }
        public List<ChuTro> GetLstChuTro()
        {
            return _LstChuTro = _DBContext.ChuTros.ToList();
        }

        public string LuuChuTro()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaChuTro(ChuTro ChuTro)
        {
            _DBContext.ChuTros.Update(ChuTro);
            return "Sửa Thành Công!";
        }

        public string ThemChuTro(ChuTro ChuTro)
        {
            _DBContext.ChuTros.Add(ChuTro);
            _LstChuTro.Add(ChuTro);
            return "Thêm Thành Công!";
        }

        public string XoaChuTro(ChuTro ChuTro)
        {
            _DBContext.ChuTros.Update(ChuTro);
            return "Xóa Thành Công!";
        }
    }
}
