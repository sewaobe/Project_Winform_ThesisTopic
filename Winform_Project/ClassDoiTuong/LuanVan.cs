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
        [Required, RegularExpression(@"^\d+$", ErrorMessage = "Chỉ được nhập chữ số.")]
        [Range(minimum: 1, maximum: 100, ErrorMessage = "Số lượng chỉ từ 1 đến 100")]
        public string MaDeTai { get => maDeTai; set => maDeTai = value; }
        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s]+$", ErrorMessage = "Chỉ được nhập chữ cái và số.")]
        public string TenDeTai { get => tenDeTai; set => tenDeTai = value; }
        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s]+$", ErrorMessage = "Chỉ được nhập chữ cái và số.")]
        public string TheLoai { get => theLoai; set => theLoai = value; }
        [Required, RegularExpression(@"^\d+$", ErrorMessage = "Chỉ được nhập chữ số.")]
        [Range(minimum: 1, maximum: 4, ErrorMessage = "Số lượng chỉ từ 1 đến 4")]
        public string SoLuong { get => soLuong; set => soLuong = value; }
        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s\p{P}]+$", ErrorMessage = "Chỉ được nhập chữ cái, số và dấu câu.")]
        public string MoTa { get => moTa; set => moTa = value; }
        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s\p{P}]+$", ErrorMessage = "Chỉ được nhập chữ cái, số và dấu câu.")]
        public string ChucNang { get => chucNang; set => chucNang = value; }
        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s\p{P}]+$", ErrorMessage = "Chỉ được nhập chữ cái, số và dấu câu.")]
        public string YeuCau { get => yeuCau; set => yeuCau = value; }
        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Chỉ được nhập chữ cái.")]
        public string Khoa { get => khoa; set => khoa = value; }
        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Chỉ được nhập chữ cái.")]
        public string Nganh { get => nganh; set => nganh = value; }
        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Chỉ được nhập chữ cái.")]
        public string TenGiangVien { get => tenGiangVien; set => tenGiangVien = value; }
        [Required, RegularExpression(@"^[a-zA-Z.,?!'""-]+$", ErrorMessage = "Chỉ được nhập chữ cái và dấu câu.")]
        public string CongNghe { get => congNghe; set => congNghe = value; }
        public string HocKy { get => hocKy; set => hocKy = value; }
        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Chỉ được nhập chữ cái.")]
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string Diem { get => diem; set => diem = value; }
    }
}
