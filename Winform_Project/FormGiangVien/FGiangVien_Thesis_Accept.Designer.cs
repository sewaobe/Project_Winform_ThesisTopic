namespace Winform_Project.FormGiangVien
{
    partial class FGiangVien_Thesis_Accept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGiangVien_Thesis_Accept));
            this.deTaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.btnCho = new Guna.UI2.WinForms.Guna2Button();
            this.fLoTrungTam = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDongY = new Guna.UI2.WinForms.Guna2Button();
            this.btnTuChoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnTongQuan = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.progress = new Guna.UI2.WinForms.Guna2Panel();
            this.headerDeTai = new Guna.UI2.WinForms.Guna2Button();
            this.headerMaNhom = new Guna.UI2.WinForms.Guna2Button();
            this.headerOperation = new Guna.UI2.WinForms.Guna2Button();
            this.fGiangVienThesisAcceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).BeginInit();
            this.fLoTrungTam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTongQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGiangVienThesisAcceptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deTaiBindingSource1
            // 
            this.deTaiBindingSource1.DataMember = "DeTai\r\n";
            // 
            // deTaiBindingSource
            // 
            this.deTaiBindingSource.DataMember = "DeTai\r\n";
            // 
            // btnDuyet
            // 
            this.btnDuyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDuyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDuyet.FillColor = System.Drawing.Color.White;
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.ForeColor = System.Drawing.Color.Black;
            this.btnDuyet.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnDuyet.Location = new System.Drawing.Point(61, 120);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(160, 61);
            this.btnDuyet.TabIndex = 0;
            this.btnDuyet.Text = "Đã duyệt";
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // btnCho
            // 
            this.btnCho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCho.FillColor = System.Drawing.Color.White;
            this.btnCho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCho.ForeColor = System.Drawing.Color.Black;
            this.btnCho.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnCho.Location = new System.Drawing.Point(227, 120);
            this.btnCho.Name = "btnCho";
            this.btnCho.Size = new System.Drawing.Size(160, 61);
            this.btnCho.TabIndex = 1;
            this.btnCho.Text = "Đang chờ";
            this.btnCho.Click += new System.EventHandler(this.btnCho_Click);
            // 
            // fLoTrungTam
            // 
            this.fLoTrungTam.AutoScroll = true;
            this.fLoTrungTam.BackColor = System.Drawing.SystemColors.Control;
            this.fLoTrungTam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLoTrungTam.Controls.Add(this.headerDeTai);
            this.fLoTrungTam.Controls.Add(this.headerMaNhom);
            this.fLoTrungTam.Controls.Add(this.headerOperation);
            this.fLoTrungTam.Location = new System.Drawing.Point(12, 187);
            this.fLoTrungTam.Name = "fLoTrungTam";
            this.fLoTrungTam.Size = new System.Drawing.Size(1208, 570);
            this.fLoTrungTam.TabIndex = 7;
            this.fLoTrungTam.Paint += new System.Windows.Forms.PaintEventHandler(this.fLoTrungTam_Paint);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconRight")));
            this.guna2TextBox1.Location = new System.Drawing.Point(44, 36);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm đề tài";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(441, 49);
            this.guna2TextBox1.TabIndex = 8;
            // 
            // btnDongY
            // 
            this.btnDongY.AutoRoundedCorners = true;
            this.btnDongY.BackColor = System.Drawing.Color.Transparent;
            this.btnDongY.BorderRadius = 25;
            this.btnDongY.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnDongY.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDongY.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDongY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDongY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDongY.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnDongY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.ForeColor = System.Drawing.Color.Black;
            this.btnDongY.Location = new System.Drawing.Point(836, 69);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(56, 53);
            this.btnDongY.TabIndex = 9;
            this.btnDongY.Text = "V";
            this.btnDongY.Visible = false;
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.AutoRoundedCorners = true;
            this.btnTuChoi.BackColor = System.Drawing.Color.Transparent;
            this.btnTuChoi.BorderRadius = 25;
            this.btnTuChoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTuChoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTuChoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTuChoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTuChoi.FillColor = System.Drawing.Color.Crimson;
            this.btnTuChoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuChoi.ForeColor = System.Drawing.Color.Black;
            this.btnTuChoi.Location = new System.Drawing.Point(917, 69);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(57, 53);
            this.btnTuChoi.TabIndex = 10;
            this.btnTuChoi.Text = "X";
            this.btnTuChoi.Visible = false;
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTongQuan.Image = ((System.Drawing.Image)(resources.GetObject("btnTongQuan.Image")));
            this.btnTongQuan.ImageRotate = 0F;
            this.btnTongQuan.Location = new System.Drawing.Point(1035, 58);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTongQuan.Size = new System.Drawing.Size(64, 64);
            this.btnTongQuan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTongQuan.TabIndex = 11;
            this.btnTongQuan.TabStop = false;
            this.btnTongQuan.Visible = false;
            // 
            // progress
            // 
            this.progress.FillColor = System.Drawing.Color.Blue;
            this.progress.Location = new System.Drawing.Point(61, 176);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(160, 5);
            this.progress.TabIndex = 12;
            // 
            // headerDeTai
            // 
            this.headerDeTai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.headerDeTai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.headerDeTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.headerDeTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.headerDeTai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.headerDeTai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.headerDeTai.ForeColor = System.Drawing.Color.Black;
            this.headerDeTai.Location = new System.Drawing.Point(3, 3);
            this.headerDeTai.Name = "headerDeTai";
            this.headerDeTai.Size = new System.Drawing.Size(681, 45);
            this.headerDeTai.TabIndex = 0;
            this.headerDeTai.Text = "Đề tài";
            // 
            // headerMaNhom
            // 
            this.headerMaNhom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.headerMaNhom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.headerMaNhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.headerMaNhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.headerMaNhom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.headerMaNhom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerMaNhom.ForeColor = System.Drawing.Color.Black;
            this.headerMaNhom.Location = new System.Drawing.Point(690, 3);
            this.headerMaNhom.Name = "headerMaNhom";
            this.headerMaNhom.Size = new System.Drawing.Size(271, 45);
            this.headerMaNhom.TabIndex = 1;
            this.headerMaNhom.Text = "Mã nhóm";
            // 
            // headerOperation
            // 
            this.headerOperation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.headerOperation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.headerOperation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.headerOperation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.headerOperation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.headerOperation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerOperation.ForeColor = System.Drawing.Color.Black;
            this.headerOperation.Location = new System.Drawing.Point(967, 3);
            this.headerOperation.Name = "headerOperation";
            this.headerOperation.Size = new System.Drawing.Size(223, 45);
            this.headerOperation.TabIndex = 2;
            this.headerOperation.Text = "Operation";
            // 
            // fGiangVienThesisAcceptBindingSource
            // 
            this.fGiangVienThesisAcceptBindingSource.DataSource = typeof(Winform_Project.FormGiangVien.FGiangVien_Thesis_Accept);
            // 
            // FGiangVien_Thesis_Accept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 769);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.btnTongQuan);
            this.Controls.Add(this.btnTuChoi);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.fLoTrungTam);
            this.Controls.Add(this.btnCho);
            this.Controls.Add(this.btnDuyet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGiangVien_Thesis_Accept";
            this.Text = "FGiangVien_Thesis_Accept";
            this.Load += new System.EventHandler(this.FGiangVien_Thesis_Accept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).EndInit();
            this.fLoTrungTam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnTongQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGiangVienThesisAcceptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fGiangVienThesisAcceptBindingSource;
        private System.Windows.Forms.BindingSource deTaiBindingSource;
        private System.Windows.Forms.BindingSource deTaiBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhómThucHienDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btnDuyet;
        private Guna.UI2.WinForms.Guna2Button btnCho;
        private System.Windows.Forms.FlowLayoutPanel fLoTrungTam;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnDongY;
        private Guna.UI2.WinForms.Guna2Button btnTuChoi;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnTongQuan;
        private Guna.UI2.WinForms.Guna2Panel progress;
        private Guna.UI2.WinForms.Guna2Button headerDeTai;
        private Guna.UI2.WinForms.Guna2Button headerMaNhom;
        private Guna.UI2.WinForms.Guna2Button headerOperation;
    }
}