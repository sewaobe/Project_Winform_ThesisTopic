namespace Winform_Project.FSinhVien
{
    partial class FSinhVien_Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSinhVien_Reg));
            this.deTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.cbbGiangVien = new System.Windows.Forms.ToolStripComboBox();
            this.cbbTheLoai = new System.Windows.Forms.ToolStripComboBox();
            this.cbbHocKy = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.flow_DeTai = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deTaiBindingSource
            // 
            this.deTaiBindingSource.DataMember = "DeTai\r\n";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 28;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1178, 46);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(212, 58);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.Text = "Đề xuất";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // cbbGiangVien
            // 
            this.cbbGiangVien.Items.AddRange(new object[] {
            "Giảng Viên"});
            this.cbbGiangVien.MergeIndex = 0;
            this.cbbGiangVien.Name = "cbbGiangVien";
            this.cbbGiangVien.Size = new System.Drawing.Size(180, 33);
            this.cbbGiangVien.Text = "Giảng Viên";
            this.cbbGiangVien.SelectedIndexChanged += new System.EventHandler(this.cbbGiangVien_SelectedIndexChanged);
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.Items.AddRange(new object[] {
            "Thể Loại"});
            this.cbbTheLoai.MergeIndex = 0;
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(180, 33);
            this.cbbTheLoai.Text = "Thể Loại";
            this.cbbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbbTheLoai_SelectedIndexChanged);
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.Items.AddRange(new object[] {
            "Học Kỳ",
            "Hoc Ky 1",
            "Hoc Ky 2",
            "Hoc Ky 3"});
            this.cbbHocKy.MergeIndex = 0;
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(121, 33);
            this.cbbHocKy.Text = "Học Kỳ";
            this.cbbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbbHocKy_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbbGiangVien,
            this.cbbTheLoai,
            this.cbbHocKy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1392, 37);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thesis List:";
            // 
            // flow_DeTai
            // 
            this.flow_DeTai.AutoScroll = true;
            this.flow_DeTai.Location = new System.Drawing.Point(0, 112);
            this.flow_DeTai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flow_DeTai.Name = "flow_DeTai";
            this.flow_DeTai.Size = new System.Drawing.Size(1389, 820);
            this.flow_DeTai.TabIndex = 28;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoScroll = true;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconRight = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.IconRight")));
            this.txtTimKiem.Location = new System.Drawing.Point(502, 0);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm đề tài luận văn";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(333, 42);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // FSinhVien_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 951);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.flow_DeTai);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FSinhVien_Reg";
            this.Text = "FSinhVien_Reg";
            this.Load += new System.EventHandler(this.FSinhVien_Reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongThanhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deTaiBindingSource;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.ToolStripComboBox cbbGiangVien;
        private System.Windows.Forms.ToolStripComboBox cbbTheLoai;
        private System.Windows.Forms.ToolStripComboBox cbbHocKy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flow_DeTai;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}