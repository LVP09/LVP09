using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IKhachHangService
    {
        public List<KhachHang> getLstKhachHang();


        public void getLstKhachHangFromDB();


        public string InsertKH(KhachHang khachHang);


        public string UpdateKH(KhachHang khachHang);



        public string DeleteKH(KhachHang KhachHang);
            

        public string SaveData();
       
    }
}
