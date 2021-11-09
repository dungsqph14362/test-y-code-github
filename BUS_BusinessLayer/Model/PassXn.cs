using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BusinessLayer.Model
{
   public class PassXn
    {
        public string pass { get; set; }
        public string code { get; set; }

        public PassXn(string pass, string code)
        {
            this.pass = pass;
            this.code = code;
        }
    }
}
