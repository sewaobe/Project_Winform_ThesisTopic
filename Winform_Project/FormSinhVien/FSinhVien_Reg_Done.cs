using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;
using Winform_Project.uc_SV;

namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien_Reg_Done : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        LuanVan luanvan = new LuanVan();
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        
        public FSinhVien_Reg_Done( LuanVan lv)
        {
            InitializeComponent();
            luanvan = lv;
            txtMoTa.Text = lv.MoTa;
            txtChucNang.Text = lv.ChucNang;
            txtCongNghe.Text = lv.CongNghe;
            txtMaDeTai.Text = lv.MaDeTai;
            txtTenDeTai.Text = lv.TenDeTai;
        }

        private void FSinhVien_Reg_Done_Load(object sender, EventArgs e)
        {
            flowThongTinSV.Controls.Clear();
            string sqlStr = string.Format("SELECT * FROM SinhVien WHERE MSSV LIKE '{0}%'", txtMSSV.Text);
            DataTable dtSinhVien = svDao.LoadData(sqlStr);
            for (int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                SinhVien sinhvien = new SinhVien(dtSinhVien.Rows[i]["HoTen"].ToString(),
                    dtSinhVien.Rows[i]["GioiTinh"].ToString(),
                    Convert.ToDateTime(dtSinhVien.Rows[i]["NgaySinh"]),
                    dtSinhVien.Rows[i]["SDT"].ToString(),
                    dtSinhVien.Rows[i]["Khoa"].ToString(),
                    dtSinhVien.Rows[i]["Nganh"].ToString(),
                    dtSinhVien.Rows[i]["MSSV"].ToString(),
                    txtIDnhom.Text
                                                    );
                uc_SV_ThongTin uc_SV_ThongTin = new uc_SV_ThongTin(sinhvien);
                uc_SV_ThongTin.btnThemSinhVien.Click += btnThemSV_Click;
                flowThongTinSV.Controls.Add(uc_SV_ThongTin);
                uc_SV_ThongTin.Show();
            }
        }

        private void txtChucNang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMoTa_Click(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            Guna2CirclePictureBox btn = (Guna2CirclePictureBox)sender;
            uc_SV_ThongTin uc = btn.Parent as uc_SV_ThongTin;
            
            svDao.themSinhVien(uc.sv,txtMaDeTai.Text);
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            FSinhVien_Reg_Done_Load(sender, e);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(cbXacNhan.Checked == true)
            {
                svDao.DangKy(SinhVienAccount, txtIDnhom.Text, txtMaDeTai.Text);
                FDangNhap fDangNhap = new FDangNhap();
                fDangNhap.layThongTinSinhVien(SinhVienAccount.Mssv);
                this.Hide();
            }    
        }

        private void flowThongTinSV_Paint()
        {
            
        }

        private void txtIDnhom_TextChanged(object sender, EventArgs e)
        {
            FSinhVien_Reg_Done_Load(sender, e);
        }
    }
}
