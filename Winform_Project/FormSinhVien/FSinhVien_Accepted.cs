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
using Winform_Project.FSinhVien;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Accepted : Form
    {
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        SinhVienDao svDao = new SinhVienDao();
        public FSinhVien_Accepted()
        {
            InitializeComponent();
        }

        private void Load_Flo(string trangThai)
        {
            DataTable dtDeTai = conNguoiDao.LayThongTinDeTaiDangCapNhat(trangThai);

            DataTable dtNhomDangKy = conNguoiDao.LayThongTinTatCaNhomDangKy();
            int flag = 0;
            for(int i = 0; i < dtDeTai.Rows.Count; i++)
            {
                //Thoát khỏi vòng lặp khi đã kiếm được đã tài của nhóm
                if (flag == 1)
                    break;
                for(int j = 0;j < dtNhomDangKy.Rows.Count; j++)
                {
                    //Tìm đề tài mà nhóm đăng kí
                    if (dtDeTai.Rows[i]["MaDeTai"].ToString() == dtNhomDangKy.Rows[j]["MaDeTai"].ToString() && dtNhomDangKy.Rows[j]["MaSoNhom"].ToString() == FDangNhap.SinhVienAccount.Masonhom)
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
                        uc_SV_DeTai uc = new uc_SV_DeTai(lv);
                        uc.btnChiTiet.Click += btnChiTiet_Click;
                        fLoTrungTam.Controls.Add(uc);
                        flag = 1;
                        break;
                    } 
                }
            }

        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            uc_SV_DeTai uc = btn.Parent as uc_SV_DeTai;
            List<SinhVien> listSinhVien = new List<SinhVien>();
            DataTable dtSinhVien = conNguoiDao.LayThongTinSinhVien(FDangNhap.SinhVienAccount.Masonhom);
            for(int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                SinhVien sv = new SinhVien(dtSinhVien.Rows[i]["HoTen"].ToString(), 
                                           dtSinhVien.Rows[i]["GioiTinh"].ToString(), 
                                           Convert.ToDateTime(dtSinhVien.Rows[i]["NgaySinh"]), 
                                           dtSinhVien.Rows[i]["SDT"].ToString(), 
                                           dtSinhVien.Rows[i]["Khoa"].ToString(), 
                                           dtSinhVien.Rows[i]["Nganh"].ToString(), 
                                           dtSinhVien.Rows[i]["MSSV"].ToString(), 
                                           dtSinhVien.Rows[i]["MaSoNhom"].ToString());
                listSinhVien.Add(sv);
            }
            
            FSinhVien_Thesis_Detail fSinhVien_Thesis_Detail = new FSinhVien_Thesis_Detail(uc.luanvan, listSinhVien);
            fSinhVien_Thesis_Detail.Dock = DockStyle.Fill;
            FSinhVien.FSinhVien.panelTrungTam.Controls.Clear();
            FSinhVien.FSinhVien.panelTrungTam.Controls.Add(fSinhVien_Thesis_Detail);
            fSinhVien_Thesis_Detail.BringToFront();
        }
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnDuyet.Location.X, btnDuyet.Location.Y + 35);

            Load_Flo("Da duyet");
        }

        private void btnCho_Click(object sender, EventArgs e)
        {
            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnCho.Location.X, btnDuyet.Location.Y + 35);
            Load_Flo("Chua duyet");
        }

        private void FSinhVien_Accepted_Load(object sender, EventArgs e)
        {
            Load_Flo("Da duyet");

        }
    }
}
