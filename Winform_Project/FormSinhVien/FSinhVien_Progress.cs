using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Winform_Project.FormSinhVien;

namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien_Progress : Form
    {
        public FSinhVien_Progress()
        {
            InitializeComponent();
        }
        bool expand1 = false;
        bool expand2 = false;   
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if(expand1 == false)
            {
                flowLayoutPanel1.Height += 15;
                if(flowLayoutPanel1.Height >= flowLayoutPanel1.MaximumSize.Height)
                {
                    flowLayoutPanel2.Location = new Point(flowLayoutPanel2.Location.X, flowLayoutPanel1.MaximumSize.Height);
                    timer1.Stop();
                    expand1 = true;
                }
            }
            else
            {
                flowLayoutPanel1.Height -= 15;
                if(flowLayoutPanel1.Height<= flowLayoutPanel1.MinimumSize.Height) 
                {
                    flowLayoutPanel2.Location = new Point(flowLayoutPanel2.Location.X, flowLayoutPanel1.MinimumSize.Height);
                    timer1.Stop();
                    expand1 = false;
                }
            }*/
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }


        private void FSinhVien_Progress_Load(object sender, EventArgs e)
        {

        }
       
    

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            object fileName = "";
            object filePath = "";
            if(open.ShowDialog()==DialogResult.OK)
            {
                fileName = open.SafeFileName;
                filePath = open.FileName;
            }
            txtFile.Text = fileName.ToString();
        }

        private void btnXemNhanXet_Click(object sender, EventArgs e)
        {
            FSinhVien_Progress_Check fsinhVien_Progress_Check = new FSinhVien_Progress_Check();
            fsinhVien_Progress_Check.ShowDialog();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {

        }
    }
}
