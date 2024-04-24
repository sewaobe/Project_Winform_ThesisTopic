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
    public partial class FGiangVien_Thesis_Edit : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        LuanVan lv;
        public FGiangVien_Thesis_Edit()
        {
            InitializeComponent();
        }
        public FGiangVien_Thesis_Edit(LuanVan lv)
        {
            try
            {
                InitializeComponent();
                this.lv = lv;
                txtMaDeTai.Text = lv.MaDeTai;
                txtTen.Text = lv.TenDeTai;
                txtSoLuong.Text = lv.SoLuong;
                txtChucNang.Text = lv.ChucNang;
                txtMoTa.Text = lv.MoTa;
                txtTheLoai.Text = lv.TheLoai;
                txtYeuCau.Text = lv.YeuCau;
                cbbKhoa.Text = lv.Khoa;
                cbbNganh.Text = lv.Nganh;
                cbbHocKi.Text = lv.HocKy;
                cbbCongNghe.Text = lv.CongNghe;
            }
            catch
            {
                ;
            }
           
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private LuanVan LoadData()
        {
            return new LuanVan(txtMaDeTai.Text,
                              txtTen.Text,
                              txtTheLoai.Text,
                              txtSoLuong.Text,
                              txtMoTa.Text,
                              txtChucNang.Text,
                              txtYeuCau.Text,
                              cbbCongNghe.Text,
                              cbbKhoa.Text,
                              cbbNganh.Text,
                              cbbHocKi.Text,
                              "Nguyen Van A",
                              lv.TrangThai
                              ) ;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LuanVan lv = LoadData();
            gvDao.Sua(lv);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LuanVan lv = LoadData();
            gvDao.Xoa(lv);
        }
    }
}
