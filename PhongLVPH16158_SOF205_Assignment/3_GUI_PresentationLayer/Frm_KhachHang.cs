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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_KhachHang : Form
    {
        
        private IQLKhachHangService _iQLKhachHangService;
        private IQLDangNhapService _iQLDangNhapService;
        private List<KhachHang> _lstKhachHangs;
      
        public static string maNVphake;

        string pkKhachHang;
         int flag;
        public Frm_KhachHang( )
        {
          
            InitializeComponent();
            
            _iQLKhachHangService = new QLKhachHangSerive();
            _lstKhachHangs = new List<KhachHang>();
            _iQLDangNhapService = new QLDangNhapService();
           
            LoadDataKH();
        
        }
        public void LoadDataKH()
        {
            _lstKhachHangs = new List<KhachHang>();
            _lstKhachHangs = _iQLKhachHangService.getListKhachHang_BUS();
            Dgrid_NV.ColumnCount = 5;
            Dgrid_NV.Columns[0].Name = "Số điện thoại";
            Dgrid_NV.Columns[1].Name = "Họ Và Tên";
            Dgrid_NV.Columns[2].Name = "Địa Chỉ";
            Dgrid_NV.Columns[3].Name = "Giới Tính";         
            Dgrid_NV.Columns[4].Name = "Nhân Viên Quản Lý";
          
            Dgrid_NV.Rows.Clear();
            foreach (var x in _lstKhachHangs)
            {
                Dgrid_NV.Rows.Add(x.DienThoai, x.TenKhach, x.DiaChi ,x.GioiTinh == true ? "Nam" : x.GioiTinh == false ? "Nữ" : "", _iQLDangNhapService.getListNhanVien_BUS().Where(c => c.MaNv == x.MaNv).Select(c => c.TenNv).FirstOrDefault());
            }
        }
       
        #region CRUD:



        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (validateFrom())
            {
                if (_iQLKhachHangService.Checksdt(txt_Sdt.Text))
                {
                    MessageBox.Show("Khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Sdt.Focus();

                }
                else
                {

               
                KhachHang khachHang = new KhachHang();
                khachHang.DienThoai = txt_Sdt.Text;
                khachHang.TenKhach = txt_HoTen.Text;
                khachHang.DiaChi = txt_DiaChi.Text;
                khachHang.GioiTinh = Convert.ToBoolean(rbtn_Nam.Checked ? true : false);
                khachHang.MaNv = Frm_KhachHang.maNVphake;
                if (MessageBox.Show($"Bạn có chắc chắn muốn thêm Khách Hànng {khachHang.TenKhach}", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(_iQLKhachHangService.AddKhachHang_BUS(khachHang), "Thông Báo");
                    ClearTextBox(this);

                    LoadDataKH();

                }
                flag = 1;
                }
            }
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {           
            
              if (validateFrom())
                {

                    var kh = _iQLKhachHangService.getListKhachHang_BUS().FirstOrDefault(c => c.DienThoai == pkKhachHang);

                    kh.DienThoai = txt_Sdt.Text;
                    kh.TenKhach = txt_HoTen.Text;
                    kh.DiaChi = txt_DiaChi.Text;                     
                    kh.GioiTinh = Convert.ToBoolean(rbtn_Nam.Checked ? 1 : 0);                  
                    if (MessageBox.Show($"Bạn có chắc chắn muốn sửa  khách  hàng {kh.TenKhach} ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show(_iQLKhachHangService.EditKhachHang_BUS(kh), "Thông Báo");
                        ClearTextBox(this);
                    }

                    LoadDataKH();
                    flag = 2;
                }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {


            try
            {
                var nhanVien = _iQLKhachHangService.getListKhachHang_BUS().FirstOrDefault(c => c.DienThoai == pkKhachHang);
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng {nhanVien.TenKhach}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show(_iQLKhachHangService.DeleteNhanVien_BUS(nhanVien), "Thông Báo");
                    ClearTextBox(this);
                }
                LoadDataKH();
                flag = 3;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           
            
        }
        #endregion

        public void ClearTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iQLKhachHangService.SaveData(), "Thông báo");
            flag = 4;
        }
        private bool validateFrom()
        {
         
            if (string.IsNullOrEmpty(txt_Sdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK);
                txt_Sdt.Focus();
                return false;
            }
            if (txt_Sdt.Text.Length > 11 && txt_Sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại bạn nhập không đúng định dạng", "Thông báo", MessageBoxButtons.OK);
                txt_Sdt.Focus();
                return false;

            }
            if (txt_HoTen.Text.All(char.IsDigit))
            {
                MessageBox.Show("Tên không hợp lệ mời nhập lại ! ", "Thông báo");
                txt_HoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_HoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK);
                txt_HoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_DiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txt_DiaChi.Focus();
                return false;
            }


            return true;
        }

        private void Dgrid_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            if (rowIndex == _iQLKhachHangService.getListKhachHang_BUS().Count || rowIndex == -1) return;


            txt_Sdt.Text = Dgrid_NV.Rows[rowIndex].Cells[0].Value.ToString();
            txt_HoTen.Text = Dgrid_NV.Rows[rowIndex].Cells[1].Value.ToString();          
            txt_DiaChi.Text = Dgrid_NV.Rows[rowIndex].Cells[2].Value.ToString();     
            rbtn_Nam.Checked = Dgrid_NV.Rows[rowIndex].Cells[3].Value.ToString() == "Nam" ? true : false;
            rbtn_Nu.Checked = Dgrid_NV.Rows[rowIndex].Cells[3].Value.ToString() == "Nữ" ? true : false;

            pkKhachHang = txt_Sdt.Text;
        }

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            ClearTextBox(this);
            LoadDataKH();
        }

        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            ClearTextBox(this);
            LoadDataKH();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            find(txt_TimKiem.Text);
        }
        public void find(string temp)
        {
            
            Dgrid_NV.ColumnCount = 5;
            Dgrid_NV.Columns[0].Name = "Số điện thoại";
            Dgrid_NV.Columns[1].Name = "Họ Và Tên";
            Dgrid_NV.Columns[2].Name = "Địa Chỉ";
            Dgrid_NV.Columns[3].Name = "Giới Tính";
            Dgrid_NV.Columns[4].Name = "Nhân Viên Quản Lý";

            Dgrid_NV.Rows.Clear();
            foreach (var x in _iQLKhachHangService.getfind(temp))
            {
                Dgrid_NV.Rows.Add(x.DienThoai, x.TenKhach, x.DiaChi, x.GioiTinh == true ? "Nam" : x.GioiTinh == false ? "Nữ" : "", _iQLDangNhapService.getListNhanVien_BUS().Where(c => c.MaNv == x.MaNv).Select(c => c.TenNv).FirstOrDefault());
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mời bạn nhập đúng định dạng số điện thoại!!!", "Thông báo");
                txt_Sdt.Focus();
            }
        }
    }
}
