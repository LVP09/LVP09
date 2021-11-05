using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.DALService
{
    public class NhanVienService : INhanVienService
    {
        private List<NhanVien> lstNhanViens;
        private DatabaseContext _dbContext;
        public NhanVienService()
        {
            lstNhanViens = new List<NhanVien>();
            _dbContext = new DatabaseContext();
            getLstNhanVienFromDB();
        }
        public List<NhanVien> getLstNhanVien()
        {
            return lstNhanViens;
        }
        public void getLstNhanVienFromDB()
        {
            lstNhanViens = _dbContext.NhanViens.ToList();
        }
        public string InsertNV(NhanVien nhanVien)
        {
            nhanVien.Id = lstNhanViens.Max(c => c.Id) + 1;
            nhanVien.MaNv = "NV" + nhanVien.Id;
            lstNhanViens.Add(nhanVien);
            _dbContext.NhanViens.Add(nhanVien);
           
            return "Thêm thành công ";

        }
        public string UpdateNV(NhanVien nhanVien)
        {
           
                _dbContext.NhanViens.Update(nhanVien);
                return " Sửa thành Công";
            

        }
      

        public string DeleteNV(NhanVien nhanVien)
        {
            lstNhanViens.Remove(nhanVien);
                _dbContext.NhanViens.Remove(nhanVien);
                return " Xóa thành Công";
           
        }
        
        public string SaveData()
        {
            _dbContext.SaveChanges();
            return " Lưu Thành Công";
        }
        
    }
}
