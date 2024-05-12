using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.EntityModel;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Progress_Check : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        SinhVienn SinhVienAccount = FDangNhap.SinhVienAccount;
        public FSinhVien_Progress_Check()
        {
            InitializeComponent();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void FSinhVien_Progress_Check_Load(object sender, EventArgs e)
        {

            
        }

        private void txtNhanXet_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtDanhGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BaoCaoo bc = new BaoCaoo{TieuDe = txtFile.Text,
                       ThoiGianGui = DateTime.Now.ToString(),
                       TienDo = "NULL",
                       NhanXet = "NULL",
                       MaSoNhom = SinhVienAccount.MaSoNhom,
                       TrangThai = "Dang cho" };
            svDao.Save_File(bc);
            this.Hide();

        }

        private void btnThemFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            txtFile.Text = open.FileName;
            txtTieuDe.Text = open.SafeFileName;
        }
    }
}
