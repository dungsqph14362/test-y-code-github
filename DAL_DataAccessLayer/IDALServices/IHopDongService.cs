using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface IHopDongService
    {
        public List<HopDong> GetLstHopDong();
        public string ThemHopDong(HopDong HopDong);
        public string SuaHopDong(HopDong HopDong);
        public string XoaHopDong(HopDong HopDong);
        public string LuuHopDong();
    }
}
