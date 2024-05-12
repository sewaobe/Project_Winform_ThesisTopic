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
using Winform_Project.FormGiangVien;
using Winform_Project.FSinhVien;
using Winform_Project.uc_SV;

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
                    if (dtDeTai.Rows[i]["MaDeTai"].ToString() == dtNhomDangKy.Rows[j]["MaDeTai"].ToString() && dtNhomDangKy.Rows[j]["MaSoNhom"].ToString() == FDangNhap.SinhVienAccount.MaSoNhom)
                    {
                        
                        ThongTinDeTaii lv = new ThongTinDeTaii 
                        { 
                            MaDeTai = dtDeTai.Rows[i]["MaDeTai"].ToString(),
                        TenDeTai = dtDeTai.Rows[i]["TenDeTai"].ToString(),
                        SoLuong = dtDeTai.Rows[i]["SoLuong"].ToString(),
                        MoTa = dtDeTai.Rows[i]["MoTa"].ToString(),
                        YeuCau = dtDeTai.Rows[i]["YeuCau"].ToString(),
                        ChucNang = dtDeTai.Rows[i]["ChucNang"].ToString(),
                        TheLoai = dtDeTai.Rows[i]["TheLoai"].ToString(),
                        CongNghe = dtDeTai.Rows[i]["CongNghe"].ToString(),
                        Nganh = dtDeTai.Rows[i]["Nganh"].ToString(),
                        Khoa = dtDeTai.Rows[i]["Khoa"].ToString(),
                        HocKy = dtDeTai.Rows[i]["HocKy"].ToString(),
                        TenGiangVien = dtDeTai.Rows[i]["TenGiangVien"].ToString(),
                        TrangThai = dtDeTai.Rows[i]["TrangThai"].ToString()
                    };
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
            List<SinhVienn> listSinhVien = new List<SinhVienn>();
            DataTable dtSinhVien = conNguoiDao.LayThongTinSinhVien(FDangNhap.SinhVienAccount.MaSoNhom);
            for(int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                SinhVienn sv = new SinhVienn{HoTen = dtSinhVien.Rows[i]["HoTen"].ToString(),
                                           GioiTinh = dtSinhVien.Rows[i]["GioiTinh"].ToString(),
                                           NgaySinh = Convert.ToDateTime(dtSinhVien.Rows[i]["NgaySinh"]),
                                           SDT = dtSinhVien.Rows[i]["SDT"].ToString(),
                                           Khoa = dtSinhVien.Rows[i]["Khoa"].ToString(),
                                           Nganh = dtSinhVien.Rows[i]["Nganh"].ToString(),
                                           MSSV = dtSinhVien.Rows[i]["MSSV"].ToString(),
                                           MaSoNhom  = dtSinhVien.Rows[i]["MaSoNhom"].ToString()};
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

        private void btnDaHoanThanh_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDaHoanThanh_Click_1(object sender, EventArgs e)
        {
            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnDaHoanThanh.Location.X, btnDuyet.Location.Y + 35);
            Load_Flo("Da hoan thanh");
        }

       
    }
}
