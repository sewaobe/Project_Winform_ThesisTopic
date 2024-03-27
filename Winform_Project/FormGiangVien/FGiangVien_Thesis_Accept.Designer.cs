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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGiangVien_Thesis_Accept));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbbKhoa = new System.Windows.Forms.ToolStripComboBox();
            this.cbbNganh = new System.Windows.Forms.ToolStripComboBox();
            this.cbbNamHoc = new System.Windows.Forms.ToolStripComboBox();
            this.cbbHocKy = new System.Windows.Forms.ToolStripComboBox();
            this.deTaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDeTai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDaDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.btnChuaDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.fGiangVienThesisAcceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeTai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGiangVienThesisAcceptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbbKhoa,
            this.cbbNganh,
            this.cbbNamHoc,
            this.cbbHocKy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 39);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.BackColor = System.Drawing.Color.White;
            this.cbbKhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Thiết kế đồ họa",
            "Công nghệ thực phẩm",
            "Kiến trúc và xây dựng",
            "Kinh tế",
            "Marketting",
            "Quản trị kinh doanh",
            "Ngôn ngữ Anh",
            "Ngôn ngữ Trung"});
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(300, 33);
            this.cbbKhoa.Text = "Khoa";
            // 
            // cbbNganh
            // 
            this.cbbNganh.BackColor = System.Drawing.Color.White;
            this.cbbNganh.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Thiết kế đồ họa",
            "Công nghệ thực phẩm",
            "Kiến trúc và xây dựng",
            "Kinh tế",
            "Marketting",
            "Quản trị kinh doanh",
            "Ngôn ngữ Anh",
            "Ngôn ngữ Trung"});
            this.cbbNganh.Name = "cbbNganh";
            this.cbbNganh.Size = new System.Drawing.Size(300, 33);
            this.cbbNganh.Text = "Ngành";
            // 
            // cbbNamHoc
            // 
            this.cbbNamHoc.BackColor = System.Drawing.Color.White;
            this.cbbNamHoc.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024"});
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Size = new System.Drawing.Size(121, 33);
            this.cbbNamHoc.Text = "Năm học";
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.BackColor = System.Drawing.Color.White;
            this.cbbHocKy.ForeColor = System.Drawing.Color.Black;
            this.cbbHocKy.Items.AddRange(new object[] {
            "Kỳ 1",
            "Kỳ 2",
            "Kỳ 3"});
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(121, 33);
            this.cbbHocKy.Text = "Học kỳ";
            // 
            // deTaiBindingSource1
            // 
            this.deTaiBindingSource1.DataMember = "DeTai\r\n";
            // 
            // deTaiBindingSource
            // 
            this.deTaiBindingSource.DataMember = "DeTai\r\n";
            // 
            // gvDeTai
            // 
            this.gvDeTai.AllowUserToAddRows = false;
            this.gvDeTai.AllowUserToDeleteRows = false;
            this.gvDeTai.AllowUserToResizeColumns = false;
            this.gvDeTai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvDeTai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDeTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDeTai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDeTai.ColumnHeadersHeight = 30;
            this.gvDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDeTai.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDeTai.EnableHeadersVisualStyles = true;
            this.gvDeTai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvDeTai.Location = new System.Drawing.Point(48, 191);
            this.gvDeTai.Name = "gvDeTai";
            this.gvDeTai.RowHeadersVisible = false;
            this.gvDeTai.RowHeadersWidth = 62;
            this.gvDeTai.RowTemplate.Height = 28;
            this.gvDeTai.Size = new System.Drawing.Size(1129, 538);
            this.gvDeTai.TabIndex = 27;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvDeTai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvDeTai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvDeTai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvDeTai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvDeTai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDeTai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvDeTai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvDeTai.ThemeStyle.HeaderStyle.Height = 30;
            this.gvDeTai.ThemeStyle.ReadOnly = false;
            this.gvDeTai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvDeTai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvDeTai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDeTai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvDeTai.ThemeStyle.RowsStyle.Height = 28;
            this.gvDeTai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvDeTai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvDeTai.Visible = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderRadius = 20;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.IconLeft")));
            this.txtTimKiem.Location = new System.Drawing.Point(863, 127);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "           Tìm kiếm đề tài";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(286, 42);
            this.txtTimKiem.TabIndex = 30;
            this.txtTimKiem.Visible = false;
            // 
            // btnDaDuyet
            // 
            this.btnDaDuyet.AutoRoundedCorners = true;
            this.btnDaDuyet.BorderRadius = 21;
            this.btnDaDuyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDaDuyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDaDuyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDaDuyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDaDuyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.btnDaDuyet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDaDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDaDuyet.Location = new System.Drawing.Point(48, 72);
            this.btnDaDuyet.Name = "btnDaDuyet";
            this.btnDaDuyet.Size = new System.Drawing.Size(1129, 45);
            this.btnDaDuyet.TabIndex = 31;
            this.btnDaDuyet.Text = "Các đề tài đã duyệt";
            this.btnDaDuyet.Click += new System.EventHandler(this.btnDaDuyet_Click);
            // 
            // btnChuaDuyet
            // 
            this.btnChuaDuyet.AutoRoundedCorners = true;
            this.btnChuaDuyet.BorderRadius = 21;
            this.btnChuaDuyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuaDuyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuaDuyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuaDuyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuaDuyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.btnChuaDuyet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuaDuyet.ForeColor = System.Drawing.Color.White;
            this.btnChuaDuyet.Location = new System.Drawing.Point(48, 140);
            this.btnChuaDuyet.Name = "btnChuaDuyet";
            this.btnChuaDuyet.Size = new System.Drawing.Size(1129, 45);
            this.btnChuaDuyet.TabIndex = 32;
            this.btnChuaDuyet.Text = "Các đề tài chưa duyệt";
            this.btnChuaDuyet.Click += new System.EventHandler(this.btnChuaDuyet_Click);
            // 
            // fGiangVienThesisAcceptBindingSource
            // 
            this.fGiangVienThesisAcceptBindingSource.DataSource = typeof(Winform_Project.FormGiangVien.FGiangVien_Thesis_Accept);
            // 
            // FGiangVien_Thesis_Accept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1232, 769);
            this.Controls.Add(this.gvDeTai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnChuaDuyet);
            this.Controls.Add(this.btnDaDuyet);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGiangVien_Thesis_Accept";
            this.Text = "FGiangVien_Thesis_Accept";
            this.Load += new System.EventHandler(this.FGiangVien_Thesis_Accept_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeTai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGiangVienThesisAcceptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource fGiangVienThesisAcceptBindingSource;
        private System.Windows.Forms.BindingSource deTaiBindingSource;
        private System.Windows.Forms.BindingSource deTaiBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhómThucHienDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox cbbKhoa;
        private System.Windows.Forms.ToolStripComboBox cbbNganh;
        private System.Windows.Forms.ToolStripComboBox cbbNamHoc;
        private System.Windows.Forms.ToolStripComboBox cbbHocKy;
        private Guna.UI2.WinForms.Guna2DataGridView gvDeTai;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnDaDuyet;
        private Guna.UI2.WinForms.Guna2Button btnChuaDuyet;
    }
}