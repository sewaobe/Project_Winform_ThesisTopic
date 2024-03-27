using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.Model;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_Thesis_Accept : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        public FGiangVien_Thesis_Accept()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FGiangVien_Thesis_Accept_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winDataSet5._DeTai__' table. You can move, or remove it, as needed.
            
        }

        private void btnDaDuyet_Click(object sender, EventArgs e)
        {
            gvDeTai.DataSource = gvDao.LoadData("SELECT ThongTinDeTai.MaDeTai, ThongTinDeTai.TenDeTai, ThongTinDeTai.TheLoai, ThongTinDeTai.NgayBatDau, ThongTinDeTai.NgayKetThuc, ThongTinNhomDangKy.MaSoNhom, ThongTinNhomDangKy.TrangThai FROM ThongTinDeTai INNER JOIN ThongTinNhomDangKy ON ThongTinNhomDangKy.MaDeTai = ThongTinDeTai.MaDeTai AND ThongTinNhomDangKy.TrangThai = 'Da duyet'");
            gvDeTai.Visible = !gvDeTai.Visible;
            txtTimKiem.Visible = !txtTimKiem.Visible;
            if(gvDeTai.Visible == true) 
                btnChuaDuyet.Location = new Point(btnChuaDuyet.Location.X, gvDeTai.Location.Y + gvDeTai.Size.Height+30);
            else
                btnChuaDuyet.Location = new Point(btnChuaDuyet.Location.X, btnDaDuyet.Location.Y+30);
        }

        private void btnChuaDuyet_Click(object sender, EventArgs e)
        {
            gvDeTai.DataSource = gvDao.LoadData("SELECT ThongTinDeTai.MaDeTai, ThongTinDeTai.TenDeTai, ThongTinDeTai.TheLoai, ThongTinDeTai.NgayBatDau, ThongTinDeTai.NgayKetThuc, ThongTinNhomDangKy.MaSoNhom, ThongTinNhomDangKy.TrangThai FROM ThongTinDeTai INNER JOIN ThongTinNhomDangKy ON ThongTinNhomDangKy.MaDeTai = ThongTinDeTai.MaDeTai AND ThongTinNhomDangKy.TrangThai = 'Chua duyet'");
            gvDeTai.Visible = !gvDeTai.Visible;
            txtTimKiem.Visible = !txtTimKiem.Visible;
        }
    }
}
