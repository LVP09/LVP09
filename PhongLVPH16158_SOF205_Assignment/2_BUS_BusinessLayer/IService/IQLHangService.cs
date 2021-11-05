using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IService
{
    public interface IQLHangService
    {
        public List<Hang> getListHang_BUS();


        public string AddHang_BUS(Hang hang);


        public string EditHang_BUS(Hang hang);


        public string DeleteHang_BUS(Hang hang);



        public string SaveData();


        public List<Hang> getfind(string temp);
    }
}
