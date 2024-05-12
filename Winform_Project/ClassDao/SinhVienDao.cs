using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.EntityModel;
using Winform_Project.Model;

namespace Winform_Project.ClassDao
{
    internal class SinhVienDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        DatabaseContext dbContext = new DatabaseContext();
        ToastMessage ToastMessage = new ToastMessage();

        SinhVienn sinhvien = new SinhVienn();
        public static byte[] buffer_s;

        public SinhVienDao() { }
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
        
        public DataTable LayTatCaThongBaoCuaNhom(string MSN)
        {
            var query = (from p in dbContext.ThongBaoos
                         where p.MaSoNhom == MSN
                         select p).ToList();

            return ToDataTable<ThongBaoo>(query);
        }
        public DataTable LayThongTinTatCaGiangVien()
        {
            var query = (dbContext.GiangVienns).ToList();

            return ToDataTable<GiangVienn>(query);
        }
        public DataTable LayNhiemVuCuaNhom(string MSN)
        {
            var query = (from p in dbContext.NhiemVuus
                         where p.MaSoNhom == MSN
                         select p).ToList();

            return ToDataTable<NhiemVuu>(query);
        }
        public DataTable LayBaoCaoCuaNhomDangKy(string MSN)
        {
            var query = (from p in dbContext.BaoCaoos
                         where p.MaSoNhom == MSN
                         select p).ToList();

            return ToDataTable<BaoCaoo>(query);
        }
        public void DeXuatDeTai(ThongTinDeTaii lv)
        {
            ThongTinDeTaii thongTinDeTai = new ThongTinDeTaii
            {
                MaDeTai = lv.MaDeTai,
                TenDeTai = lv.TenDeTai,
                SoLuong = lv.SoLuong,
                MoTa = lv.MoTa,
                YeuCau = lv.YeuCau,
                ChucNang = lv.ChucNang,
                TheLoai = lv.TheLoai,
                CongNghe = lv.CongNghe,
                Nganh = lv.Nganh,
                Khoa = lv.Khoa,
                HocKy = lv.HocKy,
                TenGiangVien = lv.TenGiangVien,
                TrangThai = "Chua duyet"
            };
            dbContext.ThongTinDeTaiis.Add(thongTinDeTai);
            ToastMessage.Check(dbContext.SaveChanges());
        }
        public void DangKy(SinhVienn svAccount, string masonhom, string madetai)
        {
            var insert = new ThongTinNhomDangKyy
            {
                MSSV = svAccount.MSSV,
                HoTen = svAccount.HoTen,
                MaSoNhom = masonhom,
                MaDeTai = madetai
            };
            dbContext.ThongTinNhomDangKyies.Add(insert);

            var update1 = dbContext.SinhVienns.Where(p => p.MSSV == svAccount.MSSV).FirstOrDefault();
            update1.MaSoNhom = masonhom;

            var update2 = dbContext.ThongTinDeTaiis.Where(p => p.MaDeTai == madetai).FirstOrDefault();
            update2.TrangThai = "Chua duyet";

            ToastMessage.Check(dbContext.SaveChanges());
        }
        public SinhVienn LayThongTinSinhVien(string MSSV)
        {
            var query = from p in dbContext.SinhVienns
                        where p.MSSV == MSSV
                        select p;
            foreach (var item in query)
            {
                sinhvien = new SinhVienn
                {   
                    HoTen = item.HoTen,
                    GioiTinh = item.GioiTinh,
                    NgaySinh = (DateTime)item.NgaySinh,
                    SDT = item.SDT,
                    Khoa = item.Khoa,
                    Nganh = item.Nganh,
                    MSSV = item.MSSV,
                    MaSoNhom = item.MaSoNhom
                };
                return sinhvien;
            }
            return null;
        }
        public void themSinhVien(SinhVienn sinhvien, string madetai)
        {
            var insert = new ThongTinNhomDangKyy()
            {
                MSSV = sinhvien.MSSV,
                HoTen = sinhvien.HoTen,
                MaSoNhom = sinhvien.MaSoNhom,
                MaDeTai = madetai
            };
            dbContext.ThongTinNhomDangKyies.Add(insert);
            var update1 = dbContext.SinhVienns.Where(x => x.MSSV == sinhvien.MSSV).FirstOrDefault();
            update1.MaSoNhom = sinhvien.MaSoNhom;

            ToastMessage.Check(dbContext.SaveChanges());
        }
        
        
        public void capnhatTrangThaiNhiemVu(NhiemVuu nv)
        {
            var query = (from p in dbContext.NhiemVuus
                        where p.TieuDe == nv.TieuDe
                        select p).SingleOrDefault();
            query.TrangThai = "Da hoan thanh";
            ToastMessage.Check(dbContext.SaveChanges());

        }
        public void Save_File(BaoCaoo baoCao)
        {
            using (Stream stream = File.OpenRead(baoCao.TieuDe))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string extn = new FileInfo(baoCao.TieuDe).Extension;
                buffer_s = buffer;

                var insert = new BaoCaoo()
                {
                    TieuDe = baoCao.TieuDe,
                    MaSoNhom = baoCao.MaSoNhom,
                    FileBaoCao = buffer,
                    TienDo = baoCao.TienDo,
                    NhanXet = baoCao.NhanXet,
                    ThoiGianGui = baoCao.ThoiGianGui,
                    TrangThai = baoCao.TrangThai
                };
                dbContext.BaoCaoos.Add(insert);
                ToastMessage.Check(dbContext.SaveChanges());
            }
        }
        public int kiemtraTrangThai(SinhVienn sv)
        {
                var sinhVien = dbContext.SinhVienns.Where(p => p.MSSV == sv.MSSV).SingleOrDefault();
                if (sinhVien.MaSoNhom is null)
                    return 2;

                var thongTinNhomDangKy = dbContext.ThongTinNhomDangKyies.Where(p => p.MaSoNhom == sinhVien.MaSoNhom).ToList();
            foreach (ThongTinNhomDangKyy thongTinNhomDangKyy in thongTinNhomDangKy) 
            {
                var deTaiNhomDangKy = dbContext.ThongTinDeTaiis.Where(p => p.MaDeTai == thongTinNhomDangKyy.MaDeTai).SingleOrDefault();
                if (deTaiNhomDangKy.TrangThai == "Chua duyet")
                    return 3;
            }
                
                return 1;
            
            
        }
    }
}
