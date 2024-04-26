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
    public partial class FSinhVien_Support : Form
    {
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();

        public FSinhVien_Support()
        {
            InitializeComponent();
        }

        public void FSinhVien_Support_Load(object sender, EventArgs e)
        {
            //string sqlStr = string.Format("SELECT ThongBao.MaSoNhom,ThongBao.TenGiangVien,ThongBao.TieuDe,ThongBao.NoiDung,ThongBao.TrangThai,ThongBao.ThoiGianGui,ThongBao.ThoiGianKetThuc,ThongTinNhomDangKy.MSSV FROM ThongBao INNER JOIN ThongTinNhomDangKy On ThongBao.MaSoNhom = ThongTinNhomDangKy.MaSoNhom WHERE ThongTinNhomDangKy.MSSV={0}", SinhVienAccount.Mssv);
            string sqlStr = string.Format("SELECT * FROM ThongBao WHERE MaSoNhom={0}", SinhVienAccount.Masonhom);
            DataTable dtThongBao = svDao.LoadData(sqlStr);
            for (int i = 0; i < dtThongBao.Rows.Count; i++)
            {
                ThongBao thongBao = new ThongBao(dtThongBao.Rows[i]["MaSoNhom"].ToString(),
                                                 dtThongBao.Rows[i]["TenGiangVien"].ToString(),
                                                 dtThongBao.Rows[i]["TieuDe"].ToString(),
                                                 dtThongBao.Rows[i]["NoiDung"].ToString(),
                                                 dtThongBao.Rows[i]["TrangThai"].ToString(),
                                                 Convert.ToDateTime(dtThongBao.Rows[i]["ThoiGianGui"]));
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
