namespace Winform_Project
{
    partial class ucDeTai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDeTai));
            this.lblTenDeTai = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.fLoCongNghe = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCongNghe = new Guna.UI2.WinForms.Guna2Button();
            this.btnChiTiet = new Guna.UI2.WinForms.Guna2Button();
            this.lblMaDeTai = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnYeuThich = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.fLoCongNghe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnYeuThich)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenDeTai
            // 
            this.lblTenDeTai.AutoSize = true;
            this.lblTenDeTai.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDeTai.Location = new System.Drawing.Point(37, 55);
            this.lblTenDeTai.Name = "lblTenDeTai";
            this.lblTenDeTai.Size = new System.Drawing.Size(110, 22);
            this.lblTenDeTai.TabIndex = 1;
            this.lblTenDeTai.Text = "Tên đề tài";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTheLoai.Location = new System.Drawing.Point(38, 91);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(74, 18);
            this.lblTheLoai.TabIndex = 2;
            this.lblTheLoai.Text = "Thể loại";
            // 
            // fLoCongNghe
            // 
            this.fLoCongNghe.Controls.Add(this.btnCongNghe);
            this.fLoCongNghe.Location = new System.Drawing.Point(17, 128);
            this.fLoCongNghe.Name = "fLoCongNghe";
            this.fLoCongNghe.Size = new System.Drawing.Size(431, 37);
            this.fLoCongNghe.TabIndex = 3;
            // 
            // btnCongNghe
            // 
            this.btnCongNghe.Animated = true;
            this.btnCongNghe.AutoRoundedCorners = true;
            this.btnCongNghe.BorderRadius = 16;
            this.btnCongNghe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCongNghe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCongNghe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCongNghe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCongNghe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(204)))), ((int)(((byte)(156)))));
            this.btnCongNghe.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongNghe.ForeColor = System.Drawing.Color.Black;
            this.btnCongNghe.Location = new System.Drawing.Point(3, 3);
            this.btnCongNghe.Name = "btnCongNghe";
            this.btnCongNghe.Size = new System.Drawing.Size(120, 34);
            this.btnCongNghe.TabIndex = 0;
            this.btnCongNghe.Text = "Công nghệ ";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AutoRoundedCorners = true;
            this.btnChiTiet.BorderRadius = 17;
            this.btnChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnChiTiet.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChiTiet.Location = new System.Drawing.Point(879, 128);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(116, 37);
            this.btnChiTiet.TabIndex = 4;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // lblMaDeTai
            // 
            this.lblMaDeTai.AutoSize = true;
            this.lblMaDeTai.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDeTai.Location = new System.Drawing.Point(38, 22);
            this.lblMaDeTai.Name = "lblMaDeTai";
            this.lblMaDeTai.Size = new System.Drawing.Size(102, 22);
            this.lblMaDeTai.TabIndex = 5;
            this.lblMaDeTai.Text = "Mã đề tài";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.Olive;
            this.lblTrangThai.Location = new System.Drawing.Point(794, 13);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(93, 18);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(204)))), ((int)(((byte)(156)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 178);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1010, 3);
            this.guna2Panel1.TabIndex = 7;
            // 
            // btnYeuThich
            // 
            this.btnYeuThich.Image = ((System.Drawing.Image)(resources.GetObject("btnYeuThich.Image")));
            this.btnYeuThich.ImageRotate = 0F;
            this.btnYeuThich.Location = new System.Drawing.Point(932, 13);
            this.btnYeuThich.Name = "btnYeuThich";
            this.btnYeuThich.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnYeuThich.Size = new System.Drawing.Size(63, 54);
            this.btnYeuThich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnYeuThich.TabIndex = 9;
            this.btnYeuThich.TabStop = false;
            // 
            // ucDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnYeuThich);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblMaDeTai);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.fLoCongNghe);
            this.Controls.Add(this.lblTheLoai);
            this.Controls.Add(this.lblTenDeTai);
            this.Name = "ucDeTai";
            this.Size = new System.Drawing.Size(1010, 181);
            this.fLoCongNghe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnYeuThich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTenDeTai;
        public System.Windows.Forms.Label lblTheLoai;
        public System.Windows.Forms.FlowLayoutPanel fLoCongNghe;
        public Guna.UI2.WinForms.Guna2Button btnChiTiet;
        public Guna.UI2.WinForms.Guna2Button btnCongNghe;
        public System.Windows.Forms.Label lblMaDeTai;
        public System.Windows.Forms.Label lblTrangThai;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnYeuThich;
    }
}
