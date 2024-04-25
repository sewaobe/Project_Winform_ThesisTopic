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
using Winform_Project.FormSinhVien;

namespace Winform_Project
{
    public partial class uc_SV_ThongBao : UserControl
    {
        ThongBao thongbao = new ThongBao();
        SinhVienDao svDao = new SinhVienDao();
        public uc_SV_ThongBao(ThongBao tb)
        {
            InitializeComponent();
            thongbao = tb;
            lblTieuDe.Text = tb.Tieude;
            lblNoiDung.Text = tb.Noidung;
            
        }

        private void uc_SV_ThongBao_Load(object sender, EventArgs e)
        {
            if (thongbao.Trangthai == "Da Doc")
            {
                
            }
            else
            {
                
            }
        }

        private void uc_SV_ThongBao_Click(object sender, EventArgs e)
        {
            svDao.docThongBao(thongbao);
            FSinhVien_Support_View fSinhVien_Support_View = new FSinhVien_Support_View();
            thongbao.Trangthai = "Da Doc";
            uc_SV_ThongBao_Load(sender, e);
            fSinhVien_Support_View.Text=thongbao.Tieude;
            fSinhVien_Support_View.txtNoiDung.Text = thongbao.Noidung;
/*            fSinhVien_Support_View.lblThoiGianKetThuc.Text="Thời gian kết thúc: " + thongbao.Thoigianketthuc.ToString();
*/            fSinhVien_Support_View.Show();
        }


        private void uc_SV_ThongBao_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void uc_SV_ThongBao_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Silver;
        }
    }
}
