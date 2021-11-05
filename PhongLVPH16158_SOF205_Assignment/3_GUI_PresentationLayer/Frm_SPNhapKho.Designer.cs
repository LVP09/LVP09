
namespace _3_GUI_PresentationLayer
{
    partial class Frm_SPNhapKho
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
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.btn_nvNhaphang = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_hangTon = new System.Windows.Forms.Button();
            this.DGV_ThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(807, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 23);
            this.label20.TabIndex = 8;
            this.label20.Text = "Hàng Tồn Kho:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TenNV);
            this.groupBox1.Controls.Add(this.btn_nvNhaphang);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(5, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 99);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng được nhập bởi:";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(166, 47);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(216, 30);
            this.txt_TenNV.TabIndex = 4;
            // 
            // btn_nvNhaphang
            // 
            this.btn_nvNhaphang.Location = new System.Drawing.Point(425, 45);
            this.btn_nvNhaphang.Name = "btn_nvNhaphang";
            this.btn_nvNhaphang.Size = new System.Drawing.Size(64, 29);
            this.btn_nvNhaphang.TabIndex = 1;
            this.btn_nvNhaphang.Text = "Xem";
            this.btn_nvNhaphang.UseVisualStyleBackColor = true;
            this.btn_nvNhaphang.Click += new System.EventHandler(this.btn_nvNhaphang_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 23);
            this.label17.TabIndex = 3;
            this.label17.Text = "Tên nhân viên:";
            // 
            // btn_hangTon
            // 
            this.btn_hangTon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hangTon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_hangTon.Location = new System.Drawing.Point(938, 61);
            this.btn_hangTon.Name = "btn_hangTon";
            this.btn_hangTon.Size = new System.Drawing.Size(64, 29);
            this.btn_hangTon.TabIndex = 7;
            this.btn_hangTon.Text = "Xem";
            this.btn_hangTon.UseVisualStyleBackColor = true;
            this.btn_hangTon.Click += new System.EventHandler(this.btn_hangTon_Click);
            // 
            // DGV_ThongKe
            // 
            this.DGV_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ThongKe.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DGV_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ThongKe.Location = new System.Drawing.Point(12, 121);
            this.DGV_ThongKe.Name = "DGV_ThongKe";
            this.DGV_ThongKe.RowHeadersWidth = 51;
            this.DGV_ThongKe.RowTemplate.Height = 29;
            this.DGV_ThongKe.Size = new System.Drawing.Size(1010, 573);
            this.DGV_ThongKe.TabIndex = 6;
            // 
            // Frm_SPNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 730);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_hangTon);
            this.Controls.Add(this.DGV_ThongKe);
            this.Name = "Frm_SPNhapKho";
            this.Text = "Frm_SPNhapKho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Button btn_nvNhaphang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_hangTon;
        private System.Windows.Forms.DataGridView DGV_ThongKe;
    }
}