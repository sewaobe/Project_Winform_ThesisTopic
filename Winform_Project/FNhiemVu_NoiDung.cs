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
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class FNhiemVu_NoiDung : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        NhiemVu nhiemVu;

        public FNhiemVu_NoiDung(NhiemVu nhiemVu)
        {
            InitializeComponent();
            lblTieuDe.Text = nhiemVu.TieuDe;
            lblThoiGian.Text = nhiemVu.ThoiGianGui.Day.ToString() + "/" + nhiemVu.ThoiGianGui.Month.ToString() + "/" + nhiemVu.ThoiGianGui.Year.ToString() + " --> " + nhiemVu.ThoiGianKetThuc.Day.ToString() + "/" + nhiemVu.ThoiGianKetThuc.Month.ToString() + "/" + nhiemVu.ThoiGianKetThuc.Year.ToString();
            lblNguoiThucHien.Text = nhiemVu.TenNguoiNhan;
            txtNoiDung.Text = nhiemVu.NoiDung;
            
            if (nhiemVu.TrangThai == "Dang thuc hien")
                btnXacNhan.Enabled = true;
            this.nhiemVu = nhiemVu;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn đã làm xong nhiệm vụ của giảng viên giao chứ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                svDao.capnhatTrangThaiNhiemVu(nhiemVu);
                this.Hide();
            }
            FGiangVien_Controls.flag_NhiemVu = 1;
        }
    }
}
