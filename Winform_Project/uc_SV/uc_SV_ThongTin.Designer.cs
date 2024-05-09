namespace Winform_Project.uc_SV
{
    partial class uc_SV_ThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_SV_ThongTin));
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.btnThemSinhVien = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.picAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_User = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThayDoiTroChuyen = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(141, 29);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(142, 25);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Ten sinh vien";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(141, 63);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(75, 25);
            this.lblMSSV.TabIndex = 1;
            this.lblMSSV.Text = "MSSV";
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSinhVien.Image")));
            this.btnThemSinhVien.ImageRotate = 0F;
            this.btnThemSinhVien.Location = new System.Drawing.Point(479, 29);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnThemSinhVien.Size = new System.Drawing.Size(58, 55);
            this.btnThemSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThemSinhVien.TabIndex = 4;
            this.btnThemSinhVien.TabStop = false;
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(17, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(87, 76);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.DarkGray;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 109);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(551, 2);
            this.guna2Panel3.TabIndex = 69;
            // 
            // panel_User
            // 
            this.panel_User.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_User.FillColor = System.Drawing.Color.SteelBlue;
            this.panel_User.Location = new System.Drawing.Point(0, 0);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(10, 109);
            this.panel_User.TabIndex = 72;
            this.panel_User.Visible = false;
            // 
            // btnThayDoiTroChuyen
            // 
            this.btnThayDoiTroChuyen.AutoRoundedCorners = true;
            this.btnThayDoiTroChuyen.BackColor = System.Drawing.Color.Transparent;
            this.btnThayDoiTroChuyen.BorderRadius = 6;
            this.btnThayDoiTroChuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThayDoiTroChuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThayDoiTroChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThayDoiTroChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThayDoiTroChuyen.FillColor = System.Drawing.Color.Crimson;
            this.btnThayDoiTroChuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThayDoiTroChuyen.ForeColor = System.Drawing.Color.Black;
            this.btnThayDoiTroChuyen.Location = new System.Drawing.Point(522, 29);
            this.btnThayDoiTroChuyen.Name = "btnThayDoiTroChuyen";
            this.btnThayDoiTroChuyen.Size = new System.Drawing.Size(15, 15);
            this.btnThayDoiTroChuyen.TabIndex = 73;
            this.btnThayDoiTroChuyen.Tag = "0";
            this.btnThayDoiTroChuyen.Visible = false;
            // 
            // uc_SV_ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnThayDoiTroChuyen);
            this.Controls.Add(this.panel_User);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.btnThemSinhVien);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.lblTen);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "uc_SV_ThongTin";
            this.Size = new System.Drawing.Size(551, 111);
            this.Load += new System.EventHandler(this.uc_SV_ThongTin_Load);
            this.MouseLeave += new System.EventHandler(this.uc_SV_ThongTin_MouseLeave);
            this.MouseHover += new System.EventHandler(this.uc_SV_ThongTin_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTen;
        public System.Windows.Forms.Label lblMSSV;
        public Guna.UI2.WinForms.Guna2PictureBox picAvatar;
        public Guna.UI2.WinForms.Guna2CirclePictureBox btnThemSinhVien;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        public Guna.UI2.WinForms.Guna2Panel panel_User;
        public Guna.UI2.WinForms.Guna2Button btnThayDoiTroChuyen;
    }
}
