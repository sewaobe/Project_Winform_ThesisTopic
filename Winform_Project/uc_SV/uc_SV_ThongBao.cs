﻿using System;
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
using Winform_Project.FormSinhVien;

namespace Winform_Project
{
    public partial class uc_SV_ThongBao : UserControl
    {
        ThongBaoo thongbao = new ThongBaoo();
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        public uc_SV_ThongBao(ThongBaoo tb)
        {
            InitializeComponent();
            thongbao = tb;
            lblTieuDe.Text = tb.TieuDe;
            lblNguoiGui.Text = tb.TenGiangVien;
            lblThoiGianGui.Text = tb.ThoiGianGui;
        }

        private void uc_SV_ThongBao_Load(object sender, EventArgs e)
        {
            if (thongbao.TrangThai == "Da Doc")
            {
                pic.Image = Properties.Resources.letter_open;
            }
            else
            {
                pic.Image = Properties.Resources.letter_close;
            }
        }

        private void uc_SV_ThongBao_Click(object sender, EventArgs e)
        {
            conNguoiDao.docThongBao(thongbao);
            FSinhVien_Support_View fSinhVien_Support_View = new FSinhVien_Support_View();
            thongbao.TrangThai = "Da Doc";
            uc_SV_ThongBao_Load(sender, e);
            fSinhVien_Support_View.Text=thongbao.TieuDe;
            fSinhVien_Support_View.txtNoiDung.Text = thongbao.NoiDung;
/*            fSinhVien_Support_View.lblThoiGianKetThuc.Text="Thời gian kết thúc: " + thongbao.Thoigianketthuc.ToString();
*/            fSinhVien_Support_View.Show();
        }


        private void uc_SV_ThongBao_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void uc_SV_ThongBao_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Silver;
        }
    }
}
