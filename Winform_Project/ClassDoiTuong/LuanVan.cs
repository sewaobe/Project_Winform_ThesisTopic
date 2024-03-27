using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    internal class LuanVan
    {
        private string maDeTai;
        private string tenDeTai;
        private string theLoai;
        private string soLuong;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string moTa;
        private string chucNang;
        private string yeuCau;
        private string khoa;
        private string nganh;
        private string tenGiangVien;
        public LuanVan()
        {
        }

        public LuanVan(string maDeTai, string tenDeTai, string theLoai, string soLuong, DateTime ngayBatDau, DateTime ngayKetThuc, string moTa, string chucNang, string yeuCau, string khoa, string nganh, string tenGiangVien)
        {
            this.MaDeTai = maDeTai;
            this.TenDeTai = tenDeTai;
            this.TheLoai = theLoai;
            this.SoLuong = soLuong;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.MoTa = moTa;
            this.ChucNang = chucNang;
            this.YeuCau = yeuCau;
            this.Khoa = khoa;
            this.Nganh = nganh;
            this.TenGiangVien = tenGiangVien;
        }
        
        public string MaDeTai { get => maDeTai; set => maDeTai = value; }
        public string TenDeTai { get => tenDeTai; set => tenDeTai = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string ChucNang { get => chucNang; set => chucNang = value; }
        public string YeuCau { get => yeuCau; set => yeuCau = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public string TenGiangVien { get => tenGiangVien; set => tenGiangVien = value; }
    }
}
