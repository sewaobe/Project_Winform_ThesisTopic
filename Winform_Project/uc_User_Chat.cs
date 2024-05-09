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
    public partial class uc_User_Chat : UserControl
    {
        public uc_User_Chat()
        {
            InitializeComponent();
           
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(txtNoiDung.Text, txtNoiDung.Font);
            txtNoiDung.Width = size.Width + 17;
            txtNoiDung.Height = size.Height;
        }

        private void txtNoiDung_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
        }
    }
}
