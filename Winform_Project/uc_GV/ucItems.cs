using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Project
{
    public partial class ucItems : UserControl
    {
        Nganh_Khoa j;
        public ucItems()
        {
            InitializeComponent();
        }

        public ucItems(Nganh_Khoa j)
        {
            InitializeComponent();

            this.j = j;
            Bitmap path = new Bitmap(Application.StartupPath + j.PathImg);
            picBgk.Image = path;
            picBgk.Tag = j.Ten;
            lblTen.Text = j.Ten;
            picBgk.MouseHover += Change_Color_Hover;
            picBgk.MouseLeave += Change_Color_Leave;
        }
        private void Change_Color_Hover(object sender, EventArgs e)
        {
            picBgk.BackColor = Color.FromArgb(0,0,0);
        }
        private void Change_Color_Leave(object sender, EventArgs e)
        {
            picBgk.BackColor = Color.White;
        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void ucItems_Load(object sender, EventArgs e)
        {
            
        }
    }
}
