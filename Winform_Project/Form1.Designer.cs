namespace Winform_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuayVe = new Guna.UI2.WinForms.Guna2Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.ucItems1 = new Winform_Project.ucItems();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ucItems1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(869, 375);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.AutoRoundedCorners = true;
            this.btnQuayVe.BorderRadius = 19;
            this.btnQuayVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuayVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuayVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuayVe.ForeColor = System.Drawing.Color.White;
            this.btnQuayVe.Location = new System.Drawing.Point(746, 457);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(126, 40);
            this.btnQuayVe.TabIndex = 1;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.Visible = false;
            this.btnQuayVe.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(30, 29);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 20);
            this.lblPath.TabIndex = 2;
            // 
            // ucItems1
            // 
            this.ucItems1.AutoScroll = true;
            this.ucItems1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucItems1.Location = new System.Drawing.Point(3, 3);
            this.ucItems1.Name = "ucItems1";
            this.ucItems1.Size = new System.Drawing.Size(773, 109);
            this.ucItems1.TabIndex = 1;
            this.ucItems1.Load += new System.EventHandler(this.ucItems1_Load_1);
            this.ucItems1.Click += new System.EventHandler(this.ucItems1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 519);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ucItems ucItems1;
        private Guna.UI2.WinForms.Guna2Button btnQuayVe;
        private System.Windows.Forms.Label lblPath;
    }
}