namespace Winform_Project.FormSinhVien
{
    partial class ucChat_Messages
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChat_Messages));
            this.fLoDanhSachUser = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.fLoChat = new System.Windows.Forms.FlowLayoutPanel();
            this.thoiGianGui = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.fLoDanhSachUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLoDanhSachUser
            // 
            this.fLoDanhSachUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fLoDanhSachUser.Controls.Add(this.guna2TextBox1);
            this.fLoDanhSachUser.Location = new System.Drawing.Point(0, 12);
            this.fLoDanhSachUser.Margin = new System.Windows.Forms.Padding(0);
            this.fLoDanhSachUser.Name = "fLoDanhSachUser";
            this.fLoDanhSachUser.Size = new System.Drawing.Size(568, 600);
            this.fLoDanhSachUser.TabIndex = 0;
            this.thoiGianGui.SetToolTip(this.fLoDanhSachUser, "");
            this.thoiGianGui.SetToolTipIcon(this.fLoDanhSachUser, null);
            this.thoiGianGui.SetToolTipTitle(this.fLoDanhSachUser, "");
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(30, 30);
            this.guna2TextBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm.......";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(555, 57);
            this.guna2TextBox1.TabIndex = 0;
            this.thoiGianGui.SetToolTip(this.guna2TextBox1, "");
            this.thoiGianGui.SetToolTipIcon(this.guna2TextBox1, null);
            this.thoiGianGui.SetToolTipTitle(this.guna2TextBox1, "");
            // 
            // fLoChat
            // 
            this.fLoChat.Location = new System.Drawing.Point(589, 12);
            this.fLoChat.Name = "fLoChat";
            this.fLoChat.Size = new System.Drawing.Size(764, 600);
            this.fLoChat.TabIndex = 1;
            this.thoiGianGui.SetToolTip(this.fLoChat, "");
            this.thoiGianGui.SetToolTipIcon(this.fLoChat, null);
            this.thoiGianGui.SetToolTipTitle(this.fLoChat, "");
            // 
            // thoiGianGui
            // 
            this.thoiGianGui.Active = true;
            this.thoiGianGui.AlignTextWithTitle = false;
            this.thoiGianGui.AllowAutoClose = false;
            this.thoiGianGui.AllowFading = true;
            this.thoiGianGui.AutoCloseDuration = 5000;
            this.thoiGianGui.BackColor = System.Drawing.SystemColors.Control;
            this.thoiGianGui.BorderColor = System.Drawing.Color.Gainsboro;
            this.thoiGianGui.ClickToShowDisplayControl = false;
            this.thoiGianGui.ConvertNewlinesToBreakTags = true;
            this.thoiGianGui.DisplayControl = null;
            this.thoiGianGui.EntryAnimationSpeed = 350;
            this.thoiGianGui.ExitAnimationSpeed = 200;
            this.thoiGianGui.GenerateAutoCloseDuration = false;
            this.thoiGianGui.IconMargin = 6;
            this.thoiGianGui.InitialDelay = 0;
            this.thoiGianGui.Name = "thoiGianGui";
            this.thoiGianGui.Opacity = 1D;
            this.thoiGianGui.OverrideToolTipTitles = false;
            this.thoiGianGui.Padding = new System.Windows.Forms.Padding(10);
            this.thoiGianGui.ReshowDelay = 10;
            this.thoiGianGui.ShowAlways = true;
            this.thoiGianGui.ShowBorders = false;
            this.thoiGianGui.ShowIcons = true;
            this.thoiGianGui.ShowShadows = true;
            this.thoiGianGui.Tag = null;
            this.thoiGianGui.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.thoiGianGui.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thoiGianGui.TextMargin = 2;
            this.thoiGianGui.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.thoiGianGui.TitleForeColor = System.Drawing.Color.Black;
            this.thoiGianGui.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.thoiGianGui.ToolTipTitle = "Thời gian gửi:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.Location = new System.Drawing.Point(587, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(3, 603);
            this.guna2Panel1.TabIndex = 2;
            this.thoiGianGui.SetToolTip(this.guna2Panel1, "");
            this.thoiGianGui.SetToolTipIcon(this.guna2Panel1, null);
            this.thoiGianGui.SetToolTipTitle(this.guna2Panel1, "");
            // 
            // ucChat_Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.fLoChat);
            this.Controls.Add(this.fLoDanhSachUser);
            this.Name = "ucChat_Messages";
            this.Size = new System.Drawing.Size(1370, 615);
            this.thoiGianGui.SetToolTip(this, "");
            this.thoiGianGui.SetToolTipIcon(this, null);
            this.thoiGianGui.SetToolTipTitle(this, "");
            this.Load += new System.EventHandler(this.FChat_Messages_Load);
            this.fLoDanhSachUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLoDanhSachUser;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.FlowLayoutPanel fLoChat;
        private Bunifu.UI.WinForms.BunifuToolTip thoiGianGui;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}