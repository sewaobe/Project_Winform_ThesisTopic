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
    public partial class ucBaoCao : UserControl
    {
        public ucBaoCao()
        {
            InitializeComponent();
        }
        public ucBaoCao(BaoCao bc)
        {
            InitializeComponent();
            lblTieuDe.Text = bc.TieuDe;
            lblThoiGianGui.Text = bc.ThoiGianGui;
            lblFile.Text = bc.File;
            lblTrangThai.Text = bc.TrangThai;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
