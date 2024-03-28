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
            string sqlStr = string.Format("SELECT HoTen, ChucVu, MSSV FROM ThongTinDangNhap WHERE TenDangNhap='{0}' AND MatKhau='{1}'", tk.TenDangNhap, tk.MatKhau);
            DataTable dt = conNguoiDao.LoadData(sqlStr);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tai khoan hop le");
                if (dt.Rows[0][1].ToString() == "Giảng viên")
                {
                    FGiangVien fGiangVien = new FGiangVien();
                    fGiangVien.lblChucVu.Text = dt.Rows[0][1].ToString();
                    fGiangVien.lblTenGiangVien.Text = dt.Rows[0][0].ToString();
                    this.Hide();
                    fGiangVien.ShowDialog();

                }
                else
                {
                    FSinhVien.FSinhVien fSinhVien = new FSinhVien.FSinhVien();
                    fSinhVien.lblTen.Text = dt.Rows[0][0].ToString();
                    fSinhVien.lblChucVu.Text = dt.Rows[0][1].ToString();
                    fSinhVien.lblMSSV.Text = dt.Rows[0][2].ToString();
                    this.Hide();
                    fSinhVien.ShowDialog();

                }
                

            }
            else
            {
                MessageBox.Show("Tai khoan khong hop le!!!");
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
