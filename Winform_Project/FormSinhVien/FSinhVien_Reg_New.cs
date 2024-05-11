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
using Winform_Project.FormGiangVien;
using Winform_Project.FSinhVien;
using Winform_Project.uc_SV;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Reg_New : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        private string namHoc, hocKi;
        ConNguoiDao conNguoiDao = new ConNguoiDao();
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
            FSinhVien_Reg_Done.fLoHienThiSinhVien = flowThongTinSV;
        }

       

      
        private LuanVan LoadData()
        {
           
            return new LuanVan(txtMaDeTai.Text, txtTenDeTai.Text, txtTheLoai.Text,
                                flowThongTinSV.Controls.Count.ToString(), txtMoTa.Text, 
                                txtChucNang.Text, "NULL",txtCongNghe.Text, SinhVienAccount.Khoa, 
                                SinhVienAccount.Nganh,hocKi, cbbGVHD1.Text, "Chua duyet");
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

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            LuanVan lv = LoadData();
            if (cbXacNhan.Checked == true)
            {
                
                if (conNguoiDao.Validation(this, lv))
                {
                    int n = 0;
                    if (int.TryParse(txtIDnhom.Text, out n) == false)
                    {
                        ErrorProvider errorProvider = new ErrorProvider();
                        errorProvider.SetError(txtIDnhom, "Vui lòng nhập số !!");
                        uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Thông tin đề tài không hợp lệ", "Thất bại");
                        uc_Toast_Notice.Show();
                    }
                    else
                    {
                        svDao.DeXuatDeTai(lv);
                        FDangNhap.SinhVienAccount.Masonhom = txtIDnhom.Text;
                        foreach (uc_SV_ThongTin uc in flowThongTinSV.Controls.OfType<uc_SV_ThongTin>())
                        {
                            svDao.DangKy(uc.sv, txtIDnhom.Text, txtMaDeTai.Text);
                        }
                    }
                }
                else
                {
                    uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Thông tin đề tài không hợp lệ", "Thất bại");
                    uc_Toast_Notice.Show();
                }

            }
        }
    }
}
