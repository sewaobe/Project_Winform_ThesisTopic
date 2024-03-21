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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTrangThaiDeTai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deTaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fGiangVienThesisAcceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbbKhoa = new System.Windows.Forms.ToolStripComboBox();
            this.cbbNganh = new System.Windows.Forms.ToolStripComboBox();
            this.cbbNamHoc = new System.Windows.Forms.ToolStripComboBox();
            this.cbbHocKy = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGiangVienThesisAcceptBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrangThaiDeTai});
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1232, 705);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colTrangThaiDeTai
            // 
            this.colTrangThaiDeTai.HeaderText = "TrangThaiDeTai";
            this.colTrangThaiDeTai.Items.AddRange(new object[] {
            "Đã duyệt",
            "Chưa duyệt"});
            this.colTrangThaiDeTai.MinimumWidth = 8;
            this.colTrangThaiDeTai.Name = "colTrangThaiDeTai";
            this.colTrangThaiDeTai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrangThaiDeTai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deTaiBindingSource1
            // 
            this.deTaiBindingSource1.DataMember = "DeTai\r\n";
            // 
            // deTaiBindingSource
            // 
            this.deTaiBindingSource.DataMember = "DeTai\r\n";
            // 
            // fGiangVienThesisAcceptBindingSource
            // 
            this.fGiangVienThesisAcceptBindingSource.DataSource = typeof(Winform_Project.FormGiangVien.FGiangVien_Thesis_Accept);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1232, 37);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
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
            this.cbbNganh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
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
            this.cbbNamHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
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
            this.cbbHocKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.cbbHocKy.ForeColor = System.Drawing.Color.Black;
            this.cbbHocKy.Items.AddRange(new object[] {
            "Kỳ 1",
            "Kỳ 2",
            "Kỳ 3"});
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(121, 33);
            this.cbbHocKy.Text = "Học kỳ";
            // 
            // FGiangVien_Thesis_Accept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1232, 769);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGiangVien_Thesis_Accept";
            this.Text = "FGiangVien_Thesis_Accept";
            this.Load += new System.EventHandler(this.FGiangVien_Thesis_Accept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGiangVienThesisAcceptBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fGiangVienThesisAcceptBindingSource;
        private System.Windows.Forms.BindingSource deTaiBindingSource;
        private System.Windows.Forms.BindingSource deTaiBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhómThucHienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTrangThaiDeTai;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox cbbKhoa;
        private System.Windows.Forms.ToolStripComboBox cbbNganh;
        private System.Windows.Forms.ToolStripComboBox cbbNamHoc;
        private System.Windows.Forms.ToolStripComboBox cbbHocKy;
    }
}