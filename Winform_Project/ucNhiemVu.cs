using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Project
{
    public partial class ucNhiemVu : UserControl
    {
        public ucNhiemVu()
        {
            InitializeComponent();
        }
        public ucNhiemVu(string tieuDe, string thoiGian, string nguoiThucHien, string trangThai)
        {
            lblTieuDe.Text = tieuDe;    
            lblThoiGian.Text = thoiGian; 
            lblNguoiThucHien.Text = nguoiThucHien;
            lblTrangThai.Text = trangThai;
        }
    }
}
