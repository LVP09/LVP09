using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Models
{
    public class PassCode
    {
        public string pass { get; set; }
        public string code { get; set; }

        public PassCode(string pass, string code)
        {
            this.pass = pass;
            this.code = code;
        }
    }
}
