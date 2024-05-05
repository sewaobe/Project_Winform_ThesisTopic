using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class uc_Lich_ThoiGian : UserControl
    {
        public static List<string> thoiGianBatDau;
        public uc_Lich_ThoiGian()
        {
            InitializeComponent();
            bunifuToolTip1.SetToolTip(btnThemLichHen, "Thêm lịch hẹn");
            thoiGianBatDau = new List<string>();
        }

        private void uc_Lich_ThoiGian_Load(object sender, EventArgs e)
        {
            Load_UC_ThoiGian();
        }
        private void Load_UC_ThoiGian()
        {
            fLoTrungTam.Controls.Clear();
            for(int i = 0; i <=23; i++)
            {
                uc_Lich_Ngay ucNgay = new uc_Lich_Ngay();
                if(i+1==24)
                    ucNgay.btnNgay.Text = $"{i}h -> 0h";
                else
                    ucNgay.btnNgay.Text = $"{i}h -> {i + 1}h";
                ucNgay.btnNgay.Click += ucNgay_Click;
                fLoTrungTam.Controls.Add(ucNgay);
            }
        }
        private void ucNgay_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            
            if (btn.FillColor == Color.WhiteSmoke)
            {
                btn.FillColor = Color.White;
                thoiGianBatDau.Remove(btn.Text);
            }
            else
            {
                btn.FillColor = Color.WhiteSmoke;

                thoiGianBatDau.Add(btn.Text);
            }
            
        }
        // Khi quay lai -> fLoTrungTam cap nhat uc_Lich_Thu_Ngay
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            
            uc_Lich_Thu_Ngay uc_Lich_Thu_Ngay = new uc_Lich_Thu_Ngay();
            uc_Calendar.fLoTrungTam.Controls.Clear();
            uc_Calendar.fLoTrungTam.Controls.Add(uc_Lich_Thu_Ngay);
        }

        //Khi click vào btnThemLichHen-> Đặt lịch hẹn
        private void btnThemLichHen_Click(object sender, EventArgs e)
        {
            
            FLichHen fLichHen = new FLichHen();
            fLichHen.ShowDialog();
        }
    }
}
