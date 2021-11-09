using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface IChuTroService
    {
        public List<ChuTro> GetLstChuTro();
        public string ThemChuTro(ChuTro ChuTro);
        public string SuaChuTro(ChuTro ChuTro);
        public string XoaChuTro(ChuTro ChuTro);
        public string LuuChuTro();
    }
}
