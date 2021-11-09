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
    public class QuanLyHopDong : IQuanLyHopDong
    {
        private IHopDongService _service;
        private IKhachHangService _khachHangService;

        public QuanLyHopDong()
        {
            _service = new HopDongService();
            _khachHangService = new KhachHangService();
        }
        public List<HopDong> GetLstHopDong()
        {
            return _service.GetLstHopDong();
        }

        public string SuaHopDong(HopDong HopDong)
        {
            return _service.SuaHopDong(HopDong);
        }
        public string ThemHopDong(HopDong HopDong)
        {
            return _service.ThemHopDong(HopDong);
        }
        public List<HopDong> TimKiem(string Ma)
        {
            var acc = _khachHangService.GetLstKhachHang().Where(c => c.SoDienThoai == Ma).Select(c=>c.MaKhachHang);
            return _service.GetLstHopDong().Where(c => c.MaKhachHang == Convert.ToInt32(acc)).ToList();

        }
        public string XoaHopDong(HopDong HopDong)
        {
            return _service.XoaHopDong(HopDong);
        }
    }
}
