using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Services;
using _1_DAL_DataAccessLayer.Models;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_QuenMatKhau : Form
    {
        private IQuenMatKhau QMK = new QuenMatKhau();
        private IQLNhanVienService nv = new QLNhanVienService();
        int _TimeNow, _Time;
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        NhanVien _NhanVien;
        private string mess = "Thông báo";
        private string _pass;
        private string _code;

        private int flag;
        public Frm_QuenMatKhau()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            Txt_XacNhan.Enabled = false;
            btn_XacNhan.Enabled = false;
        }
        //Hàm có nhiệm vụ lấy tham số truyền vào

        private void GetMessage(string Message)
        {
            txt_Email.Text = Message;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            _TimeNow = DateTime.Now.Minute;

            if (_TimeNow - _Time > 1)
            {
                MessageBox.Show("Đã quá thời gian 1 phút .\n Mã code đã vô hiệu hóa");

            }
            else if (flag == 3)
            {
                MessageBox.Show("Đã quá 3 lần xác nhân .\n Mã code đã vô hiệu hóa");

            }
            else if (Txt_XacNhan.Text == _code)
            {
                _NhanVien = new NhanVien();
                _NhanVien = nv.getListNhanVien_BUS().FirstOrDefault(c => c.Email == txt_Email.Text);
                _NhanVien.MatKhau = _pass;
                MessageBox.Show(nv.EditNhanVien_BUS(_NhanVien), mess);
                nv.SaveData();
                this.Close();
            }
            else
            {
                flag += 1;
                MessageBox.Show("Mã code không hợp lệ", mess);
            }
        }

        private void btn_SendtoEmail_Click(object sender, EventArgs e)
        {
            vadidatefrom();
            if (btn_SendtoEmail.Text == "Send")
            {
                flag = 0;
                txt_Email.Enabled = false;
                if (nv.getListNhanVien_BUS().Any(c => c.Email == txt_Email.Text) == false)
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống", mess);
                    txt_Email.Enabled = true;
                    return;
                }
                else
                {
                    var sendPassCode = QMK.SenderMail(txt_Email.Text);
                    if (sendPassCode == null)
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                    else
                    {
                        _pass = sendPassCode.pass;
                        _code = sendPassCode.code;

                        btn_XacNhan.Text = "Send";
                        MessageBox.Show("Mã Code đã được giử vào email", mess);
                        _Time = DateTime.Now.Minute;
                        Txt_XacNhan.Enabled = true;
                        btn_XacNhan.Enabled = true;
                        btn_SendtoEmail.Enabled = false;
                    }
                }
            }

            else if (btn_SendtoEmail.Text == "Send")
            {
                _TimeNow = DateTime.Now.Minute;

                if (_TimeNow - _Time > 1)
                {
                    MessageBox.Show("Đã quá thời gian 1 phút .\n Mã code đã vô hiệu hóa");

                }
                else if (flag == 3)
                {
                    MessageBox.Show("Đã quá 3 lần xác nhân .\n Mã code đã vô hiệu hóa");

                }
                else if (Txt_XacNhan.Text == _code)
                {
                    _NhanVien = new NhanVien();
                    _NhanVien = QMK.nhanViens(txt_Email.Text);
                    _NhanVien.MatKhau = _pass;
                    _NhanVien.TinhTrang = false;
                    MessageBox.Show(QMK.UpdatePass(_NhanVien), mess);
                    this.Close();
                }
                else
                {
                    flag += 1;
                    MessageBox.Show("Mã code không hợp lệ", mess);
                }
            }
        }
        bool vadidatefrom()
        {
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Không được để trống email ");
                return false;
            }
            if (string.IsNullOrEmpty(Txt_XacNhan.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã xác nhận ");
                return false;
            }
            return true;
        }

       

      







    }
}
