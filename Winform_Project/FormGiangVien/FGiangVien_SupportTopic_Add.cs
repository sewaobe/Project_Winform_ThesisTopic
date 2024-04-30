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

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_SupportTopic_Add : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        public FGiangVien_SupportTopic_Add()
        {
            InitializeComponent();
            txtNguoiGiaoViec.Text = FDangNhap.giangVienAccount.Ten;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhiemVu nhiemVu = new NhiemVu(txtTieuDe.Text,
                                          pckThoiGianBatDau.Value,
                                          pckThoiGianKetThuc.Value,
                                          txtNguoiGiaoViec.Text,
                                          txtSinhVien.Text,
                                          cbbTrangThai.Text,
                                          txtNoiDung.Text,
                                          FGiangVien_Support_Add_SinhVien.sinhVien.Mssv,
                                          FGiangVien_Support_Add_SinhVien.sinhVien.Masonhom);
            gvDao.ThemNhiemVu(nhiemVu);
            FSinhVien_Controls.flag_NhiemVu = 1;
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            FGiangVien_Support_Add_SinhVien fGiangVien_Support_Add_SinhVien = new FGiangVien_Support_Add_SinhVien();
            fGiangVien_Support_Add_SinhVien.ShowDialog();
            txtSinhVien.Text = FGiangVien_Support_Add_SinhVien.sinhVien.Ten;
        }

        private void pckThoiGianBatDau_ValueChanged(object sender, EventArgs e)
        {
            txtThoiGianBatDau.Text = pckThoiGianBatDau.Value.ToString();
        }

        private void pckThoiGianKetThuc_ValueChanged(object sender, EventArgs e)
        {
            txtThoiGianKetThuc.Text = pckThoiGianKetThuc.Value.ToString();

        }
    }
}
