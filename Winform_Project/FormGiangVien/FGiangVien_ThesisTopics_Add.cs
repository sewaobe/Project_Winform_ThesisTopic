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
    public partial class FGiangVien_ThesisTopics_Add : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        private string khoa, nganh, tenGiangVien, namHoc, hocKi;
        public FGiangVien_ThesisTopics_Add(string Khoa, string Nganh, string TenGiangVien, string HocKi)
        {
            InitializeComponent();
            this.khoa = Khoa;
            this.nganh = Nganh; 
            this.tenGiangVien = TenGiangVien;
            this.hocKi = HocKi; 
            
        }
        public FGiangVien_ThesisTopics_Add()
        {
            InitializeComponent();
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
                               khoa,
                               nganh,
                               hocKi,
                               tenGiangVien,
                               "Chua dang ki");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LuanVan lv = LoadData();
            gvDao.Them(lv);
        }
    }
}
