namespace Winform_Project
{
    partial class uc_Lich_Ngay
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
            this.btnNgay = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnNgay
            // 
            this.btnNgay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNgay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNgay.FillColor = System.Drawing.Color.White;
            this.btnNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNgay.ForeColor = System.Drawing.Color.Black;
            this.btnNgay.Location = new System.Drawing.Point(0, 0);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(107, 82);
            this.btnNgay.TabIndex = 2;
            this.btnNgay.Text = "Trống";
            // 
            // uc_Lich_Ngay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNgay);
            this.Name = "uc_Lich_Ngay";
            this.Size = new System.Drawing.Size(107, 85);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnNgay;
    }
}
