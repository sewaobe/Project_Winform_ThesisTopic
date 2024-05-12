using Guna.UI2.WinForms.Enums;
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
    public partial class ucBaoCao : UserControl
    {
        public BaoCaoo baoCao;
        public ucBaoCao()
        {
            InitializeComponent();
        }
        public ucBaoCao(BaoCaoo bc)
        {
            InitializeComponent();
            int indexS = bc.TieuDe.LastIndexOf("\\") + 1;
            int indexE = bc.TieuDe.LastIndexOf(".") - indexS;
            lblTieuDe.Text = bc.TieuDe.Substring(indexS,indexE);
            lblThoiGianGui.Text = bc.ThoiGianGui;
            lblFile.Text = bc.TieuDe.Substring(indexS,bc.TieuDe.Length-indexS);
            lblTrangThai.Text = bc.TrangThai;

            this.baoCao = bc;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
