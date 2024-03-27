using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    public class TaiKhoanDangNhap
    {
        private string tenDangNhap;
        private string matKhau;

        public TaiKhoanDangNhap()
        {
        }

        public TaiKhoanDangNhap(string tenDangNhap, string matKhau)
        {
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
        }

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
