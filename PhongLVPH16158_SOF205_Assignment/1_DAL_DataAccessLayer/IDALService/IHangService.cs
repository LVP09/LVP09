using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALService
{
   public interface IHangService
    {
        public List<Hang> getLstHang();


        public void getLstHangFromDB();


        public string InsertHang(Hang hang);


        public string UpdateHang(Hang hang);



        public string DeleteHang(Hang hang);



        public string SaveData();
       
    }
}
