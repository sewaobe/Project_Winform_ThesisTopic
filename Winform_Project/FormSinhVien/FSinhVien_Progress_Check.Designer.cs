namespace Winform_Project.FormSinhVien
{
    partial class FSinhVien_Progress_Check
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
            this.lblNameGiangVien = new System.Windows.Forms.Label();
            this.lblDanhGia = new System.Windows.Forms.Label();
            this.lblNhanXet = new System.Windows.Forms.Label();
            this.txtNhanXet = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnQuayVe = new Guna.UI2.WinForms.Guna2Button();
            this.txtDanhGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenGiangVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblNameGiangVien
            // 
            this.lblNameGiangVien.AutoSize = true;
            this.lblNameGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGiangVien.Location = new System.Drawing.Point(41, 85);
            this.lblNameGiangVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameGiangVien.Name = "lblNameGiangVien";
            this.lblNameGiangVien.Size = new System.Drawing.Size(116, 24);
            this.lblNameGiangVien.TabIndex = 0;
            this.lblNameGiangVien.Text = "Giảng viên:";
            // 
            // lblDanhGia
            // 
            this.lblDanhGia.AutoSize = true;
            this.lblDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhGia.Location = new System.Drawing.Point(41, 136);
            this.lblDanhGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhGia.Name = "lblDanhGia";
            this.lblDanhGia.Size = new System.Drawing.Size(99, 24);
            this.lblDanhGia.TabIndex = 1;
            this.lblDanhGia.Text = "Đánh giá:";
            // 
            // lblNhanXet
            // 
            this.lblNhanXet.AutoSize = true;
            this.lblNhanXet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanXet.Location = new System.Drawing.Point(41, 190);
            this.lblNhanXet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhanXet.Name = "lblNhanXet";
            this.lblNhanXet.Size = new System.Drawing.Size(100, 24);
            this.lblNhanXet.TabIndex = 2;
            this.lblNhanXet.Text = "Nhận xét:";
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhanXet.DefaultText = "";
            this.txtNhanXet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhanXet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhanXet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhanXet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhanXet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhanXet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhanXet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhanXet.Location = new System.Drawing.Point(175, 190);
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.PasswordChar = '\0';
            this.txtNhanXet.PlaceholderText = "";
            this.txtNhanXet.SelectedText = "";
            this.txtNhanXet.Size = new System.Drawing.Size(243, 151);
            this.txtNhanXet.TabIndex = 4;
            this.txtNhanXet.TextChanged += new System.EventHandler(this.txtNhanXet_TextChanged);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.AutoRoundedCorners = true;
            this.btnQuayVe.BorderRadius = 13;
            this.btnQuayVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuayVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuayVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuayVe.ForeColor = System.Drawing.Color.White;
            this.btnQuayVe.Location = new System.Drawing.Point(507, 338);
            this.btnQuayVe.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(120, 29);
            this.btnQuayVe.TabIndex = 5;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // txtDanhGia
            // 
            this.txtDanhGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDanhGia.DefaultText = "";
            this.txtDanhGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDanhGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDanhGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDanhGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDanhGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDanhGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDanhGia.Location = new System.Drawing.Point(175, 139);
            this.txtDanhGia.Name = "txtDanhGia";
            this.txtDanhGia.PasswordChar = '\0';
            this.txtDanhGia.PlaceholderText = "";
            this.txtDanhGia.SelectedText = "";
            this.txtDanhGia.Size = new System.Drawing.Size(203, 21);
            this.txtDanhGia.TabIndex = 6;
            this.txtDanhGia.TextChanged += new System.EventHandler(this.txtDanhGia_TextChanged);
            // 
            // txtTenGiangVien
            // 
            this.txtTenGiangVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenGiangVien.DefaultText = "";
            this.txtTenGiangVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenGiangVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenGiangVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenGiangVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenGiangVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenGiangVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenGiangVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenGiangVien.Location = new System.Drawing.Point(175, 85);
            this.txtTenGiangVien.Name = "txtTenGiangVien";
            this.txtTenGiangVien.PasswordChar = '\0';
            this.txtTenGiangVien.PlaceholderText = "";
            this.txtTenGiangVien.SelectedText = "";
            this.txtTenGiangVien.Size = new System.Drawing.Size(203, 21);
            this.txtTenGiangVien.TabIndex = 7;
            // 
            // FSinhVien_Progress_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 386);
            this.Controls.Add(this.txtTenGiangVien);
            this.Controls.Add(this.txtDanhGia);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.txtNhanXet);
            this.Controls.Add(this.lblNhanXet);
            this.Controls.Add(this.lblDanhGia);
            this.Controls.Add(this.lblNameGiangVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FSinhVien_Progress_Check";
            this.Text = "FSinhVien_Progress_Check";
            this.Load += new System.EventHandler(this.FSinhVien_Progress_Check_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameGiangVien;
        private System.Windows.Forms.Label lblDanhGia;
        private System.Windows.Forms.Label lblNhanXet;
        private Guna.UI2.WinForms.Guna2TextBox txtNhanXet;
        public Guna.UI2.WinForms.Guna2Button btnQuayVe;
        private Guna.UI2.WinForms.Guna2TextBox txtDanhGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTenGiangVien;
    }
}