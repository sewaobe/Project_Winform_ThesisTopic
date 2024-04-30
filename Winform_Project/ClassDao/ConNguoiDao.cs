using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDoiTuong;
using Winform_Project.Model;


namespace Winform_Project.ClassDao
{
    internal class ConNguoiDao
    {
        
        DBConnection db = new DBConnection();

        public ConNguoiDao()
        {
        }
        public DataTable XacNhanDangNhap(TaiKhoanDangNhap tk)
        {
            string sqlStr = string.Format("SELECT * FROM ThongTinDangNhap WHERE TenDangNhap='{0}' AND MatKhau='{1}'", tk.TenDangNhap, tk.MatKhau);
            return db.Load(sqlStr);
        }
        public DataTable LoadData(string sqlStr)
        {
            return db.Load(sqlStr);
        }
        public void Them(string sqlStr)
        {
            string sql = sqlStr;
        }
        public void docThongBao(ThongBao tb)
        {
            string sqlStr = string.Format("UPDATE ThongBao SET TrangThai='Da Doc' Where TieuDe='{0}'",
                                            tb.Tieude);
            db.ThucThi(sqlStr);
        }
       
    }
}
