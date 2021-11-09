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
    public class dangnhapServices : IdangnhapServices
    {
        private IChuTroService _ct = new ChuTroService();
        private Unlititi uni = new Unlititi();
        private List<ChuTro> _lstChuTros;

        public dangnhapServices()
        {
            _lstChuTros = new List<ChuTro>();
            _lstChuTros = _ct.GetLstChuTro();
        }
        public int checkLogin(string email, string pass)
        {
            try
            {
                var chutro = _lstChuTros.Where(c => c.Email == email).FirstOrDefault();

                if (chutro != null)
                {
                    if (chutro.MatKhau == pass)
                    {
                        var role = chutro.ChucVu;
                        return role;
                    }
                }
                return -1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public bool checkHD(string email)
        {
            try
            {
                var status = _lstChuTros.Where(c => c.Email == email).Select(c => c.TrangThai).FirstOrDefault();
                if (status == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return true;
            }
        }
    }
}
