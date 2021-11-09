using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface IPhongTroService
    {
        public List<PhongTro> GetLstPhongTro();
        public string ThemPhongTro(PhongTro PhongTro);
        public string SuaPhongTro(PhongTro PhongTro);
        public string XoaPhongTro(PhongTro PhongTro);
        public string LuuPhongTro();
    }
}
