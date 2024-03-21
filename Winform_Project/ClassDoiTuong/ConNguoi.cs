using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    internal class ConNguoi
    {
        private string ten;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sdt;

        public ConNguoi()
        {
        }

        public ConNguoi(string ten, string gioiTinh, DateTime ngaySinh, string sdt)
        {
            this.Ten = ten;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.Sdt = sdt;
        }

        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
