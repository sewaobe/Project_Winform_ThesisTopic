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

namespace Winform_Project.uc_SV
{
    public partial class uc_SV_TongKet_DanhGia : UserControl
    {
        SinhVien sinhVien;
        public uc_SV_TongKet_DanhGia()
        {
            InitializeComponent();
        }
        public uc_SV_TongKet_DanhGia(SinhVien sv)
        {
            InitializeComponent();
            this.sinhVien = sv;
            lblTen.Text = sv.Ten;
            lblGioiTinh.Text = sv.GioiTinh;
            lblMSSV.Text = sv.Mssv;
            lblKhoa.Text = sv.Khoa;
            lblNganh.Text = sv.Nganh;
            picEdit.MouseHover += picHover;
            picEdit.MouseLeave += picLeave;
        }
        private void picHover(object sender, EventArgs e)
        {
            picEdit.BackColor = Color.WhiteSmoke;
        }
        private void picLeave(object sender, EventArgs e)
        {
            picEdit.BackColor = Color.White;
        }
        private void progress_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            lblDiem.Text = progress.Value.ToString();
            lblDiem.Visible = true;
            lblDiem.Location = new Point(progress.Location.X + progress.Value * 5 / 3, progress.Location.Y - 20);

        }
    }
}
