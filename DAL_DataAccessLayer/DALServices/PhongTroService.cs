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
    public class PhongTroService : IPhongTroService
    {
        private DatabaseContext _DBContext;
        private List<PhongTro> _LstPhongTro;

        public PhongTroService()
        {
            _DBContext = new DatabaseContext();
            _LstPhongTro = new List<PhongTro>();
        }

        public List<PhongTro> GetLstPhongTro()
        {
            return _LstPhongTro = _DBContext.PhongTros.ToList();
        }

        public string LuuPhongTro()
        {
            _DBContext.SaveChanges();
            return "Lưu thành công";
        }

        public string SuaPhongTro(PhongTro PhongTro)
        {
            _DBContext.PhongTros.Update(PhongTro);
            return "Sửa Thành Công!";
        }

        public string ThemPhongTro(PhongTro PhongTro)
        {
            _DBContext.PhongTros.Add(PhongTro);
            _LstPhongTro.Add(PhongTro);
            return "Thêm Thành Công!";
        }

        public string XoaPhongTro(PhongTro PhongTro)
        {
            _DBContext.PhongTros.Update(PhongTro);
            return "Xóa Thành Công!";
        }
    }
}
