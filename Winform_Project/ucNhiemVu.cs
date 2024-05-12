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

namespace Winform_Project
{
    public partial class ucNhiemVu : UserControl
    {
        public NhiemVuu nhiemVu;
        public ucNhiemVu()
        {
            InitializeComponent();
        }
        public ucNhiemVu(NhiemVuu nhiemVu)
        {
            InitializeComponent();
            
            this.nhiemVu = nhiemVu;
            lblTieuDe.Text = nhiemVu.TieuDe;
            lblThoiGian.Text = nhiemVu.ThoiGianGui.Value.Day.ToString() +"/" + nhiemVu.ThoiGianGui.Value.Month.ToString() + "/" + nhiemVu.ThoiGianGui.Value.Year.ToString()  + " --> " + nhiemVu.ThoiGianKetThuc.Value.Day.ToString() + "/" + nhiemVu.ThoiGianKetThuc.Value.Month.ToString() + "/" + nhiemVu.ThoiGianKetThuc.Value.Year.ToString();
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
