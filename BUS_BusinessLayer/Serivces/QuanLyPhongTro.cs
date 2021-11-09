using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_BusinessLayer.IServices;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.IDALServices;
using DAL_DataAccessLayer.Models;

namespace BUS_BusinessLayer.Serivces
{
    public class QuanLyPhongTro : IQuanLyPhongTro
    {
        private IPhongTroService _IPhongTroService;

        public QuanLyPhongTro()
        {
            _IPhongTroService = new PhongTroService();
        }
        public List<PhongTro> GetLstPhongTro()
        {
            return _IPhongTroService.GetLstPhongTro();
        }

        public string LuuPhongTro()
        {
            return _IPhongTroService.LuuPhongTro();
        }

        public string SuaPhongTro(PhongTro PhongTro)
        {
            return _IPhongTroService.SuaPhongTro(PhongTro);
        }

        public string ThemPhongTro(PhongTro PhongTro)
        {
            return _IPhongTroService.ThemPhongTro(PhongTro);
        }

        public string XoaPhongTro(PhongTro PhongTro)
        {
            return _IPhongTroService.XoaPhongTro(PhongTro);
        }
    }
}
