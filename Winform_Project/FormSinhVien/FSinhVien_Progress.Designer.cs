namespace Winform_Project.FSinhVien
{
    partial class FSinhVien_Progress
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSinhVien_Progress));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.lblBaoCao = new System.Windows.Forms.Label();
            this.chartTienDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBarTienDo = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.btnXemNhanXet = new Guna.UI2.WinForms.Guna2Button();
            this.txtFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemFile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTienDo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnGui
            // 
            this.btnGui.AutoRoundedCorners = true;
            this.btnGui.BorderRadius = 16;
            this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(698, 165);
            this.btnGui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(111, 34);
            this.btnGui.TabIndex = 17;
            this.btnGui.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // lblBaoCao
            // 
            this.lblBaoCao.AutoSize = true;
            this.lblBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCao.Location = new System.Drawing.Point(389, 171);
            this.lblBaoCao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaoCao.Name = "lblBaoCao";
            this.lblBaoCao.Size = new System.Drawing.Size(92, 24);
            this.lblBaoCao.TabIndex = 11;
            this.lblBaoCao.Text = "Báo cáo:";
            // 
            // chartTienDo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTienDo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTienDo.Legends.Add(legend1);
            this.chartTienDo.Location = new System.Drawing.Point(32, 227);
            this.chartTienDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartTienDo.Name = "chartTienDo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTienDo.Series.Add(series1);
            this.chartTienDo.Size = new System.Drawing.Size(409, 214);
            this.chartTienDo.TabIndex = 10;
            this.chartTienDo.Text = "chart1";
            // 
            // progressBarTienDo
            // 
            this.progressBarTienDo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressBarTienDo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressBarTienDo.ForeColor = System.Drawing.Color.Black;
            this.progressBarTienDo.Location = new System.Drawing.Point(115, 58);
            this.progressBarTienDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarTienDo.Minimum = 0;
            this.progressBarTienDo.Name = "progressBarTienDo";
            this.progressBarTienDo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBarTienDo.Size = new System.Drawing.Size(105, 105);
            this.progressBarTienDo.TabIndex = 9;
            this.progressBarTienDo.Text = "guna2CircleProgressBar1";
            this.progressBarTienDo.Value = 10;
            // 
            // btnXemNhanXet
            // 
            this.btnXemNhanXet.AutoRoundedCorners = true;
            this.btnXemNhanXet.BorderRadius = 16;
            this.btnXemNhanXet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemNhanXet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemNhanXet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemNhanXet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemNhanXet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemNhanXet.ForeColor = System.Drawing.Color.White;
            this.btnXemNhanXet.Location = new System.Drawing.Point(664, 272);
            this.btnXemNhanXet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemNhanXet.Name = "btnXemNhanXet";
            this.btnXemNhanXet.Size = new System.Drawing.Size(111, 34);
            this.btnXemNhanXet.TabIndex = 18;
            this.btnXemNhanXet.Text = "Xem nhận xét";
            this.btnXemNhanXet.Click += new System.EventHandler(this.btnXemNhanXet_Click);
            // 
            // txtFile
            // 
            this.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFile.DefaultText = "";
            this.txtFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFile.Location = new System.Drawing.Point(483, 160);
            this.txtFile.Name = "txtFile";
            this.txtFile.PasswordChar = '\0';
            this.txtFile.PlaceholderText = "Thêm file.doc";
            this.txtFile.SelectedText = "";
            this.txtFile.Size = new System.Drawing.Size(191, 39);
            this.txtFile.TabIndex = 19;
            // 
            // btnThemFile
            // 
            this.btnThemFile.AutoRoundedCorners = true;
            this.btnThemFile.BackColor = System.Drawing.Color.White;
            this.btnThemFile.BorderRadius = 18;
            this.btnThemFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemFile.FillColor = System.Drawing.Color.White;
            this.btnThemFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemFile.ForeColor = System.Drawing.Color.White;
            this.btnThemFile.Image = ((System.Drawing.Image)(resources.GetObject("btnThemFile.Image")));
            this.btnThemFile.Location = new System.Drawing.Point(631, 160);
            this.btnThemFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemFile.Name = "btnThemFile";
            this.btnThemFile.Size = new System.Drawing.Size(43, 39);
            this.btnThemFile.TabIndex = 20;
            this.btnThemFile.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "BaoCaoLan1",
            "BaoCaoLan2",
            "BaoCaoLan3"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(483, 272);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox1.TabIndex = 21;
            // 
            // FSinhVien_Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 500);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.btnThemFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnXemNhanXet);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.lblBaoCao);
            this.Controls.Add(this.chartTienDo);
            this.Controls.Add(this.progressBarTienDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FSinhVien_Progress";
            this.Text = "FSinhVien_Progress";
            this.Load += new System.EventHandler(this.FSinhVien_Progress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTienDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private System.Windows.Forms.Label lblBaoCao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTienDo;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBarTienDo;
        private Guna.UI2.WinForms.Guna2Button btnXemNhanXet;
        private Guna.UI2.WinForms.Guna2TextBox txtFile;
        private Guna.UI2.WinForms.Guna2Button btnThemFile;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}