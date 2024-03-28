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

namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien_Reg_Done : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        LuanVan luanvan = new LuanVan();
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = new SinhVien("Bao", "", DateTime.Now, "", "", "", "22110285");

        public FSinhVien_Reg_Done()
        {
            InitializeComponent();
        }

        private void FSinhVien_Reg_Done_Load(object sender, EventArgs e)
        {

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
            svDao.themSinhVien(txtIDnhom.Text,txtMaDeTai.Text);
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(cbXacNhan.Checked == true)
            {
                svDao.DangKy(SinhVienAccount, txtIDnhom.Text, txtMaDeTai.Text);
            }    
        }
    }
}
