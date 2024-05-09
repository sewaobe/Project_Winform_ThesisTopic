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
    public partial class uc_SV_ThongTin : UserControl
    {
        public SinhVien sv = new SinhVien();
        public static int flag = 0;
        public uc_SV_ThongTin()
        {
            InitializeComponent();
        }
        public uc_SV_ThongTin(GiangVien gv)
        {
            InitializeComponent();
            lblTen.Text = gv.Ten;
            lblMSSV.Text = "Giảng viên";
            picAvatar.Image = Properties.Resources.teacher;
            btnThayDoiTroChuyen.Tag = flag;
        }
        public uc_SV_ThongTin(SinhVien sinhvien)
        {
            InitializeComponent();
            lblMSSV.Text = sinhvien.Mssv;
            lblTen.Text = sinhvien.Ten;
            btnThayDoiTroChuyen.Tag = flag;
            this.sv = sinhvien;
        }

        private void uc_SV_ThongTin_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        

        private void uc_SV_ThongTin_Load(object sender, EventArgs e)
        {
            
        }

        private void uc_SV_ThongTin_MouseLeave(object sender, EventArgs e)
        {
            if (panel_User.Visible == true)
                BackColor = Color.White;
            BackColor = Color.WhiteSmoke;
        }
    }
}
