using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface IHinhAnhService
    {
        public List<HinhAnh> GetLstHinhAnh();
        public string ThemHinhAnh(HinhAnh HinhAnh);
        public string SuaHinhAnh(HinhAnh HinhAnh);
        public string XoaHinhAnh(HinhAnh HinhAnh);
        public string LuuHinhAnh();
    }
}
