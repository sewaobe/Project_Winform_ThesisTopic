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
        public FGiangVien_ThesisTopics_Add(string Khoa, string Nganh, string TenGiangVien,string NamHoc, string HocKi)
        {
            InitializeComponent();
            this.khoa = Khoa;
            this.nganh = Nganh; 
            this.tenGiangVien = TenGiangVien;
            this.namHoc = NamHoc;
            this.hocKi = HocKi; 
        }
        public FGiangVien_ThesisTopics_Add()
        {
            InitializeComponent();
        }

        private LuanVan LoadData()
        {
            DateTime dtStart, dtEnd;

            if (hocKi == "Kỳ 1")
            {
                MessageBox.Show(namHoc.Substring(0, 4));
                dtStart = new DateTime(Int32.Parse(namHoc.Substring(0, 4)),8,25);
                dtEnd = new DateTime(Int32.Parse(namHoc.Substring(0, 4))+1,1,1);
            }
            else if(hocKi == "Kỳ 2")
            {
                dtStart = new DateTime(Int32.Parse(namHoc.Substring(0, 4)), 1, 1);
                dtEnd = new DateTime(Int32.Parse(namHoc.Substring(0, 4)), 6, 1);
            }
            else
            {
                dtStart = new DateTime(Int32.Parse(namHoc.Substring(0, 4)), 6, 1);
                dtEnd = new DateTime(Int32.Parse(namHoc.Substring(0, 4)), 8, 25);
            }
            return new LuanVan(txtMaDeTai.Text, txtTen.Text, txtTheLoai.Text, txtSoLuong.Text,dtStart, dtEnd, txtMoTa.Text, txtChucNang.Text, txtYeuCau.Text, this.khoa, this.nganh, this.tenGiangVien);
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
