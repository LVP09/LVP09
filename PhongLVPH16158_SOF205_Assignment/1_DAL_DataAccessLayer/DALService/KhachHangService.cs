using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.DALService
{
    public class KhachHangService: IKhachHangService
    {
        private List<KhachHang> lstKhachHangs;
        private DatabaseContext _dbContext;
        public KhachHangService()
        {
            lstKhachHangs = new List<KhachHang>();
            _dbContext = new DatabaseContext();
            getLstKhachHangFromDB();
        }
        public List<KhachHang> getLstKhachHang()
        {
            return lstKhachHangs;
        }
        public void getLstKhachHangFromDB()
        {
            lstKhachHangs = _dbContext.KhachHangs.ToList();
        }
        public string InsertKH(KhachHang khachHang)
        {

            
            _dbContext.KhachHangs.Add(khachHang);

            return "Thêm thành công ";

        }
        public string UpdateKH(KhachHang khachHang)
        {
            if (_dbContext.KhachHangs.ToList().Any(c => c.DienThoai == khachHang.DienThoai))
            {
                _dbContext.KhachHangs.Update(khachHang);
                return " Sửa thành Công";
            }
            else
            {
                return " Sửa thành Công";
            }

        }

        public string DeleteKH(KhachHang khachHang)
        {
            if (_dbContext.KhachHangs.ToList().Any(c => c.DienThoai == khachHang.DienThoai))
            {
                _dbContext.KhachHangs.Remove(khachHang);
                return " Xóa thành Công";
            }
            else
            {
                return " Xóa thành Công";
            }

            
        }

        public string SaveData()
        {
            _dbContext.SaveChanges();
            return " Lưu Thành Công";
        }
    }
}
