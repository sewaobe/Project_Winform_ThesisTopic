using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDoiTuong;

namespace Winform_Project
{
    public partial class uc_TinNhan : UserControl
    {
        public TinNhan tinNhan;
        public uc_TinNhan()
        {
            InitializeComponent();
        }
        public uc_TinNhan(TinNhan tn)
        {
            InitializeComponent();  
            lblNoiDung.Text = tn.Noidung;
            lblThoiGianGui.Text = tn.Thoigiangui.ToShortTimeString();
            setHeight();
            this.tinNhan = tn;
        }
        
        void setHeight()
        {
            Size maxSize = new Size(620, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(lblNoiDung.Text, lblNoiDung.Font, lblNoiDung.Width);
            lblNoiDung.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            lblThoiGianGui.Top = lblNoiDung.Bottom + 10;
            
            this.Height = lblThoiGianGui.Bottom + 10;
            
        }

            private void uc_TinNhan_Resize(object sender, EventArgs e)
        {
            setHeight();
        }
    }
}
