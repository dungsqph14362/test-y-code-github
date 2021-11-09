using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface IChucVuService
    {
        public List<ChucVu> GetLstChucVu();
        public string ThemChucVu(ChucVu ChucVu);
        public string SuaChucVu(ChucVu ChucVu);
        public string XoaChucVu(ChucVu ChucVu);
        public string LuuChucVu();
    }
}
