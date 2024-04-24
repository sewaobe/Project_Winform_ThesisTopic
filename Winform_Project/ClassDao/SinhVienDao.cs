﻿using System;
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
            string sqlStr = string.Format("INSERT INTO ThongTinDeTai(MaDeTai, TenDeTai, SoLuong, MoTa, YeuCau, ChucNang, TheLoai,CongNghe, Nganh, Khoa, HocKy, TenGiangVien) " +
                                            "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}') ",
                                            lv.MaDeTai, lv.TenDeTai, lv.SoLuong, lv.MoTa, lv.YeuCau, lv.ChucNang, lv.TheLoai, lv.CongNghe, lv.Nganh, lv.Khoa, lv.HocKy, lv.TenGiangVien);
            db.ThucThi(sqlStr);
        }
        public void DangKy(SinhVien svAccount, string masonhom, string madetai)
        {
            MessageBox.Show(svAccount.Ten);
            string sqlStr = string.Format("INSERT INTO ThongTinNhomDangKy(MSSV,HoTen,MaSoNhom,MaDeTai)" +
                                            "VALUES('{0}','{1}','{2}','{3}')",
                                            svAccount.Mssv, svAccount.Ten, masonhom, madetai);
            db.ThucThi(sqlStr);
            sqlStr = string.Format("UPDATE SinhVien SET MaSoNhom = '{0}' WHERE MSSV='{1}'", masonhom, svAccount.Mssv);
            db.ThucThi(sqlStr);
            sqlStr = string.Format("UPDATE ThongTinDeTai SET TrangThai = '{0}' WHERE MaDeTai='{1}'", "Chua duyet", madetai);
            db.ThucThi(sqlStr);
        }
        
        public SinhVien LayThongTinSinhVien(string MSSV)
        {
            string sqlStr = string.Format("SELECT * FROM SinhVien WHERE MSSV={0}", MSSV);
            DataTable dtSinhVien = db.Load(sqlStr);
            if (dtSinhVien.Rows.Count > 0)
            {
                //DateTime dt =Convert.ToDateTime(dtSinhVien.Rows[0][3]);
                sinhvien = new SinhVien(dtSinhVien.Rows[0][1].ToString(), dtSinhVien.Rows[0][2].ToString(), Convert.ToDateTime(dtSinhVien.Rows[0][3]), dtSinhVien.Rows[0][4].ToString(), dtSinhVien.Rows[0][5].ToString(), dtSinhVien.Rows[0][6].ToString(), dtSinhVien.Rows[0][0].ToString(), dtSinhVien.Rows[0][7].ToString());
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
            sqlStr = string.Format("UPDATE SinhVien SET MaSoNhom = '{0}' WHERE MSSV='{1}'", masonhom, sinhvien.Mssv);
            db.ThucThi(sqlStr);
        }
        public void guiBaoCao(string MaSoNhom, string MaDeTai, string FileBaoCao)
        {
            DataTable dtTienDo = db.Load(string.Format("SELECT * From TienDo Where MaSoNhom='{0}'", MaSoNhom));
            MessageBox.Show((dtTienDo.Rows.Count + 1).ToString());
            string sqlStr = string.Format("INSERT INTO TienDo(MaSoNhom,MaDeTai,FileBaoCao,LanBaoCao)" +
                                            "VALUES('{0}','{1}','{2}','{3}')",
                                            MaSoNhom, MaDeTai, FileBaoCao, (dtTienDo.Rows.Count + 1).ToString());
            db.ThucThi(sqlStr);
        }
        public void docThongBao(ThongBao tb)
        {
            string sqlStr = string.Format("UPDATE ThongBao SET TrangThai='Da Doc' Where MaSoNhom='{0}'",
                                            tb.Masonhom);
            db.ThucThi(sqlStr);
        }
        public void GuiTinNhan(TinNhan tinnhan)
        {
            string sqlStr = string.Format("INSERT INTO Messenger(NguoiGui,NguoiNhan,NoiDung,ThoiGianGui)" +
                                            "VALUES('{0}','{1}','{2}','{3}')",
                                            tinnhan.Nguoigui, tinnhan.Nguoinhan, tinnhan.Noidung, tinnhan.Thoigiangui);
            db.ThucThi(sqlStr);
        }
    }
}
