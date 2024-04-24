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
using Winform_Project.FSinhVien;

namespace Winform_Project
{
    public partial class uc_SV_DeTai : UserControl
    {
        LuanVan luanvan = new LuanVan();
        public uc_SV_DeTai(LuanVan lv)
        {
            InitializeComponent();
            luanvan = lv;
            lblTenDeTai2.Text = lv.TenDeTai.ToString();
            lblMaDeTai2.Text=lv.MaDeTai.ToString();
            lblTheLoai2.Text = lv.TheLoai.ToString();
            lblGVHD2.Text=lv.TenGiangVien.ToString();
            lblHocKy2.Text=lv.HocKy.ToString();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FSinhVien_Reg_Done fSinhVien_Reg_Done = new FSinhVien_Reg_Done(luanvan);
            fSinhVien_Reg_Done.ShowDialog();
            this.Show();
        }

        private void uc_SV_DeTai_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void uc_SV_DeTai_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(114, 204, 156);
        }
    }
}
