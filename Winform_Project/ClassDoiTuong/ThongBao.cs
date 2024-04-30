    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    public class ThongBao
    {
        private string masonhom;
        private string tengiangvien;
        private string tieude;
        private string noidung;
        private string trangthai;
        private DateTime thoigiangui;
        public ThongBao() { }

        public ThongBao(string masonhom, string tengiangvien, string tieude, string noidung, string trangthai, DateTime thoigiangui)
        {
            this.masonhom = masonhom;
            this.tengiangvien = tengiangvien;
            this.tieude = tieude;
            this.noidung = noidung;
            this.trangthai = trangthai;
            this.thoigiangui = thoigiangui;
        }

        public string Masonhom { get => masonhom; set => masonhom = value; }
        public string Tengiangvien { get => tengiangvien; set => tengiangvien = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public DateTime Thoigiangui { get => thoigiangui; set => thoigiangui = value; }
    }
}
