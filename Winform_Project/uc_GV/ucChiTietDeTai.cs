using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDoiTuong;

namespace Winform_Project
{
    public partial class ucChiTietDeTai : UserControl
    {
        public ucChiTietDeTai()
        {
            InitializeComponent();
        }
        public ucChiTietDeTai(LuanVan lv, List<SinhVien> listSinhVien)
        {
            InitializeComponent();
            txtMaDeTai.Text =lv.MaDeTai;
            txtTenDeTai.Text =lv.TenDeTai;
            txtChucNang.Text =lv.ChucNang;  
            txtCongNghe.Text =lv.CongNghe;  
            txtYeuCau.Text =lv.YeuCau;
            txtKhoa.Text = lv.Khoa;
            txtNganh.Text = lv.Nganh;
            txtMoTa.Text = lv.MoTa;
            txtTheLoai.Text = lv.TheLoai;
            txtHocKy.Text = lv.HocKy;

            string tenCacThanhVien = "";
            string maNhom = "";
            for(int i =0;i <listSinhVien.Count;i++)
            {
                tenCacThanhVien+= (listSinhVien[i].Ten) + " - ";
                maNhom = listSinhVien[i].Masonhom;
            }
            txtMaNhom.Text = maNhom;
            txtThanhVien.Text = tenCacThanhVien;

        }
    }
}
