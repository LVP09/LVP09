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
    public class QLHangService: IQLHangService
    {
        private IHangService _iHangService;
        private List<Hang> _lstHangBUS;

        public QLHangService()
        {
            _iHangService = new HangService();
            _lstHangBUS = new List<Hang>();
            getListHang_BUS();
        }

        public List<Hang> getListHang_BUS()
        {
            return _lstHangBUS = _iHangService.getLstHang();
        }


        public string AddHang_BUS(Hang hang)
        {
            _lstHangBUS.Add(hang);
            return _iHangService.InsertHang(hang);

        }

        public string EditHang_BUS(Hang hang)
        {
            _lstHangBUS[_lstHangBUS.FindIndex(c => c.MaHang == hang.MaHang)] = hang;
            return _iHangService.UpdateHang(hang);
        }

        public string DeleteHang_BUS(Hang hang)
        {
            _lstHangBUS.RemoveAt(_lstHangBUS.FindIndex(c => c.MaHang == hang.MaHang));
            return _iHangService.DeleteHang(hang);
        }

        public string SaveData()
        {


            return _iHangService.SaveData();
        }
        public List<Hang> getfind(string temp)
        {
            return _lstHangBUS.Where(c => c.TenHang.StartsWith(temp)).ToList();


        }
        
    }
}
