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
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class uc_Lich_ThoiGian : UserControl
    {
        public static List<string> thoiGianBatDau;
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        public uc_Lich_ThoiGian()
        {
            InitializeComponent();
            bunifuToolTip1.SetToolTip(btnThemLichHen, "Thêm lịch hẹn");
            thoiGianBatDau = new List<string>();
            if (FGiangVien_Controls.role == 1)
                btnThemLichHen.Visible = false;
            
        }

        private void uc_Lich_ThoiGian_Load(object sender, EventArgs e)
        {
            Load_UC_ThoiGian();
        }
        private void Load_UC_ThoiGian()
        {
            fLoTrungTam.Controls.Clear();
            //Check thời gian nào đã có lịch hẹn
            DataTable dtLich;
            List<Lich> listLich = new List<Lich>();
            if (FGiangVien_Controls.role == 1)
            {
                dtLich = conNguoiDao.LayThongTinLichHen(FDangNhap.SinhVienAccount.Masonhom);
            }
            else
            {
                dtLich = conNguoiDao.LayThongTinLichHen(FGiangVien_Controls.maSoNhom);
            }
            for (int i = 0; i < dtLich.Rows.Count; i++)
            {
                Lich lich = new Lich(dtLich.Rows[i]["TieuDe"].ToString(),
                                dtLich.Rows[i]["NoiDung"].ToString(),
                                Convert.ToDateTime(dtLich.Rows[i]["ThoiGianBatDau"]),
                                Convert.ToDateTime(dtLich.Rows[i]["ThoiGianKetThuc"]),
                                dtLich.Rows[i]["SuKien"].ToString(),
                                dtLich.Rows[i]["MaSoNhom"].ToString()
                                );
                listLich.Add(lich);
            }
            for (int i = 0; i <=23; i++)
            {
                uc_Lich_Ngay ucNgay = new uc_Lich_Ngay();
                if(i+1==24)
                    ucNgay.btnNgay.Text = $"{i}h -> 0h";
                else
                    ucNgay.btnNgay.Text = $"{i}h -> {i + 1}h";
                ucNgay.btnNgay.Tag = i;
                ucNgay.btnNgay.Click += ucNgay_Click;
                fLoTrungTam.Controls.Add(ucNgay);
            }

            foreach (var item in listLich)
            {
                if (uc_Calendar.Thang == item.ThoiGianBatDau.Month && uc_Calendar.Nam == item.ThoiGianBatDau.Year && uc_Lich_Thu_Ngay.Ngay == item.ThoiGianBatDau.Day)
                {
                    int khoangCach = item.ThoiGianKetThuc.Hour - item.ThoiGianBatDau.Hour;
                    while (khoangCach != 0)
                    {
                        khoangCach -= 1;

                        var uc = fLoTrungTam.Controls.Cast<uc_Lich_Ngay>().FirstOrDefault(q => Convert.ToInt32(q.btnNgay.Tag) == (item.ThoiGianBatDau.Hour + khoangCach));

                        if (item.SuKien == "Online meeting")
                            uc.btnNgay.FillColor = Color.PaleTurquoise;
                        else if (item.SuKien == "Offline meeting")
                            uc.btnNgay.FillColor = Color.PaleVioletRed;
                        else
                            uc.btnNgay.FillColor = Color.Plum;
                        uc.Tag = item;
                    }
                }
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
            else if(btn.FillColor == Color.White)
            {
                btn.FillColor = Color.WhiteSmoke;

                thoiGianBatDau.Add(btn.Text);
            }
            else
            {
                uc_Lich_Ngay uc = btn.Parent as uc_Lich_Ngay;
                FLichHen fLichHen = new FLichHen(uc.Tag as Lich);
                fLichHen.Show();
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
            if (thoiGianBatDau.Count > 0)
            {
                FLichHen fLichHen = new FLichHen();
                fLichHen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng lựa thời gian cần đặt lịch hẹn!!!!!!");
            }
        }
    }
}
