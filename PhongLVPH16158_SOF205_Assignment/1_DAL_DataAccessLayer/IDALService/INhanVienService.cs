using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface INhanVienService
    {
        public List<NhanVien> getLstNhanVien();

        public void getLstNhanVienFromDB();

        public string InsertNV(NhanVien nhanVien);

        public string UpdateNV(NhanVien nhanVien);
     

        public string DeleteNV(NhanVien nhanVien);
        public string SaveData();

    }
}
