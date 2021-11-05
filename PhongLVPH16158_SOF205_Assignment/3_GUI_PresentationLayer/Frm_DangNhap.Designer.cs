
namespace _3_GUI_PresentationLayer
{
    partial class Frm_DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Ghi = new System.Windows.Forms.CheckBox();
            this.llb_QuenMK = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_DangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DangNhap.Location = new System.Drawing.Point(243, 275);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(143, 48);
            this.btn_DangNhap.TabIndex = 20;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tài Khoản email:";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_TaiKhoan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_TaiKhoan.Location = new System.Drawing.Point(186, 94);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(200, 27);
            this.txt_TaiKhoan.TabIndex = 16;
            this.txt_TaiKhoan.Text = "phonglvph16158@fpt.edu.vn";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_MatKhau.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_MatKhau.Location = new System.Drawing.Point(186, 167);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(200, 27);
            this.txt_MatKhau.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(11, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(40, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đăng Nhập Hệ Thống";
            // 
            // Ghi
            // 
            this.Ghi.AutoSize = true;
            this.Ghi.BackColor = System.Drawing.SystemColors.Menu;
            this.Ghi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Ghi.Location = new System.Drawing.Point(11, 226);
            this.Ghi.Name = "Ghi";
            this.Ghi.Size = new System.Drawing.Size(147, 24);
            this.Ghi.TabIndex = 21;
            this.Ghi.Text = "Ghi nhớ tài khoản";
            this.Ghi.UseVisualStyleBackColor = false;
            // 
            // llb_QuenMK
            // 
            this.llb_QuenMK.AutoSize = true;
            this.llb_QuenMK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llb_QuenMK.Location = new System.Drawing.Point(266, 226);
            this.llb_QuenMK.Name = "llb_QuenMK";
            this.llb_QuenMK.Size = new System.Drawing.Size(120, 20);
            this.llb_QuenMK.TabIndex = 22;
            this.llb_QuenMK.TabStop = true;
            this.llb_QuenMK.Text = "Quên mật khẩu ?";
            this.llb_QuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_QuenMK_LinkClicked);
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 364);
            this.Controls.Add(this.llb_QuenMK);
            this.Controls.Add(this.Ghi);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.txt_MatKhau);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From_DangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_DangNhap_FormClosed);
            this.Load += new System.EventHandler(this.Frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Ghi;
        private System.Windows.Forms.LinkLabel llb_QuenMK;
    }
}

