using Bunifu.UI.WinForms.Helpers.Transitions;
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

namespace Winform_Project
{
    public partial class FGiangVien : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        GiangVien giangVienAccount = FDangNhap.giangVienAccount;
        Dictionary<string,string> tmp = new Dictionary<string, string>();
        string khoa, nganh, hocKy, tenGV;

        public FGiangVien()
        {
            InitializeComponent();
            lblChucVu.Text = "Giang vien";
            lblTenGiangVien.Text = giangVienAccount.Ten;
        }
        private void HienThi(object sender,  EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            ucDeTai uc = btn.Parent as ucDeTai;
            FGiangVien_Thesis_Edit fGiangVien_Thesis_Edit = new FGiangVien_Thesis_Edit(uc.lv);
            fGiangVien_Thesis_Edit.ShowDialog();
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
            container(new FGiangVien_ThesisTopics_Main());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            

        }



       

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            DataTable dt = gvDao.LoadData($"SELECT * FROM GiangVien WHERE HoTen = '{lblTenGiangVien.Text}'");
            DateTime date = DateTime.Now;
            
            if (dt.Rows.Count > 0)
            {
                GiangVien giangVien = new GiangVien(dt.Rows[0]["HoTen"].ToString(),
                                                dt.Rows[0]["GioiTinh"].ToString(),
                                                date,
                                                dt.Rows[0]["SDT"].ToString(),
                                                dt.Rows[0]["Email"].ToString(),
                                                dt.Rows[0]["Facebook"].ToString());
                container(new FGiangVien_Login(giangVien));
            }

        }

        private void btnThemDeTai_Click(object sender, EventArgs e)
        {
            container(new FGiangVien_ThesisTopics_Main());

        }

        

        private void btnTienDo_Click(object sender, EventArgs e)
        {
            container(new FGiangVien_Progress());

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            container(new FGiangVien_Notify());
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FGiangVien_ThesisTopics_1 fGiangVien_ThesisTopics_1 = new FGiangVien_ThesisTopics_1();
            fGiangVien_ThesisTopics_1.ShowDialog(); 
        }
        private void CapNhatCBB()
        {
            tmp["Khoa"] = khoa;
            tmp["Nganh"] = nganh;
            tmp["HocKy"] = hocKy;
            
        }
        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            khoa = cbbKhoa.Text;
            CapNhatCBB();
            
            foreach(ucDeTai uc in fLoTrungTam.Controls)
            {
                uc.Visible = true;
                if(cbbKhoa.Text != uc.lv.Khoa)
                {
                    uc.Visible = false;
                }
            }
        }
        private void movePicChonBtn(object sender)
        {
            Guna2Button btn = sender as Guna2Button;
            picChonBtn.Location = new Point(btn.Location.X + 30, btn.Location.Y );
            picChonBtn.SendToBack();
        }
        private void btnThongTinCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            movePicChonBtn(sender);
        }
        

        private void fLoTrungTam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            nganh = cbbNganh.Text;
            CapNhatCBB();
           
            foreach (ucDeTai uc in fLoTrungTam.Controls)
            {
                uc.Visible = true;
                if (cbbNganh.Text != uc.lv.Nganh)
                {
                    uc.Visible = false;
                }
            }
        }

        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocKy = cbbHocKy.Text;
            CapNhatCBB();

            foreach (ucDeTai uc in fLoTrungTam.Controls)
            {
                uc.Visible = true;
                if (cbbHocKy.Text.ToLower() != uc.lv.HocKy.ToLower())
                {
                    uc.Visible = false;
                }
            }
        }
    }
}
