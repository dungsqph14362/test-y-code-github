using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BusinessLayer.IServices
{
   public interface IdangnhapServices
    {
        int checkLogin(string email, string pass);

        bool checkHD(string email);
    }
}
