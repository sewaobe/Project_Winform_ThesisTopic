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
    public partial class FSinhVien_login : Form
    {
        public FSinhVien_login()
        {
            InitializeComponent();
        }
        private void Change(bool val)
        {
            
            txtMSSV.Enabled = val;
            txtTen.Enabled = val;
            cbbGioiTinh.Enabled = val;
            DTPngaysinh.Enabled = val;
            txtSDT.Enabled = val;
            txtEmail.Enabled = val;
            cbbKhoa.Enabled = val;
            cbbNganh.Enabled = val;
            btnChinhsua.Visible = !val;
            btnLuu.Visible = val;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Change(false);
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            Change(true);

        }
    }
}
