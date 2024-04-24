using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    public class NhiemVu
    {
        private string tieuDe;
        private DateTime thoiGianGui;
        private DateTime thoiGianKetThuc;
        private string tenNguoiGui;
        private string tenNguoiNhan;
        private string trangThai;
        private string noiDung;
        private string mSSV;
        private string maSoNhom;
        
        public NhiemVu(string tieuDe, DateTime thoiGianGui, DateTime thoiGianKetThuc, string tenNguoiGui, string tenNguoiNhan, string trangThai, string noiDung, string mssv, string maSoNhom)
        {
            TieuDe = tieuDe;
            ThoiGianGui = thoiGianGui;
            ThoiGianKetThuc = thoiGianKetThuc;
            TenNguoiGui = tenNguoiGui;
            TenNguoiNhan = tenNguoiNhan;
            TrangThai = trangThai;
            NoiDung = noiDung;
            MSSV = mssv;
            MaSoNhom = maSoNhom;
        }

        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public DateTime ThoiGianGui { get => thoiGianGui; set => thoiGianGui = value; }
        public DateTime ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
        public string TenNguoiGui { get => tenNguoiGui; set => tenNguoiGui = value; }
        public string TenNguoiNhan { get => tenNguoiNhan; set => tenNguoiNhan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string MSSV { get => mSSV; set => mSSV = value; }
        public string MaSoNhom { get => maSoNhom; set => maSoNhom = value; }
    }
}
