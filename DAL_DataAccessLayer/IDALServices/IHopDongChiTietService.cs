using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface IHopDongChiTietService
    {
        public List<HopDongChiTiet> GetLstHopDongChiTiet();
        public string ThemHopDongChiTiet(HopDongChiTiet HopDongChiTiet);
        public string SuaHopDongChiTiet(HopDongChiTiet HopDongChiTiet);
        public string XoaHopDongChiTiet(HopDongChiTiet HopDongChiTiet);
        public string LuuHopDongChiTiet();
    }
}
