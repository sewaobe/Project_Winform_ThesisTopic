namespace Winform_Project
{
    partial class uc_TinNhan_DacBiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_TinNhan_DacBiet));
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.picFile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TinNhanDacBiet = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinNhanDacBiet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.ForeColor = System.Drawing.Color.White;
            this.lblNoiDung.Location = new System.Drawing.Point(21, 11);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(295, 25);
            this.lblNoiDung.TabIndex = 1;
            this.lblNoiDung.Text = "Nguyen Thuy An da gui 1 file pdf";
            // 
            // picFile
            // 
            this.picFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.picFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.picFile.Image = ((System.Drawing.Image)(resources.GetObject("picFile.Image")));
            this.picFile.ImageRotate = 0F;
            this.picFile.Location = new System.Drawing.Point(408, 11);
            this.picFile.Name = "picFile";
            this.picFile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picFile.Size = new System.Drawing.Size(42, 42);
            this.picFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFile.TabIndex = 3;
            this.picFile.TabStop = false;
            // 
            // TinNhanDacBiet
            // 
            this.TinNhanDacBiet.BorderRadius = 15;
            this.TinNhanDacBiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TinNhanDacBiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.TinNhanDacBiet.ImageRotate = 0F;
            this.TinNhanDacBiet.Location = new System.Drawing.Point(0, 0);
            this.TinNhanDacBiet.Name = "TinNhanDacBiet";
            this.TinNhanDacBiet.Size = new System.Drawing.Size(464, 63);
            this.TinNhanDacBiet.TabIndex = 0;
            this.TinNhanDacBiet.TabStop = false;
            this.TinNhanDacBiet.Click += new System.EventHandler(this.TinNhanDacBiet_Click);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.White;
            this.lblThoiGian.Location = new System.Drawing.Point(21, 38);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(19, 21);
            this.lblThoiGian.TabIndex = 4;
            this.lblThoiGian.Text = "a";
            // 
            // uc_TinNhan_DacBiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.picFile);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.TinNhanDacBiet);
            this.Name = "uc_TinNhan_DacBiet";
            this.Size = new System.Drawing.Size(464, 63);
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinNhanDacBiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox TinNhanDacBiet;
        private System.Windows.Forms.Label lblNoiDung;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picFile;
        private System.Windows.Forms.Label lblThoiGian;
    }
}
