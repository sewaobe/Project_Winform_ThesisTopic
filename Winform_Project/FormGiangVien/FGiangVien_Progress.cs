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
using Winform_Project.uc_GV;

namespace Winform_Project
{
    public partial class FGiangVien_Progress : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        ConNguoiDao conNguoiDao = new   ConNguoiDao();
        public FGiangVien_Progress()
        {
            InitializeComponent();
        }

        
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            
        }
        private double Load_Chart_ChatLuong_Add(string hocKy, DataTable dtDeTai)
        {
            double diemTB = 0, diemTong = 0, soLuong = 0;
            for (int i = 0; i < dtDeTai.Rows.Count; i++)
            {
                if (dtDeTai.Rows[i]["TenGiangVien"].ToString() == FDangNhap.giangVienAccount.Ten)
                {
                    if (dtDeTai.Rows[i]["HocKy"].ToString() == hocKy)
                    {
                        diemTong += Double.Parse(dtDeTai.Rows[i]["Diem"].ToString());
                        soLuong += 1;
                    }
                }
            }
            diemTB =Math.Round( diemTong / soLuong,2);
            return diemTB;
        }
        private void Load_Chart_ChatLuong()
        {
            DataTable dtDeTai = conNguoiDao.LayThongTinDeTaiDangCapNhat("Da hoan thanh");
            
            chartThongKeChatLuong.ChartAreas["ChartArea1"].AxisX.Title = "Học kì";
            chartThongKeChatLuong.ChartAreas["ChartArea1"].AxisY.Title = "Tiến độ (%)";
            for (int i = 1; i <= 3; i++)
            {
                double diemHK = Load_Chart_ChatLuong_Add($"Ky {i}", dtDeTai);
                chartThongKeChatLuong.Series["chartLine"].Points.AddXY($"Học kỳ {i}",diemHK*10);
            }
        }
        private double Load_Chart_SinhVienDangKy_Add(string hocKy, DataTable dtDeTai, DataTable dtNhomDangKy)
        {
            DataTable dtSinhVien = conNguoiDao.LayThongTinTatCaSinhVien();
            int soLuongDangKi = 0;

            for (int i = 0; i < dtDeTai.Rows.Count; i++)
            {
                if (dtDeTai.Rows[i]["HocKy"].ToString() == hocKy)
                {
                    for (int j = 0; j < dtNhomDangKy.Rows.Count; j++)
                    {
                        if (dtNhomDangKy.Rows[j]["MaDeTai"].ToString() == dtDeTai.Rows[i]["MaDeTai"].ToString())
                        {
                            if (dtDeTai.Rows[i]["TenGiangVien"].ToString() == FDangNhap.giangVienAccount.Ten)
                            {
                                soLuongDangKi += 1;
                            }
                        }
                    }
                }
            }
            double diemTb;
            if (dtSinhVien.Rows.Count == 0)
                diemTb = 0;
            else

                diemTb = soLuongDangKi / dtSinhVien.Rows.Count;

            return Math.Round(diemTb, 2);

        }
        private void Load_Chart_SinhVienDangKy()
        {
            DataTable dtDeTai = conNguoiDao.LayThongTinDeTaiDangCapNhat("Da hoan thanh");
            DataTable dtNhomDangKy = conNguoiDao.LayThongTinTatCaNhomDangKy();
            chartThongKeSoLuongSinhVienDangKy.ChartAreas["ChartArea1"].AxisX.Title = "Học kì";
            chartThongKeSoLuongSinhVienDangKy.ChartAreas["ChartArea1"].AxisY.Title = "Tỷ lệ(/Tổng sô sinh viên)";
        
            for (int i = 1; i <= 3; i++)
            {
                double diemHK = Load_Chart_SinhVienDangKy_Add($"Ky {i}", dtDeTai, dtNhomDangKy);
                chartThongKeSoLuongSinhVienDangKy.Series["chartLine"].Points.AddXY($"Học kỳ {i}", diemHK * 10);
            }

        }
        private void LoadUCTong(string ten, string soLuong, ucTongSoDeTai uc, int maMau1, int maMau2, int maMau3, int value)
        {
            Color color = Color.FromArgb(maMau1, maMau2, maMau3);

            uc.lblTen.Text = ten;
            uc.lblSoLuong.Text = soLuong;
            uc.lblTen.BackColor = color;
            uc.lblSoLuong.BackColor = color;
            uc.pic.FillColor = color;
            uc.progressBar.FillColor = Color.White;
            uc.progressBar.Value = value;
            uc.progressBar.BackColor = uc.pic.FillColor;
            uc.progressBar.ProgressColor2 = Color.FromArgb(53,41,123);
            uc.progressBar.ProgressColor = Color.FromArgb(53, 41, 123);
        }
        private void FGiangVien_Progress_Load(object sender, EventArgs e)
        {
            int tongDeTai = 0, tongDeTaiDaDangKy = 0, tongDeTaiChuaDangKy = 0;

            DataTable dtTongDeTaiDaDangKy1 = conNguoiDao.LayThongTinDeTaiDangCapNhat("Da duyet");
            DataTable dtTongDeTaiDaDangKy2 = conNguoiDao.LayThongTinDeTaiDangCapNhat("Da hoan thanh");
            DataTable dtTongDeTaiChuaDangKy = conNguoiDao.LayThongTinDeTaiDangCapNhat("Chua dang ki");

            tongDeTaiDaDangKy = dtTongDeTaiDaDangKy1.Rows.Count + dtTongDeTaiDaDangKy2.Rows.Count;
            tongDeTaiChuaDangKy = dtTongDeTaiChuaDangKy.Rows.Count;
            tongDeTai = tongDeTaiChuaDangKy + tongDeTaiDaDangKy;

            ucTongSoDeTai ucTongDeTai = this.ucTongSoDeTai;
            LoadUCTong("Tong de tai", tongDeTai.ToString(), ucTongDeTai, 135, 206, 250, 100);

            ucTongSoDeTai ucTongDeTaiDangKy = this.ucTongSoDeTaiDangKy;
            LoadUCTong("De tai da dang ky", tongDeTaiDaDangKy.ToString(), ucTongDeTaiDangKy, 144, 238, 144, tongDeTaiDaDangKy*100/tongDeTai);

            ucTongSoDeTai ucTongDeTaiChuaDangKy = this.ucTongSoDeTaiChuaDangKy;
            LoadUCTong("De tai chua dang ky", tongDeTaiChuaDangKy.ToString(), ucTongDeTaiChuaDangKy, 255, 128, 128, tongDeTaiChuaDangKy*100 / tongDeTai);

            Load_Chart_ChatLuong();
            Load_Chart_SinhVienDangKy();
            ThongKeChiTiet_DeTai();
        }

        private void ThongKeChiTiet_DeTai()
        {
            DataTable dtTongDeTaiDaDangKy = conNguoiDao.LayThongTinDeTaiDangCapNhat("Da hoan thanh");
            int deTaiHoanThanh = 0, deTaiKhongHoanThanh = 0;
            double tongDiem = 0, diemTb = 0;
            for(int i = 0; i < dtTongDeTaiDaDangKy.Rows.Count; i++)
            {
                if (double.Parse((dtTongDeTaiDaDangKy.Rows[i]["Diem"].ToString())) >= 5)
                {
                    deTaiHoanThanh += 1;
                }
                else
                    deTaiKhongHoanThanh += 1;
                tongDiem += double.Parse(dtTongDeTaiDaDangKy.Rows[i]["Diem"].ToString());
            }
            if (dtTongDeTaiDaDangKy.Rows.Count != 0)
            {
                diemTb = tongDiem / dtTongDeTaiDaDangKy.Rows.Count;

                lblSoLuongLuanVanChuaHoanThanh.Text = deTaiKhongHoanThanh.ToString();
                progressLuanVanChuaHoanThanh.Value = deTaiKhongHoanThanh * 100 / dtTongDeTaiDaDangKy.Rows.Count;
                lblSoLuongLuanVanHoanThanh.Text = deTaiHoanThanh.ToString();
                progressLuanVanHoanThanh.Value = deTaiHoanThanh * 100 / dtTongDeTaiDaDangKy.Rows.Count;
                lblSoLuongLuanVanDiemTrungBinh.Text = diemTb.ToString();
                progressLuanVanDiemTrungBinh.Value = int.Parse(Math.Round((diemTb * 10), 2).ToString());
            }
        }
        private void Load_Chart_Line()
        {
            DataTable dtBaoCao = gvDao.LayThongTinBaoCao(FGiangVien_Controls.maSoNhom);

            chartThongKeChatLuong.ChartAreas["ChartArea1"].AxisX.Title = "Tiêu đề báo cáo";
            chartThongKeChatLuong.ChartAreas["ChartArea1"].AxisY.Title = "Tiến độ (%)";

            for (int i = 0; i < dtBaoCao.Rows.Count; i++)
            {
                chartThongKeChatLuong.Series["chartLine"].Points.AddXY(dtBaoCao.Rows[i]["TieuDe"].ToString(), dtBaoCao.Rows[i]["TienDo"].ToString());
            }
        }
        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
