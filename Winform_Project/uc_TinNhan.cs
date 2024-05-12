using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.EntityModel;

namespace Winform_Project
{
    public partial class uc_TinNhan : UserControl
    {
        public Messengerr tinNhan;
        public uc_TinNhan()
        {
            InitializeComponent();
        }
        public uc_TinNhan(Messengerr tn)
        {
            InitializeComponent();  
            lblNoiDung.Text = tn.NoiDung;
            lblThoiGianGui.Text = tn.ThoiGianGui.ToShortTimeString();
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
