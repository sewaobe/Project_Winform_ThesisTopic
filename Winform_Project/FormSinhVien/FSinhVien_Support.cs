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
    public partial class FSinhVien_Support : Form
    {
        SinhVienn SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();

        public FSinhVien_Support()
        {
            InitializeComponent();
        }

        public void FSinhVien_Support_Load(object sender, EventArgs e)
        {
            //string sqlStr = string.Format("SELECT ThongBao.MaSoNhom,ThongBao.TenGiangVien,ThongBao.TieuDe,ThongBao.NoiDung,ThongBao.TrangThai,ThongBao.ThoiGianGui,ThongBao.ThoiGianKetThuc,ThongTinNhomDangKy.MSSV FROM ThongBao INNER JOIN ThongTinNhomDangKy On ThongBao.MaSoNhom = ThongTinNhomDangKy.MaSoNhom WHERE ThongTinNhomDangKy.MSSV={0}", SinhVienAccount.Mssv);
            DataTable dtThongBao = svDao.LayTatCaThongBaoCuaNhom(SinhVienAccount.MaSoNhom);
            for (int i = 0; i < dtThongBao.Rows.Count; i++)
            {
                ThongBaoo thongBao = new ThongBaoo{MaSoNhom = dtThongBao.Rows[i]["MaSoNhom"].ToString(),
                                                 TenGiangVien = dtThongBao.Rows[i]["TenGiangVien"].ToString(),
                                                 TieuDe = dtThongBao.Rows[i]["TieuDe"].ToString(),
                                                 NoiDung = dtThongBao.Rows[i]["NoiDung"].ToString(),
                                                 TrangThai = dtThongBao.Rows[i]["TrangThai"].ToString(),
                                                 ThoiGianGui = dtThongBao.Rows[i]["ThoiGianGui"].ToString()};
                uc_SV_ThongBao uc_sv_ThongBao = new uc_SV_ThongBao(thongBao);
                flowThongBao.Controls.Add(uc_sv_ThongBao);
                uc_sv_ThongBao.Show();
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
