namespace Winform_Project.FormGiangVien
{
    partial class FGiangVien_ThesisTopics_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGiangVien_ThesisTopics_Main));
            this.btnTaoDeTai = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLiDeTai = new Guna.UI2.WinForms.Guna2Button();
            this.gvDeTai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeTai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoDeTai
            // 
            this.btnTaoDeTai.AutoRoundedCorners = true;
            this.btnTaoDeTai.BorderRadius = 29;
            this.btnTaoDeTai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoDeTai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoDeTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoDeTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoDeTai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(208)))), ((int)(((byte)(194)))));
            this.btnTaoDeTai.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDeTai.ForeColor = System.Drawing.Color.Black;
            this.btnTaoDeTai.Location = new System.Drawing.Point(107, 39);
            this.btnTaoDeTai.Name = "btnTaoDeTai";
            this.btnTaoDeTai.Size = new System.Drawing.Size(1152, 61);
            this.btnTaoDeTai.TabIndex = 0;
            this.btnTaoDeTai.Text = "Tạo đề tài";
            this.btnTaoDeTai.Click += new System.EventHandler(this.btnTaoDeTai_Click);
            // 
            // btnQuanLiDeTai
            // 
            this.btnQuanLiDeTai.AutoRoundedCorners = true;
            this.btnQuanLiDeTai.BorderRadius = 29;
            this.btnQuanLiDeTai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLiDeTai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLiDeTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLiDeTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLiDeTai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(208)))), ((int)(((byte)(194)))));
            this.btnQuanLiDeTai.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLiDeTai.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLiDeTai.Location = new System.Drawing.Point(107, 126);
            this.btnQuanLiDeTai.Name = "btnQuanLiDeTai";
            this.btnQuanLiDeTai.Size = new System.Drawing.Size(1152, 61);
            this.btnQuanLiDeTai.TabIndex = 1;
            this.btnQuanLiDeTai.Text = "Quản lí đề tài";
            this.btnQuanLiDeTai.Click += new System.EventHandler(this.btnQuanLiDeTai_Click);
            // 
            // gvDeTai
            // 
            this.gvDeTai.AllowUserToAddRows = false;
            this.gvDeTai.AllowUserToDeleteRows = false;
            this.gvDeTai.AllowUserToResizeColumns = false;
            this.gvDeTai.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDeTai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gvDeTai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.gvDeTai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDeTai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvDeTai.ColumnHeadersHeight = 25;
            this.gvDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSua,
            this.ColXoa});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDeTai.DefaultCellStyle = dataGridViewCellStyle13;
            this.gvDeTai.EnableHeadersVisualStyles = true;
            this.gvDeTai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvDeTai.Location = new System.Drawing.Point(25, 272);
            this.gvDeTai.Name = "gvDeTai";
            this.gvDeTai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDeTai.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gvDeTai.RowHeadersVisible = false;
            this.gvDeTai.RowHeadersWidth = 62;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(208)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.gvDeTai.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gvDeTai.RowTemplate.Height = 28;
            this.gvDeTai.Size = new System.Drawing.Size(1344, 610);
            this.gvDeTai.TabIndex = 27;
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
            this.gvDeTai.Visible = false;
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
            this.txtTimKiem.Location = new System.Drawing.Point(1044, 210);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "           Tìm kiếm đề tài";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(286, 42);
            this.txtTimKiem.TabIndex = 29;
            this.txtTimKiem.Visible = false;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // FGiangVien_ThesisTopics_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 894);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gvDeTai);
            this.Controls.Add(this.btnQuanLiDeTai);
            this.Controls.Add(this.btnTaoDeTai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGiangVien_ThesisTopics_Main";
            this.Text = "FGiangVien_ThesisTopics_Main";
            this.Load += new System.EventHandler(this.FGiangVien_ThesisTopics_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDeTai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTaoDeTai;
        private Guna.UI2.WinForms.Guna2Button btnQuanLiDeTai;
        public Guna.UI2.WinForms.Guna2DataGridView gvDeTai;
        public System.Windows.Forms.DataGridViewImageColumn ColSua;
        public System.Windows.Forms.DataGridViewImageColumn ColXoa;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}