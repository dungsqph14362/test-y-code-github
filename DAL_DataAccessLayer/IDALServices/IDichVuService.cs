using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace DAL_DataAccessLayer.IDALServices
{
    public interface IDichVuService
    {
        public List<DichVu> GetLstDichVu();
        public string ThemDichVu(DichVu DichVu);
        public string SuaDichVu(DichVu DichVu);
        public string XoaDichVu(DichVu DichVu);
        public string luuDichVu();
    }
}
