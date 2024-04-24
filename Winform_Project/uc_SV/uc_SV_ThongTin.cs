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
        SinhVien sv = new SinhVien();
        public uc_SV_ThongTin()
        {
            InitializeComponent();
        }
        public uc_SV_ThongTin(SinhVien sinhvien)
        {
            InitializeComponent();
            lblMSSV.Text = sinhvien.Mssv;
            lblTen.Text = sinhvien.Ten;
            sv = sinhvien;
        }
    }
}
