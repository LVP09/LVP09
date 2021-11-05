using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public  class QLDangNhapService: IQLDangNhapService
    {


        private INhanVienService iNhanVienService;
        private List<NhanVien> _lstNhanVienBUS;

        public QLDangNhapService()
        {
            iNhanVienService = new NhanVienService();
            _lstNhanVienBUS = new List<NhanVien>();
          
        }
        public List<NhanVien> getListNhanVien_BUS()
        {
            return _lstNhanVienBUS = iNhanVienService.getLstNhanVien();
        }
        


    }
}
