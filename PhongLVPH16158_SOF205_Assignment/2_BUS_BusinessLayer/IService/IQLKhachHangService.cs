using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IService
{
    public interface IQLKhachHangService
    {
        public List<KhachHang> getListKhachHang_BUS();



        public string AddKhachHang_BUS(KhachHang khachHang);


        public string EditKhachHang_BUS(KhachHang khachHang);


        public string DeleteNhanVien_BUS(KhachHang khachHang);
        public List<KhachHang> getfind(string temp);


        public bool Checksdt(string sdt);
        public string SaveData();
        
    }
}
