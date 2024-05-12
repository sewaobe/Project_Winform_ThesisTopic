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
using Winform_Project.FormSinhVien;

namespace Winform_Project
{
    public partial class FLichHen : Form
    {
        DateTime dateTimeStart, dateTimeEnd;
        GiangVienDao gvDao = new GiangVienDao();
        public FLichHen()
        {
            InitializeComponent();

            //Chuẩn hóa uc_Lich_ThoiGian.thoiGianBatDau về thời gian bắt đầu và kết thúc
            List<string[]> tmp = new List<string[]>();
            foreach(var item in uc_Lich_ThoiGian.thoiGianBatDau)
            {
                string[] result = item.Split('h', '-', '>', ' ');
                tmp.Add(result);
            }
            uc_Lich_ThoiGian.thoiGianBatDau = new List<string>();
            string ans = "";
            foreach(var item in tmp)
            {
                foreach(var result in item)
                {
                    if (result != "")
                    {
                        if (ans.Contains(result) == false)
                            ans += result + "\n";
                        else
                            ans = ans.Replace(result, string.Empty);
                    }
                }
            }
            string[] tmp2 = ans.Split();
            dateTimeStart = new DateTime(uc_Calendar.Nam, uc_Calendar.Thang, uc_Lich_Thu_Ngay.Ngay, Convert.ToInt32(tmp2[0]), 0, 0);
            dateTimeEnd = new DateTime(uc_Calendar.Nam, uc_Calendar.Thang, uc_Lich_Thu_Ngay.Ngay, Convert.ToInt32(tmp2[tmp2.Length-2]), 0, 0);
            ThoiGianBatDau.Value = dateTimeStart;
            ThoiGianKetThuc.Value = dateTimeEnd;
            DTPTimeStart.Value = dateTimeStart;
            DTPTimeEnd.Value = dateTimeEnd;
        }
        public FLichHen(Lichh lich)
        {
            InitializeComponent();

            txtTieuDe.Text = lich.TieuDe;
            txtNoiDung.Text = lich.NoiDung;
            ThoiGianBatDau.Value = lich.ThoiGianBatDau;
            ThoiGianKetThuc.Value = lich.ThoiGianKetThuc.Value;
            DTPTimeStart.Value = lich.ThoiGianBatDau;
            DTPTimeEnd.Value = lich.ThoiGianKetThuc.Value;
            cbbSuKien.StartIndex = cbbSuKien.Items.IndexOf(lich.SuKien);
            btnGui.Visible = false;

        }
        private void FLichHen_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            Lichh lich = new Lichh { TieuDe = txtTieuDe.Text, 
                                    NoiDung = txtNoiDung.Text, 
                                    ThoiGianBatDau = dateTimeStart, 
                                    ThoiGianKetThuc = dateTimeEnd, 
                                    SuKien = cbbSuKien.Text, 
                                    MaSoNhom = FGiangVien_Controls.maSoNhom };
            gvDao.DatLich(lich);
            FSinhVien_Controls.flag_Lich = 1;
            this.Hide();
            
        }
    }
}
