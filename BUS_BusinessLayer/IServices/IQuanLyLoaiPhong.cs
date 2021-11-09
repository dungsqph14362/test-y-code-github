using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace BUS_BusinessLayer.IServices
{
    public interface IQuanLyLoaiPhong
    {
        public List<LoaiPhong> GetLstLoaiPhong();
        public string ThemLoaiPhong(LoaiPhong LoaiPhong);
        public string SuaLoaiPhong(LoaiPhong LoaiPhong);
        public string XoaLoaiPhong(LoaiPhong LoaiPhong);
        public string LuuLoaiPhong();
    }
}
