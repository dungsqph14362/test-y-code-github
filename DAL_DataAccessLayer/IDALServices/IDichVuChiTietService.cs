using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface IDichVuChiTietService
    {
        public List<DichVuChiTiet> GetLstDichVuChiTiet();
        public string ThemDichVuChiTiet(DichVuChiTiet DichVuChiTiet);
        public string SuaDichVuChiTiet(DichVuChiTiet DichVuChiTiet);
        public string XoaDichVuChiTiet(DichVuChiTiet DichVuChiTiet);
        public string LuuDichVuChiTiet();
    }
}
