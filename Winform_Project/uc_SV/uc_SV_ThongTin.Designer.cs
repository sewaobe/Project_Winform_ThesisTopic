namespace Winform_Project.uc_SV
{
    partial class uc_SV_ThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_SV_ThongTin));
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnThemSinhVien = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(141, 29);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(142, 25);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Ten sinh vien";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(141, 63);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(75, 25);
            this.lblMSSV.TabIndex = 1;
            this.lblMSSV.Text = "MSSV";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(101, 87);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSinhVien.Image")));
            this.btnThemSinhVien.ImageRotate = 0F;
            this.btnThemSinhVien.Location = new System.Drawing.Point(479, 29);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnThemSinhVien.Size = new System.Drawing.Size(58, 55);
            this.btnThemSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThemSinhVien.TabIndex = 4;
            this.btnThemSinhVien.TabStop = false;
            // 
            // uc_SV_ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemSinhVien);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.lblTen);
            this.Name = "uc_SV_ThongTin";
            this.Size = new System.Drawing.Size(556, 111);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTen;
        public System.Windows.Forms.Label lblMSSV;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox btnThemSinhVien;
    }
}
