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

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_login : Form
    {
        SinhVienn SinhVienAccount = FDangNhap.SinhVienAccount;
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

        private void FSinhVien_login_Load(object sender, EventArgs e)
        {
            txtMSSV.Text = SinhVienAccount.MSSV;
            txtTen.Text = SinhVienAccount.HoTen;
            cbbGioiTinh.Text = SinhVienAccount.GioiTinh;
            DTPngaysinh.Value = Convert.ToDateTime(SinhVienAccount.NgaySinh);
            txtSDT.Text = SinhVienAccount.SDT;
            txtEmail.Text = "không có";
            cbbKhoa.Text = SinhVienAccount.Khoa;
            cbbNganh.Text = SinhVienAccount.Nganh;
        }
    }
}
