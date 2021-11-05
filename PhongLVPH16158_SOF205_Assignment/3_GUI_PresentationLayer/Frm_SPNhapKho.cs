using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_SPNhapKho : Form
    {

        private IQLNhanVienService _iQLNhanVienService;
        private IQLHangService _iQLHangService;
      
        public Frm_SPNhapKho()
        {
            InitializeComponent();
            _iQLNhanVienService = new QLNhanVienService();
            _iQLHangService = new QLHangService();

        }
        

        private void btn_nvNhaphang_Click(object sender, EventArgs e)
        {
            var maNhanVien = _iQLNhanVienService.getListNhanVien_BUS().Where(c => c.TenNv == txt_TenNV.Text).Select(c => c.MaNv)
               .FirstOrDefault();
            DGV_ThongKe.ColumnCount = 6;
            DGV_ThongKe.Columns[0].Name = "  Tên Sản Phẩm";
            DGV_ThongKe.Columns[1].Name = "  Số Lượng";
            DGV_ThongKe.Columns[2].Name = "  Đơn Giá Nhập ";
            DGV_ThongKe.Columns[3].Name = "  Đơn Giá Xuất";
            DGV_ThongKe.Columns[4].Name = "  Ghi Chú ";
            DGV_ThongKe.Columns[5].Name = " Nhân Viên nhập";
            DGV_ThongKe.Rows.Clear();

            foreach (var x in _iQLHangService.getListHang_BUS().Where(c => c.MaNv == maNhanVien))
            {
                DGV_ThongKe.Rows.Add(x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu,
                    _iQLNhanVienService.getListNhanVien_BUS().Where(c => c.MaNv == x.MaNv).Select(c => c.TenNv).FirstOrDefault());
            }
        }

        private void btn_hangTon_Click(object sender, EventArgs e)
        {
            DGV_ThongKe.ColumnCount = 6;
            DGV_ThongKe.Columns[0].Name = "  Tên Sản Phẩm";
            DGV_ThongKe.Columns[1].Name = "  Số Lượng";
            DGV_ThongKe.Columns[2].Name = "  Đơn Giá Nhập ";
            DGV_ThongKe.Columns[3].Name = "  Đơn Giá Xuất";
            DGV_ThongKe.Columns[4].Name = "  Ghi Chú ";
            DGV_ThongKe.Columns[5].Name = " Nhân Viên nhập";
            DGV_ThongKe.Rows.Clear();

            foreach (var x in _iQLHangService.getListHang_BUS().Where(c => c.SoLuong > 0 ))
            {
                DGV_ThongKe.Rows.Add(x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu,
                    _iQLNhanVienService.getListNhanVien_BUS().Where(c => c.MaNv == x.MaNv).Select(c => c.TenNv).FirstOrDefault());
            }
        }
    }
}
