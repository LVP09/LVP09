
namespace _3_GUI_PresentationLayer
{
    partial class Frm_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_KhongHD = new System.Windows.Forms.CheckBox();
            this.Cbx_HoatDong = new System.Windows.Forms.CheckBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.rbtn_QuanTri = new System.Windows.Forms.RadioButton();
            this.rbtn_NhanVien = new System.Windows.Forms.RadioButton();
            this.txt_DiaChiNV = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Dgrid_NV = new System.Windows.Forms.DataGridView();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFrmKhachHang = new System.Windows.Forms.Label();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Boqua = new System.Windows.Forms.Button();
            this.btn_DanhSach = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_KhongHD
            // 
            this.cbx_KhongHD.AutoSize = true;
            this.cbx_KhongHD.Location = new System.Drawing.Point(836, 187);
            this.cbx_KhongHD.Name = "cbx_KhongHD";
            this.cbx_KhongHD.Size = new System.Drawing.Size(155, 24);
            this.cbx_KhongHD.TabIndex = 97;
            this.cbx_KhongHD.Text = "Ngừng Hoạt Động";
            this.cbx_KhongHD.UseVisualStyleBackColor = true;
            this.cbx_KhongHD.CheckedChanged += new System.EventHandler(this.cbx_KhongHD_CheckedChanged);
            // 
            // Cbx_HoatDong
            // 
            this.Cbx_HoatDong.AutoSize = true;
            this.Cbx_HoatDong.Location = new System.Drawing.Point(712, 187);
            this.Cbx_HoatDong.Name = "Cbx_HoatDong";
            this.Cbx_HoatDong.Size = new System.Drawing.Size(105, 24);
            this.Cbx_HoatDong.TabIndex = 96;
            this.Cbx_HoatDong.Text = "Hoạt Động";
            this.Cbx_HoatDong.UseVisualStyleBackColor = true;
            this.Cbx_HoatDong.CheckedChanged += new System.EventHandler(this.Cbx_HoatDong_CheckedChanged);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatKhau.Location = new System.Drawing.Point(712, 130);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(218, 27);
            this.txt_MatKhau.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(591, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 94;
            this.label3.Text = "Mật khẩu:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Thoat.Location = new System.Drawing.Point(1034, 740);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 38);
            this.btn_Thoat.TabIndex = 93;
            this.btn_Thoat.Text = "Đóng";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Save.Location = new System.Drawing.Point(560, 740);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 38);
            this.btn_Save.TabIndex = 92;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sua.Location = new System.Drawing.Point(244, 740);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 38);
            this.btn_Sua.TabIndex = 91;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Xoa.Location = new System.Drawing.Point(402, 740);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 38);
            this.btn_Xoa.TabIndex = 90;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Them.Location = new System.Drawing.Point(86, 740);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 38);
            this.btn_Them.TabIndex = 89;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Search.Location = new System.Drawing.Point(439, 677);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderText = "Mời nhập tên hoặc email để tìm kiếm";
            this.txt_Search.Size = new System.Drawing.Size(287, 30);
            this.txt_Search.TabIndex = 87;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // rbtn_QuanTri
            // 
            this.rbtn_QuanTri.AutoSize = true;
            this.rbtn_QuanTri.Location = new System.Drawing.Point(234, 237);
            this.rbtn_QuanTri.Name = "rbtn_QuanTri";
            this.rbtn_QuanTri.Size = new System.Drawing.Size(85, 24);
            this.rbtn_QuanTri.TabIndex = 85;
            this.rbtn_QuanTri.TabStop = true;
            this.rbtn_QuanTri.Text = "Quản Trị";
            this.rbtn_QuanTri.UseVisualStyleBackColor = true;
            // 
            // rbtn_NhanVien
            // 
            this.rbtn_NhanVien.AutoSize = true;
            this.rbtn_NhanVien.Location = new System.Drawing.Point(354, 237);
            this.rbtn_NhanVien.Name = "rbtn_NhanVien";
            this.rbtn_NhanVien.Size = new System.Drawing.Size(98, 24);
            this.rbtn_NhanVien.TabIndex = 84;
            this.rbtn_NhanVien.Text = "Nhân Viên";
            this.rbtn_NhanVien.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChiNV
            // 
            this.txt_DiaChiNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChiNV.Location = new System.Drawing.Point(234, 130);
            this.txt_DiaChiNV.Multiline = true;
            this.txt_DiaChiNV.Name = "txt_DiaChiNV";
            this.txt_DiaChiNV.Size = new System.Drawing.Size(218, 27);
            this.txt_DiaChiNV.TabIndex = 83;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNV.Location = new System.Drawing.Point(234, 73);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(218, 27);
            this.txt_TenNV.TabIndex = 82;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Location = new System.Drawing.Point(712, 73);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(218, 27);
            this.txt_Email.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(591, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 80;
            this.label6.Text = "Tình Trạng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(591, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 76;
            this.label10.Text = "Email:";
            // 
            // Dgrid_NV
            // 
            this.Dgrid_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_NV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.Dgrid_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_NV.GridColor = System.Drawing.SystemColors.Desktop;
            this.Dgrid_NV.Location = new System.Drawing.Point(25, 292);
            this.Dgrid_NV.Name = "Dgrid_NV";
            this.Dgrid_NV.RowHeadersWidth = 51;
            this.Dgrid_NV.RowTemplate.Height = 29;
            this.Dgrid_NV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_NV.Size = new System.Drawing.Size(966, 360);
            this.Dgrid_NV.TabIndex = 99;
            this.Dgrid_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_NV_CellClick_1);
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(234, 184);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(218, 27);
            this.txt_SDT.TabIndex = 83;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(317, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // lbFrmKhachHang
            // 
            this.lbFrmKhachHang.AutoSize = true;
            this.lbFrmKhachHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrmKhachHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFrmKhachHang.Location = new System.Drawing.Point(373, 9);
            this.lbFrmKhachHang.Name = "lbFrmKhachHang";
            this.lbFrmKhachHang.Size = new System.Drawing.Size(155, 38);
            this.lbFrmKhachHang.TabIndex = 100;
            this.lbFrmKhachHang.Text = "Nhân Viên";
            this.lbFrmKhachHang.Click += new System.EventHandler(this.lbFrmKhachHang_Click);
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMaHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaHang.Location = new System.Drawing.Point(84, 73);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(126, 23);
            this.lblMaHang.TabIndex = 106;
            this.lblMaHang.Text = "Tên nhân viên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(84, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 106;
            this.label1.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(84, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 106;
            this.label4.Text = "Số điện thoại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(84, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 106;
            this.label5.Text = "Vai trò:";
            // 
            // btn_Boqua
            // 
            this.btn_Boqua.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Boqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Boqua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Boqua.Location = new System.Drawing.Point(718, 740);
            this.btn_Boqua.Name = "btn_Boqua";
            this.btn_Boqua.Size = new System.Drawing.Size(94, 38);
            this.btn_Boqua.TabIndex = 92;
            this.btn_Boqua.Text = "Bỏ qua";
            this.btn_Boqua.UseVisualStyleBackColor = false;
            this.btn_Boqua.Click += new System.EventHandler(this.btn_Boqua_Click);
            // 
            // btn_DanhSach
            // 
            this.btn_DanhSach.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_DanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhSach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DanhSach.Location = new System.Drawing.Point(876, 740);
            this.btn_DanhSach.Name = "btn_DanhSach";
            this.btn_DanhSach.Size = new System.Drawing.Size(94, 38);
            this.btn_DanhSach.TabIndex = 92;
            this.btn_DanhSach.Text = "Danh sách";
            this.btn_DanhSach.UseVisualStyleBackColor = false;
            this.btn_DanhSach.Click += new System.EventHandler(this.btn_DanhSach_Click);
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 809);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaHang);
            this.Controls.Add(this.lbFrmKhachHang);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DanhSach);
            this.Controls.Add(this.btn_Boqua);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.Dgrid_NV);
            this.Controls.Add(this.cbx_KhongHD);
            this.Controls.Add(this.Cbx_HoatDong);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.rbtn_QuanTri);
            this.Controls.Add(this.rbtn_NhanVien);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_DiaChiNV);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbx_KhongHD;
        private System.Windows.Forms.CheckBox Cbx_HoatDong;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.RadioButton rbtn_QuanTri;
        private System.Windows.Forms.RadioButton rbtn_NhanVien;
        private System.Windows.Forms.TextBox txt_DiaChiNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Dgrid_NV_CellClick;
        private System.Windows.Forms.DataGridView Dgrid_NV;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFrmKhachHang;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Boqua;
        private System.Windows.Forms.Button btn_DanhSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}