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

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_ThesisTopics_Main : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        Dictionary<string, string> tmp = new Dictionary<string, string>();
        string khoa, nganh, hocKy;
        public FGiangVien_ThesisTopics_Main()
        {
            InitializeComponent();
        }

        private void btnTaoDeTai_Click(object sender, EventArgs e)
        {
            FGiangVien_ThesisTopics_1 fgiangVien_ThesisTopics_1 = new FGiangVien_ThesisTopics_1();
            fgiangVien_ThesisTopics_1.ShowDialog();
        }
        private void Instance_GridView()
        {
          /*  gvDeTai.Columns["MaDeTai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gvDeTai.Columns["MaDeTai"].HeaderText = "Mã đề tài";
            gvDeTai.Columns["TenDeTai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gvDeTai.Columns["TenDeTai"].HeaderText = "Tên đề tài";
            gvDeTai.Columns["TheLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gvDeTai.Columns["TheLoai"].HeaderText = "Thể loại";
            gvDeTai.Columns["NgayBatDau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gvDeTai.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            gvDeTai.Columns["NgayKetThuc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gvDeTai.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
            gvDeTai.Columns["Khoa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            gvDeTai.Columns["Nganh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gvDeTai.Columns["MoTa"].Visible = false;
            gvDeTai.Columns["ChucNang"].Visible = false;
            gvDeTai.Columns["TenGiangVien"].Visible = false;
            gvDeTai.Columns["YeuCau"].Visible = false;
            gvDeTai.Columns["SoLuong"].Visible = false;*/
        }
        private void gvDeTai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string click = gvDeTai.Columns[e.ColumnIndex].Index.ToString();
            if (click == "0")
            {
                FGiangVien_Thesis_Edit fgiangVien_Thesis_Edit = new FGiangVien_Thesis_Edit();
                fgiangVien_Thesis_Edit.txtMaDeTai.Text = gvDeTai.Rows[e.RowIndex].Cells["MaDeTai"].Value.ToString();
                fgiangVien_Thesis_Edit.txtTen.Text = gvDeTai.Rows[e.RowIndex].Cells["TenDeTai"].Value.ToString();
                fgiangVien_Thesis_Edit.txtTheLoai.Text = gvDeTai.Rows[e.RowIndex].Cells["TheLoai"].Value.ToString();
                fgiangVien_Thesis_Edit.txtMoTa.Text = gvDeTai.Rows[e.RowIndex].Cells["MoTa"].Value.ToString();
                fgiangVien_Thesis_Edit.txtYeuCau.Text = gvDeTai.Rows[e.RowIndex].Cells["YeuCau"].Value.ToString();
                fgiangVien_Thesis_Edit.txtChucNang.Text = gvDeTai.Rows[e.RowIndex].Cells["ChucNang"].Value.ToString();
                fgiangVien_Thesis_Edit.txtSoLuong.Text = gvDeTai.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                fgiangVien_Thesis_Edit.cbbKhoa.Text = gvDeTai.Rows[e.RowIndex].Cells["Khoa"].Value.ToString();
                fgiangVien_Thesis_Edit.cbbNganh.Text = gvDeTai.Rows[e.RowIndex].Cells["Nganh"].Value.ToString();
                this.Hide();
                fgiangVien_Thesis_Edit.ShowDialog();
                this.Show();
            }
            else if (click == "1")
            {
                if (MessageBox.Show($"Bạn muốn xóa đề tài này?", "Xác minh xóa đề tài", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LuanVan lv = new LuanVan();
                    lv.MaDeTai = gvDeTai.Rows[e.RowIndex].Cells["MaDeTai"].Value.ToString();
                    gvDao.Xoa(lv);
                }

            }*/
        }

        private void FGiangVien_ThesisTopics_Main_Load(object sender, EventArgs e)
        {
            /*gvDeTai.DataSource = gvDao.LoadData("SELECT * From ThongTinDeTai");
            Instance_GridView();*/
            DataTable dtDeTai = gvDao.LoadData("SELECT * FROM ThongTinDeTai");
            List<LuanVan> lv_list = new List<LuanVan>();
            for (int i = 0; i < dtDeTai.Rows.Count; i++)
            {
                string MaDeTai, TenDeTai, SoLuong, MoTa, YeuCau, ChucNang, TheLoai, CongNghe, Nganh, Khoa, HocKy, TenGiangVien, TrangThai;

                MaDeTai = dtDeTai.Rows[i]["MaDeTai"].ToString();
                TenDeTai = dtDeTai.Rows[i]["TenDeTai"].ToString();
                SoLuong = dtDeTai.Rows[i]["SoLuong"].ToString();
                MoTa = dtDeTai.Rows[i]["MoTa"].ToString();
                YeuCau = dtDeTai.Rows[i]["YeuCau"].ToString();
                ChucNang = dtDeTai.Rows[i]["ChucNang"].ToString();
                TheLoai = dtDeTai.Rows[i]["TheLoai"].ToString();
                CongNghe = dtDeTai.Rows[i]["CongNghe"].ToString();
                Nganh = dtDeTai.Rows[i]["Nganh"].ToString();
                Khoa = dtDeTai.Rows[i]["Khoa"].ToString();
                HocKy = dtDeTai.Rows[i]["HocKy"].ToString();
                TenGiangVien = dtDeTai.Rows[i]["TenGiangVien"].ToString();
                TrangThai = dtDeTai.Rows[i]["TrangThai"].ToString();
                LuanVan lv = new LuanVan(MaDeTai,
                                         TenDeTai,
                                         TheLoai,
                                         SoLuong,
                                         MoTa,
                                         ChucNang,
                                         YeuCau,
                                         CongNghe,
                                         Khoa,
                                         Nganh,
                                         HocKy,
                                         TenGiangVien,
                                         TrangThai);
                lv_list.Add(lv);
            }
            int pos_current_X = -100;
            int pos_current_Y = 0;
            foreach (LuanVan lv in lv_list)
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
/*            gvDeTai.DataSource = gvDao.LoadData("SELECT * From ThongTinDeTai WHERE MaDeTai like '%"+txtTimKiem.Text+ "%' OR TenDeTai like '%"+txtTimKiem.Text+"%' OR TheLoai like '%"+txtTimKiem.Text+ "%' OR Nganh like '%"+txtTimKiem.Text+ "%'OR Khoa like '%"+txtTimKiem.Text+"%'");
*/        }
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
