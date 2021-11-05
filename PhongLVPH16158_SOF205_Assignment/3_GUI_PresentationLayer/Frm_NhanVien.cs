
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
    public partial class Frm_NhanVien : Form
    {
       
        private IQLNhanVienService _INhanVienService_bus;
        private List<NhanVien> _lstNhanViens;
        int pkNhanVien;
        private int flag;
        public Frm_NhanVien()
        {
            InitializeComponent();
            _INhanVienService_bus = new QLNhanVienService();
              _lstNhanViens = new List<NhanVien>();
            rbtn_QuanTri.Checked = true;
            Cbx_HoatDong.Checked = true;
            LoadDataNV();         



        }
       
        public void LoadDataNV()
        {
            _lstNhanViens = new List<NhanVien>();
            _lstNhanViens = _INhanVienService_bus.getListNhanVien_BUS();
            Dgrid_NV.ColumnCount = 9;
            Dgrid_NV.Columns[0].Name = "MaNV";
            Dgrid_NV.Columns[1].Name = "Tên Nhân Viên";      
            Dgrid_NV.Columns[2].Name = "Địa Chỉ";
            Dgrid_NV.Columns[3].Name = "SDT";
            Dgrid_NV.Columns[4].Name = "Email";
            Dgrid_NV.Columns[5].Name = "Mật Khẩu";
            Dgrid_NV.Columns[6].Name = "Vai Trò";
            Dgrid_NV.Columns[7].Name = "Trạng Thái";
            Dgrid_NV.Columns[8].Name = "idNV";
            Dgrid_NV.Columns["idNV"].Visible = false;
            Dgrid_NV.Rows.Clear();
            foreach (var x in _lstNhanViens) 
            {
                Dgrid_NV.Rows.Add(x.MaNv,x.TenNv,x.DiaChi,x.Sdt,x.Email,x.MatKhau,x.VaiTro == true ?"Quản Trị":x.VaiTro == false ?"Nhân Viên":"",x.TinhTrang == true?"Hoạt Động":x.TinhTrang == false? "Ngừng Hoạt Động" : "",x.Id);
            }
        }
        public void find(string temp)
        {
            Dgrid_NV.ColumnCount = 9;
            Dgrid_NV.Columns[0].Name = "MaNV";
            Dgrid_NV.Columns[1].Name = "Tên Nhân Viên";
            Dgrid_NV.Columns[2].Name = "Địa Chỉ";
            Dgrid_NV.Columns[3].Name = "SDT";
            Dgrid_NV.Columns[4].Name = "Email";
            Dgrid_NV.Columns[5].Name = "Mật Khẩu";
            Dgrid_NV.Columns[6].Name = "Vai Trò";
            Dgrid_NV.Columns[7].Name = "Trạng Thái";
            Dgrid_NV.Columns[8].Name = "idNV";
            Dgrid_NV.Columns["idNV"].Visible = false;
            Dgrid_NV.Rows.Clear();
            foreach (var x in _INhanVienService_bus.getfind(temp))
            {
                Dgrid_NV.Rows.Add(x.MaNv, x.TenNv, x.DiaChi, x.Sdt, x.Email, x.MatKhau, x.VaiTro == true ? "Quản Trị" : x.VaiTro == false ? "Nhân Viên" : "", x.TinhTrang == true ? "Hoạt Động" : x.TinhTrang == false ? "Ngừng Hoạt Động" : "",x.Id);
            }
        }
        #region CRUD:
        private void btn_Them_Click(object sender, EventArgs e)
        { 
            if (validateFrom())
            {
                if (_INhanVienService_bus.CheckMail(txt_Email.Text) && _INhanVienService_bus.CheckSdt(txt_SDT.Text))
                {
                    MessageBox.Show("Nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TenNV.Focus();

                }
                else
                {

                
                NhanVien nhanVien = new NhanVien();
                nhanVien.TenNv = txt_TenNV.Text;
                nhanVien.DiaChi = txt_DiaChiNV.Text;
                nhanVien.Sdt = txt_SDT.Text;
                nhanVien.Email = txt_Email.Text;
                nhanVien.MatKhau = txt_MatKhau.Text;
                nhanVien.VaiTro = Convert.ToBoolean(rbtn_QuanTri.Checked ? true : false);
                nhanVien.TinhTrang = Convert.ToBoolean(Cbx_HoatDong.Checked ? true : false);
                nhanVien.MatKhau = txt_MatKhau.Text;
                if (MessageBox.Show($"Bạn có chắc chắn muốn thêm  nhân viên {nhanVien.TenNv}", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(_INhanVienService_bus.AddNhanvien_BUS(nhanVien), "Thông Báo");
                    ClearTextBox(this);
                   
                    LoadDataNV();

                }              
                flag = 1;
                }
            }
            

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (pkNhanVien == 0)
            {
                MessageBox.Show("Mời bạn click nhân viên để xóa", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (validateFrom())
                {

                    var nhanVien = _INhanVienService_bus.getListNhanVien_BUS().FirstOrDefault(c => c.Id == pkNhanVien);

                    nhanVien.TenNv = txt_TenNV.Text;
                    nhanVien.DiaChi = txt_DiaChiNV.Text;
                    nhanVien.Sdt = txt_SDT.Text;
                    nhanVien.Email = txt_Email.Text;
                    nhanVien.MatKhau = txt_MatKhau.Text;
                    nhanVien.VaiTro = Convert.ToBoolean(rbtn_NhanVien.Checked ? 1 : 0);
                    nhanVien.TinhTrang = Convert.ToBoolean(Cbx_HoatDong.Checked ? 1 : 0);
                    if (MessageBox.Show($"Bạn có chắc chắn muốn sửa  nhân viên {nhanVien.TenNv} ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show(_INhanVienService_bus.EditNhanVien_BUS(nhanVien), "Thông Báo");
                        ClearTextBox(this);
                    }

                    LoadDataNV();
                    flag = 2;
                }
            }

           

          

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (pkNhanVien == 0)
            {
                MessageBox.Show("Mời bạn click nhân viên để xóa", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pkNhanVien == 1)
                {
                    MessageBox.Show("Tài khoản quản trị ứng dụng không thể xóa", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var nhanVien = _INhanVienService_bus.getListNhanVien_BUS().FirstOrDefault(c => c.Id == pkNhanVien);

                    if (MessageBox.Show($"Bạn có chắc chắn muốn xóa  nhân viên{nhanVien.TenNv}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        MessageBox.Show(_INhanVienService_bus.DeleteNhanVien_BUS(nhanVien), "Thông Báo");
                        ClearTextBox(this);
                    }


                    LoadDataNV();
                    flag = 3;
                }
            }
           

        }
        #endregion


        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            find(txt_Search.Text);
        }

        private void Dgrid_NV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            if (rowIndex == _INhanVienService_bus.getListNhanVien_BUS().Count || rowIndex == -1) return;

            
            txt_TenNV.Text = Dgrid_NV.Rows[rowIndex].Cells[1].Value.ToString();
            txt_DiaChiNV.Text = Dgrid_NV.Rows[rowIndex].Cells[2].Value.ToString();
            txt_SDT.Text = Dgrid_NV.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Email.Text = Dgrid_NV.Rows[rowIndex].Cells[4].Value.ToString();
            txt_MatKhau.Text = Dgrid_NV.Rows[rowIndex].Cells[5].Value.ToString();
            rbtn_QuanTri.Checked = Dgrid_NV.Rows[rowIndex].Cells[6].Value.ToString() == "Quản Trị" ? true : false;
            rbtn_NhanVien.Checked = Dgrid_NV.Rows[rowIndex].Cells[6].Value.ToString() == "Nhân Viên" ? true : false;         
            Cbx_HoatDong.Checked = Dgrid_NV.Rows[rowIndex].Cells[7].Value.ToString() == "Hoạt Động" ? true : false;
            cbx_KhongHD.Checked = Dgrid_NV.Rows[rowIndex].Cells[7].Value.ToString() == "Ngừng Hoạt Động" ? true : false;
            pkNhanVien = Convert.ToInt32(Dgrid_NV.Rows[rowIndex].Cells[8].Value.ToString());



        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(_INhanVienService_bus.SaveData(), "Thông báo");
            flag = 4;
        }
        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            ClearTextBox(this);
            LoadDataNV();
        }
        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            ClearTextBox(this);
            LoadDataNV();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
          
            DialogResult confirm;

            if (flag == 1 ||  flag == 2 || flag == 3)
            {
                 confirm = MessageBox.Show("Dữ liệu chưa được lưu vào database \n bạn có muốn lưu trước khi thoát ?",
                     "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (confirm == DialogResult.Yes)
                {
                    _INhanVienService_bus.SaveData();
                     MessageBox.Show("Lưu thành công","Thông báo");
                    this.Close();
                    
                  
                }
              
                           
            }

            if ( flag == 4)
            {
              
                this.Close();

            }
          
            this.Close();
    


        }
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
        bool validateFrom()
        {
            if (string.IsNullOrEmpty(txt_TenNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo", MessageBoxButtons.OK);
                txt_TenNV.Focus();
                return false;
            }
            if ( txt_TenNV.Text.All(char.IsDigit))
            {
                MessageBox.Show("Tên không hợp lệ mời nhập lại ! ", "Thông báo");

                return false;
            }
            if (string.IsNullOrEmpty(txt_DiaChiNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txt_DiaChiNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoạt", "Thông báo", MessageBoxButtons.OK);
                txt_SDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Bạn chưa nhập email", "Thông báo", MessageBoxButtons.OK);
                txt_Email.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK);
                txt_MatKhau.Focus();
                return false;

            }
            if (Cbx_HoatDong.Checked == false && cbx_KhongHD.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
          
            if (txt_SDT.Text.Length > 11 || txt_SDT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại bạn nhập không đúng định dạng", "Thông báo", MessageBoxButtons.OK);
                txt_MatKhau.Focus();
                return false;

            }
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
             @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(txt_Email.Text))
            {}
            else
            {
                MessageBox.Show("Email bạn nhập không đúng định dạng", "Thông báo", MessageBoxButtons.OK);
                txt_Email.Focus();
                return false;
            }
            

          
            return true;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" Mời bạn nhập đúng định dạng số điện thoại!!!", "Thông báo");
                txt_SDT.Focus();
            }
        }

        private void Cbx_HoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx_HoatDong.Checked)
            {
                cbx_KhongHD.Checked = false;
            }
        }

        private void cbx_KhongHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_KhongHD.Checked)
            {
                Cbx_HoatDong.Checked = false;
            }
        }

        private void lbFrmKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
