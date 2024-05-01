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
using Winform_Project.FormGiangVien;
using Winform_Project.uc_GV;

namespace Winform_Project
{
    public partial class FGiangVien_Progress : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        public FGiangVien_Progress()
        {
            InitializeComponent();
        }

        
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void LoadUCTong(string ten, string soLuong, ucTongSoDeTai uc, int maMau1, int maMau2, int maMau3)
        {
            Color color = Color.FromArgb(maMau1, maMau2, maMau3);

            uc.lblTen.Text = ten;
            uc.lblSoLuong.Text = soLuong;
            uc.lblTen.BackColor = color;
            uc.lblSoLuong.BackColor = color;
            uc.pic.FillColor = color;
            uc.progressBar.FillColor = Color.White;
            uc.progressBar.BackColor = uc.pic.FillColor;
            uc.progressBar.ProgressColor2 = Color.FromArgb(53,41,123);
            uc.progressBar.ProgressColor = Color.FromArgb(53, 41, 123);
        }
        private void FGiangVien_Progress_Load(object sender, EventArgs e)
        {
            ucTongSoDeTai ucTongDeTai = this.ucTongSoDeTai;
            LoadUCTong("Tong de tai", "20", ucTongDeTai, 135, 206, 250);

            ucTongSoDeTai ucTongDeTaiDangKy = this.ucTongSoDeTaiDangKy;
            LoadUCTong("De tai da dang ky", "15", ucTongDeTaiDangKy, 144, 238, 144);

            ucTongSoDeTai ucTongDeTaiChuaDangKy = this.ucTongSoDeTaiChuaDangKy;
            LoadUCTong("De tai chua dang ky", "5", ucTongDeTaiChuaDangKy, 255, 128, 128);

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Load_Chart_Line()
        {
            DataTable dtBaoCao = gvDao.LayThongTinBaoCao(FGiangVien_Controls.maSoNhom);

            chartThongKeChatLuong.ChartAreas["ChartArea1"].AxisX.Title = "Tiêu đề báo cáo";
            chartThongKeChatLuong.ChartAreas["ChartArea1"].AxisY.Title = "Tiến độ (%)";

            for (int i = 0; i < dtBaoCao.Rows.Count; i++)
            {
                chartThongKeChatLuong.Series["chartLine"].Points.AddXY(dtBaoCao.Rows[i]["TieuDe"].ToString(), dtBaoCao.Rows[i]["TienDo"].ToString());
            }
        }
        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
