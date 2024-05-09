namespace Winform_Project
{
    partial class uc_User_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_User_Chat));
            this.lblTen = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.fLoTrungTam = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnMore = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.uc_TinNhan1 = new Winform_Project.uc_TinNhan();
            this.fLoTrungTam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.White;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(102, 34);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(41, 25);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 83);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(777, 2);
            this.guna2Panel1.TabIndex = 5;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNoiDung.BorderColor = System.Drawing.Color.Black;
            this.txtNoiDung.BorderRadius = 10;
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.DefaultText = "";
            this.txtNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txtNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Location = new System.Drawing.Point(83, 529);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoiDung.MaximumSize = new System.Drawing.Size(660, 500);
            this.txtNoiDung.MinimumSize = new System.Drawing.Size(600, 55);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PasswordChar = '\0';
            this.txtNoiDung.PlaceholderText = "";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.Size = new System.Drawing.Size(600, 57);
            this.txtNoiDung.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNoiDung.TabIndex = 8;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            this.txtNoiDung.Scroll += new System.Windows.Forms.ScrollEventHandler(this.txtNoiDung_Scroll);
            this.txtNoiDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
            // 
            // fLoTrungTam
            // 
            this.fLoTrungTam.AutoScroll = true;
            this.fLoTrungTam.BackColor = System.Drawing.SystemColors.Control;
            this.fLoTrungTam.Controls.Add(this.uc_TinNhan1);
            this.fLoTrungTam.Location = new System.Drawing.Point(0, 83);
            this.fLoTrungTam.Name = "fLoTrungTam";
            this.fLoTrungTam.Size = new System.Drawing.Size(764, 438);
            this.fLoTrungTam.TabIndex = 14;
            // 
            // btnGui
            // 
            this.btnGui.BackColor = System.Drawing.Color.Transparent;
            this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGui.FillColor = System.Drawing.Color.White;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Image = ((System.Drawing.Image)(resources.GetObject("btnGui.Image")));
            this.btnGui.ImageSize = new System.Drawing.Size(35, 35);
            this.btnGui.Location = new System.Drawing.Point(699, 538);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(47, 45);
            this.btnGui.TabIndex = 11;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Transparent;
            this.btnFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFile.FillColor = System.Drawing.Color.White;
            this.btnFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFile.Location = new System.Drawing.Point(14, 541);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(47, 45);
            this.btnFile.TabIndex = 15;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.White;
            this.btnMore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMore.FillColor = System.Drawing.Color.Transparent;
            this.btnMore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMore.ForeColor = System.Drawing.Color.White;
            this.btnMore.Image = ((System.Drawing.Image)(resources.GetObject("btnMore.Image")));
            this.btnMore.Location = new System.Drawing.Point(706, 34);
            this.btnMore.Name = "btnMore";
            this.btnMore.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMore.Size = new System.Drawing.Size(40, 43);
            this.btnMore.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(657, 34);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTimKiem.Size = new System.Drawing.Size(43, 43);
            this.btnTimKiem.TabIndex = 3;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.picAvatar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.picAvatar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.picAvatar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.picAvatar.FillColor = System.Drawing.Color.RosyBrown;
            this.picAvatar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.picAvatar.ForeColor = System.Drawing.Color.White;
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.ImageSize = new System.Drawing.Size(40, 40);
            this.picAvatar.Location = new System.Drawing.Point(23, 15);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(60, 62);
            this.picAvatar.TabIndex = 3;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(764, 85);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 516);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(764, 84);
            this.guna2PictureBox2.TabIndex = 13;
            this.guna2PictureBox2.TabStop = false;
            // 
            // uc_TinNhan1
            // 
            this.uc_TinNhan1.BackColor = System.Drawing.Color.SkyBlue;
            this.uc_TinNhan1.Location = new System.Drawing.Point(3, 3);
            this.uc_TinNhan1.Name = "uc_TinNhan1";
            this.uc_TinNhan1.Size = new System.Drawing.Size(743, 63);
            this.uc_TinNhan1.TabIndex = 12;
            // 
            // uc_User_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.fLoTrungTam);
            this.Name = "uc_User_Chat";
            this.Size = new System.Drawing.Size(764, 600);
            this.fLoTrungTam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2CircleButton picAvatar;
        public System.Windows.Forms.Label lblTen;
        public Guna.UI2.WinForms.Guna2CircleButton btnTimKiem;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2CircleButton btnMore;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        public uc_TinNhan uc_TinNhan1;
        public System.Windows.Forms.FlowLayoutPanel fLoTrungTam;
        public Guna.UI2.WinForms.Guna2TextBox txtNoiDung;
        public Guna.UI2.WinForms.Guna2Button btnGui;
        public Guna.UI2.WinForms.Guna2Button btnFile;
    }
}
