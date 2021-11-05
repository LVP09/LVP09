
namespace _3_GUI_PresentationLayer
{
    partial class Frm_SanPham
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
            this.txt_GhiChu = new System.Windows.Forms.RichTextBox();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lbFrmNhanVien = new System.Windows.Forms.Label();
            this.Dgrid_NV = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DanhSach = new System.Windows.Forms.Button();
            this.btn_Boqua = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Hinh = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.btn_chonlai = new System.Windows.Forms.Button();
            this.btn_chonanh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(508, 206);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(240, 82);
            this.txt_GhiChu.TabIndex = 115;
            this.txt_GhiChu.Text = "";
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Enabled = false;
            this.txt_MaHang.Location = new System.Drawing.Point(173, 78);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.ReadOnly = true;
            this.txt_MaHang.Size = new System.Drawing.Size(265, 27);
            this.txt_MaHang.TabIndex = 117;
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMaHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaHang.Location = new System.Drawing.Point(71, 81);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(78, 20);
            this.lblMaHang.TabIndex = 106;
            this.lblMaHang.Text = "Mã hàng :";
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(173, 265);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(265, 27);
            this.txt_GiaBan.TabIndex = 107;
            this.txt_GiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaBan_KeyPress);
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Location = new System.Drawing.Point(173, 220);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(265, 27);
            this.txt_GiaNhap.TabIndex = 105;
            this.txt_GiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaNhap_KeyPress);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGiaBan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGiaBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGiaBan.Location = new System.Drawing.Point(71, 268);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(70, 20);
            this.lblGiaBan.TabIndex = 108;
            this.lblGiaBan.Text = "Giá bán :";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGiaNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGiaNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGiaNhap.Location = new System.Drawing.Point(71, 223);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(82, 20);
            this.lblGiaNhap.TabIndex = 110;
            this.lblGiaNhap.Text = "Giá Nhập :";
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_TenHang.Location = new System.Drawing.Point(173, 124);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(265, 27);
            this.txt_TenHang.TabIndex = 102;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoLuong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSoLuong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSoLuong.Location = new System.Drawing.Point(71, 176);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(79, 20);
            this.lblSoLuong.TabIndex = 112;
            this.lblSoLuong.Text = "Số lượng :";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDiaChi.Location = new System.Drawing.Point(508, 173);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 20);
            this.lblDiaChi.TabIndex = 113;
            this.lblDiaChi.Text = "GhiChu";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTenHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTenHang.Location = new System.Drawing.Point(71, 127);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(81, 20);
            this.lblTenHang.TabIndex = 109;
            this.lblTenHang.Text = "Tên hàng :";
            // 
            // lbFrmNhanVien
            // 
            this.lbFrmNhanVien.AutoSize = true;
            this.lbFrmNhanVien.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrmNhanVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFrmNhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbFrmNhanVien.Location = new System.Drawing.Point(460, 9);
            this.lbFrmNhanVien.Name = "lbFrmNhanVien";
            this.lbFrmNhanVien.Size = new System.Drawing.Size(174, 45);
            this.lbFrmNhanVien.TabIndex = 101;
            this.lbFrmNhanVien.Text = "Sản Phẩm";
            // 
            // Dgrid_NV
            // 
            this.Dgrid_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_NV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.Dgrid_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_NV.GridColor = System.Drawing.SystemColors.Desktop;
            this.Dgrid_NV.Location = new System.Drawing.Point(34, 340);
            this.Dgrid_NV.Name = "Dgrid_NV";
            this.Dgrid_NV.RowHeadersWidth = 51;
            this.Dgrid_NV.RowTemplate.Height = 29;
            this.Dgrid_NV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_NV.Size = new System.Drawing.Size(1155, 379);
            this.Dgrid_NV.TabIndex = 118;
            this.Dgrid_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_NV_CellClick);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Search.Location = new System.Drawing.Point(554, 738);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderText = "Mời bạn nhập tên sản phẩm";
            this.txt_Search.Size = new System.Drawing.Size(287, 30);
            this.txt_Search.TabIndex = 120;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(432, 738);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 119;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Thoat.Location = new System.Drawing.Point(1028, 790);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 38);
            this.btn_Thoat.TabIndex = 127;
            this.btn_Thoat.Text = "Đóng";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DanhSach
            // 
            this.btn_DanhSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhSach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DanhSach.Location = new System.Drawing.Point(870, 790);
            this.btn_DanhSach.Name = "btn_DanhSach";
            this.btn_DanhSach.Size = new System.Drawing.Size(94, 38);
            this.btn_DanhSach.TabIndex = 124;
            this.btn_DanhSach.Text = "Danh sách";
            this.btn_DanhSach.UseVisualStyleBackColor = false;
            this.btn_DanhSach.Click += new System.EventHandler(this.btn_DanhSach_Click);
            // 
            // btn_Boqua
            // 
            this.btn_Boqua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Boqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Boqua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Boqua.Location = new System.Drawing.Point(712, 790);
            this.btn_Boqua.Name = "btn_Boqua";
            this.btn_Boqua.Size = new System.Drawing.Size(94, 38);
            this.btn_Boqua.TabIndex = 125;
            this.btn_Boqua.Text = "Bỏ qua";
            this.btn_Boqua.UseVisualStyleBackColor = false;
            this.btn_Boqua.Click += new System.EventHandler(this.btn_Boqua_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Save.Location = new System.Drawing.Point(554, 790);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 38);
            this.btn_Save.TabIndex = 126;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sua.Location = new System.Drawing.Point(238, 790);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 38);
            this.btn_Sua.TabIndex = 123;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Xoa.Location = new System.Drawing.Point(396, 790);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 38);
            this.btn_Xoa.TabIndex = 122;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Them.Location = new System.Drawing.Point(80, 790);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 38);
            this.btn_Them.TabIndex = 121;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(508, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 128;
            this.label1.Text = "Hình :";
            // 
            // txt_Hinh
            // 
            this.txt_Hinh.Enabled = false;
            this.txt_Hinh.Location = new System.Drawing.Point(564, 104);
            this.txt_Hinh.Name = "txt_Hinh";
            this.txt_Hinh.Size = new System.Drawing.Size(184, 27);
            this.txt_Hinh.TabIndex = 129;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SoLuong.Location = new System.Drawing.Point(172, 173);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(266, 27);
            this.txt_SoLuong.TabIndex = 102;
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // btn_chonlai
            // 
            this.btn_chonlai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_chonlai.Location = new System.Drawing.Point(775, 116);
            this.btn_chonlai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_chonlai.Name = "btn_chonlai";
            this.btn_chonlai.Size = new System.Drawing.Size(106, 31);
            this.btn_chonlai.TabIndex = 132;
            this.btn_chonlai.Text = "RESET ẢNH";
            this.btn_chonlai.UseVisualStyleBackColor = true;
            this.btn_chonlai.Click += new System.EventHandler(this.btn_chonlai_Click_1);
            // 
            // btn_chonanh
            // 
            this.btn_chonanh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_chonanh.Location = new System.Drawing.Point(775, 168);
            this.btn_chonanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_chonanh.Name = "btn_chonanh";
            this.btn_chonanh.Size = new System.Drawing.Size(106, 31);
            this.btn_chonanh.TabIndex = 130;
            this.btn_chonanh.Text = "CHỌN ẢNH";
            this.btn_chonanh.UseVisualStyleBackColor = true;
            this.btn_chonanh.Click += new System.EventHandler(this.btn_chonanh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(887, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 282);
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 860);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_chonlai);
            this.Controls.Add(this.btn_chonanh);
            this.Controls.Add(this.txt_Hinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DanhSach);
            this.Controls.Add(this.btn_Boqua);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgrid_NV);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.txt_MaHang);
            this.Controls.Add(this.lblMaHang);
            this.Controls.Add(this.txt_GiaBan);
            this.Controls.Add(this.txt_GiaNhap);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblGiaNhap);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_TenHang);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.lbFrmNhanVien);
            this.Name = "Frm_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lbFrmNhanVien;
        private System.Windows.Forms.DataGridView Dgrid_NV;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DanhSach;
        private System.Windows.Forms.Button btn_Boqua;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Hinh;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Button btn_chonlai;
        private System.Windows.Forms.Button btn_chonanh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}