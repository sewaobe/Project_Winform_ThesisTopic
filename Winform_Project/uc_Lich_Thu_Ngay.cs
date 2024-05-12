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
using Winform_Project.EntityModel;
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class uc_Lich_Thu_Ngay : UserControl
    {
        int Thang, Nam;
        public static int Ngay;
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        public uc_Lich_Thu_Ngay()
        {
            InitializeComponent();
        }

        private void uc_Lich_Thu_Ngay_Load(object sender, EventArgs e)
        {
            Load_Uc_Ngay();
            lblThangNam.Text = $"Tháng {uc_Calendar.Thang} Năm {uc_Calendar.Nam}";
        }
        private void Load_Uc_Ngay()
        {
            Thang = uc_Calendar.Thang;
            Nam = uc_Calendar.Nam;

            DateTime ngayDauTienCuaThang = new DateTime(Nam, Thang, 1);

            int tongNgayTrongThang = DateTime.DaysInMonth(Nam, Thang);

            int thu = Convert.ToInt32(ngayDauTienCuaThang.DayOfWeek.ToString("d"));
            for(int i =1; i<thu;i++)
            {
                uc_Lich_Ngay ucNgay =  new uc_Lich_Ngay();
                ucNgay.btnNgay.Text = "";
                fLoTrungTam.Controls.Add(ucNgay);
            }
            DataTable dtLich;
            List<Lichh> listLich = new List<Lichh>(); 
            if (FGiangVien_Controls.role == 1)
            {
                dtLich = conNguoiDao.LayThongTinLichHen(FDangNhap.SinhVienAccount.MaSoNhom);
            }
            else
            {
                dtLich = conNguoiDao.LayThongTinLichHen(FGiangVien_Controls.maSoNhom);
            }
            for (int i = 0; i < dtLich.Rows.Count; i++)
            {
                Lichh lich = new Lichh{TieuDe = dtLich.Rows[i]["TieuDe"].ToString(),
                                NoiDung = dtLich.Rows[i]["NoiDung"].ToString(),
                                ThoiGianBatDau = Convert.ToDateTime(dtLich.Rows[i]["ThoiGianBatDau"]),
                                ThoiGianKetThuc = Convert.ToDateTime(dtLich.Rows[i]["ThoiGianKetThuc"]),
                                SuKien = dtLich.Rows[i]["SuKien"].ToString(),
                                MaSoNhom = dtLich.Rows[i]["MaSoNhom"].ToString()
                };
                listLich.Add(lich);
            }
            for(int i = 1; i <= tongNgayTrongThang; i++)
            {
                uc_Lich_Ngay uc_Lich_Ngay = new uc_Lich_Ngay();
                uc_Lich_Ngay.btnNgay.Text = i.ToString();
                if (i == DateTime.Now.Day)
                    uc_Lich_Ngay.btnNgay.ForeColor = Color.Blue;
                foreach(var item in listLich)
                {
                    if(item.ThoiGianBatDau.Day == i && item.ThoiGianBatDau.Month == uc_Calendar.Thang && item.ThoiGianBatDau.Year == uc_Calendar.Nam) //Check ngày nào đã được hẹn -> Tô màu cho ngày đó theo sự kiện
                    {
                        
                        uc_Lich_Ngay.btnNgay.FillColor = Color.LightBlue;

                    }
                }
                uc_Lich_Ngay.btnNgay.Click += ucNgay_Click;
                fLoTrungTam.Controls.Add(uc_Lich_Ngay);

            }
        }
        private void ucNgay_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            uc_Lich_Ngay uc_Lich_Ngay = btn.Parent as uc_Lich_Ngay;
            Ngay = Convert.ToInt32(uc_Lich_Ngay.btnNgay.Text);

            //Khi click vao ngay -> fLoTrungTam cap nhat lai uc_Lich_ThoiGian
            uc_Lich_ThoiGian uc_Lich_ThoiGian = new uc_Lich_ThoiGian();
            uc_Calendar.fLoTrungTam.Controls.Clear();
            uc_Calendar.fLoTrungTam.Controls.Add(uc_Lich_ThoiGian);
        }



    }
}
