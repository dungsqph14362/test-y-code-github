using DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BusinessLayer.IServices
{
    public interface IQuanLyHopDong
    {
        public List<HopDong> GetLstHopDong();
        public string ThemHopDong(HopDong HopDong);
        public string SuaHopDong(HopDong HopDong);
        public string XoaHopDong(HopDong HopDong);
        public List<HopDong> TimKiem(string Ma);
    } 
}
