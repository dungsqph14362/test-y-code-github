using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Models;

namespace BUS_BusinessLayer.IServices
{
    public interface IDoimatkhauServices
    {
        string UpdatePass(ChuTro ct);
        ChuTro chutros(string email, string pass);
    }
}
