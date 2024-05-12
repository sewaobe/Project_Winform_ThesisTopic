using Bunifu.UI.WinForms.Helpers.Transitions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Winform_Project.EntityModel;
using Winform_Project.FormGiangVien;
using Winform_Project.Model;

namespace Winform_Project.ClassDao
{
    internal class GiangVienDao
    {
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        DatabaseContext dbContext = new DatabaseContext();
        ToastMessage toastMessage = new ToastMessage(); 
        public static byte[] buffer_s;
        public void DanhGiaSinhVien(SinhVienn sv)
        {
           var query = (from p in dbContext.SinhVienns
                        where p.MSSV == sv.MSSV 
                        select p).SingleOrDefault();
            query.Diem = sv.Diem;
            toastMessage.Check(dbContext.SaveChanges());
        }
       
        public void DatLich(Lichh lich)
        {
            dbContext.Lichhs.Add(lich);
            toastMessage.Check(dbContext.SaveChanges());
        }
        public GiangVienDao() { }
        //New 
        public void CapNhatDiemChoDeTai(string MDT, string diem)
        {
            var query = (from p in dbContext.ThongTinDeTaiis
                        where p.MaDeTai == MDT
                        select p).SingleOrDefault();

            query.Diem = diem;
            query.TrangThai = "Da hoan thanh";
            toastMessage.Check(dbContext.SaveChanges());
        }
        //New
        public DataTable LayThongTinNhomDangKyTheoMDT(string MDT)
        {
            List<ThongTinNhomDangKyy> listNhomDangKy = dbContext.ThongTinNhomDangKyies.Where(p=>p.MaDeTai == MDT).ToList();

            return ToDataTable<ThongTinNhomDangKyy>(listNhomDangKy);
        }
        static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            // Lấy tất cả các thuộc tính public của đối tượng
            System.Reflection.PropertyInfo[] Props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            // Tạo các cột trong DataTable dựa trên tên của các thuộc tính
            foreach (System.Reflection.PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }

            // Thêm dữ liệu vào DataTable từ danh sách đối tượng
            foreach (T item in items)
            {
                object[] values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    // Lấy giá trị của thuộc tính tương ứng của đối tượng
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
        //New
        public DataTable LayThongTinDeTaiTheoTenGiangVien()
        {
            var deTai = dbContext.ThongTinDeTaiis.Where(p => p.TenGiangVien == FDangNhap.giangVienAccount.HoTen).ToList();
            return ToDataTable<ThongTinDeTaii>(deTai);
        }
        //New
        public List<ThongTinDeTaii> ChuyenDoiDuLieuSangLuanVan(DataTable dtDeTai)
        {
            List<ThongTinDeTaii> lv_list = new List<ThongTinDeTaii>();
            for (int i = 0; i < dtDeTai.Rows.Count; i++)
            {
                if (dtDeTai.Rows[i]["TenGiangVien"].ToString() == FDangNhap.giangVienAccount.HoTen)
                {
                        ThongTinDeTaii lv = new ThongTinDeTaii
                        {
                        MaDeTai = dtDeTai.Rows[i]["MaDeTai"].ToString(),
                        TenDeTai = dtDeTai.Rows[i]["TenDeTai"].ToString(),
                        SoLuong = dtDeTai.Rows[i]["SoLuong"].ToString(),
                        MoTa = dtDeTai.Rows[i]["MoTa"].ToString(),
                        YeuCau = dtDeTai.Rows[i]["YeuCau"].ToString(),
                        ChucNang = dtDeTai.Rows[i]["ChucNang"].ToString(),
                        TheLoai = dtDeTai.Rows[i]["TheLoai"].ToString(),
                        CongNghe = dtDeTai.Rows[i]["CongNghe"].ToString(),
                        Nganh = dtDeTai.Rows[i]["Nganh"].ToString(),
                        Khoa = dtDeTai.Rows[i]["Khoa"].ToString(),
                        HocKy = dtDeTai.Rows[i]["HocKy"].ToString(),
                        TenGiangVien = dtDeTai.Rows[i]["TenGiangVien"].ToString(),
                        TrangThai = dtDeTai.Rows[i]["TrangThai"].ToString()
                        };
                    lv_list.Add(lv);
                }
            }
            return lv_list is null ? null : lv_list;
        }
    
        public void Open_File(BaoCaoo baoCao)
        {
            var query = from p in dbContext.BaoCaoos
                        where p.ThoiGianGui == baoCao.ThoiGianGui && p.MaSoNhom == baoCao.MaSoNhom
                        select p;
            if (query.Count() > 0)
            {
                foreach (var item in query)
                {
                    File.WriteAllBytes(baoCao.TieuDe, item.FileBaoCao);
                    System.Diagnostics.Process.Start(baoCao.TieuDe);
                }
            }
        }
        public GiangVienn LayThongTinGiangVien(string hoTen)
        {
            GiangVienn gv = dbContext.GiangVienns.Where(p=>p.HoTen ==  hoTen).FirstOrDefault();
            if (gv != null)
            {
                return gv;
            }
            return null;
        }
        public void ThemNhiemVu(NhiemVuu nv)
        {
                dbContext.NhiemVuus.Add(nv);
                toastMessage.Check(dbContext.SaveChanges());
        }
        public void ThongBaoToiSinhVien(ThongBaoo tb)
        {
            var thongBaoo = new ThongBaoo
            {
                TieuDe = tb.TieuDe,
                TenGiangVien = tb.TenGiangVien,
                MaSoNhom = tb.MaSoNhom,
                NoiDung = tb.NoiDung,
                ThoiGianGui = string.Format("{0: dd/MM/yyyy HH:ss}", tb.ThoiGianGui),
                TrangThai = tb.TrangThai
            };
            dbContext.ThongBaoos.Add(thongBaoo);
            toastMessage.Check(dbContext.SaveChanges());
        }
       
        public List<ucNhiemVu> LayThongTinNhiemVu(string MSN, string trangThai, string MSSV)
        {
            List<ucNhiemVu> listUcNhiemVu = new List<ucNhiemVu>();
            List<NhiemVuu> listNhiemVu = new List<NhiemVuu>();
            if(MSSV != "NULL")
            {
                if (trangThai == "Tat ca")
                {
                    listNhiemVu = dbContext.NhiemVuus.Where(p=>p.MSSV == MSSV).ToList();
                }
                else
                {
                    listNhiemVu = dbContext.NhiemVuus.Where(p => p.MSSV == MSSV && p.TrangThai == trangThai).ToList();
                }
            }
            else
            {
                if (trangThai == "Tat ca")
                {
                    listNhiemVu = dbContext.NhiemVuus.Where(p => p.MaSoNhom == MSN).ToList();
                }
                else
                {
                    listNhiemVu = dbContext.NhiemVuus.Where(p => p.MaSoNhom == MSN && p.TrangThai == trangThai).ToList();
                }
            }
            if (listNhiemVu.Count > 0)
            {
                foreach(NhiemVuu nhiemVuu in listNhiemVu)
                {
                    ucNhiemVu uc = new ucNhiemVu(nhiemVuu);
                    listUcNhiemVu.Add(uc);
                }
                return listUcNhiemVu;
            }
            return null;
        }
        public DataTable LayThongTinDeTai(string maDeTai)
        {
            var query = (from p in dbContext.ThongTinDeTaiis
                        where p.MaDeTai == maDeTai
                        select p).ToList();
            return ToDataTable<ThongTinDeTaii>(query);
        }
        public void NhanXetBaoCao(BaoCaoo bc)
        {
            var query = (from p in dbContext.BaoCaoos
                        where p.TieuDe == bc.TieuDe
                        select p).SingleOrDefault();
            query.TienDo = bc.TienDo;
            query.NhanXet = bc.NhanXet;
            query.TrangThai = bc.TrangThai; 
            toastMessage.Check(dbContext.SaveChanges());
        }
        public DataTable LayThongTinBaoCao(string maSoNhom)
        {
            var query = (from p in dbContext.BaoCaoos
                        where p.MaSoNhom == maSoNhom
                        select p).ToList();
            return ToDataTable<BaoCaoo>(query);
        }
        
        
        public void Them(ThongTinDeTaii lv)
        {
            dbContext.ThongTinDeTaiis.Add(lv);
            toastMessage.Check(dbContext.SaveChanges());
        }
        public void Sua(ThongTinDeTaii lv)
        {
                ThongTinDeTaii lv_old= dbContext.ThongTinDeTaiis.Where(p => p.MaDeTai.Contains(lv.MaDeTai)).SingleOrDefault();
                lv_old.TenDeTai = lv.TenDeTai;
                lv_old.SoLuong = lv.SoLuong;
                lv_old.MoTa = lv.MoTa;
                lv_old.YeuCau = lv.YeuCau;
                lv_old.ChucNang = lv.ChucNang;
                lv_old.Khoa = lv.Khoa;
                lv_old.Nganh = lv.Nganh;
                lv_old.HocKy = lv.HocKy;
                lv_old.TheLoai = lv.TheLoai;
                lv_old.CongNghe = lv.CongNghe;
                toastMessage.Check(dbContext.SaveChanges());
        }
        public void Xoa(ThongTinDeTaii lv)
        {
                ThongTinDeTaii lv_old = dbContext.ThongTinDeTaiis.Where(p => p.MaDeTai == lv.MaDeTai).SingleOrDefault();
                dbContext.ThongTinDeTaiis.Remove(lv_old);
                toastMessage.Check(dbContext.SaveChanges());
        }
        
        public void DuyetDeTai(string MSDT,string MSN)
        {
                ThongTinDeTaii lv = dbContext.ThongTinDeTaiis.Where(p => p.MaDeTai == MSDT).SingleOrDefault();
                lv.TrangThai = "Da duyet";
                //Set trạng thái cho các sinh viên trong 1 nhóm = da duyet
                var nhomDangKyy = dbContext.ThongTinNhomDangKyies.Where(p => p.MaSoNhom == MSN).ToList();
                foreach(ThongTinNhomDangKyy thongTinNhomDangKyy in nhomDangKyy)
                {
                    thongTinNhomDangKyy.TrangThai = "Da duyet";
                }
                toastMessage.Check(dbContext.SaveChanges());
        }
        //New
        public void KhongDuyetDeTai(string MSDT, string MSN)
        {
                //Set lại trạng thái đề tài = 'Chưa duyêt'
                ThongTinDeTaii lv = dbContext.ThongTinDeTaiis.Where(p => p.MaDeTai == MSDT).SingleOrDefault();
                lv.TrangThai = "Chua dang ki";

                //Set lại mã số nhóm của từng sinh viên đã đăng kí đề tài = null vì không duyệt
                var nhomSinhVien = dbContext.SinhVienns.Where(p => p.MaSoNhom == MSN).ToList();
                foreach(SinhVienn sinhVienn in  nhomSinhVien)
                {
                    SinhVienn sv = dbContext.SinhVienns.Where(p => p.MSSV == sinhVienn.MSSV).FirstOrDefault();
                    sv.MaSoNhom = null;
                }

                //Xóa khỏi database ThongTinNhomDangKy
                var nhomDangKy = dbContext.ThongTinNhomDangKyies.Where(p => p.MaSoNhom == MSN).ToList();
                foreach(ThongTinNhomDangKyy thongTinNhomDangKyy in nhomDangKy)
                {
                    dbContext.ThongTinNhomDangKyies.Remove(thongTinNhomDangKyy);
                }
                toastMessage.Check(dbContext.SaveChanges());

        }
    }
}
