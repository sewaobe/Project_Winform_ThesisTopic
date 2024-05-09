using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    public class SinhVien : ConNguoi
    {
        private string khoa;
        private string nganh;
        private string mssv;
        private string masonhom;
        private string diem;

        public SinhVien()
        {
        }
        public SinhVien(string mssv, string diem)
        {
            Mssv = mssv;
            Diem = diem;
        }
        public SinhVien(string ten, string gioiTinh, DateTime ngaySinh, string sdt, string khoa, string nganh, string mssv,string masonhom) : base(ten, gioiTinh, ngaySinh, sdt)
        {
            this.Mssv = mssv;   
            this.Khoa = khoa;   
            this.Nganh = nganh;
            this.masonhom = masonhom;
        }

        public string Khoa { get => khoa; set => khoa = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public string Masonhom { get => masonhom; set => masonhom = value; }
        public string Diem { get => diem; set => diem = value; }
    }
}
