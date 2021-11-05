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
    public class QLKhachHangSerive:IQLKhachHangService
    {
        private IKhachHangService _iKhachHangService;
        private List<KhachHang> _lstKhachHangBUS;
       


        public QLKhachHangSerive()
        {
            _iKhachHangService = new KhachHangService();
            _lstKhachHangBUS = new List<KhachHang>();
            getListKhachHang_BUS();

        }

        public List<KhachHang> getListKhachHang_BUS()
        {
            return _lstKhachHangBUS = _iKhachHangService.getLstKhachHang();
        }

       
        public string AddKhachHang_BUS(KhachHang khachHang)
        {
            _lstKhachHangBUS.Add(khachHang);
            return _iKhachHangService.InsertKH(khachHang);

        }

        public string EditKhachHang_BUS(KhachHang khachHang)
        {
            _lstKhachHangBUS[_lstKhachHangBUS.FindIndex(c => c.DienThoai == khachHang.DienThoai)] = khachHang;
            return _iKhachHangService.UpdateKH(khachHang);
        }

        public string DeleteNhanVien_BUS(KhachHang khachHang)
        {
            _lstKhachHangBUS[_lstKhachHangBUS.FindIndex(c => c.DienThoai == khachHang.DienThoai)] = khachHang;
            _lstKhachHangBUS.Remove(khachHang);
            return _iKhachHangService.DeleteKH(khachHang);
        }
        public List<KhachHang> getfind(string temp)
        {
            return _lstKhachHangBUS.Where(c => c.TenKhach.StartsWith(temp) || c.DienThoai.StartsWith(temp)).ToList();


        }
        public bool Checksdt(string sdt)
        {
            if (_lstKhachHangBUS.Where(x => x.DienThoai == sdt).FirstOrDefault() != null) return true;
            return false;
        }

        public string SaveData()
        {

            return _iKhachHangService.SaveData();
        }
    }
}
