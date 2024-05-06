namespace Winform_Project.FormSinhVien
{
    partial class FChat_Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChat_Messages));
            this.fLoDanhSachUser = new System.Windows.Forms.FlowLayoutPanel();
            this.fLoChat = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.fLoDanhSachUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLoDanhSachUser
            // 
            this.fLoDanhSachUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fLoDanhSachUser.Controls.Add(this.guna2TextBox1);
            this.fLoDanhSachUser.Location = new System.Drawing.Point(12, 12);
            this.fLoDanhSachUser.Margin = new System.Windows.Forms.Padding(0);
            this.fLoDanhSachUser.Name = "fLoDanhSachUser";
            this.fLoDanhSachUser.Size = new System.Drawing.Size(556, 600);
            this.fLoDanhSachUser.TabIndex = 0;
            // 
            // fLoChat
            // 
            this.fLoChat.Location = new System.Drawing.Point(589, 12);
            this.fLoChat.Name = "fLoChat";
            this.fLoChat.Size = new System.Drawing.Size(777, 600);
            this.fLoChat.TabIndex = 1;
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
            // 
            // FChat_Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 615);
            this.Controls.Add(this.fLoChat);
            this.Controls.Add(this.fLoDanhSachUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FChat_Messages";
            this.Text = "FChat_Messages";
            this.Load += new System.EventHandler(this.FChat_Messages_Load);
            this.fLoDanhSachUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLoDanhSachUser;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.FlowLayoutPanel fLoChat;
    }
}