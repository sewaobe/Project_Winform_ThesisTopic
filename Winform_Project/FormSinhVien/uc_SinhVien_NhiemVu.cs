using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;

namespace Winform_Project.FormSinhVien
{
    public partial class uc_SinhVien_NhiemVu : UserControl
    {
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();
        public uc_SinhVien_NhiemVu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            flowDaHoanThanh.Controls.Clear();
            flowDangThucHien.Controls.Clear();
            flowDaQuaHan.Controls.Clear();
            string sqlStr = string.Format("SELECT * FROM NhiemVu WHERE MaSoNhom = '{0}'", SinhVienAccount.Masonhom);
            DataTable dt = svDao.LoadData(sqlStr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                NhiemVu nv = new NhiemVu(dt.Rows[i]["TieuDe"].ToString(),
                                        Convert.ToDateTime(dt.Rows[i]["ThoiGianGui"]),
                                        Convert.ToDateTime(dt.Rows[i]["ThoiGianKetThuc"]),
                                        dt.Rows[i]["TenNguoiGui"].ToString(),
                                        dt.Rows[i]["TenNguoiNhan"].ToString(),
                                        dt.Rows[i]["TrangThai"].ToString(),
                                        dt.Rows[i]["NoiDung"].ToString(),
                                        dt.Rows[i]["MSSV"].ToString(),
                                        dt.Rows[i]["MaSoNhom"].ToString());
                ucNhiemVu ucnhiemvu = new ucNhiemVu(nv);
                ucnhiemvu.Click += Ucnhiemvu_Click;
                DateTime now = DateTime.Now;
                if (nv.TrangThai == "Qua han")
                {
                    flowDaQuaHan.Controls.Add(ucnhiemvu);
                }
                else if (nv.TrangThai== "Da hoan thanh")
                {
                    flowDaHoanThanh.Controls.Add(ucnhiemvu);
                }    
                else
                {
                    flowDangThucHien.Controls.Add(ucnhiemvu);
                }    
                ucnhiemvu.Show();
            }
            lblSoLuongHoanThanh.Text = flowDaHoanThanh.Controls.OfType<UserControl>().Count().ToString();
            lblSoLuongQuaHan.Text = flowDaQuaHan.Controls.OfType<UserControl>().Count().ToString();
            lblSoLuongThucHien.Text = flowDangThucHien.Controls.OfType<UserControl>().Count().ToString();
        }

        private void Ucnhiemvu_Click(object sender, EventArgs e)
        {
            var uc = sender as ucNhiemVu;
            NhiemVu nv = uc.nhiemVu;
            FNhiemVu_NoiDung fNhiemVu_NoiDung = new FNhiemVu_NoiDung(nv);
            fNhiemVu_NoiDung.ShowDialog();
            Form2_Load(sender, e);
        }
    }
}
