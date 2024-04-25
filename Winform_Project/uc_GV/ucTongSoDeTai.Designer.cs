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
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(19, 184);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(59, 29);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Ten";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(18, 63);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(135, 32);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "So luong";
            // 
            // progressBar
            // 
            this.progressBar.FillColor = System.Drawing.Color.White;
            this.progressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(214, 46);
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.Red;
            this.progressBar.ProgressColor2 = System.Drawing.Color.White;
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.Size = new System.Drawing.Size(130, 130);
            this.progressBar.TabIndex = 3;
            this.progressBar.Text = "guna2CircleProgressBar1";
            this.progressBar.Value = 80;
            // 
            // ucTongSoDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblSoLuong);
            this.Name = "ucTongSoDeTai";
            this.Size = new System.Drawing.Size(369, 224);
            this.Load += new System.EventHandler(this.ucTongSoDeTai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTen;
        public System.Windows.Forms.Label lblSoLuong;
        public Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}
