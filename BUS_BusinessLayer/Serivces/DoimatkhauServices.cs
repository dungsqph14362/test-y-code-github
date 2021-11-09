using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_BusinessLayer.IServices;
using BUS_BusinessLayer.unlititi;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.IDALServices;
using DAL_DataAccessLayer.Models;

namespace BUS_BusinessLayer.Serivces
{
    public class DoimatkhauServices : IDoimatkhauServices
    {
        private IChuTroService _ct;
        private Unlititi uni = new Unlititi();
        private ChuTro _chutro;
        private List<ChuTro> _lstChuTros;
        public DoimatkhauServices()
        {
            _ct = new ChuTroService();
            _lstChuTros = _ct.GetLstChuTro();
        }
        public string UpdatePass(ChuTro ct)
        {
            try
            {
                _ct.SuaChuTro(ct);
                _ct.LuuChuTro();
                return "Mật khẩu đã được đổi thành công";
            }
            catch (Exception e)
            {
                return "Lỗi";
            }
        }

        public ChuTro chutros(string email, string pass)
        {
            try
            {
                _chutro = new ChuTro();
                _chutro = _lstChuTros.FirstOrDefault(c => c.Email == email);
                if (_chutro != null)
                {
                    if (_chutro.MatKhau == pass)
                    {
                        return _chutro;
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
