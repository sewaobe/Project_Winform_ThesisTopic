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

namespace Winform_Project
{
    public partial class ucNhiemVu : UserControl
    {
        public NhiemVu nhiemVu;
        public ucNhiemVu()
        {
            InitializeComponent();
        }
        public ucNhiemVu(NhiemVu nhiemVu)
        {
            InitializeComponent();
            
            this.nhiemVu = nhiemVu;
            lblTieuDe.Text = nhiemVu.TieuDe;
            lblThoiGian.Text = nhiemVu.ThoiGianGui.Day.ToString() +"/" + nhiemVu.ThoiGianGui.Month.ToString() + "/" + nhiemVu.ThoiGianGui.Year.ToString()  + " --> " + nhiemVu.ThoiGianKetThuc.Day.ToString() + "/" + nhiemVu.ThoiGianKetThuc.Month.ToString() + "/" + nhiemVu.ThoiGianKetThuc.Year.ToString();
            lblNguoiThucHien.Text = nhiemVu.TenNguoiNhan;
            lblTrangThai.Text = nhiemVu.TrangThai;
            if (lblTrangThai.Text == "Dang thuc hien")
            {
                panelBottom.FillColor = Color.Yellow;
                panelRight.FillColor = Color.Yellow;
            }
            else if (lblTrangThai.Text == "Da hoan thanh")
            {
                panelBottom.FillColor = Color.Lime;
                panelRight.FillColor = Color.Lime;
            }
            else
            {
                panelBottom.FillColor = Color.Red;
                panelRight.FillColor = Color.Red;
            }
        }
    }
}
