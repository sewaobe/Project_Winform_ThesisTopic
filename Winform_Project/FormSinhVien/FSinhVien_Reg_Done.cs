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
using Winform_Project.FormGiangVien;
using Winform_Project.FormSinhVien;
using Winform_Project.uc_SV;
namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien_Reg_Done : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        LuanVan luanvan = new LuanVan();
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        public static FlowLayoutPanel fLoHienThiSinhVien;
        ConNguoiDao conNguoiDao = new ConNguoiDao();

        public FSinhVien_Reg_Done( LuanVan lv)
        {
            InitializeComponent();
            luanvan = lv;
            txtMoTa.Text = lv.MoTa;
            txtChucNang.Text = lv.ChucNang;
            txtCongNghe.Text = lv.CongNghe;
            txtMaDeTai.Text = lv.MaDeTai;
            txtTenDeTai.Text = lv.TenDeTai;
            fLoHienThiSinhVien = flowThongTinSV;
        }

        private void FSinhVien_Reg_Done_Load(object sender, EventArgs e)
        {
            flowThongTinSV.Controls.Clear();
            DataTable dtSinhVien = conNguoiDao.TimThongTinSinhVien("");
            for (int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                if (dtSinhVien.Rows[i]["MSSV"].ToString() == FDangNhap.SinhVienAccount.Mssv)
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
                    uc_SV_ThongTin.btnThemSinhVien.Image = Properties.Resources.check;
                    flowThongTinSV.Controls.Add(uc_SV_ThongTin);
                    break;
                }
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

        

        
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(cbXacNhan.Checked == true)
            {
                foreach(uc_SV_ThongTin uc in fLoHienThiSinhVien.Controls.OfType<uc_SV_ThongTin>())
                {
                    svDao.DangKy(uc.sv, txtIDnhom.Text, txtMaDeTai.Text);
                }
               
            }    
        }

        private void txtIDnhom_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            FGiangVien_Support_Add_SinhVien fGiangVien_Support_Add_SinhVien = new FGiangVien_Support_Add_SinhVien();
            fGiangVien_Support_Add_SinhVien.Show();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FSinhVien_Thesis_Detail.container(new FSinhVien_Reg());
        }
    }
}
