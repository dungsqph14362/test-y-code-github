using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace BUS_BusinessLayer.IServices
{
    public interface IQuanLyPhongTro
    {
        public List<PhongTro> GetLstPhongTro();
        public string ThemPhongTro(PhongTro PhongTro);
        public string SuaPhongTro(PhongTro PhongTro);
        public string XoaPhongTro(PhongTro PhongTro);
        public string LuuPhongTro();
    }
}
