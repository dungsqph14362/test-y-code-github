using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface ILoaiPhongService
    {
        public List<LoaiPhong> GetLstLoaiPhong();
        public string ThemLoaiPhong(LoaiPhong LoaiPhong);
        public string SuaLoaiPhong(LoaiPhong LoaiPhong);
        public string XoaLoaiPhong(LoaiPhong LoaiPhong);
        public string LuuLoaiPhong();
    }
}
