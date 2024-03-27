using Bunifu.UI.WinForms.Helpers.Transitions;
using Guna.UI2.WinForms;
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

namespace Winform_Project
{
    public partial class Form1 : Form
    {
        ucItems uc;
        int flag = 0;
        string[] paths = { "\\CÁC KHOA\\CLC.png", "\\CÁC KHOA\\CKĐ.png", "\\CÁC KHOA\\CƠ KHÍ MÁY.png", "\\CÁC KHOA\\CÔNG NGHỆ THÔNG TIN.png", "\\CÁC KHOA\\DIEN - DIEN TU.png", "\\CÁC KHOA\\ĐTQT.png", "\\CÁC KHOA\\HÓA THỰC PHẨM.png", "\\CÁC KHOA\\KHOA HỌC ỨNG DỤNG.png", "\\CÁC KHOA\\Kinh tế.png", "\\CÁC KHOA\\LOGO Khoa In.png", "\\CÁC KHOA\\Logo Thời trang và Du lịch.png", "\\CÁC KHOA\\NGOẠI NGỮ.png", "\\CÁC KHOA\\XÂY DỰNG.png" };
        string[] ten = { "Chất lượng cao", "Cơ khí điện", "Cơ khí máy", "Công nghệ thông tin", "Điện-Điện tử", "Đào tạo quốc tế", "Hóa thực phẩm", "Khoa học ứng dụng", "Kinh tế", "Khoa in", "Khoa Du lịch và thời trang", "Ngoại ngữ", "Xây dựng" };
        public Form1()
        {
            InitializeComponent();
            uc = this.ucItems1;

            uc.picBgk.Click += LoadDataKhoa;

        }

      
        private void LoadDataKhoa(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            
            if (flag == 0)
            {
               
                List<Class1> nganh = new List<Class1>();
                for (int i = 0; i<paths.Length; i++)
                {
                    Class1 nganh_test = new Class1(ten[i], paths[i]);
                    nganh.Add(nganh_test);
                }
                
                int pos_current_X = -100;
                int pos_current_Y = -0;
                int pos_next_X = 0;   
                int pos_next_Y = 0;   
                foreach (Class1 j in nganh)
                {
                    ucItems uc = new ucItems(j);
                    pos_current_X += 100;
                    uc.Location = new Point(pos_current_X, pos_current_Y);
                    uc.picBgk.Click += LoadDataKhoa;
                    btnQuayVe.Visible = false;
                    flowLayoutPanel1.Controls.Add(uc);
                    
                }
                flag = 1;

            }
            else
            {

                List<Class1> nganh = new List<Class1>();
                for (int i = 0; i < paths.Length; i++)
                {
                    Class1 nganh_test = new Class1(ten[i], paths[i]);
                    nganh.Add(nganh_test);
                }
                int pos_current_X = -100;
                int pos_current_Y = 0;
                foreach (Class1 j in nganh)
                {
                    ucItems uc = new ucItems(j);
                    btnQuayVe.Visible = true;
                    pos_current_X += 100; 
                    uc.Location = new Point(pos_current_X, pos_current_Y);
                    flowLayoutPanel1.Controls.Add(uc);
                }
                flag = 0;
            }
            Guna2PictureBox gnpck = sender as Guna2PictureBox;
            if (gnpck != null)
            {
                lblPath.Text = gnpck.Tag.ToString() + "/Moi ban chon nganh";
            }

        }
       
        private void ucItems1_Load(object sender, EventArgs e)
        {
           
        }

        private void ucItems1_Load_1(object sender, EventArgs e)
        {

        }

        private void ucItems1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flag = 0;
            lblPath.Text = "Moi ban chon khoa";
            LoadDataKhoa(sender,e);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
