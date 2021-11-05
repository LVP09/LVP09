using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IService
{
    public interface IQLNhanVienService
    {

        public List<NhanVien> getListNhanVien_BUS();

 
       
        public string AddNhanvien_BUS(NhanVien nhanVien);


        public string EditNhanVien_BUS(NhanVien nhanVien);

        public string DeleteNhanVien_BUS(NhanVien nhanVien);
        public string SaveData();
        public List<NhanVien> getfind(string temp);
        public bool CheckMail(string Mail);
        public bool CheckSdt(string Sdt);
    }
}
