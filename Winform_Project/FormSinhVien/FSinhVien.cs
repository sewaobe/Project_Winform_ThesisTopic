using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;
using Winform_Project.FormSinhVien;

namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien : Form
    {
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();      
        public FSinhVien()
        {
            InitializeComponent();
            lblTen.Text = SinhVienAccount.Ten;
            lblMSSV.Text = SinhVienAccount.Mssv;
            container(new FSinhVien_Reg());
        }
        private void container(object form)
        {
            if (guna2Panel_container.Controls.Count > 0) { guna2Panel_container.Controls.Clear(); }
            try
            {
                Form fm = form as Form;
                fm.TopLevel = false;
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.Dock = DockStyle.Fill;
                guna2Panel_container.Controls.Add(fm);
                guna2Panel_container.Tag = fm;
                fm.Show();
            }
            catch
            {
                UserControl uc = form as UserControl;
                uc.Dock = DockStyle.Fill;
                guna2Panel_container.Controls.Clear();
                guna2Panel_container.Controls.Add(uc);
                uc.BringToFront();

            }
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            container(new FSinhVien_login());
        }

        private void btnDangKyDeTai_Click(object sender, EventArgs e)
        {
            container(new FSinhVien_Reg());
        }

        private void btnTienDo_Click(object sender, EventArgs e)
        {
            container(new FSinhVien_Progress());

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            container(new FSinhVien_Support());

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FDangNhap f1 = new FDangNhap();
            this.Hide();
            f1.ShowDialog();
        }

        private void btnLienHeGVHD_Click(object sender, EventArgs e)
        {
            container(new FSinhVien_ContactGV());
        }

        private void FSinhVien_Load(object sender, EventArgs e)
        {
            
        }

    }
}
