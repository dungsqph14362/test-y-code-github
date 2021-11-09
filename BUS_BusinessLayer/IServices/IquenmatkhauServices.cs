using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_BusinessLayer.Model;
using DAL_DataAccessLayer.Models;

namespace BUS_BusinessLayer.IServices
{
   public interface IquenmatkhauServices
    {
        PassXn SenderMail(string mail);
        bool checkEmail(string email);
        string suaMK(ChuTro ct);
        ChuTro chutros(string email);
    }
}
