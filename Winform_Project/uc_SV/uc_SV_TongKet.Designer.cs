namespace Winform_Project.uc_SV
{
    partial class uc_SV_TongKet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_SV_TongKet));
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblTongDeTaiDuocGiao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTongDeTaiDaHoanThanh = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.BackColor = System.Drawing.Color.White;
            this.lblMSSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(137, 85);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(61, 28);
            this.lblMSSV.TabIndex = 4;
            this.lblMSSV.Text = "MSSV";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.White;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(128, 43);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(136, 28);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Ten sinh vien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(315, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng nhiệm vụ\r\nđược giao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(504, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 56);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng nhiệm vụ\r\nđã hoàn thành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(703, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả";
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.White;
            this.progress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progress.FillThickness = 10;
            this.progress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.Color.Black;
            this.progress.Location = new System.Drawing.Point(832, 26);
            this.progress.Minimum = 0;
            this.progress.Name = "progress";
            this.progress.ProgressThickness = 10;
            this.progress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progress.ShowText = true;
            this.progress.Size = new System.Drawing.Size(79, 79);
            this.progress.TabIndex = 9;
            this.progress.Text = "guna2CircleProgressBar1";
            // 
            // lblTongDeTaiDuocGiao
            // 
            this.lblTongDeTaiDuocGiao.AutoSize = true;
            this.lblTongDeTaiDuocGiao.BackColor = System.Drawing.Color.White;
            this.lblTongDeTaiDuocGiao.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDeTaiDuocGiao.ForeColor = System.Drawing.Color.DimGray;
            this.lblTongDeTaiDuocGiao.Location = new System.Drawing.Point(362, 30);
            this.lblTongDeTaiDuocGiao.Name = "lblTongDeTaiDuocGiao";
            this.lblTongDeTaiDuocGiao.Size = new System.Drawing.Size(56, 45);
            this.lblTongDeTaiDuocGiao.TabIndex = 10;
            this.lblTongDeTaiDuocGiao.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(836, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Điểm ";
            // 
            // lblTongDeTaiDaHoanThanh
            // 
            this.lblTongDeTaiDaHoanThanh.AutoSize = true;
            this.lblTongDeTaiDaHoanThanh.BackColor = System.Drawing.Color.White;
            this.lblTongDeTaiDaHoanThanh.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDeTaiDaHoanThanh.ForeColor = System.Drawing.Color.DimGray;
            this.lblTongDeTaiDaHoanThanh.Location = new System.Drawing.Point(552, 30);
            this.lblTongDeTaiDaHoanThanh.Name = "lblTongDeTaiDaHoanThanh";
            this.lblTongDeTaiDaHoanThanh.Size = new System.Drawing.Size(56, 45);
            this.lblTongDeTaiDaHoanThanh.TabIndex = 14;
            this.lblTongDeTaiDaHoanThanh.Text = "30";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.BackColor = System.Drawing.Color.White;
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.DimGray;
            this.lblKetQua.Location = new System.Drawing.Point(720, 26);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(46, 45);
            this.lblKetQua.TabIndex = 15;
            this.lblKetQua.Text = "--";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(21, 26);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(101, 87);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.BorderRadius = 10;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.pic.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pic.Size = new System.Drawing.Size(927, 141);
            this.pic.TabIndex = 16;
            this.pic.TabStop = false;
            // 
            // uc_SV_TongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblTongDeTaiDaHoanThanh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTongDeTaiDuocGiao);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.pic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "uc_SV_TongKet";
            this.Size = new System.Drawing.Size(927, 141);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public System.Windows.Forms.Label lblMSSV;
        public System.Windows.Forms.Label lblTen;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblTongDeTaiDuocGiao;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblTongDeTaiDaHoanThanh;
        public System.Windows.Forms.Label lblKetQua;
        public Guna.UI2.WinForms.Guna2CircleProgressBar progress;
        public Guna.UI2.WinForms.Guna2PictureBox pic;
    }
}
