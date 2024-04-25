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
using Winform_Project.uc_SV;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_Support_Add_SinhVien : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        public static SinhVien sinhVien;
        public FGiangVien_Support_Add_SinhVien()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            fLoTrungTam.Controls.Clear();
            DataTable dtNhomSinhVien = gvDao.LayThongTinSinhVien(FGiangVien_Controls.maSoNhom);
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
                uc_SV_ThongTin uc = new uc_SV_ThongTin(sv);
                uc.btnThemSinhVien.Click += btnThemSinhVien_Click;
                fLoTrungTam.Controls.Add(uc);

            }
            
        }
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            Guna2CirclePictureBox btn = sender as Guna2CirclePictureBox;
            uc_SV_ThongTin uc = btn.Parent as uc_SV_ThongTin;
            sinhVien = uc.sv;
            this.Hide();
        }
    }
}
