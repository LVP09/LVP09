using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IService
{
   public interface IQLDangNhapService
    {
        public List<NhanVien> getListNhanVien_BUS();

    }
}
