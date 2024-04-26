namespace Winform_Project
{
    partial class uc_Lich_Thang
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
            this.btnThang = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnThang
            // 
            this.btnThang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThang.FillColor = System.Drawing.SystemColors.Control;
            this.btnThang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThang.ForeColor = System.Drawing.Color.Black;
            this.btnThang.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnThang.Location = new System.Drawing.Point(15, 3);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(180, 65);
            this.btnThang.TabIndex = 0;
            this.btnThang.Text = "Tháng 1";
            // 
            // uc_Lich_Thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThang);
            this.Name = "uc_Lich_Thang";
            this.Size = new System.Drawing.Size(195, 65);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnThang;
    }
}
