
namespace _3_GUI_PresentationLayer
{
    partial class Frm_KhachHang
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgrid_NV = new System.Windows.Forms.DataGridView();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lbFrmKhachHang = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.btn_DanhSach = new System.Windows.Forms.Button();
            this.btn_Boqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Thoat.Location = new System.Drawing.Point(917, 737);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 38);
            this.btn_Thoat.TabIndex = 125;
            this.btn_Thoat.Text = "Đóng";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Luu.Location = new System.Drawing.Point(473, 737);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(94, 38);
            this.btn_Luu.TabIndex = 124;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sua.Location = new System.Drawing.Point(164, 737);
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
            this.btn_Xoa.Location = new System.Drawing.Point(312, 737);
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
            this.btn_Them.Location = new System.Drawing.Point(21, 737);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 38);
            this.btn_Them.TabIndex = 121;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_TimKiem.Location = new System.Drawing.Point(436, 685);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Mời nhập tên hoặc SĐT để tìm kiếm";
            this.txt_TimKiem.Size = new System.Drawing.Size(287, 30);
            this.txt_TimKiem.TabIndex = 120;
            this.txt_TimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(314, 685);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 119;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // Dgrid_NV
            // 
            this.Dgrid_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_NV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.Dgrid_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_NV.GridColor = System.Drawing.SystemColors.Desktop;
            this.Dgrid_NV.Location = new System.Drawing.Point(74, 210);
            this.Dgrid_NV.Name = "Dgrid_NV";
            this.Dgrid_NV.RowHeadersWidth = 51;
            this.Dgrid_NV.RowTemplate.Height = 29;
            this.Dgrid_NV.Size = new System.Drawing.Size(876, 444);
            this.Dgrid_NV.TabIndex = 118;
            this.Dgrid_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_NV_CellClick);
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbtn_Nu.Location = new System.Drawing.Point(766, 145);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(50, 24);
            this.rbtn_Nu.TabIndex = 116;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDienThoai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDienThoai.Location = new System.Drawing.Point(42, 94);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(89, 20);
            this.lblDienThoai.TabIndex = 109;
            this.lblDienThoai.Text = "Điện thoại :";
            // 
            // lbFrmKhachHang
            // 
            this.lbFrmKhachHang.AutoSize = true;
            this.lbFrmKhachHang.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrmKhachHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFrmKhachHang.Location = new System.Drawing.Point(367, 9);
            this.lbFrmKhachHang.Name = "lbFrmKhachHang";
            this.lbFrmKhachHang.Size = new System.Drawing.Size(207, 45);
            this.lbFrmKhachHang.TabIndex = 108;
            this.lbFrmKhachHang.Text = "Khách Hàng";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_HoTen.Location = new System.Drawing.Point(162, 144);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(227, 27);
            this.txt_HoTen.TabIndex = 114;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHoTen.Location = new System.Drawing.Point(42, 151);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(64, 20);
            this.lblHoTen.TabIndex = 110;
            this.lblHoTen.Text = "Họ tên :";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_DiaChi.Location = new System.Drawing.Point(661, 91);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(257, 27);
            this.txt_DiaChi.TabIndex = 115;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.Location = new System.Drawing.Point(537, 94);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(64, 20);
            this.lblDiaChi.TabIndex = 111;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Sdt.Location = new System.Drawing.Point(162, 94);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(227, 27);
            this.txt_Sdt.TabIndex = 112;
            this.txt_Sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sdt_KeyPress);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGioiTinh.Location = new System.Drawing.Point(537, 143);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(73, 20);
            this.lblGioiTinh.TabIndex = 113;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbtn_Nam.Location = new System.Drawing.Point(661, 143);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(62, 24);
            this.rbtn_Nam.TabIndex = 117;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // btn_DanhSach
            // 
            this.btn_DanhSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhSach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DanhSach.Location = new System.Drawing.Point(783, 737);
            this.btn_DanhSach.Name = "btn_DanhSach";
            this.btn_DanhSach.Size = new System.Drawing.Size(94, 38);
            this.btn_DanhSach.TabIndex = 126;
            this.btn_DanhSach.Text = "Danh sách";
            this.btn_DanhSach.UseVisualStyleBackColor = false;
            this.btn_DanhSach.Click += new System.EventHandler(this.btn_DanhSach_Click);
            // 
            // btn_Boqua
            // 
            this.btn_Boqua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Boqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Boqua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Boqua.Location = new System.Drawing.Point(628, 737);
            this.btn_Boqua.Name = "btn_Boqua";
            this.btn_Boqua.Size = new System.Drawing.Size(94, 38);
            this.btn_Boqua.TabIndex = 127;
            this.btn_Boqua.Text = "Bỏ qua";
            this.btn_Boqua.UseVisualStyleBackColor = false;
            this.btn_Boqua.Click += new System.EventHandler(this.btn_Boqua_Click);
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 809);
            this.Controls.Add(this.btn_DanhSach);
            this.Controls.Add(this.btn_Boqua);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgrid_NV);
            this.Controls.Add(this.rbtn_Nu);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lbFrmKhachHang);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txt_Sdt);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.rbtn_Nam);
            this.Name = "Frm_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgrid_NV;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lbFrmKhachHang;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.Button btn_DanhSach;
        private System.Windows.Forms.Button btn_Boqua;
    }
}