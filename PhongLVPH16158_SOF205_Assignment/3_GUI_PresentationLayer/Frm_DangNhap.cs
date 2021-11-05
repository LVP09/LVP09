using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Models;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_DangNhap : Form
    {
       
       
        
        private IQLDangNhapService _iQLDangNhapService;
        private NhanVien nhanVien;
        private List<NhanVien> listNhanViens;
        public bool vaitro { get; set; }
        public Frm_DangNhap()
        {
            InitializeComponent();
            _iQLDangNhapService = new QLDangNhapService();          
            listNhanViens = new List<NhanVien>();
            listNhanViens = _iQLDangNhapService.getListNhanVien_BUS();
            nhanVien = new NhanVien();


        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

            nhanVien = _iQLDangNhapService.getListNhanVien_BUS().Where(c => c.Email == txt_TaiKhoan.Text && c.MatKhau == txt_MatKhau.Text && c.TinhTrang == true).FirstOrDefault();


            if (KiemTraDangNhap())
            {
                if (_iQLDangNhapService.getListNhanVien_BUS().Any(c => c.Email == txt_TaiKhoan.Text && c.MatKhau == txt_MatKhau.Text && c.TinhTrang == true))
                {
                    vaitro = nhanVien.VaiTro;
                    Frm_Main.mail = txt_TaiKhoan.Text;                
                    Frm_KhachHang.maNVphake = nhanVien.MaNv;
                    Frm_SanPham.manvfake = nhanVien.MaNv;
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    Frm_Main.session = 1;                 
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công,kiểm tra lại email hoặc mật khẩu ");

                    txt_TaiKhoan.Focus();
                }
            }
            

        }
        
        #region Method
        bool KiemTraDangNhap()
        {
           

            if (string.IsNullOrEmpty(txt_TaiKhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập email", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_TaiKhoan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MatKhau.Focus();
                return false;
            }

            return true;
        }
        #endregion
       

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            Frm_Main.session = 0;
        }

        private void Frm_DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void llb_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_QuenMatKhau QMK = new Frm_QuenMatKhau();
            this.Hide();
            QMK.ShowDialog();
            this.Show();


        }
    }
}

