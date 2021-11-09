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
    public class QuanLyHinhAnh : IQuanLyHinhAnh
    {
        private IHinhAnhService _IHinhAnhService;

        public QuanLyHinhAnh()
        {
            _IHinhAnhService = new HinhAnhService();
        }

        public List<HinhAnh> GetLstHinhAnh()
        {
            return _IHinhAnhService.GetLstHinhAnh();
        }

        public string LuuHinhAnh()
        {
            return _IHinhAnhService.LuuHinhAnh();
        }

        public string SuaHinhAnh(HinhAnh HinhAnh)
        {
            return _IHinhAnhService.SuaHinhAnh(HinhAnh);
        }

        public string ThemHinhAnh(HinhAnh HinhAnh)
        {
            return _IHinhAnhService.ThemHinhAnh(HinhAnh);
        }

        public string XoaHinhAnh(HinhAnh HinhAnh)
        {
            return _IHinhAnhService.XoaHinhAnh(HinhAnh);
        }
    }
}
