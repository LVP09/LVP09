
namespace _3_GUI_PresentationLayer
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.item_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_SP = new System.Windows.Forms.ToolStripMenuItem();
            this.item_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.item_KH = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_SPNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ChaoBan = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1230, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_DangNhap,
            this.item_DangXuat,
            this.item_Thoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // item_DangNhap
            // 
            this.item_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("item_DangNhap.Image")));
            this.item_DangNhap.Name = "item_DangNhap";
            this.item_DangNhap.Size = new System.Drawing.Size(198, 32);
            this.item_DangNhap.Text = "Đăng Nhập";
            this.item_DangNhap.Click += new System.EventHandler(this.item_DangNhap_Click);
            // 
            // item_DangXuat
            // 
            this.item_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("item_DangXuat.Image")));
            this.item_DangXuat.Name = "item_DangXuat";
            this.item_DangXuat.Size = new System.Drawing.Size(198, 32);
            this.item_DangXuat.Text = "Đăng Xuất";
            this.item_DangXuat.Click += new System.EventHandler(this.item_DangXuat_Click);
            // 
            // item_Thoat
            // 
            this.item_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("item_Thoat.Image")));
            this.item_Thoat.Name = "item_Thoat";
            this.item_Thoat.Size = new System.Drawing.Size(198, 32);
            this.item_Thoat.Text = "Thoát";
            this.item_Thoat.Click += new System.EventHandler(this.item_Thoat_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_SP,
            this.item_NV,
            this.item_KH});
            this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // item_SP
            // 
            this.item_SP.Image = ((System.Drawing.Image)(resources.GetObject("item_SP.Image")));
            this.item_SP.Name = "item_SP";
            this.item_SP.Size = new System.Drawing.Size(200, 32);
            this.item_SP.Text = "Sản Phẩm";
            this.item_SP.Click += new System.EventHandler(this.item_SP_Click);
            // 
            // item_NV
            // 
            this.item_NV.Image = ((System.Drawing.Image)(resources.GetObject("item_NV.Image")));
            this.item_NV.Name = "item_NV";
            this.item_NV.Size = new System.Drawing.Size(200, 32);
            this.item_NV.Text = "Nhân Viên";
            this.item_NV.Click += new System.EventHandler(this.item_NV_Click);
            // 
            // item_KH
            // 
            this.item_KH.Image = ((System.Drawing.Image)(resources.GetObject("item_KH.Image")));
            this.item_KH.Name = "item_KH";
            this.item_KH.Size = new System.Drawing.Size(200, 32);
            this.item_KH.Text = "Khách hàng";
            this.item_KH.Click += new System.EventHandler(this.item_KH_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_SPNhapKho});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(107, 32);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // item_SPNhapKho
            // 
            this.item_SPNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("item_SPNhapKho.Image")));
            this.item_SPNhapKho.Name = "item_SPNhapKho";
            this.item_SPNhapKho.Size = new System.Drawing.Size(277, 32);
            this.item_SPNhapKho.Text = "Nhập Kho - Tồn Kho";
            this.item_SPNhapKho.Click += new System.EventHandler(this.item_SPNhapKho_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(125, 32);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // lbl_ChaoBan
            // 
            this.lbl_ChaoBan.AutoSize = true;
            this.lbl_ChaoBan.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ChaoBan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ChaoBan.ForeColor = System.Drawing.Color.Black;
            this.lbl_ChaoBan.Location = new System.Drawing.Point(883, 9);
            this.lbl_ChaoBan.Name = "lbl_ChaoBan";
            this.lbl_ChaoBan.Size = new System.Drawing.Size(100, 19);
            this.lbl_ChaoBan.TabIndex = 1;
            this.lbl_ChaoBan.Text = " Chào bạn : ";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1230, 1014);
            this.Controls.Add(this.lbl_ChaoBan);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Main";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem item_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item_SP;
        private System.Windows.Forms.ToolStripMenuItem item_NV;
        private System.Windows.Forms.ToolStripMenuItem item_KH;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item_SPNhapKho;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.Label lbl_ChaoBan;
        private System.Windows.Forms.ToolStripMenuItem item_Thoat;
    }
}