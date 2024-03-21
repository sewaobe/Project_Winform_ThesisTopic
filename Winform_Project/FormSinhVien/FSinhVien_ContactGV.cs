using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_ContactGV : Form
    {
        public FSinhVien_ContactGV()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbGVHD.Text == "Giảng Viên A")
            {
                txtEmail.Text = "GiangVienA@gmail.com";
                txtFace.Text = "Link Facebook";
                txtSDT.Text = "0912345678";
                txtZalo.Text = "Link Zalo";
            }
            else if (cbbGVHD.Text == "Giảng Viên B")
            {
                txtEmail.Text = "GiangVienB@gmail.com";
                txtFace.Text = "Link Facebook";
                txtSDT.Text = "0123456789";
                txtZalo.Text = "Link Zalo";
            }
        }
    }
}
