namespace Winform_Project
{
    partial class uc_Toast_Notice
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
            this.lbltieuDe = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.panelBorder = new System.Windows.Forms.Panel();
            this.picType = new System.Windows.Forms.PictureBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltieuDe
            // 
            this.lbltieuDe.AutoSize = true;
            this.lbltieuDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieuDe.Location = new System.Drawing.Point(78, 60);
            this.lbltieuDe.Name = "lbltieuDe";
            this.lbltieuDe.Size = new System.Drawing.Size(59, 25);
            this.lbltieuDe.TabIndex = 0;
            this.lbltieuDe.Text = "label1";
            // 
            // timerClose
            // 
            this.timerClose.Enabled = true;
            this.timerClose.Interval = 10;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(11, 100);
            this.panelBorder.TabIndex = 1;
            // 
            // picType
            // 
            this.picType.Image = global::Winform_Project.Properties.Resources.accept;
            this.picType.Location = new System.Drawing.Point(17, 33);
            this.picType.Name = "picType";
            this.picType.Size = new System.Drawing.Size(40, 43);
            this.picType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picType.TabIndex = 2;
            this.picType.TabStop = false;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(77, 15);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(70, 28);
            this.lblTheLoai.TabIndex = 3;
            this.lblTheLoai.Text = "label1";
            // 
            // timerHide
            // 
            this.timerHide.Interval = 10;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // uc_Toast_Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 100);
            this.Controls.Add(this.lblTheLoai);
            this.Controls.Add(this.picType);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.lbltieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uc_Toast_Notice";
            this.Load += new System.EventHandler(this.uc_Toast_Notice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltieuDe;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Timer timerHide;
    }
}
