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
using Winform_Project.EntityModel;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_NhiemVu : Form
    {
        SinhVienn SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();
        public FSinhVien_NhiemVu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            flowDaHoanThanh.Controls.Clear();
            flowDangThucHien.Controls.Clear();
            flowDaQuaHan.Controls.Clear();
            DataTable dt = svDao.LayNhiemVuCuaNhom(SinhVienAccount.MaSoNhom);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                NhiemVuu nv = new NhiemVuu{TieuDe = dt.Rows[i]["TieuDe"].ToString(),
                                        ThoiGianGui = Convert.ToDateTime(dt.Rows[i]["ThoiGianGui"]),
                                        ThoiGianKetThuc = Convert.ToDateTime(dt.Rows[i]["ThoiGianKetThuc"]),
                                        TenNguoiGui = dt.Rows[i]["TenNguoiGui"].ToString(),
                                        TenNguoiNhan = dt.Rows[i]["TenNguoiNhan"].ToString(),
                                        TrangThai = dt.Rows[i]["TrangThai"].ToString(),
                                        NoiDung = dt.Rows[i]["NoiDung"].ToString(),
                                        MSSV = dt.Rows[i]["MSSV"].ToString(),
                                        MaSoNhom = dt.Rows[i]["MaSoNhom"].ToString() };
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
            NhiemVuu nv = uc.nhiemVu;
            FNhiemVu_NoiDung fNhiemVu_NoiDung = new FNhiemVu_NoiDung(nv);
            fNhiemVu_NoiDung.ShowDialog();
            Form2_Load(uc.Parent, e);
        }
    }
}
