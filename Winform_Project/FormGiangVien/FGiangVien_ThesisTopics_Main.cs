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
using Winform_Project.EntityModel;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_ThesisTopics_Main : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        Dictionary<string, string> tmp = new Dictionary<string, string>();
        string khoa, nganh, hocKy;
        public FGiangVien_ThesisTopics_Main()
        {
            InitializeComponent();
        }

       
       
        

        private void FGiangVien_ThesisTopics_Main_Load(object sender, EventArgs e)
        {
            /*gvDeTai.DataSource = gvDao.LoadData("SELECT * From ThongTinDeTai");
            Instance_GridView();*/
            DataTable dtDeTai = conNguoiDao.LayThongTinTatCaDeTai();
            List<ThongTinDeTaii> lv_list = gvDao.ChuyenDoiDuLieuSangLuanVan(dtDeTai);
            int pos_current_X = -100;
            int pos_current_Y = 0;
            foreach (ThongTinDeTaii lv in lv_list)
            {
                ucDeTai uc = new ucDeTai(lv);
                uc.Location = new Point(pos_current_X, pos_current_Y);
                uc.btnChiTiet.Click += HienThi;
                fLoTrungTam.Controls.Add(uc);
            }
        }
        private void HienThi(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            ucDeTai uc = btn.Parent as ucDeTai;
            FGiangVien_Thesis_Edit fGiangVien_Thesis_Edit = new FGiangVien_Thesis_Edit(uc.lv);
            fGiangVien_Thesis_Edit.ShowDialog();
        }
        private void btnQuanLiDeTai_Click(object sender, EventArgs e)
        {
           /* txtTimKiem.Visible = !txtTimKiem.Visible;
            gvDeTai.Visible = !gvDeTai.Visible;*/
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

            foreach (ucDeTai uc in fLoTrungTam.Controls)
            {
                uc.Visible = true;
                if (cbbKhoa.Text != uc.lv.Khoa)
                {
                    uc.Visible = false;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FGiangVien_ThesisTopics_1 fGiangVien_ThesisTopics_1 = new FGiangVien_ThesisTopics_1();
            fGiangVien_ThesisTopics_1.ShowDialog();
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
