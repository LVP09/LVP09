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
    public class QLNhanVienService : IQLNhanVienService
    {
        private INhanVienService _iNhanVienService;
        private List<NhanVien> _lstNhanVienBUS;
  
        public QLNhanVienService()
        {
            _iNhanVienService = new NhanVienService();
            _lstNhanVienBUS = new List<NhanVien>();
            getListNhanVien_BUS();

        }
        
        public List<NhanVien> getListNhanVien_BUS()
        {
            return _lstNhanVienBUS = _iNhanVienService.getLstNhanVien();
        }
      

        public string AddNhanvien_BUS(NhanVien nhanVien)
        {
           
            return _iNhanVienService.InsertNV(nhanVien);
           
        }

        public string EditNhanVien_BUS(NhanVien nhanVien)
        {
            return _iNhanVienService.UpdateNV(nhanVien);
        }

        public string DeleteNhanVien_BUS(NhanVien nhanVien)
        {
           
            return _iNhanVienService.DeleteNV(nhanVien);
        }
       
        public string SaveData()
        {
       
            
            return _iNhanVienService.SaveData();
        }
        public List<NhanVien> getfind(string temp)
        {
            return _lstNhanVienBUS.Where(c => c.Email.StartsWith(temp) || c.TenNv.StartsWith(temp)).ToList();


        }
        public bool CheckMail(string Mail)
        {
            if (_lstNhanVienBUS.Where(x => x.Email == Mail).FirstOrDefault() != null) return true;
            return false;
        }
        public bool CheckSdt(string Sdt)
        {
            if (_lstNhanVienBUS.Where(x => x.Sdt == Sdt).FirstOrDefault() != null) return true;
            return false;
        }

    }
}
