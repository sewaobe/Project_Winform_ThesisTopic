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
        public BaoCao()
        {

        }
        public BaoCao(string tieuDe, string thoiGianGui, string file, string trangThai)
        {
            TieuDe = tieuDe;
            ThoiGianGui = thoiGianGui;
            File = file;
            TrangThai = trangThai;
        }

        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string ThoiGianGui { get => thoiGianGui; set => thoiGianGui = value; }
        public string File { get => file; set => file = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
