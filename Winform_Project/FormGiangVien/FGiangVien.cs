using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class FGiangVien : Form
    {
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void container(object form)
        {
            if(guna2Panel_container.Controls.Count > 0) { guna2Panel_container.Controls.Clear(); }
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

        private void guna2Panel_container_Paint(object sender, PaintEventArgs e)
        {

        }


        private void FGiangVien_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            container(new FGiangVien_ThesisTopics());

        }



       

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            container(new FGiangVien_Login());

        }

        private void btnThemDeTai_Click(object sender, EventArgs e)
        {
            container(new FGiangVien_ThesisTopics());

        }

        

        private void btnTienDo_Click(object sender, EventArgs e)
        {
            container(new FGiangVien_Progress());

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            container(new FGiangVien_SupportTopic());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FDangNhap f1 = new FDangNhap();
            this.Hide();
            f1.ShowDialog();
        }

        private void btnDuyetDeTai_Click(object sender, EventArgs e)
        {
            container(new FGiangVien_Thesis_Accept());
        }

        private void guna2ShadowForm1_Load(object sender, EventArgs e)
        {

        }

        private void lblTenGiangVien_Click(object sender, EventArgs e)
        {

        }
    }
}
