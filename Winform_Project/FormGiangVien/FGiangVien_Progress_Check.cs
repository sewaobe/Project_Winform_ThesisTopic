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
using Winform_Project.EntityModel;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_Progress_Check : Form
    {
        BaoCaoo baoCao;
        GiangVienDao gvDao = new GiangVienDao();
        public FGiangVien_Progress_Check(BaoCaoo bc)
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
            BaoCaoo bc = new BaoCaoo{TieuDe = txtTieuDe.Text,
                                   ThoiGianGui = DateTime.Now.ToString(),
                                   FileBaoCao = baoCao.FileBaoCao,
                                   NhanXet = txtNhanXet.Text,
                                   TienDo = progress.Value.ToString(),
                                   MaSoNhom = baoCao.MaSoNhom,
                                   TrangThai = "Da duyet"};
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
