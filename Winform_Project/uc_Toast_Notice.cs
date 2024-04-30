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
    public partial class uc_Toast_Notice : Form
    {
        int toastX, toastY;
        public uc_Toast_Notice(string tinNhan, string loai)
        {
            InitializeComponent();
            lbltieuDe.Text = tinNhan;
            lblTheLoai.Text = loai;
            switch (loai)
            {
                case "Thành công":
                    panelBorder.BackColor = Color.FromArgb(57, 155, 53);
                    picType.Image = Properties.Resources.accept;
                    break;
                case "Thất bại":
                    panelBorder.BackColor = Color.FromArgb(227, 50, 45);
                    picType.Image = Properties.Resources.remove;
                    break;
            }
        }

        private void uc_Toast_Notice_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            toastX -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastX <= 980)
            {
                timerClose.Stop();
                timerHide.Start();
            }
        }
        int x_close = 100;
        private void timerHide_Tick(object sender, EventArgs e)
        {
            x_close--;
            if(x_close <= 0)
            {
                toastX += 1;
                this.Location = new Point(toastX += 10, toastY);
                if(toastX > 1000)
                {
                    timerHide.Stop();
                    x_close = 100;
                    this.Hide();
                }
            }
        }

        private void Position()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width;
            toastX = x - this.Width ;
            int y = Screen.PrimaryScreen.WorkingArea.Height;
            toastY = y - this.Height - 600 ;
            this.Location = new Point(toastX, toastY);

        }
    }
}
