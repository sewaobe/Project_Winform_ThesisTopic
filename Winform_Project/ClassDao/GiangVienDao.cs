using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_Project.ClassDoiTuong;
using Winform_Project.Model;

namespace Winform_Project.ClassDao
{
    internal class GiangVienDao
    {
        DBConnection db = new DBConnection();
        public GiangVienDao() { }
        public DataTable LoadData(string sqlStr)
        {
            return db.Load(sqlStr);
        }
        public void Them(LuanVan lv)
        {
            string sqlStr = string.Format("INSERT INTO ThongTinDeTai(MaDeTai, TenDeTai, SoLuong, MoTa, YeuCau, ChucNang, NgayBatDau, NgayKetThuc, TheLoai, Khoa, Nganh, TenGiangVien) " +
                                            "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}') ",
                                            lv.MaDeTai, lv.TenDeTai, lv.SoLuong, lv.MoTa, lv.YeuCau, lv.ChucNang, lv.NgayBatDau, lv.NgayKetThuc, lv.TheLoai, lv.Khoa, lv.Nganh, lv.TenGiangVien);
            db.ThucThi(sqlStr);
        }
        public void Sua(LuanVan lv)
        {
            string sqlStr = string.Format("UPDATE ThongTinDeTai SET TenDeTai = '{0}', SoLuong = '1', MoTa = '{2}', YeuCau = '{3}', ChucNang = '{4}', NgayBatDau = '{5}', NgayKetThuc='{6}'," +
                "TheLoai = '{7}', Khoa = '{8}', Nganh = '{9}' WHERE MaDeTai = '{10}'",lv.TenDeTai, lv.SoLuong, lv.MoTa, lv.YeuCau, lv.ChucNang, lv.NgayBatDau, lv.NgayKetThuc, lv.TheLoai, lv.Khoa, lv.Nganh,lv.MaDeTai);
            db.ThucThi(sqlStr);
        }
        public void Xoa(LuanVan lv)
        {
            string sqlStr = string.Format("DELETE FROM ThongTinDeTai WHERE MaDeTai = '{0}'", lv.MaDeTai);
            db.ThucThi(sqlStr);
        }
    }
}
