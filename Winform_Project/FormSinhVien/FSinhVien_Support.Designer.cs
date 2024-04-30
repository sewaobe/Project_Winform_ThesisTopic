namespace Winform_Project.FormSinhVien
{
    partial class FSinhVien_Support
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flowThongBao = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.radioChuaDoc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioDaDoc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // flowThongBao
            // 
            this.flowThongBao.Location = new System.Drawing.Point(8, 88);
            this.flowThongBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowThongBao.Name = "flowThongBao";
            this.flowThongBao.Size = new System.Drawing.Size(1206, 663);
            this.flowThongBao.TabIndex = 0;
            this.flowThongBao.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // radioChuaDoc
            // 
            this.radioChuaDoc.AutoSize = true;
            this.radioChuaDoc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioChuaDoc.CheckedState.BorderThickness = 0;
            this.radioChuaDoc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioChuaDoc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioChuaDoc.CheckedState.InnerOffset = -4;
            this.radioChuaDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioChuaDoc.Location = new System.Drawing.Point(1019, 12);
            this.radioChuaDoc.Name = "radioChuaDoc";
            this.radioChuaDoc.Size = new System.Drawing.Size(201, 26);
            this.radioChuaDoc.TabIndex = 1;
            this.radioChuaDoc.Text = "Tin nhắn chưa đọc";
            this.radioChuaDoc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioChuaDoc.UncheckedState.BorderThickness = 2;
            this.radioChuaDoc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioChuaDoc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioDaDoc
            // 
            this.radioDaDoc.AutoSize = true;
            this.radioDaDoc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioDaDoc.CheckedState.BorderThickness = 0;
            this.radioDaDoc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioDaDoc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioDaDoc.CheckedState.InnerOffset = -4;
            this.radioDaDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDaDoc.Location = new System.Drawing.Point(1019, 54);
            this.radioDaDoc.Name = "radioDaDoc";
            this.radioDaDoc.Size = new System.Drawing.Size(180, 26);
            this.radioDaDoc.TabIndex = 2;
            this.radioDaDoc.Text = "Tin nhắn đã đọc";
            this.radioDaDoc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioDaDoc.UncheckedState.BorderThickness = 2;
            this.radioDaDoc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioDaDoc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // FSinhVien_Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 769);
            this.Controls.Add(this.radioDaDoc);
            this.Controls.Add(this.radioChuaDoc);
            this.Controls.Add(this.flowThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FSinhVien_Support";
            this.Text = "FSinhVien_Support";
            this.Load += new System.EventHandler(this.FSinhVien_Support_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.FlowLayoutPanel flowThongBao;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2RadioButton radioChuaDoc;
        private Guna.UI2.WinForms.Guna2RadioButton radioDaDoc;
    }
}