namespace Winform_Project.FormSinhVien
{
    partial class Form1
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
            this.btnNhanXet = new Guna.UI2.WinForms.Guna2Button();
            this.btnTienDo = new Guna.UI2.WinForms.Guna2Button();
            this.progress = new Guna.UI2.WinForms.Guna2Panel();
            this.fLoTrungTam = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNhiemVu = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnNhanXet
            // 
            this.btnNhanXet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanXet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanXet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanXet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanXet.FillColor = System.Drawing.Color.White;
            this.btnNhanXet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanXet.ForeColor = System.Drawing.Color.Black;
            this.btnNhanXet.Location = new System.Drawing.Point(71, 36);
            this.btnNhanXet.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanXet.Name = "btnNhanXet";
            this.btnNhanXet.Size = new System.Drawing.Size(120, 29);
            this.btnNhanXet.TabIndex = 0;
            this.btnNhanXet.Text = "Nhận xét ";
            this.btnNhanXet.Click += new System.EventHandler(this.btnNhanXet_Click);
            // 
            // btnTienDo
            // 
            this.btnTienDo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTienDo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTienDo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTienDo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTienDo.FillColor = System.Drawing.Color.White;
            this.btnTienDo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienDo.ForeColor = System.Drawing.Color.Black;
            this.btnTienDo.Location = new System.Drawing.Point(195, 36);
            this.btnTienDo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTienDo.Name = "btnTienDo";
            this.btnTienDo.Size = new System.Drawing.Size(120, 29);
            this.btnTienDo.TabIndex = 1;
            this.btnTienDo.Text = "Tiến độ";
            this.btnTienDo.Click += new System.EventHandler(this.btnTienDo_Click);
            // 
            // progress
            // 
            this.progress.FillColor = System.Drawing.Color.Blue;
            this.progress.Location = new System.Drawing.Point(71, 70);
            this.progress.Margin = new System.Windows.Forms.Padding(2);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(120, 3);
            this.progress.TabIndex = 2;
            // 
            // fLoTrungTam
            // 
            this.fLoTrungTam.AutoScroll = true;
            this.fLoTrungTam.BackColor = System.Drawing.SystemColors.Control;
            this.fLoTrungTam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLoTrungTam.Location = new System.Drawing.Point(38, 112);
            this.fLoTrungTam.Margin = new System.Windows.Forms.Padding(2);
            this.fLoTrungTam.Name = "fLoTrungTam";
            this.fLoTrungTam.Size = new System.Drawing.Size(885, 424);
            this.fLoTrungTam.TabIndex = 3;
            // 
            // btnNhiemVu
            // 
            this.btnNhiemVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhiemVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhiemVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhiemVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhiemVu.FillColor = System.Drawing.Color.White;
            this.btnNhiemVu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhiemVu.ForeColor = System.Drawing.Color.Black;
            this.btnNhiemVu.Location = new System.Drawing.Point(319, 36);
            this.btnNhiemVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhiemVu.Name = "btnNhiemVu";
            this.btnNhiemVu.Size = new System.Drawing.Size(120, 29);
            this.btnNhiemVu.TabIndex = 4;
            this.btnNhiemVu.Text = "Nhiệm Vụ";
            this.btnNhiemVu.Click += new System.EventHandler(this.btnNhiemVu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.btnNhiemVu);
            this.Controls.Add(this.fLoTrungTam);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.btnTienDo);
            this.Controls.Add(this.btnNhanXet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnNhanXet;
        public Guna.UI2.WinForms.Guna2Button btnTienDo;
        public Guna.UI2.WinForms.Guna2Panel progress;
        public System.Windows.Forms.FlowLayoutPanel fLoTrungTam;
        public Guna.UI2.WinForms.Guna2Button btnNhiemVu;
    }
}