namespace Winform_Project
{
    partial class ucItems
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
            this.lblTen = new System.Windows.Forms.Label();
            this.picBgk = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBgk)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(29, 39);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(85, 32);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Khoa";
            this.lblTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // picBgk
            // 
            this.picBgk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBgk.ImageRotate = 0F;
            this.picBgk.Location = new System.Drawing.Point(0, 0);
            this.picBgk.Name = "picBgk";
            this.picBgk.Size = new System.Drawing.Size(699, 104);
            this.picBgk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBgk.TabIndex = 1;
            this.picBgk.TabStop = false;
            this.picBgk.Tag = "";
            // 
            // ucItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.picBgk);
            this.Name = "ucItems";
            this.Size = new System.Drawing.Size(699, 104);
            this.Load += new System.EventHandler(this.ucItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBgk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTen;
        public Guna.UI2.WinForms.Guna2PictureBox picBgk;
    }
}
