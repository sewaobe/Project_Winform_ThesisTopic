using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    public class LuanVan
    {
       
        private string maDeTai;
        private string tenDeTai;
        private string theLoai;
        private string soLuong;
        private string hocKy;
        private string moTa;
        private string chucNang;
        private string yeuCau;
        private string khoa;
        private string nganh;
        private string tenGiangVien;
        private string congNghe;
        private string trangThai;
        private string diem;
        public LuanVan()
        {
        }
        public LuanVan(string maDeTai, string diem)
        {
            MaDeTai = maDeTai;
            Diem = diem;
        }
        public LuanVan(string maDeTai, string tenDeTai, string theLoai, string soLuong, string moTa, string chucNang, string yeuCau, string congNghe, string khoa, string nganh,string hocKy, string tenGiangVien, string trangThai)
        {
            this.MaDeTai = maDeTai;
            this.TenDeTai = tenDeTai;
            this.TheLoai = theLoai;
            this.SoLuong = soLuong;
            this.MoTa = moTa;
            this.ChucNang = chucNang;
            this.YeuCau = yeuCau;
            this.Khoa = khoa;
            this.Nganh = nganh;
            this.TenGiangVien = tenGiangVien;
            this.CongNghe = congNghe;
            this.HocKy = hocKy;
            this.TrangThai = trangThai;
        }
        [Required]
        [Range(minimum:1,maximum:3,ErrorMessage ="123")]
        public string MaDeTai { get => maDeTai; set => maDeTai = value; }
        public string TenDeTai { get => tenDeTai; set => tenDeTai = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string ChucNang { get => chucNang; set => chucNang = value; }
        public string YeuCau { get => yeuCau; set => yeuCau = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public string TenGiangVien { get => tenGiangVien; set => tenGiangVien = value; }
        public string CongNghe { get => congNghe; set => congNghe = value; }
        public string HocKy { get => hocKy; set => hocKy = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string Diem { get => diem; set => diem = value; }
    }
}
