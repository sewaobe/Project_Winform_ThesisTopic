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
    public partial class FGiangVien_Controls : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        public static string maSoNhom, maDeTai;
        public FGiangVien_Controls()
        {
            InitializeComponent();
        }
        public FGiangVien_Controls(string MDT, string MSN)
        {
            InitializeComponent();
            maSoNhom = MSN;
            maDeTai = MDT;
            MessageBox.Show(maSoNhom + maDeTai);
        }
        private void HienThiThongTinChiTiet()
        {
            DataTable dtLuanVan = gvDao.LayThongTinDeTai(maDeTai);
            LuanVan lv = new LuanVan(dtLuanVan.Rows[0]["MaDeTai"].ToString(),
                                     dtLuanVan.Rows[0]["TenDeTai"].ToString(),
                                     dtLuanVan.Rows[0]["TheLoai"].ToString(),
                                     dtLuanVan.Rows[0]["SoLuong"].ToString(),
                                     dtLuanVan.Rows[0]["MoTa"].ToString(),
                                     dtLuanVan.Rows[0]["ChucNang"].ToString(),
                                     dtLuanVan.Rows[0]["YeuCau"].ToString(),
                                     dtLuanVan.Rows[0]["CongNghe"].ToString(),
                                     dtLuanVan.Rows[0]["Khoa"].ToString(),
                                     dtLuanVan.Rows[0]["Nganh"].ToString(),
                                     dtLuanVan.Rows[0]["HocKy"].ToString(),
                                     dtLuanVan.Rows[0]["TenGiangVien"].ToString(),
                                     dtLuanVan.Rows[0]["TrangThai"].ToString());
            DataTable dtNhomSinhVien = gvDao.LayThongTinSinhVien(maSoNhom);
            List<SinhVien> listSinhVien = new List<SinhVien>();

            for (int i = 0; i < dtNhomSinhVien.Rows.Count; i++)
            {
                SinhVien sv = new SinhVien(dtNhomSinhVien.Rows[i]["HoTen"].ToString(),
                                           dtNhomSinhVien.Rows[i]["GioiTinh"].ToString(),
                                           Convert.ToDateTime(dtNhomSinhVien.Rows[i]["NgaySinh"]),
                                           dtNhomSinhVien.Rows[i]["SDT"].ToString(),
                                           dtNhomSinhVien.Rows[i]["Khoa"].ToString(),
                                           dtNhomSinhVien.Rows[i]["Nganh"].ToString(),
                                           dtNhomSinhVien.Rows[i]["MSSV"].ToString(),
                                           dtNhomSinhVien.Rows[i]["MaSoNhom"].ToString());
                listSinhVien.Add(sv);
            }
            ucChiTietDeTai uc = new ucChiTietDeTai(lv, listSinhVien);
            fLoTrungTam.Controls.Add(uc);
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnChiTiet.Location.X,btnChiTiet.Location.Y + 30);
            HienThiThongTinChiTiet();
        }

        private void btnNhiemVu_Click(object sender, EventArgs e)
        {
            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnNhiemVu.Location.X, btnChiTiet.Location.Y + 30);
            ucFGiangVien_Suppost uc = new ucFGiangVien_Suppost();
            uc.btnTaoDeTai.Click += btnNVTao_Click;
            fLoTrungTam.Controls.Add(uc);
        }
        private void btnNVTao_Click(object sender, EventArgs e)
        {
            FGiangVien_SupportTopic_Add fGiangVien_SupportTopic_Add = new FGiangVien_SupportTopic_Add();
            fGiangVien_SupportTopic_Add.ShowDialog();
        }
        private void btnTienDo_Click(object sender, EventArgs e)
        {
            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnTienDo.Location.X, btnChiTiet.Location.Y + 30);
            ucFGiangVien_Progress uc = new ucFGiangVien_Progress();
            fLoTrungTam.Controls.Add(uc);
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnBaoCao.Location.X, btnChiTiet.Location.Y + 30);
            DataTable dt = gvDao.LoadData($"SELECT TieuDe, FileBaoCao,ThoiGianGui, TienDo FROM TienDo WHERE MaSoNhom = '{2}'");
            List<BaoCao> list = new List<BaoCao>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string trangThai;
                if (dt.Rows[i]["TienDo"].ToString() != "NULL")
                    trangThai = "Da duyet";
                else
                    trangThai = "Chua duyet";
                BaoCao bc = new BaoCao(dt.Rows[i]["TieuDe"].ToString(), dt.Rows[i]["ThoiGianGui"].ToString(), dt.Rows[i]["FileBaoCao"].ToString(), trangThai);
                list.Add(bc);
            }
            foreach(BaoCao bc in list)
            {
                ucBaoCao ucBaoCao = new ucBaoCao(bc);
                ucBaoCao.btnDanhGia.Click += btnDanhGiaBaoCao_Click;
                ucBaoCao.btnXoa.Click += btnXoaBaoCao_Click;
                fLoTrungTam.Controls.Add(ucBaoCao);
            }
        }
        private void btnXoaBaoCao_Click(object sender, EventArgs e)
        {
                //Xoa bao cao -> Gui thong bao toi sinh vien (bao cao lan x da khong duoc duyet)
        }
        private void btnDanhGiaBaoCao_Click(object sender, EventArgs e)
        {
                //Duyet bao cao -> Gui thong bao toi sinh vien (bao cao lan x da duoc duyet)
        }

        private void FGiangVien_Controls_Load(object sender, EventArgs e)
        {
            fLoTrungTam.Controls.Clear();
            HienThiThongTinChiTiet();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
