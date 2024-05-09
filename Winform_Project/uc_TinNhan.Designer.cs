namespace Winform_Project
{
    partial class uc_TinNhan
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
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblThoiGianGui = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(26, 20);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(497, 90);
            this.lblNoiDung.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblThoiGianGui
            // 
            this.lblThoiGianGui.AutoSize = true;
            this.lblThoiGianGui.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianGui.ForeColor = System.Drawing.Color.Black;
            this.lblThoiGianGui.Location = new System.Drawing.Point(22, 110);
            this.lblThoiGianGui.Name = "lblThoiGianGui";
            this.lblThoiGianGui.Size = new System.Drawing.Size(53, 21);
            this.lblThoiGianGui.TabIndex = 1;
            this.lblThoiGianGui.Text = "label1";
            // 
            // uc_TinNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.lblThoiGianGui);
            this.Controls.Add(this.lblNoiDung);
            this.Name = "uc_TinNhan";
            this.Size = new System.Drawing.Size(558, 140);
            this.Resize += new System.EventHandler(this.uc_TinNhan_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNoiDung;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblThoiGianGui;
    }
}
