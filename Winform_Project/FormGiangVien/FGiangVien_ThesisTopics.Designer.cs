namespace Winform_Project
{
    partial class FGiangVien_ThesisTopics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGiangVien_ThesisTopics));
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbbKhoa = new System.Windows.Forms.ToolStripComboBox();
            this.cbbNganh = new System.Windows.Forms.ToolStripComboBox();
            this.cbbNamHoc = new System.Windows.Forms.ToolStripComboBox();
            this.cbbHocKy = new System.Windows.Forms.ToolStripComboBox();
            this.cbbTheLoai = new System.Windows.Forms.ToolStripComboBox();
            this.gvDeTai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeTai)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(16, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Danh sách đề tài";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 30;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(208)))), ((int)(((byte)(194)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1257, 873);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(160, 63);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "Thêm đề tài";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbbKhoa,
            this.cbbNganh,
            this.cbbNamHoc,
            this.cbbHocKy,
            this.cbbTheLoai});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1430, 37);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // cbbNganh
            // 
            this.cbbNganh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbNganh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.cbbNamHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbNamHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNamHoc.Items.AddRange(new object[] {
            "2020 - 2021",
            "2021 - 2022",
            "2022 - 2023",
            "2023 - 2024"});
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Size = new System.Drawing.Size(121, 33);
            this.cbbNamHoc.Text = "Năm học";
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbHocKy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbHocKy.Items.AddRange(new object[] {
            "Kỳ 1",
            "Kỳ 2",
            "Kỳ 3"});
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(121, 33);
            this.cbbHocKy.Text = "Học kỳ";
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTheLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTheLoai.Items.AddRange(new object[] {
            "Game\t",
            "Kinh tế",
            "Giải trí"});
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(121, 33);
            this.cbbTheLoai.Text = "Thể loại";
            // 
            // gvDeTai
            // 
            this.gvDeTai.AllowUserToAddRows = false;
            this.gvDeTai.AllowUserToDeleteRows = false;
            this.gvDeTai.AllowUserToResizeColumns = false;
            this.gvDeTai.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDeTai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.gvDeTai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDeTai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.gvDeTai.ColumnHeadersHeight = 25;
            this.gvDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSua,
            this.ColXoa});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDeTai.DefaultCellStyle = dataGridViewCellStyle38;
            this.gvDeTai.EnableHeadersVisualStyles = true;
            this.gvDeTai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvDeTai.Location = new System.Drawing.Point(21, 171);
            this.gvDeTai.Name = "gvDeTai";
            this.gvDeTai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDeTai.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.gvDeTai.RowHeadersVisible = false;
            this.gvDeTai.RowHeadersWidth = 62;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(208)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black;
            this.gvDeTai.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.gvDeTai.RowTemplate.Height = 28;
            this.gvDeTai.Size = new System.Drawing.Size(1396, 671);
            this.gvDeTai.TabIndex = 26;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvDeTai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvDeTai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvDeTai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvDeTai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvDeTai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvDeTai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDeTai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvDeTai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvDeTai.ThemeStyle.HeaderStyle.Height = 25;
            this.gvDeTai.ThemeStyle.ReadOnly = false;
            this.gvDeTai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvDeTai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvDeTai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDeTai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvDeTai.ThemeStyle.RowsStyle.Height = 28;
            this.gvDeTai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvDeTai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvDeTai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDeTai_CellContentClick);
            // 
            // ColSua
            // 
            this.ColSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSua.HeaderText = "";
            this.ColSua.Image = ((System.Drawing.Image)(resources.GetObject("ColSua.Image")));
            this.ColSua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColSua.MinimumWidth = 30;
            this.ColSua.Name = "ColSua";
            this.ColSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSua.Width = 30;
            // 
            // ColXoa
            // 
            this.ColXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColXoa.HeaderText = "";
            this.ColXoa.Image = ((System.Drawing.Image)(resources.GetObject("ColXoa.Image")));
            this.ColXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColXoa.MinimumWidth = 30;
            this.ColXoa.Name = "ColXoa";
            this.ColXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColXoa.Width = 30;
            // 
            // FGiangVien_ThesisTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 950);
            this.Controls.Add(this.gvDeTai);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FGiangVien_ThesisTopics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGiangVien_ThesisTopics";
            this.Load += new System.EventHandler(this.FGiangVien_ThesisTopics_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongThanhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeuCauDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label label9;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripComboBox cbbKhoa;
        public System.Windows.Forms.ToolStripComboBox cbbNganh;
        public System.Windows.Forms.ToolStripComboBox cbbNamHoc;
        public System.Windows.Forms.ToolStripComboBox cbbHocKy;
        public Guna.UI2.WinForms.Guna2DataGridView gvDeTai;
        public System.Windows.Forms.ToolStripComboBox cbbTheLoai;
        public System.Windows.Forms.DataGridViewImageColumn ColSua;
        public System.Windows.Forms.DataGridViewImageColumn ColXoa;
    }
}