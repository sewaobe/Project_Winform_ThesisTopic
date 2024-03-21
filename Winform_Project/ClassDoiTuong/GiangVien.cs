using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    internal class GiangVien : ConNguoi
    {
        private string email;
        private string facebook;

        public GiangVien()
        {
        }

        public GiangVien(string ten, string gioiTinh, DateTime ngaySinh, string sdt, string email, string facebook) : base(ten, gioiTinh, ngaySinh, sdt)
        {
            this.Email = email;
            this.Facebook = facebook;
        }

        public string Email { get => email; set => email = value; }
        public string Facebook { get => facebook; set => facebook = value; }
    }
}
