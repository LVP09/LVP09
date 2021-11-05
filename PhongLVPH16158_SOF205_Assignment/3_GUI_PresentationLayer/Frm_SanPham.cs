using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_SanPham : Form
    {
       
        private IQLHangService _iQLHangService;
        private IQLDangNhapService _iQLDangNhapService;
        private List<Hang> _lstHang;
        int pkHang;
        private int flag;
        public static string manvfake;
        string checkUrlImage;
        string fileName;
        string fileSavePath;
        string fileAddress;
        public Frm_SanPham()
        {
            InitializeComponent();
            _iQLHangService = new QLHangService();
            _iQLDangNhapService = new QLDangNhapService();
            _lstHang = new List<Hang>();
            LoadDatahang();


        }
        private void LoadDatahang()
        {
          
            _lstHang = new List<Hang>();
            _lstHang = _iQLHangService.getListHang_BUS();
            Dgrid_NV.ColumnCount = 8;
            Dgrid_NV.Columns[0].Name = " Mã hàng";
            Dgrid_NV.Columns[1].Name = " Tên Sản Phẩm";
            Dgrid_NV.Columns[2].Name = " Số Lượng";
            Dgrid_NV.Columns[3].Name = " Đơn Giá Nhập ";
            Dgrid_NV.Columns[4].Name = " Đơn Giá Bán";
            Dgrid_NV.Columns[5].Name = " Ghi Chú ";
            Dgrid_NV.Columns[6].Name = "Ảnh";
            Dgrid_NV.Columns["Ảnh"].Visible = false;
            Dgrid_NV.Columns[7].Name = " Nhân Viên bán";
           
           
            Dgrid_NV.Rows.Clear();
            foreach (var x in _lstHang)
            {
                Dgrid_NV.Rows.Add(x.MaHang, x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu, x.HinhAnh,
                    _iQLDangNhapService.getListNhanVien_BUS().Where(c => c.MaNv == x.MaNv).Select(c => c.TenNv).FirstOrDefault()
                  );

            }

        }

        
        #region CRUD:
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (validateFrom())
            {
                Hang hang = new Hang();
                hang.MaHang = _iQLHangService.getListHang_BUS().Max(c => c.MaHang) + 1;
                hang.TenHang = txt_TenHang.Text;
                hang.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                hang.DonGiaNhap = Convert.ToDouble(txt_GiaNhap.Text);
                hang.DonGiaBan = Convert.ToDouble(txt_GiaBan.Text);
                hang.GhiChu = txt_GhiChu.Text;
                hang.HinhAnh = txt_Hinh.Text;
                hang.MaNv = Frm_SanPham.manvfake;
                if (MessageBox.Show($"Bạn có chắc chắn muốn thêm Sản phẩm {hang.TenHang}", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(_iQLHangService.AddHang_BUS(hang), "Thông Báo");
                    //File.Copy(fileAddress, fileSavePath, true);
                    ClearTextBox(this);
                    LoadDatahang();

                }
                flag = 1;
            }
           

        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (validateFrom())
            {

                var hang = _iQLHangService.getListHang_BUS().FirstOrDefault(c => c.MaHang == pkHang);

                hang.TenHang = txt_TenHang.Text;
                hang.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                hang.DonGiaNhap = Convert.ToDouble(txt_GiaNhap.Text);
                hang.DonGiaBan = Convert.ToDouble(txt_GiaBan.Text);
                hang.GhiChu = txt_GhiChu.Text;

                if (MessageBox.Show($"Bạn có chắc chắn muốn sửa  khách  hàng {hang.TenHang} ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show(_iQLHangService.EditHang_BUS(hang), "Thông Báo");
                    ClearTextBox(this);
                }

                LoadDatahang();
                flag = 2;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var hang = _iQLHangService.getListHang_BUS().FirstOrDefault(c => c.MaHang == pkHang);
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng {hang.MaHang}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show(_iQLHangService.DeleteHang_BUS(hang), "Thông Báo");
                    ClearTextBox(this);
                }
                LoadDatahang();
                flag = 3;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Validate:
        private bool validateFrom()
        {
            if (string.IsNullOrEmpty(txt_TenHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên hàng", "Thông báo", MessageBoxButtons.OK);
                txt_TenHang.Focus();
                return false;
            }

            if (txt_TenHang.Text.All(char.IsDigit))
            {
                MessageBox.Show("Tên hàng không hợp lệ mời nhập lại ! ", "Thông báo");
                txt_TenHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_SoLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK);
                txt_SoLuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_GiaNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá nhập", "Thông báo", MessageBoxButtons.OK);
                txt_GiaNhap.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_GiaBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá bán", "Thông báo", MessageBoxButtons.OK);
                txt_GiaBan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_GhiChu.Text))
            {
                MessageBox.Show("Bạn chưa nhập ghi chú", "Thông báo", MessageBoxButtons.OK);
                txt_GhiChu.Focus();
                return false;
            }

            return true;
        }
        private void txt_GiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mời bạn nhập định dạng số ", "Thông báo");
                txt_GiaNhap.Focus();
            }
        }

        private void txt_GiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mời bạn nhập định dạng số ", "Thông báo");
                txt_GiaBan.Focus();
            }
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mời bạn nhập định dạng số ", "Thông báo");
                txt_GiaBan.Focus();
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
        private void Dgrid_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length- 10));
                int rowIndex = e.RowIndex;
                if (rowIndex == _iQLHangService.getListHang_BUS().Count || rowIndex == -1) return;
                pkHang = Convert.ToInt32(txt_MaHang.Text = Dgrid_NV.Rows[rowIndex].Cells[0].Value.ToString());
                txt_TenHang.Text = Dgrid_NV.Rows[rowIndex].Cells[1].Value.ToString();
                txt_SoLuong.Text = Dgrid_NV.Rows[rowIndex].Cells[2].Value.ToString();
                txt_GiaNhap.Text = Dgrid_NV.Rows[rowIndex].Cells[3].Value.ToString();
                txt_GiaBan.Text = Dgrid_NV.Rows[rowIndex].Cells[4].Value.ToString();
                txt_GhiChu.Text = Dgrid_NV.Rows[rowIndex].Cells[5].Value.ToString();
                txt_Hinh.Text = Dgrid_NV.Rows[rowIndex].Cells[6].Value.ToString();
                //checkUrlImage = txt_Hinh.Text;
                //pictureBox1.Image = Image.FromFile(saveDirectory + Dgrid_NV.CurrentRow.Cells[6].Value.ToString());


              
              
            




        }
        

     

        private void btn_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iQLHangService.SaveData(), "Thông báo");
            flag = 4;
        }
        private void findhang(string temp)
        {
            _lstHang = new List<Hang>();
            _lstHang = _iQLHangService.getListHang_BUS();
            Dgrid_NV.ColumnCount = 8;
            Dgrid_NV.Columns[0].Name = " Mã hàng";
            Dgrid_NV.Columns[1].Name = " Tên Sản Phẩm";
            Dgrid_NV.Columns[2].Name = " Số Lượng";
            Dgrid_NV.Columns[3].Name = " Đơn Giá Nhập ";
            Dgrid_NV.Columns[4].Name = " Đơn Giá Bán";
            Dgrid_NV.Columns[5].Name = " Ghi Chú ";
            Dgrid_NV.Columns[6].Name = "Ảnh";
            Dgrid_NV.Columns["Ảnh"].Visible = false;
            Dgrid_NV.Columns[7].Name = " Nhân Viên bán";

            Dgrid_NV.Rows.Clear();
            foreach (var x in _iQLHangService.getfind(temp))
            {
                Dgrid_NV.Rows.Add(x.MaHang, x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu, x.HinhAnh,
                     _iQLDangNhapService.getListNhanVien_BUS().Where(c => c.MaNv == x.MaNv).Select(c => c.TenNv).FirstOrDefault()
                   );
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            findhang(txt_Search.Text);
        }

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            ClearTextBox(this);
           LoadDatahang();
        }

        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            ClearTextBox(this);
            LoadDatahang();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult confirm;

            if (flag == 1 || flag == 2 || flag == 3)
            {
                confirm = MessageBox.Show("Dữ liệu chưa được lưu vào database \n bạn có muốn lưu trước khi thoát ?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirm == DialogResult.Yes)
                {
                    _iQLHangService.SaveData();
                    MessageBox.Show("Lưu thành công", "Thông báo");
                    this.Close();


                }


            }

            if (flag == 4)
            {

                this.Close();

            }

            this.Close();

        }

        private void btn_chonanh_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = @"Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình minh họa cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pictureBox1.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
                txt_Hinh.Text = "\\Images\\" + fileName;
            }
        }
      

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void btn_chonlai_Click_1(object sender, EventArgs e)
        {
            txt_Hinh.Clear();
          
        }
    }
}
