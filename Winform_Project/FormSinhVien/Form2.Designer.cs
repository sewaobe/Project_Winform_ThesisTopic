namespace Winform_Project.FormSinhVien
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnThucHien = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoanThanh = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuaHan = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblSoLuongThucHien = new System.Windows.Forms.Label();
            this.lblSoLuongHoanThanh = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblSoLuongQuaHan = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThucHien
            // 
            this.btnThucHien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThucHien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThucHien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThucHien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThucHien.FillColor = System.Drawing.Color.Yellow;
            this.btnThucHien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.ForeColor = System.Drawing.Color.DimGray;
            this.btnThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.Image")));
            this.btnThucHien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThucHien.ImageSize = new System.Drawing.Size(35, 35);
            this.btnThucHien.Location = new System.Drawing.Point(40, 45);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(365, 61);
            this.btnThucHien.TabIndex = 0;
            this.btnThucHien.Text = "Đang thực hiện";
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoanThanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoanThanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoanThanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoanThanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHoanThanh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.Color.Black;
            this.btnHoanThanh.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanThanh.Image")));
            this.btnHoanThanh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHoanThanh.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHoanThanh.Location = new System.Drawing.Point(512, 45);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(365, 61);
            this.btnHoanThanh.TabIndex = 1;
            this.btnHoanThanh.Text = "Đã hoàn thành";
            // 
            // btnQuaHan
            // 
            this.btnQuaHan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuaHan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuaHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuaHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuaHan.FillColor = System.Drawing.Color.Red;
            this.btnQuaHan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaHan.ForeColor = System.Drawing.Color.Black;
            this.btnQuaHan.Image = ((System.Drawing.Image)(resources.GetObject("btnQuaHan.Image")));
            this.btnQuaHan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuaHan.ImageSize = new System.Drawing.Size(35, 35);
            this.btnQuaHan.Location = new System.Drawing.Point(989, 45);
            this.btnQuaHan.Name = "btnQuaHan";
            this.btnQuaHan.Size = new System.Drawing.Size(365, 61);
            this.btnQuaHan.TabIndex = 2;
            this.btnQuaHan.Text = "Đã quá hạn";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 112);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(365, 764);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(512, 112);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(365, 764);
            this.flowLayoutPanel2.TabIndex = 4;
            this.flowLayoutPanel2.Visible = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(989, 112);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(365, 764);
            this.flowLayoutPanel3.TabIndex = 4;
            this.flowLayoutPanel3.Visible = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(380, 5);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(52, 34);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblSoLuongThucHien
            // 
            this.lblSoLuongThucHien.AutoSize = true;
            this.lblSoLuongThucHien.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoLuongThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongThucHien.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSoLuongThucHien.Location = new System.Drawing.Point(397, 9);
            this.lblSoLuongThucHien.Name = "lblSoLuongThucHien";
            this.lblSoLuongThucHien.Size = new System.Drawing.Size(21, 22);
            this.lblSoLuongThucHien.TabIndex = 6;
            this.lblSoLuongThucHien.Text = "1";
            // 
            // lblSoLuongHoanThanh
            // 
            this.lblSoLuongHoanThanh.AutoSize = true;
            this.lblSoLuongHoanThanh.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoLuongHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongHoanThanh.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSoLuongHoanThanh.Location = new System.Drawing.Point(869, 9);
            this.lblSoLuongHoanThanh.Name = "lblSoLuongHoanThanh";
            this.lblSoLuongHoanThanh.Size = new System.Drawing.Size(21, 22);
            this.lblSoLuongHoanThanh.TabIndex = 8;
            this.lblSoLuongHoanThanh.Text = "1";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(852, 5);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(52, 34);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 7;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // lblSoLuongQuaHan
            // 
            this.lblSoLuongQuaHan.AutoSize = true;
            this.lblSoLuongQuaHan.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoLuongQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongQuaHan.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuongQuaHan.Location = new System.Drawing.Point(1346, 9);
            this.lblSoLuongQuaHan.Name = "lblSoLuongQuaHan";
            this.lblSoLuongQuaHan.Size = new System.Drawing.Size(21, 22);
            this.lblSoLuongQuaHan.TabIndex = 10;
            this.lblSoLuongQuaHan.Text = "1";
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(1329, 5);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(52, 34);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 9;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 951);
            this.Controls.Add(this.lblSoLuongQuaHan);
            this.Controls.Add(this.guna2CirclePictureBox3);
            this.Controls.Add(this.lblSoLuongHoanThanh);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.lblSoLuongThucHien);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnQuaHan);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.btnThucHien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnThucHien;
        private Guna.UI2.WinForms.Guna2Button btnHoanThanh;
        private Guna.UI2.WinForms.Guna2Button btnQuaHan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblSoLuongThucHien;
        private System.Windows.Forms.Label lblSoLuongHoanThanh;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label lblSoLuongQuaHan;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
    }
}