
namespace _3_GUI_PresentationLayer
{
    partial class Frm_QuenMatKhau
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
            this.lbFrmKhachHang = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_SendtoEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_XacNhan = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFrmKhachHang
            // 
            this.lbFrmKhachHang.AutoSize = true;
            this.lbFrmKhachHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrmKhachHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFrmKhachHang.Location = new System.Drawing.Point(153, 37);
            this.lbFrmKhachHang.Name = "lbFrmKhachHang";
            this.lbFrmKhachHang.Size = new System.Drawing.Size(220, 38);
            this.lbFrmKhachHang.TabIndex = 101;
            this.lbFrmKhachHang.Text = "Quên mật khẩu";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(337, 251);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(94, 29);
            this.btn_XacNhan.TabIndex = 107;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_SendtoEmail
            // 
            this.btn_SendtoEmail.Location = new System.Drawing.Point(141, 251);
            this.btn_SendtoEmail.Name = "btn_SendtoEmail";
            this.btn_SendtoEmail.Size = new System.Drawing.Size(94, 29);
            this.btn_SendtoEmail.TabIndex = 106;
            this.btn_SendtoEmail.Text = "Send";
            this.btn_SendtoEmail.UseVisualStyleBackColor = true;
            this.btn_SendtoEmail.Click += new System.EventHandler(this.btn_SendtoEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Xác nhận Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Email";
            // 
            // Txt_XacNhan
            // 
            this.Txt_XacNhan.Location = new System.Drawing.Point(236, 190);
            this.Txt_XacNhan.Name = "Txt_XacNhan";
            this.Txt_XacNhan.Size = new System.Drawing.Size(195, 27);
            this.Txt_XacNhan.TabIndex = 103;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(235, 107);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(195, 27);
            this.txt_Email.TabIndex = 102;
            // 
            // Frm_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 386);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.btn_SendtoEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_XacNhan);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbFrmKhachHang);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Frm_QuenMatKhau";
            this.Text = "FrmQuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFrmKhachHang;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_SendtoEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_XacNhan;
        private System.Windows.Forms.TextBox txt_Email;
    }
}