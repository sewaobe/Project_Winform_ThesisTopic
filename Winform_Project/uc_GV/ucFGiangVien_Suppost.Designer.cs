﻿namespace Winform_Project
{
    partial class ucFGiangVien_Suppost
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
            this.components = new System.ComponentModel.Container();
            this.btnTaoDeTai = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.deTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioTatCa = new System.Windows.Forms.RadioButton();
            this.radioQuaHan = new System.Windows.Forms.RadioButton();
            this.radioHoanThanh = new System.Windows.Forms.RadioButton();
            this.radioThucHien = new System.Windows.Forms.RadioButton();
            this.fLoTrungTam = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
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
            this.btnTaoDeTai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.btnTaoDeTai.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDeTai.ForeColor = System.Drawing.Color.Black;
            this.btnTaoDeTai.Location = new System.Drawing.Point(283, 542);
            this.btnTaoDeTai.Name = "btnTaoDeTai";
            this.btnTaoDeTai.Size = new System.Drawing.Size(790, 61);
            this.btnTaoDeTai.TabIndex = 38;
            this.btnTaoDeTai.Text = "Giao nhiệm vụ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(171, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Mời bạn nhập thông tin liên quan tới nhiệm vụ";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(640, 43);
            this.txtTimKiem.TabIndex = 37;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(17, 32);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(145, 32);
            this.lblTimKiem.TabIndex = 36;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // deTaiBindingSource
            // 
            this.deTaiBindingSource.DataMember = "DeTai\r\n";
            // 
            // radioTatCa
            // 
            this.radioTatCa.AutoSize = true;
            this.radioTatCa.Location = new System.Drawing.Point(1245, 52);
            this.radioTatCa.Name = "radioTatCa";
            this.radioTatCa.Size = new System.Drawing.Size(78, 24);
            this.radioTatCa.TabIndex = 43;
            this.radioTatCa.TabStop = true;
            this.radioTatCa.Text = "Tất cả";
            this.radioTatCa.UseVisualStyleBackColor = true;
            // 
            // radioQuaHan
            // 
            this.radioQuaHan.AutoSize = true;
            this.radioQuaHan.Location = new System.Drawing.Point(1245, 12);
            this.radioQuaHan.Name = "radioQuaHan";
            this.radioQuaHan.Size = new System.Drawing.Size(117, 24);
            this.radioQuaHan.TabIndex = 42;
            this.radioQuaHan.TabStop = true;
            this.radioQuaHan.Text = "Đã quá hạn";
            this.radioQuaHan.UseVisualStyleBackColor = true;
            // 
            // radioHoanThanh
            // 
            this.radioHoanThanh.AutoSize = true;
            this.radioHoanThanh.Location = new System.Drawing.Point(1065, 52);
            this.radioHoanThanh.Name = "radioHoanThanh";
            this.radioHoanThanh.Size = new System.Drawing.Size(140, 24);
            this.radioHoanThanh.TabIndex = 41;
            this.radioHoanThanh.TabStop = true;
            this.radioHoanThanh.Text = "Đã hoàn thành";
            this.radioHoanThanh.UseVisualStyleBackColor = true;
            // 
            // radioThucHien
            // 
            this.radioThucHien.AutoSize = true;
            this.radioThucHien.Location = new System.Drawing.Point(1065, 12);
            this.radioThucHien.Name = "radioThucHien";
            this.radioThucHien.Size = new System.Drawing.Size(142, 24);
            this.radioThucHien.TabIndex = 40;
            this.radioThucHien.TabStop = true;
            this.radioThucHien.Text = "Đang thực hiện";
            this.radioThucHien.UseVisualStyleBackColor = true;
            // 
            // fLoTrungTam
            // 
            this.fLoTrungTam.AutoScroll = true;
            this.fLoTrungTam.Location = new System.Drawing.Point(127, 101);
            this.fLoTrungTam.Margin = new System.Windows.Forms.Padding(0);
            this.fLoTrungTam.Name = "fLoTrungTam";
            this.fLoTrungTam.Size = new System.Drawing.Size(1120, 419);
            this.fLoTrungTam.TabIndex = 39;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.FillColor = System.Drawing.Color.Green;
            this.guna2Panel1.Location = new System.Drawing.Point(121, 92);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1130, 3);
            this.guna2Panel1.TabIndex = 44;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.FillColor = System.Drawing.Color.Green;
            this.guna2Panel3.Location = new System.Drawing.Point(1117, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(3, 419);
            this.guna2Panel3.TabIndex = 46;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.FillColor = System.Drawing.Color.Green;
            this.guna2Panel2.Location = new System.Drawing.Point(121, 92);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(3, 435);
            this.guna2Panel2.TabIndex = 45;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.FillColor = System.Drawing.Color.Green;
            this.guna2Panel4.Location = new System.Drawing.Point(121, 525);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1130, 3);
            this.guna2Panel4.TabIndex = 47;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.FillColor = System.Drawing.Color.Green;
            this.guna2Panel5.Location = new System.Drawing.Point(1117, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(3, 419);
            this.guna2Panel5.TabIndex = 46;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.FillColor = System.Drawing.Color.Green;
            this.guna2Panel6.Location = new System.Drawing.Point(1250, 93);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(3, 435);
            this.guna2Panel6.TabIndex = 46;
            // 
            // ucFGiangVien_Suppost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fLoTrungTam);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnTaoDeTai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.radioTatCa);
            this.Controls.Add(this.radioQuaHan);
            this.Controls.Add(this.radioHoanThanh);
            this.Controls.Add(this.radioThucHien);
            this.Name = "ucFGiangVien_Suppost";
            this.Size = new System.Drawing.Size(1378, 615);
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnTaoDeTai;
        public Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        public System.Windows.Forms.Label lblTimKiem;
        public System.Windows.Forms.BindingSource deTaiBindingSource;
        public System.Windows.Forms.RadioButton radioTatCa;
        public System.Windows.Forms.RadioButton radioQuaHan;
        public System.Windows.Forms.RadioButton radioHoanThanh;
        public System.Windows.Forms.RadioButton radioThucHien;
        public System.Windows.Forms.FlowLayoutPanel fLoTrungTam;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
    }
}
