namespace Winform_Project.FormGiangVien
{
    partial class FGiangVien_Support_Add_SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGiangVien_Support_Add_SinhVien));
            this.fLoTrungTam = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMSSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // fLoTrungTam
            // 
            this.fLoTrungTam.Location = new System.Drawing.Point(51, 81);
            this.fLoTrungTam.Name = "fLoTrungTam";
            this.fLoTrungTam.Size = new System.Drawing.Size(570, 357);
            this.fLoTrungTam.TabIndex = 0;
            // 
            // txtMSSV
            // 
            this.txtMSSV.BorderRadius = 8;
            this.txtMSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSSV.DefaultText = "";
            this.txtMSSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMSSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMSSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMSSV.ForeColor = System.Drawing.Color.Black;
            this.txtMSSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSSV.IconRight = ((System.Drawing.Image)(resources.GetObject("txtMSSV.IconRight")));
            this.txtMSSV.Location = new System.Drawing.Point(170, 17);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.PasswordChar = '\0';
            this.txtMSSV.PlaceholderText = "Tìm kiếm theo thông sinh của sinh viên";
            this.txtMSSV.SelectedText = "";
            this.txtMSSV.Size = new System.Drawing.Size(351, 45);
            this.txtMSSV.TabIndex = 8;
            this.txtMSSV.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(608, 454);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 42);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Xác nhận";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FGiangVien_Support_Add_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 508);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.fLoTrungTam);
            this.Name = "FGiangVien_Support_Add_SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGiangVien_Support_Add_SinhVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLoTrungTam;
        public Guna.UI2.WinForms.Guna2TextBox txtMSSV;
        private Guna.UI2.WinForms.Guna2Button btnThem;
    }
}