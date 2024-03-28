using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDoiTuong;
using Winform_Project.Model;

namespace Winform_Project.ClassDao
{
    internal class SinhVienDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        DBConnection db = new DBConnection();
        SinhVien sinhvien = new SinhVien();
        public SinhVienDao() { }
        public DataTable LoadData(string sqlStr)
        {
            return db.Load(sqlStr);
        }
        public void DeXuatDeTai(LuanVan lv)
        {
            string sqlStr = string.Format("INSERT INTO ThongTinDeTai(MaDeTai, TenDeTai, SoLuong, MoTa, YeuCau, ChucNang, NgayBatDau, NgayKetThuc, TheLoai, Khoa, Nganh, TenGiangVien) " +
                                            "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}') ",
                                            lv.MaDeTai, lv.TenDeTai, lv.SoLuong, lv.MoTa, lv.YeuCau, lv.ChucNang, lv.NgayBatDau, lv.NgayKetThuc, lv.TheLoai, lv.Khoa, lv.Nganh, lv.TenGiangVien);
            db.ThucThi(sqlStr);
        }
        public void DangKy(SinhVien svAccount, string masonhom, string madetai)
        {
            MessageBox.Show(svAccount.Ten);
            string sqlStr = string.Format("INSERT INTO ThongTinNhomDangKy(MSSV,HoTen,MaSoNhom,MaDeTai)" +
                                            "VALUES('{0}','{1}','{2}','{3}')",
                                            svAccount.Mssv, svAccount.Ten, masonhom, madetai);
            db.ThucThi(sqlStr);
        }
        public SinhVien LayThongTinSinhVien(string MSSV)
        {
            string sqlStr = string.Format("SELECT * FROM SinhVien WHERE MSSV={0}", MSSV);
            DataTable dtSinhVien = db.Load(sqlStr);
            if (dtSinhVien.Rows.Count > 0)
            {
                //DateTime dt =Convert.ToDateTime(dtSinhVien.Rows[0][3]);
                sinhvien = new SinhVien(dtSinhVien.Rows[0][1].ToString(), dtSinhVien.Rows[0][2].ToString(), Convert.ToDateTime(dtSinhVien.Rows[0][3]), dtSinhVien.Rows[0][4].ToString(), dtSinhVien.Rows[0][5].ToString(), dtSinhVien.Rows[0][6].ToString(), dtSinhVien.Rows[0][0].ToString());
                return sinhvien;
            }
            return null;
        }
        public void themSinhVien(string masonhom, string madetai)
        {
            MessageBox.Show(sinhvien.Ten);
            string sqlStr = string.Format("INSERT INTO ThongTinNhomDangKy(MSSV,HoTen,MaSoNhom,MaDeTai)" +
                                            "VALUES('{0}','{1}','{2}','{3}')",
                                            sinhvien.Mssv, sinhvien.Ten, masonhom, madetai);
            db.ThucThi(sqlStr);
        }
    }
}
