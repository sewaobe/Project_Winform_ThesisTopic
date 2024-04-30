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

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Reg_New : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        private string namHoc, hocKi;
        public FSinhVien_Reg_New(string HocKi)
        {
            InitializeComponent();
            DataTable dtGiangVien = svDao.LoadData("SELECT * From GiangVien");
            for (int i = 0; i < dtGiangVien.Rows.Count; i++)
            {
                //đổ data vô các combobox
                if (!cbbGVHD1.Items.Contains(dtGiangVien.Rows[i]["HoTen"].ToString()))
                {
                    cbbGVHD1.Items.Add(dtGiangVien.Rows[i]["HoTen"].ToString());
                }
            }
            this.hocKi = HocKi;
        }

        private void FSinhVien_Reg_New_Load(object sender, EventArgs e)
        {
            flowThongTinSV.Controls.Clear();
            string sqlStr = string.Format("SELECT * FROM SinhVien WHERE MSSV LIKE '{0}%'", txtMSSV.Text);
            DataTable dtSinhVien = svDao.LoadData(sqlStr);
            for (int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                if (dtSinhVien.Rows[i]["MaSoNhom"].ToString() == "")
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
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            //if (txtMSSV.Text != "")
            //{
            //    if (svDao.LayThongTinSinhVien(txtMSSV.Text) != null)
            //        lblHoTenSV.Text = svDao.LayThongTinSinhVien(txtMSSV.Text).Ten;
            //    else
            //        lblHoTenSV.Text = "không tim thấy sinh viên cần tìm";
            //}
            //lblHoTenSV.Visible = true;
            FSinhVien_Reg_New_Load(sender, e);

        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            Guna2CirclePictureBox btn = (Guna2CirclePictureBox)sender;
            uc_SV_ThongTin uc = btn.Parent as uc_SV_ThongTin;

            
            svDao.themSinhVien(uc.sv, txtMaDeTai.Text);
            FSinhVien_Reg_New_Load(sender, e);
        }
        private LuanVan LoadData()
        {
           
            return new LuanVan(txtMaDeTai.Text, txtTenDeTai.Text, txtTheLoai.Text,"5", txtMoTa.Text, txtChucNang.Text, "abc", SinhVienAccount.Khoa, SinhVienAccount.Nganh, cbbGVHD1.Text,txtCongNghe.Text,hocKi,"Chua duyet");
        }
        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            if (cbXacNhan.Checked == true)
            {
                LuanVan lv = LoadData();
                svDao.DangKy(SinhVienAccount, txtIDnhom.Text, txtMaDeTai.Text);
                FDangNhap fDangNhap = new FDangNhap();
                fDangNhap.layThongTinSinhVien(SinhVienAccount.Mssv);
                svDao.DeXuatDeTai(lv);
            }
        }
    }
}
