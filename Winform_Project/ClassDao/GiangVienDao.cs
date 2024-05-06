﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDoiTuong;
using Winform_Project.FormGiangVien;
using Winform_Project.Model;

namespace Winform_Project.ClassDao
{
    internal class GiangVienDao
    {
        DBConnection db = new DBConnection();
        public static byte[] buffer_s;
        public void DatLich(Lich lich)
        {
            string sqlStr = string.Format("INSERT INTO Lich(TieuDe, NoiDung, ThoiGianBatDau, ThoiGianKetThuc, SuKien, MaSoNhom)" +
                                           $"Values('{lich.TieuDe}','{lich.NoiDung}','{lich.ThoiGianBatDau}','{lich.ThoiGianKetThuc}','{lich.SuKien}','{lich.MaSoNhom}')");
            db.ThucThi(sqlStr);
        }
        public GiangVienDao() { }
        public List<LuanVan> ChuyenDoiDuLieuSangLuanVan(DataTable dtDeTai)
        {
            List<LuanVan> lv_list = new List<LuanVan>();
            for (int i = 0; i < dtDeTai.Rows.Count; i++)
            {
                string MaDeTai, TenDeTai, SoLuong, MoTa, YeuCau, ChucNang, TheLoai, CongNghe, Nganh, Khoa, HocKy, TenGiangVien, TrangThai;

                MaDeTai = dtDeTai.Rows[i]["MaDeTai"].ToString();
                TenDeTai = dtDeTai.Rows[i]["TenDeTai"].ToString();
                SoLuong = dtDeTai.Rows[i]["SoLuong"].ToString();
                MoTa = dtDeTai.Rows[i]["MoTa"].ToString();
                YeuCau = dtDeTai.Rows[i]["YeuCau"].ToString();
                ChucNang = dtDeTai.Rows[i]["ChucNang"].ToString();
                TheLoai = dtDeTai.Rows[i]["TheLoai"].ToString();
                CongNghe = dtDeTai.Rows[i]["CongNghe"].ToString();
                Nganh = dtDeTai.Rows[i]["Nganh"].ToString();
                Khoa = dtDeTai.Rows[i]["Khoa"].ToString();
                HocKy = dtDeTai.Rows[i]["HocKy"].ToString();
                TenGiangVien = dtDeTai.Rows[i]["TenGiangVien"].ToString();
                TrangThai = dtDeTai.Rows[i]["TrangThai"].ToString();
                LuanVan lv = new LuanVan(MaDeTai,
                                         TenDeTai,
                                         TheLoai,
                                         SoLuong,
                                         MoTa,
                                         ChucNang,
                                         YeuCau,
                                         CongNghe,
                                         Khoa,
                                         Nganh,
                                         HocKy,
                                         TenGiangVien,
                                         TrangThai);
                lv_list.Add(lv);
            }
            return lv_list is null ? null : lv_list;
        }
    
        public void Open_File(BaoCao baoCao)
        {
            string sqlStr = string.Format($"SELECT * FROM BaoCao WHERE ThoiGianGui = '{baoCao.ThoiGianGui}' AND MaSoNhom = '{baoCao.MaSoNhom}'");
            DataTable dtBaoCao = db.Load(sqlStr);
            if (dtBaoCao.Rows.Count > 0)
            {
                var file = (byte[])(dtBaoCao.Rows[0]["FileBaoCao"]);
                File.WriteAllBytes(baoCao.TieuDe, file);
                System.Diagnostics.Process.Start(baoCao.TieuDe);
            }
        }
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
            string sqlStr = string.Format("INSERT INTO NhiemVu(TieuDe, ThoiGianGui, ThoiGianKetThuc, TenNguoiNhan, TenNguoiGui, TrangThai, NoiDung, MSSV, MaSoNhom)" +
                                           $"VALUES ('{nv.TieuDe}', '{nv.ThoiGianGui}', '{nv.ThoiGianKetThuc}', '{nv.TenNguoiNhan}', '{nv.TenNguoiGui}', '{nv.TrangThai}', '{nv.NoiDung}', '{nv.MSSV}', '{nv.MaSoNhom}')");
            db.ThucThi(sqlStr);
        }
        public void ThongBaoToiSinhVien(ThongBao tb)
        {
            string sqlStr = string.Format("INSERT INTO ThongBao(TieuDe, TenGiangVien, MaSoNhom, NoiDung, ThoiGianGui, TrangThai)" +
                                          $"VALUES('{tb.Tieude}', '{tb.Tengiangvien}', '{tb.Masonhom}', '{tb.Noidung}', '{tb.Thoigiangui}','{tb.Trangthai}')");
            db.ThucThi(sqlStr);
        }
        
        public DataTable LoadData(string sqlStr)
        {
            return db.Load(sqlStr);
        }
        public List<ucNhiemVu> LayThongTinNhiemVu(string MSN, string trangThai, string MSSV)
        {
            List<ucNhiemVu> listUcNhiemVu = new List<ucNhiemVu>();
            string sqlStr;
            if(MSSV != "NULL")
            {
                if (trangThai == "Tat ca")
                {
                    sqlStr = string.Format($"SELECT * FROM NhiemVu WHERE MSSV = '{MSSV}'");
                }
                else
                {
                    sqlStr = string.Format($"SELECT * FROM NhiemVu WHERE TrangThai ='{trangThai}' AND MSSV = '{MSSV}'");
                }
            }
            else
            {
                if (trangThai == "Tat ca")
                {
                    sqlStr = string.Format($"SELECT * FROM NhiemVu WHERE MaSoNhom = '{MSN}'");
                }
                else
                {
                    sqlStr = string.Format($"SELECT * FROM NhiemVu WHERE MaSoNhom = '{MSN}' AND TrangThai ='{trangThai}'");
                }
            }
            DataTable dtNhiemVu = db.Load(sqlStr);
            if (dtNhiemVu.Rows.Count > 0)
            {
                for(int i = 0;i< dtNhiemVu.Rows.Count; i++)
                {
                    NhiemVu nhiemVu = new NhiemVu(dtNhiemVu.Rows[i]["TieuDe"].ToString(),
                                                 Convert.ToDateTime(dtNhiemVu.Rows[i]["ThoiGianGui"]),
                                                 Convert.ToDateTime(dtNhiemVu.Rows[i]["ThoiGianKetThuc"]),
                                                 dtNhiemVu.Rows[i]["TenNguoiGui"].ToString(),
                                                 dtNhiemVu.Rows[i]["TenNguoiNhan"].ToString(),
                                                 dtNhiemVu.Rows[i]["TrangThai"].ToString(),
                                                 dtNhiemVu.Rows[i]["NoiDung"].ToString(),
                                                 dtNhiemVu.Rows[i]["MSSV"].ToString(),
                                                 dtNhiemVu.Rows[i]["MaSoNhom"].ToString());
                    ucNhiemVu uc = new ucNhiemVu(nhiemVu);
                    listUcNhiemVu.Add(uc);

                }
                return listUcNhiemVu;
            }
            return null;
        }
        public DataTable LayThongTinDeTai(string maDeTai)
        {
            string sqlStr = string.Format($"SELECT * FROM ThongTinDeTai WHERE MaDeTai = '{maDeTai}'");
            return db.Load(sqlStr);
        }
        public void NhanXetBaoCao(BaoCao bc)
        {
            string sqlStr = string.Format($"UPDATE BaoCao SET TienDo =  '{bc.TienDo}'," +
                                                            $" NhanXet = '{bc.NhanXet}', " +
                                                            $"TrangThai = '{bc.TrangThai}'" +
                                                            $"WHERE TieuDe = '{bc.TieuDe}'");
            db.ThucThi(sqlStr);
        }
        public DataTable LayThongTinBaoCao(string maSoNhom)
        {
            string sqlStr = string.Format($"SELECT * FROM BaoCao WHERE MaSoNhom = '{maSoNhom}'");
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
