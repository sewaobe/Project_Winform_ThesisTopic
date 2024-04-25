using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    public class BaoCao
    {
        private string tieuDe;
        private string thoiGianGui;
        private string file;
        private string trangThai;
        private string nhanXet;
        private string tienDo;
        private string maSoNhom;
        public BaoCao(string tieuDe, string thoiGianGui, string file, string nhanXet, string tienDo, string maSoNhom, string trangThai)
        {
            TieuDe = tieuDe;
            ThoiGianGui = thoiGianGui;
            File = file;
            TrangThai = trangThai;
            NhanXet = nhanXet;
            TienDo = tienDo;
            MaSoNhom = maSoNhom;
        }
        public BaoCao(string tieuDe, string thoiGianGui, string file, string trangThai,string maSoNhom)
        {
            TieuDe = tieuDe;
            ThoiGianGui = thoiGianGui;
            File = file;
            TrangThai = trangThai;
            MaSoNhom = maSoNhom;
        }

        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string ThoiGianGui { get => thoiGianGui; set => thoiGianGui = value; }
        public string File { get => file; set => file = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string NhanXet { get => nhanXet; set => nhanXet = value; }
        public string TienDo { get => tienDo; set => tienDo = value; }
        public string MaSoNhom { get => maSoNhom; set => maSoNhom = value; }
    }
}
