using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.EntityModel;
using Winform_Project.FSinhVien;

namespace Winform_Project
{
    public partial class uc_SV_DeTai : UserControl
    {
        public ThongTinDeTaii luanvan;
        public uc_SV_DeTai(ThongTinDeTaii lv)
        {
            InitializeComponent();
            this.luanvan = lv;
            lblTenDeTai2.Text = lv.TenDeTai.ToString();
            lblMaDeTai2.Text=lv.MaDeTai.ToString();
            lblTheLoai2.Text = lv.TheLoai.ToString();
            lblGVHD2.Text=lv.TenGiangVien.ToString();
            lblHocKy2.Text=lv.HocKy.ToString();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            
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
