using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    internal class SinhVien:ConNguoi
    {
        private string khoa;
        private string nganh;
        private string mssv;

        public SinhVien()
        {
        }

        public SinhVien(string ten, string gioiTinh, DateTime ngaySinh, string sdt, string khoa, string nganh, string mssv) : base(ten, gioiTinh, ngaySinh, sdt)
        {
            this.Mssv = mssv;   
            this.Khoa = khoa;   
            this.Nganh = nganh;
        }

        public string Khoa { get => khoa; set => khoa = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public string Mssv { get => mssv; set => mssv = value; }
    }
}
