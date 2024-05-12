using Guna.UI2.WinForms;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.EntityModel;
using Winform_Project.Model;


namespace Winform_Project.ClassDao
{
    internal class ConNguoiDao
    {
        
        DatabaseContext dbContext = new DatabaseContext();
        public static int conNguoi = 0;
        private ErrorProvider errorProvider = new ErrorProvider();
        ToastMessage ToastMessage = new ToastMessage();

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

        //Tạo toast-Message cho UI
        public void TaoToastMessage(int flag)
        {
            if (flag == 1)
            {
                uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Thực thi thành công", "Thành công");
                uc_Toast_Notice.Show();
            }
            else
            {
                uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Thực thi thất bại", "Thất bại");
                uc_Toast_Notice.Show();
            }
        }
        public ConNguoiDao()
        {
        }
        //New
        public DataTable TimThongTinSinhVien(string mssv)
        {
            var query = (from p in dbContext.SinhVienns
                         where p.MSSV.Contains(mssv)
                         select p).ToList();

            return ToDataTable<SinhVienn>(query);   
        }
        //New
        public DataTable LayThongTinTatCaDeTai()
        {
            var query = dbContext.ThongTinDeTaiis.ToList();
            return ToDataTable<ThongTinDeTaii>(query);
        }
        public DataTable XacNhanDangNhap(ThongTinDangNhapp tk)
        {
            var query = (from p in dbContext.ThongTinDangNhapps
                        where p.TenDangNhap == tk.TenDangNhap && p.MatKhau == tk.MatKhau
                        select p).ToList();

            return ToDataTable<ThongTinDangNhapp>(query);
        }
        
        public void docThongBao(ThongBaoo tb)
        {
            var query = (from p in dbContext.ThongBaoos
                        where p.TieuDe == tb.TieuDe
                        select p).SingleOrDefault();

            query.TrangThai = "Da doc";
            ToastMessage.Check(dbContext.SaveChanges());
        }
        public DataTable LayThongTinDeTaiDangCapNhat(string trangThai)
        {
            var query = (from p in dbContext.ThongTinDeTaiis
                         where p.TrangThai == trangThai
                         select p).ToList();
            return ToDataTable<ThongTinDeTaii>(query);
        }
        public DataTable LayThongTinTatCaNhomDangKy()
        {
            

            var query = dbContext.ThongTinNhomDangKyies.ToList();
            return ToDataTable<ThongTinNhomDangKyy>(query);
        }
        public DataTable LayThongTinSinhVien(string maNhom)
        {
            var query = (from p in dbContext.SinhVienns
                         where p.MaSoNhom == maNhom
                         select p).ToList();

            return ToDataTable<SinhVienn>(query);
        }
        public DataTable LayThongTinLichHen(string maNhom)
        {
            var query = (from p in dbContext.Lichhs
                         where p.MaSoNhom == maNhom
                         select p).ToList();

            return ToDataTable<Lichh>(query);
        }
        public DataTable LayThongTinChat(string nguoiNhan, string nguoiGui)
        {
            var query = (from p in dbContext.Messengerrs
                         where (p.NguoiNhan == nguoiNhan && p.NguoiGui == nguoiGui) || (p.NguoiGui == nguoiNhan && p.NguoiNhan == nguoiGui)
                         select p).ToList();

            return ToDataTable<Messengerr>(query);
        }
        public void GuiTinNhan(Messengerr tn)
        {
                var insert = new Messengerr
                {
                    NguoiGui = tn.NguoiGui,
                    NguoiNhan = tn.NguoiNhan,
                    NoiDung = tn.NoiDung,
                    ThoiGianGui = tn.ThoiGianGui,
                };
                dbContext.Messengerrs.Add(insert);
                ToastMessage.Check(dbContext.SaveChanges());
            
        }
        public void GuiTinNhanDacBiet(Messengerr tn)
        {
            using (Stream stream = File.OpenRead(tn.NoiDung))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string extn = new FileInfo(tn.NoiDung).Extension;
               
                var insert = new Messengerr
                {
                    NguoiGui = tn.NguoiGui,
                    NguoiNhan = tn.NguoiNhan,
                    NoiDung = tn.NoiDung,
                    NoiDungDacBiet = buffer,
                    ThoiGianGui = tn.ThoiGianGui,
                };
                dbContext.Messengerrs.Add(insert);
                ToastMessage.Check(dbContext.SaveChanges());
            }
        }
        //New
        public void MoTinNhanDacBiet(Messengerr tn)
        {
            var test = dbContext.Messengerrs.ToList();
            foreach(var item in test)
            {
                if (item.ThoiGianGui.ToString() == tn.ThoiGianGui.ToString())
                {
                    File.WriteAllBytes(tn.NoiDung, item.NoiDungDacBiet);
                    System.Diagnostics.Process.Start(tn.NoiDung);
                }
            }
        }
        public DataTable LayThongTinTatCaSinhVien()
        {
            var query = dbContext.SinhVienns.ToList();

            return ToDataTable<SinhVienn>(query);
        }
        //New
        public bool Validation(Form sender, ThongTinDeTaii lv)
        {
            errorProvider.Clear();
            var validacao = new List<ValidationResult>();
            var contexto = new ValidationContext(lv, null, null);
            var controlErrors = new Dictionary<Control, List<string>>();
            Validator.TryValidateObject(lv, contexto, validacao, true);
            foreach (var erro in validacao)
            {

                foreach (Guna2TextBox txt in sender.Controls.OfType<Guna2TextBox>())
                {
                    {
                        if (txt.Name.ToLower().Contains(erro.MemberNames.FirstOrDefault().ToLower()))
                        {
                            if (!controlErrors.ContainsKey(txt))
                            {
                                controlErrors[txt] = new List<string>();
                            }
                            controlErrors[txt].Add(erro.ErrorMessage);
                        }
                    }
                }

            }
            int flag = 0;
            foreach (var controlError in controlErrors)
            {
                errorProvider.SetError(controlError.Key, string.Join("\n", controlError.Value));
                flag = 1;
            }
            return flag == 1? false:true;
        }

    }
}
