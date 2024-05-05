using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_Progress_Check : Form
    {
        BaoCao baoCao;
        GiangVienDao gvDao = new GiangVienDao();
        public FGiangVien_Progress_Check(BaoCao bc)
        {
            InitializeComponent();
            txtTieuDe.Text = bc.TieuDe;
            
            this.baoCao = bc;
        }
        public FGiangVien_Progress_Check()
        {
            InitializeComponent();
            
            
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            BaoCao bc = new BaoCao(txtTieuDe.Text, 
                                   DateTime.Now.ToString(),
                                   baoCao.File,
                                   txtNhanXet.Text,
                                   progress.Value.ToString(),
                                   baoCao.MaSoNhom,
                                   "Da duyet");
            gvDao.NhanXetBaoCao(bc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void progress_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            lblValueProgress.Visible = true;
            lblValueProgress.Text = progress.Value.ToString();
            lblValueProgress.Location = new Point(progress.Location.X + progress.Value*5/3, progress.Location.Y-20);
        }

        
    }
}
