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
    public class HangService: IHangService
    {
        private List<Hang> _lstHangs;
        private DatabaseContext _dbContext;
        public HangService()
        {
            _lstHangs = new List<Hang>();
            _dbContext = new DatabaseContext();
            getLstHangFromDB();
        }
        public List<Hang> getLstHang()
        {
            return _lstHangs;
        }
        public void getLstHangFromDB()
        {
            _lstHangs = _dbContext.Hangs.ToList();
        }
        public string InsertHang(Hang hang)
        {
       
            
            _dbContext.Hangs.Add(hang);

            return "Thêm thành công ";

        }
        public string UpdateHang(Hang hang)
        {
            if (_dbContext.Hangs.ToList().Any(c => c.MaHang == hang.MaHang))
            {
                _dbContext.Hangs.Update(hang);
                return " Sửa thành Công";
            }
            else
            {
                return " Sửa thành Công";
            }

        }

        public string DeleteHang(Hang hang)
        {

            if (_dbContext.Hangs.ToList().Any(c => c.MaHang == hang.MaHang))
            {
                _dbContext.Hangs.Remove(hang);
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
