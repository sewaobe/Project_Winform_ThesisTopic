using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    public class Lich
    {
        private string tieuDe;
        private string noiDung;
        private DateTime thoiGianBatDau;
        private DateTime thoiGianKetThuc;
        private string suKien;
        private string maSoNhom;

        public Lich(string tieuDe, string noiDung, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string suKien, string maSoNhom)
        {
            TieuDe = tieuDe;
            NoiDung = noiDung;
            ThoiGianBatDau = thoiGianBatDau;
            ThoiGianKetThuc = thoiGianKetThuc;
            SuKien = suKien;
            MaSoNhom = maSoNhom;
        }

        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public DateTime ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
        public string SuKien { get => suKien; set => suKien = value; }
        public string MaSoNhom { get => maSoNhom; set => maSoNhom = value; }
    }
}
