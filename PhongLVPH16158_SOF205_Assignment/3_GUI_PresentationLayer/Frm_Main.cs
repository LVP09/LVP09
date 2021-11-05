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
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
   
    public partial class Frm_Main : Form
    {
        Frm_DangNhap dn ;
        public static int session = 0;
        public static string mail;
        IQLNhanVienService iQLNhanVienService;


        public Frm_Main()
        {
            InitializeComponent();
            lbl_ChaoBan.Text = null;
            iQLNhanVienService = new QLNhanVienService();


        }
        
       

        private bool CheckExistFrom(string name)
        {
            IsMdiContainer = true;
            bool check = false;
            foreach (Form frm  in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void Resetvalue()
        {
            if (session == 1)
            {
                lbl_ChaoBan.Text = " Chào: " + Frm_Main.mail;
                item_DangXuat.Enabled = true;
                item_NV.Enabled = true;
                item_KH.Enabled = true;
                item_SP.Enabled = true;
                item_SPNhapKho.Enabled = true;
            
                item_DangNhap.Enabled = false;
                if (dn.vaitro == false)
                {
                    item_NV.Enabled = false;
                }


            }
            else
            {
                item_NV.Enabled = false;
                item_KH.Enabled = false;
                item_SP.Enabled = false;
                item_SPNhapKho.Enabled = false;
              
                item_DangNhap.Enabled = true;
            }   
        }

        

       
       
        private void item_DangNhap_Click(object sender, EventArgs e)
        {
             dn = new Frm_DangNhap();

            if (!CheckExistFrom("Frm_DangNhap"))
            {
                
                dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);



            }
            else
            {
                ActiveChildForm("Frm_DangNhap");
            }
        }

        private void Frm_DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Resetvalue();
        }

        private void item_DangXuat_Click(object sender, EventArgs e)
        {
            item_NV.Enabled = false;
            item_KH.Enabled = false;
            item_SP.Enabled = false;
            item_SPNhapKho.Enabled = false;
         
            item_DangXuat.Enabled = false;
            item_DangNhap.Enabled = true;
            lbl_ChaoBan.Text = null;
         
            
           

        }
        private void item_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void item_NV_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("Frm_NhanVien"))
            {
                Frm_NhanVien nv = new Frm_NhanVien(); ;
                nv.MdiParent = this;
                nv.Show();


            }
            else
            {
                ActiveChildForm("Frm_NhanVien");
            }

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            item_DangXuat.Enabled = false;
            Resetvalue();
            
        }

        private void item_SP_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("Frm_SanPham"))
            {
                Frm_SanPham nv = new Frm_SanPham(); ;
                nv.MdiParent = this;
                nv.Show();


            }
            else
            {
                ActiveChildForm("Frm_SanPham");
            }
        }

        private void item_KH_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("Frm_KhachHang"))
            {
                Frm_KhachHang nv = new Frm_KhachHang();
                nv.MdiParent = this;               
                nv.Show();
                


            }
            else
            {
                ActiveChildForm("Frm_KhachHang");
            }
        }  
        private void item_SPNhapKho_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("Frm_SPNhapKho"))
            {
                Frm_SPNhapKho nv = new Frm_SPNhapKho();
                nv.MdiParent = this;
                nv.Show();



            }
            else
            {
                ActiveChildForm("Frm_SPNhapKho");
            }
        }


        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "PDF |*.pdf";
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    axAcroPDF1.src = ofd.FileName;
            //}
        }
    }
}
