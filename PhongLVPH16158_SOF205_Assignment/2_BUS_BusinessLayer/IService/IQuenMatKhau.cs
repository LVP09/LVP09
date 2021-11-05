using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IService
{
    public interface IQuenMatKhau
    {
        public PassCode SenderMail(string mail);
        public NhanVien nhanViens(string email);
        public string UpdatePass(NhanVien nv);
    }
}
