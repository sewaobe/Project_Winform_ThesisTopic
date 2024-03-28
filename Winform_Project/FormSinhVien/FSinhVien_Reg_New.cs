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

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Reg_New : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = new SinhVien("Bao","", DateTime.Now, "","","","22110285");
        private string namHoc, hocKi;
        public FSinhVien_Reg_New(string NamHoc, string HocKi)
        {
            InitializeComponent();
            this.namHoc = NamHoc;
            this.hocKi = HocKi;
        }

        private void FSinhVien_Reg_New_Load(object sender, EventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            if (txtMSSV.Text != "")
            {
                if (svDao.LayThongTinSinhVien(txtMSSV.Text) != null)
                    lblHoTenSV.Text = svDao.LayThongTinSinhVien(txtMSSV.Text).Ten;
                else
                    lblHoTenSV.Text = "không tim thấy sinh viên cần tìm";
            }
            lblHoTenSV.Visible = true;
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            svDao.themSinhVien(txtIDnhom.Text, txtMaDeTai.Text);
        }
        private LuanVan LoadData()
        {
            DateTime dtStart, dtEnd;

            if (hocKi == "Kỳ 1")
            {
                MessageBox.Show(namHoc.Substring(0, 4));
                dtStart = new DateTime(Int32.Parse(namHoc.Substring(0, 4)), 8, 25);
                dtEnd = new DateTime(Int32.Parse(namHoc.Substring(0, 4)) + 1, 1, 1);
            }
            else if (hocKi == "Kỳ 2")
            {
                dtStart = new DateTime(Int32.Parse(namHoc.Substring(0, 4)), 1, 1);
                dtEnd = new DateTime(Int32.Parse(namHoc.Substring(0, 4)), 6, 1);
            }
            else
            {
                dtStart = new DateTime(Int32.Parse(namHoc.Substring(0, 4)), 6, 1);
                dtEnd = new DateTime(Int32.Parse(namHoc.Substring(0, 4)), 8, 25);
            }
            return new LuanVan(txtMaDeTai.Text, txtTenDeTai.Text, txtTheLoai.Text, "abc", dtStart, dtEnd, txtMoTa.Text, txtChucNang.Text, "abc", SinhVienAccount.Khoa, SinhVienAccount.Nganh, cbbGVHD1.Text);
        }
        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            if (cbXacNhan.Checked == true)
            {
                LuanVan lv = LoadData();
                svDao.DangKy(SinhVienAccount, txtIDnhom.Text, txtMaDeTai.Text);
                svDao.DeXuatDeTai(lv);
            }
        }
    }
}
