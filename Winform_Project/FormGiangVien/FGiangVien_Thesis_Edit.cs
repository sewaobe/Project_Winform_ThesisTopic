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
    public partial class FGiangVien_Thesis_Edit : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        ThongTinDeTaii lv;
        public FGiangVien_Thesis_Edit()
        {
            InitializeComponent();
        }
        public FGiangVien_Thesis_Edit(ThongTinDeTaii lv)
        {
            try
            {
                InitializeComponent();
                this.lv = lv;
                txtMaDeTai.Text = lv.MaDeTai;
                txtTenDeTai.Text = lv.TenDeTai;
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
        /*private LuanVan LoadData()
        {
            return new LuanVan(txtMaDeTai.Text,
                              txtTenDeTai.Text,
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
        }*/
        private ThongTinDeTaii LoadData()
        {
            ThongTinDeTaii lvs = new ThongTinDeTaii
            {
                MaDeTai = txtMaDeTai.Text,
                TenDeTai = txtTenDeTai.Text,
                TheLoai = txtTheLoai.Text,
                SoLuong = txtSoLuong.Text,
                MoTa = txtMoTa.Text,
                ChucNang = txtChucNang.Text,
                YeuCau = txtYeuCau.Text,
                CongNghe = cbbCongNghe.Text,
                Khoa = cbbKhoa.Text,
                Nganh = cbbNganh.Text,
                HocKy = cbbHocKi.Text,
                TenGiangVien = lv.TenGiangVien,
                TrangThai = lv.TrangThai,
            };
            return lvs;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThongTinDeTaii lv = LoadData();
            
            if(conNguoiDao.Validation(this,lv))
                gvDao.Sua(lv);
            else
            {
                uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Thông tin đề tài chỉnh sửa không hợp lẹ", "Thất bại");
                uc_Toast_Notice.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThongTinDeTaii lv = LoadData();
            gvDao.Xoa(lv);
        }
    }
}
