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

namespace Winform_Project
{
    public partial class FDangNhap : Form
    {
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        SinhVienDao svDao = new SinhVienDao();
        GiangVienDao gvDao = new GiangVienDao();
        public static SinhVien SinhVienAccount;
        public static GiangVien giangVienAccount;
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TaiKhoanDangNhap tk = new TaiKhoanDangNhap(txtTaiKhoan.Text,txtMatKhau.Text);
            DataTable dt = conNguoiDao.XacNhanDangNhap(tk);
            if (dt.Rows.Count > 0)
            {
                uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Đăng nhập thành công", "Thành công");
                uc_Toast_Notice.Show();
                if (dt.Rows[0]["ChucVu"].ToString() == "Giảng viên")
                {
                    LayThongTinGiangVien(dt.Rows[0]["HoTen"].ToString());
                    FGiangVien fGiangVien = new FGiangVien();
                    this.Hide();
                    fGiangVien.ShowDialog();

                }
                else
                {
                    layThongTinSinhVien(dt.Rows[0]["MSSV"].ToString());
                    //SinhVienAccount = svDao.LayThongTinSinhVien(dt.Rows[0]["MSSV"].ToString());
                    FSinhVien.FSinhVien fSinhVien = new FSinhVien.FSinhVien();
                    this.Hide();
                    fSinhVien.ShowDialog();

                }
                

            }
            else
            {
                uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Đăng nhập thất bại", "Thất bại");
                uc_Toast_Notice.Show();
            }
            
        }
        public void LayThongTinGiangVien(string hoTen)
        {
            giangVienAccount = gvDao.LayThongTinGiangVien(hoTen);
        }
        public void layThongTinSinhVien(string mssv)
        {
            SinhVienAccount = svDao.LayThongTinSinhVien(mssv);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
