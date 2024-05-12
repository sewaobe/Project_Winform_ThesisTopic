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

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_Login : Form
    {
        public FGiangVien_Login()
        {
            InitializeComponent();
          
        }
        public FGiangVien_Login(GiangVienn gv)
        {
            InitializeComponent();

            txtTen.Text = gv.HoTen;
            cbbGioiTinh.Text = gv.GioiTinh;
            DTPngaySinh.Value = gv.NgaySinh.Value;
            txtSDT.Text = gv.SDT;
            txtEmail.Text = gv.Email;
            txtFace.Text = gv.FaceBook;

        }
        private void Change(bool val)
        {

            txtTen.Enabled = val;
            cbbGioiTinh.Enabled = val;
            DTPngaySinh.Enabled = val;
            txtSDT.Enabled = val;
            txtEmail.Enabled = val;
            txtFace.Enabled = val;  
            btnChinhsua.Visible = !val;
            btnLuu.Visible = val;
        }
        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            Change(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Change(false);
        }

        private void FGiangVien_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFace_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
