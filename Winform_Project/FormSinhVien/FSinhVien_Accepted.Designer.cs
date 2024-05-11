namespace Winform_Project.FormSinhVien
{
    partial class FSinhVien_Accepted
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
            this.fLoTrungTam = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCho = new Guna.UI2.WinForms.Guna2Button();
            this.btnDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.progress = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThayDoiCho = new Guna.UI2.WinForms.Guna2Button();
            this.btnThayDoiDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.btnDaHoanThanh = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // fLoTrungTam
            // 
            this.fLoTrungTam.BackColor = System.Drawing.SystemColors.Control;
            this.fLoTrungTam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLoTrungTam.Location = new System.Drawing.Point(-1, 176);
            this.fLoTrungTam.Margin = new System.Windows.Forms.Padding(0);
            this.fLoTrungTam.Name = "fLoTrungTam";
            this.fLoTrungTam.Size = new System.Drawing.Size(1386, 570);
            this.fLoTrungTam.TabIndex = 10;
            // 
            // btnCho
            // 
            this.btnCho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCho.FillColor = System.Drawing.Color.White;
            this.btnCho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCho.ForeColor = System.Drawing.Color.Black;
            this.btnCho.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnCho.Location = new System.Drawing.Point(265, 91);
            this.btnCho.Name = "btnCho";
            this.btnCho.Size = new System.Drawing.Size(160, 61);
            this.btnCho.TabIndex = 9;
            this.btnCho.Text = "Đang chờ";
            this.btnCho.Click += new System.EventHandler(this.btnCho_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDuyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDuyet.FillColor = System.Drawing.Color.White;
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.ForeColor = System.Drawing.Color.Black;
            this.btnDuyet.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnDuyet.Location = new System.Drawing.Point(99, 91);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(160, 61);
            this.btnDuyet.TabIndex = 8;
            this.btnDuyet.Text = "Đã duyệt";
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // progress
            // 
            this.progress.FillColor = System.Drawing.Color.Blue;
            this.progress.Location = new System.Drawing.Point(99, 147);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(160, 5);
            this.progress.TabIndex = 13;
            // 
            // btnThayDoiCho
            // 
            this.btnThayDoiCho.AutoRoundedCorners = true;
            this.btnThayDoiCho.BackColor = System.Drawing.Color.Transparent;
            this.btnThayDoiCho.BorderRadius = 6;
            this.btnThayDoiCho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThayDoiCho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThayDoiCho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThayDoiCho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThayDoiCho.FillColor = System.Drawing.Color.Crimson;
            this.btnThayDoiCho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThayDoiCho.ForeColor = System.Drawing.Color.Black;
            this.btnThayDoiCho.Location = new System.Drawing.Point(635, 70);
            this.btnThayDoiCho.Name = "btnThayDoiCho";
            this.btnThayDoiCho.Size = new System.Drawing.Size(15, 15);
            this.btnThayDoiCho.TabIndex = 16;
            this.btnThayDoiCho.Visible = false;
            // 
            // btnThayDoiDuyet
            // 
            this.btnThayDoiDuyet.AutoRoundedCorners = true;
            this.btnThayDoiDuyet.BackColor = System.Drawing.Color.Transparent;
            this.btnThayDoiDuyet.BorderRadius = 6;
            this.btnThayDoiDuyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThayDoiDuyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThayDoiDuyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThayDoiDuyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThayDoiDuyet.FillColor = System.Drawing.Color.Crimson;
            this.btnThayDoiDuyet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThayDoiDuyet.ForeColor = System.Drawing.Color.Black;
            this.btnThayDoiDuyet.Location = new System.Drawing.Point(677, 70);
            this.btnThayDoiDuyet.Name = "btnThayDoiDuyet";
            this.btnThayDoiDuyet.Size = new System.Drawing.Size(15, 15);
            this.btnThayDoiDuyet.TabIndex = 15;
            this.btnThayDoiDuyet.Visible = false;
            // 
            // btnDaHoanThanh
            // 
            this.btnDaHoanThanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDaHoanThanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDaHoanThanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDaHoanThanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDaHoanThanh.FillColor = System.Drawing.Color.White;
            this.btnDaHoanThanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaHoanThanh.ForeColor = System.Drawing.Color.Black;
            this.btnDaHoanThanh.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnDaHoanThanh.Location = new System.Drawing.Point(431, 91);
            this.btnDaHoanThanh.Name = "btnDaHoanThanh";
            this.btnDaHoanThanh.Size = new System.Drawing.Size(160, 61);
            this.btnDaHoanThanh.TabIndex = 17;
            this.btnDaHoanThanh.Text = "Đã hoàn thành";
            this.btnDaHoanThanh.Click += new System.EventHandler(this.btnDaHoanThanh_Click_1);
            // 
            // FSinhVien_Accepted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1394, 951);
            this.Controls.Add(this.btnThayDoiCho);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.btnThayDoiDuyet);
            this.Controls.Add(this.fLoTrungTam);
            this.Controls.Add(this.btnCho);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.btnDaHoanThanh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSinhVien_Accepted";
            this.Text = "FSinhVien_Accepted";
            this.Load += new System.EventHandler(this.FSinhVien_Accepted_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLoTrungTam;
        private Guna.UI2.WinForms.Guna2Button btnCho;
        private Guna.UI2.WinForms.Guna2Button btnDuyet;
        private Guna.UI2.WinForms.Guna2Panel progress;
        private Guna.UI2.WinForms.Guna2Button btnThayDoiCho;
        private Guna.UI2.WinForms.Guna2Button btnThayDoiDuyet;
        private Guna.UI2.WinForms.Guna2Button btnDaHoanThanh;
    }
}