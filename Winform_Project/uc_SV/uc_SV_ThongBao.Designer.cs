namespace Winform_Project
{
    partial class uc_SV_ThongBao
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
            this.lblNguoiGui = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblThoiGianGui = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNguoiGui
            // 
            this.lblNguoiGui.AutoSize = true;
            this.lblNguoiGui.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNguoiGui.Location = new System.Drawing.Point(105, 51);
            this.lblNguoiGui.Name = "lblNguoiGui";
            this.lblNguoiGui.Size = new System.Drawing.Size(103, 20);
            this.lblNguoiGui.TabIndex = 16;
            this.lblNguoiGui.Text = "Người gửi";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(104, 6);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(105, 25);
            this.lblTieuDe.TabIndex = 18;
            this.lblTieuDe.Text = "Tiêu Đề:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 2);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(591, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 82);
            this.panel2.TabIndex = 20;
            // 
            // pic
            // 
            this.pic.ErrorImage = null;
            this.pic.Image = global::Winform_Project.Properties.Resources.letter_open;
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(13, 6);
            this.pic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(69, 65);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // lblThoiGianGui
            // 
            this.lblThoiGianGui.AutoSize = true;
            this.lblThoiGianGui.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianGui.Location = new System.Drawing.Point(400, 51);
            this.lblThoiGianGui.Name = "lblThoiGianGui";
            this.lblThoiGianGui.Size = new System.Drawing.Size(74, 17);
            this.lblThoiGianGui.TabIndex = 21;
            this.lblThoiGianGui.Text = "Thời gian";
            // 
            // uc_SV_ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblThoiGianGui);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblNguoiGui);
            this.Controls.Add(this.pic);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_SV_ThongBao";
            this.Size = new System.Drawing.Size(592, 82);
            this.Load += new System.EventHandler(this.uc_SV_ThongBao_Load);
            this.Click += new System.EventHandler(this.uc_SV_ThongBao_Click);
            this.MouseLeave += new System.EventHandler(this.uc_SV_ThongBao_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uc_SV_ThongBao_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pic;
        public System.Windows.Forms.Label lblNguoiGui;
        public System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblThoiGianGui;
    }
}
