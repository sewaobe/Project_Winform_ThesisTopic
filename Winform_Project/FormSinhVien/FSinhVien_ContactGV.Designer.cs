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
        //private void InitializeComponent()
        //{
        //    this.flowmess = new System.Windows.Forms.FlowLayoutPanel();
        //    this.txtmess = new System.Windows.Forms.TextBox();
        //    this.btnGui = new Guna.UI2.WinForms.Guna2Button();
        //    this.textBox1 = new System.Windows.Forms.TextBox();
        //    this.SuspendLayout();
        //    // 
        //    // flowmess
        //    // 
        //    this.flowmess.Location = new System.Drawing.Point(0, 36);
        //    this.flowmess.Name = "flowmess";
        //    this.flowmess.Size = new System.Drawing.Size(375, 583);
        //    this.flowmess.TabIndex = 0;
        //    // 
        //    // txtmess
        //    // 
        //    this.txtmess.Location = new System.Drawing.Point(381, 579);
        //    this.txtmess.Multiline = true;
        //    this.txtmess.Name = "txtmess";
        //    this.txtmess.Size = new System.Drawing.Size(425, 27);
        //    this.txtmess.TabIndex = 0;
        //    // 
        //    // btnGui
        //    // 
        //    this.btnGui.BorderRadius = 5;
        //    this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        //    this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        //    this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        //    this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
        //    this.btnGui.Font = new System.Drawing.Font("Segoe UI", 9F);
        //    this.btnGui.ForeColor = System.Drawing.Color.White;
        //    this.btnGui.Location = new System.Drawing.Point(812, 579);
        //    this.btnGui.Name = "btnGui";
        //    this.btnGui.Size = new System.Drawing.Size(106, 27);
        //    this.btnGui.TabIndex = 1;
        //    this.btnGui.Text = "Gửi";
        //    this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
        //    // 
        //    // textBox1
        //    // 
        //    this.textBox1.Location = new System.Drawing.Point(0, 3);
        //    this.textBox1.Multiline = true;
        //    this.textBox1.Name = "textBox1";
        //    this.textBox1.Size = new System.Drawing.Size(375, 27);
        //    this.textBox1.TabIndex = 2;
        //    this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        //    // 
        //    // FSinhVien_ContactGV
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(930, 618);
        //    this.Controls.Add(this.textBox1);
        //    this.Controls.Add(this.btnGui);
        //    this.Controls.Add(this.txtmess);
        //    this.Controls.Add(this.flowmess);
        //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    this.Name = "FSinhVien_ContactGV";
        //    this.Text = "FSinhVien_ContactGV";
        //    this.Load += new System.EventHandler(this.FSinhVien_ContactGV_Load);
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}
        private void InitializeComponent()
        {
            this.flowmess = new System.Windows.Forms.FlowLayoutPanel();
            this.txtmess = new System.Windows.Forms.TextBox();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // flowmess
            // 
            this.flowmess.Location = new System.Drawing.Point(0, 36);
            this.flowmess.Name = "flowmess";
            this.flowmess.Size = new System.Drawing.Size(375, 583);
            this.flowmess.TabIndex = 0;
            // 
            // txtmess
            // 
            this.txtmess.Location = new System.Drawing.Point(381, 579);
            this.txtmess.Multiline = true;
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(425, 27);
            this.txtmess.TabIndex = 1;
            // 
            // btnGui
            // 
            this.btnGui.BorderRadius = 5;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(812, 579);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(106, 27);
            this.btnGui.TabIndex = 2;
            this.btnGui.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(381, 36); // Đặt ngay cạnh flowmess
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(540, 537); // Điều chỉnh kích thước cho phù hợp
            this.rtbMessages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Cập nhật font ở đây
            this.rtbMessages.TabIndex = 0;
            this.rtbMessages.Text = "";

            // 
            // FSinhVien_ContactGV
            // 
            this.ClientSize = new System.Drawing.Size(930, 618);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtmess);
            this.Controls.Add(this.flowmess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSinhVien_ContactGV";
            this.Text = "FSinhVien_ContactGV";
            this.Load += new System.EventHandler(this.FSinhVien_ContactGV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            // Trong InitializeComponent
            this.lblContactName = new System.Windows.Forms.Label();
            // Cấu hình Label
            this.lblContactName.Location = new System.Drawing.Point(381, 12); // Chỉnh vị trí phù hợp
            this.lblContactName.Size = new System.Drawing.Size(540, 24); // Chỉnh kích thước phù hợp
            this.lblContactName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); // Đặt font lớn và đậm
            this.lblContactName.Text = "Tên người nhận"; // Văn bản mặc định hoặc để trống
            this.lblContactName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // Căn giữa tên

            // Thêm vào form
            this.Controls.Add(this.lblContactName);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowmess;
        private System.Windows.Forms.TextBox txtmess;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Label lblContactName;


    }
}