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

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_SupportTopic_Add : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        public FGiangVien_SupportTopic_Add()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhiemVu nhiemVu = new NhiemVu(txtTieuDe.Text,
                                          pckThoiGianBatDau.Value, 
                                          pckThoiGianKetThuc.Value, 
                                          txtNguoiGiaoViec.Text, 
                                          txtSinhVien.Text, 
                                          cbbTrangThai.Text, 
                                          txtNoiDung.Text,
                                          );
            gvDao.ThemNhiemVu(nhiemVu);
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            
        }
    }
}
