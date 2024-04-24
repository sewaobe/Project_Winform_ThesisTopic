﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDoiTuong;
using Winform_Project.Model;

namespace Winform_Project.ClassDao
{
    internal class GiangVienDao
    {
        DBConnection db = new DBConnection();
        public GiangVienDao() { }
        public GiangVien LayThongTinGiangVien(string hoTen)
        {
            string sqlStr = string.Format("SELECT * FROM GiangVien WHERE HoTen = '{0}'", hoTen);
            DataTable dtGiangVien = db.Load(sqlStr);
            if(dtGiangVien.Rows.Count > 0)
            {
                GiangVien gv = new GiangVien(dtGiangVien.Rows[0]["HoTen"].ToString(),
                                             dtGiangVien.Rows[0]["GioiTinh"].ToString(),
                                             Convert.ToDateTime(dtGiangVien.Rows[0]["NgaySinh"]),
                                             dtGiangVien.Rows[0]["SDT"].ToString(),
                                             dtGiangVien.Rows[0]["Email"].ToString(),
                                             dtGiangVien.Rows[0]["Facebook"].ToString());
                return gv;
            }
            return null;
        }
        public void ThemNhiemVu(NhiemVu nv)
        {
            string sqlStr = string.Format("INSERT INTO NhiemVu(TieuDe, ThoiGianGui, ThoiGianKetThuc, TenNguoiNhan, TenNguoiGui, TrangThai, NoiDung)" +
                                           $"VALUES ('{nv.TieuDe}', '{nv.ThoiGianGui}', '{nv.ThoiGianKetThuc}', '{nv.TenNguoiNhan}', '{nv.TenNguoiGui}', '{nv.TrangThai}'), '{nv.NoiDung}'");
            db.ThucThi(sqlStr);
        }
        public DataTable LoadData(string sqlStr)
        {
            return db.Load(sqlStr);
        }
        public DataTable LayThongTinDeTai(string maDeTai)
        {
            string sqlStr = string.Format($"SELECT * FROM ThongTinDeTai WHERE MaDeTai = '{maDeTai}'");
            return db.Load(sqlStr);
        }
        public DataTable LayThongTinSinhVien(string maNhom)
        {
            string sqlStr = string.Format($"SELECT * FROM SinhVien Where MaSoNhom = '{maNhom}'");
            return db.Load(sqlStr);
        }
        public void Them(LuanVan lv)
        {
            string sqlStr = string.Format("INSERT INTO ThongTinDeTai(MaDeTai, TenDeTai, SoLuong, MoTa, YeuCau, ChucNang, HocKy,CongNghe, TheLoai, Khoa, Nganh, TenGiangVien, TrangThai) " +
                                            "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}') ",
                                            lv.MaDeTai, lv.TenDeTai, lv.SoLuong, lv.MoTa, lv.YeuCau, lv.ChucNang, lv.HocKy,lv.CongNghe, lv.TheLoai, lv.Khoa, lv.Nganh, lv.TenGiangVien,lv.TrangThai);
            db.ThucThi(sqlStr);
        }
        public void Sua(LuanVan lv)
        {
            string sqlStr = string.Format("UPDATE ThongTinDeTai SET TenDeTai = '{0}', SoLuong = '{1}', MoTa = '{2}', YeuCau = '{3}', ChucNang = '{4}', HocKy = '{5}', CongNghe='{6}'," +
                "TheLoai = '{7}', Khoa = '{8}', Nganh = '{9}' WHERE MaDeTai = '{10}'",lv.TenDeTai, lv.SoLuong, lv.MoTa, lv.YeuCau, lv.ChucNang, lv.HocKy, lv.CongNghe, lv.TheLoai, lv.Khoa, lv.Nganh,lv.MaDeTai);
            db.ThucThi(sqlStr);
        }
        public void Xoa(LuanVan lv)
        {
            string sqlStr = string.Format("DELETE FROM ThongTinDeTai WHERE MaDeTai = '{0}'", lv.MaDeTai);
            db.ThucThi(sqlStr);
        }
        
        public void DuyetDeTai(string MSDT,string MSN)
        {
            string sqlStr1 = string.Format("UPDATE ThongTinDeTai SET TrangThai = 'Da duyet' Where MaDeTai = '{0}'", MSDT);
            db.ThucThi(sqlStr1);
            string sqlStr2 = string.Format("UPDATE ThongTinNhomDangKy SET  TrangThai = 'Da duyet' Where  MaSoNhom='{0}'",  MSN);
            db.ThucThi(sqlStr2);

        }
    }
}
