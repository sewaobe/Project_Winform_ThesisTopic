namespace Winform_Project.FormSinhVien
{
    partial class FSinhVien_ContactGV
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
            this.flowmess = new System.Windows.Forms.FlowLayoutPanel();
            this.txtmess = new System.Windows.Forms.TextBox();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // flowmess
            // 
            this.flowmess.Location = new System.Drawing.Point(0, 0);
            this.flowmess.Name = "flowmess";
            this.flowmess.Size = new System.Drawing.Size(930, 569);
            this.flowmess.TabIndex = 0;
            // 
            // txtmess
            // 
            this.txtmess.Location = new System.Drawing.Point(12, 579);
            this.txtmess.Multiline = true;
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(794, 27);
            this.txtmess.TabIndex = 0;
            // 
            // btnGui
            // 
            this.btnGui.BorderRadius = 5;
            this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(812, 579);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(106, 27);
            this.btnGui.TabIndex = 1;
            this.btnGui.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // FSinhVien_ContactGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 618);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtmess);
            this.Controls.Add(this.flowmess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSinhVien_ContactGV";
            this.Text = "FSinhVien_ContactGV";
            this.Load += new System.EventHandler(this.FSinhVien_ContactGV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowmess;
        private System.Windows.Forms.TextBox txtmess;
        private Guna.UI2.WinForms.Guna2Button btnGui;
    }
}