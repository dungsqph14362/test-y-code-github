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
    public class QuanLyLoaiPhong : IQuanLyLoaiPhong
    {
        private ILoaiPhongService _ILoaiPhongService;

        public QuanLyLoaiPhong()
        {
            _ILoaiPhongService = new LoaiPhongService();
        }

        public List<LoaiPhong> GetLstLoaiPhong()
        {
            return _ILoaiPhongService.GetLstLoaiPhong();
        }

        public string LuuLoaiPhong()
        {
            return _ILoaiPhongService.LuuLoaiPhong();
        }

        public string SuaLoaiPhong(LoaiPhong LoaiPhong)
        {
            return _ILoaiPhongService.SuaLoaiPhong(LoaiPhong);
        }

        public string ThemLoaiPhong(LoaiPhong LoaiPhong)
        {
            return _ILoaiPhongService.ThemLoaiPhong(LoaiPhong);
        }

        public string XoaLoaiPhong(LoaiPhong LoaiPhong)
        {
            return _ILoaiPhongService.XoaLoaiPhong(LoaiPhong);
        }
    }
}
