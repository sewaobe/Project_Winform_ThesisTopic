using Bunifu.UI.WinForms.Extensions;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.EntityModel;

namespace Winform_Project
{
    public partial class ucDeTai : UserControl
    {
        public ThongTinDeTaii lv;
        public ucDeTai()
        {
            InitializeComponent();
        }
        public ucDeTai(ThongTinDeTaii lv)
        {
            InitializeComponent();
            this.lv = lv;
            lblMaDeTai.Text = lv.MaDeTai;
            lblTenDeTai.Text = lv.TenDeTai;
            lblTheLoai.Text = lv.TheLoai;
            lblTrangThai.Text = lv.TrangThai;
            if (lblTrangThai.Text == "Chua duyet")
                lblTrangThai.ForeColor = Color.Olive;
            else if (lblTrangThai.Text == "Chua dang ki")
                lblTrangThai.ForeColor = Color.Red;
            else if (lblTrangThai.Text == "Da duyet")
                lblTrangThai.ForeColor = Color.Blue;
            else
                lblTrangThai.ForeColor = Color.LimeGreen;
            string[] cong_nghe = lv.CongNghe.Split(',');
            btnCongNghe.Text = cong_nghe[0];
            int x_location = btnCongNghe.Location.X;
            for (int i =1; i<cong_nghe.Length; i++)
            {
                Guna2Button btn = new Guna2Button();
                btn.Width = btnCongNghe.Width;
                btn.Height = btnCongNghe.Height;
                btn.FillColor = btnCongNghe.FillColor;
                btn.AutoRoundedCorners = btnCongNghe.AutoRoundedCorners;
                btn.Text = cong_nghe[i];
                btn.ForeColor = btnCongNghe.ForeColor;
                x_location += btnCongNghe.Width + 15;
                btn.Location = new Point(x_location, btnCongNghe.Location.Y);
                fLoCongNghe.Controls.Add(btn);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
