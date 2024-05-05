using Guna.UI2.WinForms;
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
using Winform_Project.FormGiangVien;
using Winform_Project.FormSinhVien;

namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien : Form
    {
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();
        public static Guna2Panel panelTrungTam;
        public FSinhVien()
        {
            InitializeComponent();
            lblTen.Text = SinhVienAccount.Ten;
            lblMSSV.Text = SinhVienAccount.Mssv;
            if (svDao.kiemtraTrangThai(SinhVienAccount) == true)
            {
                btnLienHe.Enabled=true;
                btnThongBao.Enabled=true;
                btnTienDo.Enabled=true;
                btnDangKyDeTai.Enabled=false;
                btnTienDo.Checked = true;
                movePicChonBtn(btnTienDo);
                container(new FSinhVien_Controls());

            }
            else
            {
                btnLienHe.Enabled = false;
                btnThongBao.Enabled = false;
                btnTienDo.Enabled = false;
                btnDangKyDeTai.Enabled = true;
                container(new FSinhVien_Reg());
            }
            panelTrungTam = guna2Panel_container;
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

      

       


       
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FDangNhap f1 = new FDangNhap();
            this.Hide();
            f1.ShowDialog();
        }

        //private void btnNhiemVu_Click(object sender, EventArgs e)
        //{
        //    container(new Form2());
        //}


        private void FSinhVien_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQuanLyDeTai_Click(object sender, EventArgs e)
        {
            container(new FSinhVien_Accepted());
        }

        private void btnThongTinCaNhan_Click_1(object sender, EventArgs e)
        {
            container(new FSinhVien_login());

        }

        private void btnDangKyDeTai_Click_1(object sender, EventArgs e)
        {
            container(new FSinhVien_Reg());

        }

        private void btnTienDo_Click_1(object sender, EventArgs e)
        {
            FSinhVien_Controls form1 = new FSinhVien_Controls();
            container(form1);
        }

        private void btnThongBao_Click_1(object sender, EventArgs e)
        {
            container(new FSinhVien_Support());

        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            container(new FSinhVien_ContactGV());

        }
        private void movePicChonBtn(object sender)
        {
            Guna2Button btn = sender as Guna2Button;
            picChonBtn.Location = new Point(btn.Location.X + 30, btn.Location.Y);
            picChonBtn.SendToBack();
        }

        private void btnThongTinCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            movePicChonBtn(sender);
        }

        
    }
}
