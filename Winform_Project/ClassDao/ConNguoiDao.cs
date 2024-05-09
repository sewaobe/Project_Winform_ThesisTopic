using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
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
        public static int conNguoi = 0;
        public ConNguoiDao()
        {
        }
        //New
        public DataTable TimThongTinSinhVien(string mssv)
        {
            string sqlStr = string.Format("SELECT * FROM SinhVien WHERE MSSV LIKE '{0}%'", mssv);
            return db.Load(sqlStr);
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
        public DataTable LayThongTinDeTaiDangCapNhat(string trangThai)
        {
            string sqlStr = string.Format($"SELECT * FROM ThongTinDeTai WHERE TrangThai = '{trangThai}'");
            return db.Load(sqlStr);
        }
        public DataTable LayThongTinTatCaNhomDangKy()
        {
            string sqlStr = string.Format("SELECT * FROM ThongTinNhomDangKy");
            return db.Load(sqlStr);
        }
        public DataTable LayThongTinSinhVien(string maNhom)
        {
            string sqlStr = string.Format($"SELECT * FROM SinhVien Where MaSoNhom = '{maNhom}'");
            return db.Load(sqlStr);
        }
        public DataTable LayThongTinLichHen(string maNhom)
        {
            string sqlStr = string.Format($"SELECT * FROM Lich WHERE MaSoNhom = '{maNhom}'");
            return db.Load(sqlStr);
        }
        public DataTable LayThongTinChat(string nguoiNhan, string nguoiGui)
        {
            string sqlStr = string.Format($"SELECT * FROM Messenger WHERE (NguoiNhan = '{nguoiNhan}' AND NguoiGui = '{nguoiGui}') OR (NguoiNhan = '{nguoiGui}' AND NguoiGui = '{nguoiNhan}')");
            return db.Load(sqlStr);
        }
        public void GuiTinNhan(TinNhan tn)
        {
            using (Stream stream = File.OpenRead(tn.Noidungdacbiet))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string extn = new FileInfo(tn.Noidungdacbiet).Extension;

                string sqlStr = string.Format($"INSERT INTO Messenger(NguoiGui, NguoiNhan, NoiDung, NoiDungDacBiet, ThoiGianGui)" +
                                            $" Values('{tn.Nguoigui}', '{tn.Nguoinhan}', '{tn.Noidung}',@File,'{tn.Thoigiangui}' )");
                SinhVienDao.buffer_s = buffer;
                db.ThucThi(sqlStr);
            }
        }
        //New
        public void MoTinNhanDacBiet(TinNhan tn)
        {
            string sqlStr = string.Format($"SELECT * FROM Messenger WHERE ThoiGianGui = '{tn.Thoigiangui}'");
            DataTable dtTinNhan = db.Load(sqlStr);
            if (dtTinNhan.Rows.Count > 0)
            {
                var file = (byte[])(dtTinNhan.Rows[0]["NoiDungDacBiet"]);
                File.WriteAllBytes(tn.Noidung, file);
                System.Diagnostics.Process.Start(tn.Noidung);
            }
        }
        public DataTable LayThongTinTatCaSinhVien()
        {
            string sqlStr = string.Format($"SELECT * FROM SinhVien");
            return db.Load(sqlStr);
        }



    }
}
