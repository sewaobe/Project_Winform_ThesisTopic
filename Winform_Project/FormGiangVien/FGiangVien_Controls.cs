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
using Winform_Project.FormSinhVien;
using Winform_Project.uc_SV;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_Controls : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        public static string maSoNhom, maDeTai;
        public static int flag_NhiemVu = 0, flag_BaoCao = 0, flag_TienDo = 0, flag_Lich = 0;
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
            btnThayDoiOFF(btnThayDoiNhiemVu, FGiangVien_Controls.flag_NhiemVu);
            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnNhiemVu.Location.X, btnChiTiet.Location.Y + 30);
            ucFGiangVien_Suppost uc = new ucFGiangVien_Suppost();
            uc.Load += ucFGiangVien_Support_Load;
            uc.btnTaoDeTai.Click += btnNVTao_Click;
            uc.radioHoanThanh.Click += ucFGiangVien_Support_Load_Done;
            uc.radioQuaHan.Click += ucFGiangVien_Support_Load_No_Done;
            uc.radioThucHien.Click += ucFGiangVien_Support_Load_Processing;
            uc.radioTatCa.Click += ucFGiangVien_Support_Load_All;
            fLoTrungTam.Controls.Add(uc);
        }
        private void ucFGiangVien_Support_Load(object sender, EventArgs e)
        {
            ucFGiangVien_Suppost uc = sender as ucFGiangVien_Suppost;
            uc.radioTatCa.Checked = true;
            ucFGiangVien_Support_Load_All(uc.radioTatCa,e);
        }
        private void NhiemVu_NoiDung(object sender, EventArgs e)
        {
            ucNhiemVu ucNhiemVu = sender as ucNhiemVu;
            FNhiemVu_NoiDung FNhiemVu_NoiDung = new FNhiemVu_NoiDung(ucNhiemVu.nhiemVu);
            FNhiemVu_NoiDung.btnXacNhan.Visible = false;
            FNhiemVu_NoiDung.ShowDialog();

        }
        private void ucFGiangVien_Support_Load_Type(List<ucNhiemVu> listUcNhiemVu, ucFGiangVien_Suppost uc)
        {

            try
            {
                uc.fLoTrungTam.Controls.Clear();
                for (int i = 0; i < listUcNhiemVu.Count; i++)
                {
                    ucNhiemVu ucNhiemVu = listUcNhiemVu[i];
                    ucNhiemVu.Click += NhiemVu_NoiDung;
                    
                    uc.fLoTrungTam.Controls.Add(ucNhiemVu);

                }
            }
            catch
            {
                MessageBox.Show("Loi!!!!!!");
            }
        }
        private void ucFGiangVien_Support_Load_All(object sender, EventArgs e)
        {
            
            List<ucNhiemVu> listUcNhiemVu = gvDao.LayThongTinNhiemVu(maSoNhom,"Tat ca","NULL");
            RadioButton radio = sender as RadioButton;
            ucFGiangVien_Suppost uc = radio.Parent as ucFGiangVien_Suppost;
            ucFGiangVien_Support_Load_Type(listUcNhiemVu, uc);
        }
        private void ucFGiangVien_Support_Load_Done(object sender, EventArgs e)
        {

            List<ucNhiemVu> listUcNhiemVu = gvDao.LayThongTinNhiemVu(maSoNhom, "Da hoan thanh", "NULL");
            RadioButton radio = sender as RadioButton;
            ucFGiangVien_Suppost uc = radio.Parent as ucFGiangVien_Suppost;
            ucFGiangVien_Support_Load_Type(listUcNhiemVu, uc);
        }
        private void ucFGiangVien_Support_Load_No_Done(object sender, EventArgs e)
        {

            List<ucNhiemVu> listUcNhiemVu = gvDao.LayThongTinNhiemVu(maSoNhom, "Qua han", "NULL");
            
            RadioButton radio = sender as RadioButton;
            ucFGiangVien_Suppost uc = radio.Parent as ucFGiangVien_Suppost;
            ucFGiangVien_Support_Load_Type(listUcNhiemVu, uc);
        }
        private void ucFGiangVien_Support_Load_Processing(object sender, EventArgs e)
        {

            List<ucNhiemVu> listUcNhiemVu = gvDao.LayThongTinNhiemVu(maSoNhom, "Dang thuc hien", "NULL");
            RadioButton radio = sender as RadioButton;
            ucFGiangVien_Suppost uc = radio.Parent as ucFGiangVien_Suppost;
            ucFGiangVien_Support_Load_Type(listUcNhiemVu, uc);
        }
        private void btnNVTao_Click(object sender, EventArgs e)
        {
            FGiangVien_SupportTopic_Add fGiangVien_SupportTopic_Add = new FGiangVien_SupportTopic_Add();
            fGiangVien_SupportTopic_Add.ShowDialog();
        }
        private void btnTienDo_Click(object sender, EventArgs e)
        {
            btnThayDoiOFF(btnThayDoiTienDo, FGiangVien_Controls.flag_TienDo);

            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnTienDo.Location.X, btnChiTiet.Location.Y + 30);
            ucFGiangVien_Progress uc = new ucFGiangVien_Progress();
            fLoTrungTam.Controls.Add(uc);
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            btnThayDoiOFF(btnThayDoiBaoCao, FGiangVien_Controls.flag_BaoCao);
            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnBaoCao.Location.X, btnChiTiet.Location.Y + 30);
            DataTable dt = gvDao.LayThongTinBaoCao("2");
            List<BaoCao> list = new List<BaoCao>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                BaoCao bc = new BaoCao(dt.Rows[i]["TieuDe"].ToString(), dt.Rows[i]["ThoiGianGui"].ToString(), dt.Rows[i]["FileBaoCao"].ToString(), dt.Rows[i]["TrangThai"].ToString(), dt.Rows[i]["MaSoNhom"].ToString());
                list.Add(bc);
            }
            foreach(BaoCao bc in list)
            {
                ucBaoCao ucBaoCao = new ucBaoCao(bc);
                if (bc.TrangThai != "Dang cho")
                {
                    ucBaoCao.btnDanhGia.Visible = false;
                    ucBaoCao.btnXoa.Visible = false;
                }
                else
                {
                    ucBaoCao.btnDanhGia.Click += btnDanhGiaBaoCao_Click;
                    ucBaoCao.btnXoa.Click += btnXoaBaoCao_Click;
                }
                fLoTrungTam.Controls.Add(ucBaoCao);
            }
        }
        private void btnXoaBaoCao_Click(object sender, EventArgs e)
        {
            //Xoa bao cao -> Gui thong bao toi sinh vien (bao cao lan x da khong duoc duyet)
            Guna2Button btn = sender as Guna2Button;
            ucBaoCao ucBaoCao = btn.Parent as ucBaoCao;
            ThongBao tb = new ThongBao(maSoNhom, FDangNhap.giangVienAccount.Ten, "Duyet de tai", $"{ucBaoCao.lblTieuDe.Text} khong duoc duyet!!!","Chua doc", DateTime.Now);
            gvDao.ThongBaoToiSinhVien(tb);
            ucBaoCao.baoCao.TrangThai = "Khong duyet";
            gvDao.NhanXetBaoCao(ucBaoCao.baoCao);

        }
        private void btnDanhGiaBaoCao_Click(object sender, EventArgs e)
        {
            //Duyet bao cao -> Gui thong bao toi sinh vien (bao cao lan x da duoc duyet)
            Guna2Button btn = sender as Guna2Button;
            ucBaoCao ucBaoCao = btn.Parent as ucBaoCao;
            FGiangVien_Progress_Check fGiangVien_Progress_Check = new FGiangVien_Progress_Check(ucBaoCao.baoCao);
            fGiangVien_Progress_Check.ShowDialog();
            ThongBao tb = new ThongBao(maSoNhom, FDangNhap.giangVienAccount.Ten, "Duyet de tai", $"{ucBaoCao.lblTieuDe.Text} da duoc duyet!!!", "Chua doc", DateTime.Now);
            gvDao.ThongBaoToiSinhVien(tb);


        }
        private void btnThayDoiON(Guna2Button btn, int flag)
        {
            if (flag != 0)
                btn.Visible = true;
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            progress.Location = new Point(btnTongKet.Location.X, btnChiTiet.Location.Y + 30);
            uc_GV_TongKet uc_GV_TongKet = new uc_GV_TongKet();
            DataTable dtSinhVien = gvDao.LayThongTinSinhVien(maSoNhom);
            for (int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                SinhVien sv = new SinhVien(dtSinhVien.Rows[i]["HoTen"].ToString(),
                                           dtSinhVien.Rows[i]["GioiTinh"].ToString(),
                                           Convert.ToDateTime(dtSinhVien.Rows[i]["NgaySinh"]),
                                           dtSinhVien.Rows[i]["SDT"].ToString(),
                                           dtSinhVien.Rows[i]["Khoa"].ToString(),
                                           dtSinhVien.Rows[i]["Nganh"].ToString(),
                                           dtSinhVien.Rows[i]["MSSV"].ToString(),
                                           dtSinhVien.Rows[i]["MaSoNhom"].ToString());
                uc_SV_TongKet uc_SV_TongKet = new uc_SV_TongKet(sv);
                uc_SV_TongKet_DanhGia uc_SV_TongKet_DanhGia = new uc_SV_TongKet_DanhGia(sv);
                uc_GV_TongKet.fLo_UC_SV_TongKet.Controls.Add(uc_SV_TongKet);
                uc_GV_TongKet.fLo_UC_SV_TongKet_DanhGia.Controls.Add(uc_SV_TongKet_DanhGia);
            }
            fLoTrungTam.Controls.Clear();
            fLoTrungTam.Controls.Add(uc_GV_TongKet);
        }

        private void btnThayDoiOFF(Guna2Button btn, int flag)
        {
            btn.Visible = false;
            flag = 1;
        }
        private void FGiangVien_Controls_Load(object sender, EventArgs e)
        {
            fLoTrungTam.Controls.Clear();
            HienThiThongTinChiTiet();
            btnThayDoiON(btnThayDoiNhiemVu, flag_NhiemVu);
            btnThayDoiON(btnThayDoiBaoCao, flag_BaoCao);
            btnThayDoiON(btnThayDoiTienDo, flag_TienDo);
            btnThayDoiON(btnThayDoiLich, flag_Lich);

        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            btnThayDoiOFF(btnThayDoiLich, FGiangVien_Controls.flag_Lich);

            fLoTrungTam.Controls.Clear();
            progress.Location = new Point(btnLich.Location.X, btnChiTiet.Location.Y + 30);
            uc_Calendar uc_Calendar = new uc_Calendar();
            fLoTrungTam.Controls.Add(uc_Calendar);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
