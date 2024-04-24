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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
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
            this.btnNhanXet.Location = new System.Drawing.Point(107, 56);
            this.btnNhanXet.Name = "btnNhanXet";
            this.btnNhanXet.Size = new System.Drawing.Size(180, 45);
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
            this.btnTienDo.Location = new System.Drawing.Point(293, 56);
            this.btnTienDo.Name = "btnTienDo";
            this.btnTienDo.Size = new System.Drawing.Size(180, 45);
            this.btnTienDo.TabIndex = 1;
            this.btnTienDo.Text = "Tiến độ";
            this.btnTienDo.Click += new System.EventHandler(this.btnTienDo_Click);
            // 
            // progress
            // 
            this.progress.FillColor = System.Drawing.Color.Blue;
            this.progress.Location = new System.Drawing.Point(107, 107);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(180, 5);
            this.progress.TabIndex = 2;
            // 
            // fLoTrungTam
            // 
            this.fLoTrungTam.AutoScroll = true;
            this.fLoTrungTam.BackColor = System.Drawing.SystemColors.Control;
            this.fLoTrungTam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLoTrungTam.Location = new System.Drawing.Point(57, 173);
            this.fLoTrungTam.Name = "fLoTrungTam";
            this.fLoTrungTam.Size = new System.Drawing.Size(1326, 651);
            this.fLoTrungTam.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(479, 56);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Nhiệm vụ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 862);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.fLoTrungTam);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.btnTienDo);
            this.Controls.Add(this.btnNhanXet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnNhanXet;
        private Guna.UI2.WinForms.Guna2Button btnTienDo;
        private Guna.UI2.WinForms.Guna2Panel progress;
        private System.Windows.Forms.FlowLayoutPanel fLoTrungTam;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}