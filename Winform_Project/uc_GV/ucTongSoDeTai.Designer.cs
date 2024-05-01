namespace Winform_Project.uc_GV
{
    partial class ucTongSoDeTai
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
            this.components = new System.ComponentModel.Container();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(29, 24);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(46, 28);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Ten";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(161, 108);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(46, 54);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "1";
            // 
            // progressBar
            // 
            this.progressBar.Animated = true;
            this.progressBar.AnimationSpeed = 0.4F;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.FillColor = System.Drawing.Color.Transparent;
            this.progressBar.FillThickness = 15;
            this.progressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressBar.ForeColor = System.Drawing.Color.Black;
            this.progressBar.Location = new System.Drawing.Point(24, 80);
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.White;
            this.progressBar.ProgressColor2 = System.Drawing.Color.Red;
            this.progressBar.ProgressThickness = 15;
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.ShowText = true;
            this.progressBar.Size = new System.Drawing.Size(115, 115);
            this.progressBar.TabIndex = 3;
            this.progressBar.Value = 80;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.BorderRadius = 20;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.FillColor = System.Drawing.Color.SteelBlue;
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(306, 224);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // ucTongSoDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.pic);
            this.Name = "ucTongSoDeTai";
            this.Size = new System.Drawing.Size(306, 224);
            this.Load += new System.EventHandler(this.ucTongSoDeTai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox pic;
        public System.Windows.Forms.Label lblTen;
        public System.Windows.Forms.Label lblSoLuong;
        public Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;
        public Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}
