using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Project.FormGiangVien
{
    public partial class uc_Calendar : UserControl
    {
        public static int Thang = DateTime.Now.Month, Nam = DateTime.Now.Year;
        public static FlowLayoutPanel fLoTrungTam;
        public uc_Calendar()
        {
            InitializeComponent();
        }
    
        private void btnNamPhai_Click(object sender, EventArgs e)
        {
            lblNam.Text = (Convert.ToInt32(lblNam.Text) + 1).ToString();
            Nam = Convert.ToInt32(lblNam.Text);
            FGiangVien_Calendar_Load(sender, e);

        }

        private void btnNamTrai_Click(object sender, EventArgs e)
        {
            lblNam.Text = (Convert.ToInt32(lblNam.Text) - 1).ToString();
            Nam = Convert.ToInt32(lblNam.Text);
            FGiangVien_Calendar_Load(sender, e);

        }
        private void LayThang(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            Thang = Convert.ToInt32(btn.Tag.ToString());
            FGiangVien_Calendar_Load(sender, e);
        }

       
        private void Load_UC()
        {
            fLoTrungTamThang.Controls.Clear();
            for (int i = 1; i <= 12; i++)
            {
                uc_Lich_Thang ucThang = new uc_Lich_Thang();
                ucThang.btnThang.Text = "Tháng " + i.ToString();
                ucThang.btnThang.Tag = i;
                ucThang.btnThang.Click += LayThang;
                fLoTrungTamThang.Controls.Add(ucThang);
            }
            fLoTrungTamNgay.Controls.Clear();
            uc_Lich_Thu_Ngay ucThuNgay = new uc_Lich_Thu_Ngay();
            fLoTrungTamNgay.Controls.Add(ucThuNgay);
        }
        private void HienThiChuThich(object sender, EventArgs e)
        {
            Guna2CirclePictureBox pck = sender as Guna2CirclePictureBox;
            lblLoaiSuKien.Visible = true;
            lblLoaiSuKien.Text = pck.Tag.ToString();
        }
        private void TatChuThich(object sender, EventArgs e)
        {
            lblLoaiSuKien.Visible = false;
        }
        private void FGiangVien_Calendar_Load(object sender, EventArgs e)
        {
            fLoTrungTam = fLoTrungTamNgay;
            Load_UC();
            bgkHenTrucTuyen.MouseHover += HienThiChuThich;
            bgkHenTrucTuyen.MouseLeave += TatChuThich;
            bgkHenGapMat.MouseHover += HienThiChuThich;
            bgkHenGapMat.MouseLeave += TatChuThich; 
            bgkKhac.MouseHover += HienThiChuThich;
            bgkKhac.MouseLeave += TatChuThich;
        }
    }
}
