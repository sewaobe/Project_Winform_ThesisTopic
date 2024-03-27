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
        public FGiangVien_Thesis_Edit()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private LuanVan LoadData()
        {
            DateTime dtStart, dtEnd;

            if (cbbHocKi.Text == "Kỳ 1")
            {
                dtStart = new DateTime(Int32.Parse(cbbNamHoc.Text.Substring(0, 4)), 8, 25);
                dtEnd = new DateTime(Int32.Parse(cbbNamHoc.Text.Substring(0, 4)) + 1, 1, 1);
            }
            else if (cbbHocKi.Text == "Kỳ 2")
            {
                dtStart = new DateTime(Int32.Parse(cbbNamHoc.Text.Substring(0, 4)), 1, 1);
                dtEnd = new DateTime(Int32.Parse(cbbNamHoc.Text.Substring(0, 4)), 6, 1);
            }
            else
            {
                dtStart = new DateTime(Int32.Parse(cbbNamHoc.Text.Substring(0, 4)), 6, 1);
                dtEnd = new DateTime(Int32.Parse(cbbNamHoc.Text.Substring(0, 4)), 8, 25);
            }
            return new LuanVan(txtMaDeTai.Text, txtTen.Text, txtTheLoai.Text, txtSoLuong.Text, dtStart, dtEnd, txtMoTa.Text, txtChucNang.Text, txtYeuCau.Text, cbbKhoa.Text, cbbNganh.Text, "TenGiangVien"); 
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            LuanVan lv = LoadData();
            gvDao.Sua(lv);
        }
    }
}
