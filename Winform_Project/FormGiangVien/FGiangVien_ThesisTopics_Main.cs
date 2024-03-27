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

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_ThesisTopics_Main : Form
    {
        GiangVienDao gvDao = new GiangVienDao();

        public FGiangVien_ThesisTopics_Main()
        {
            InitializeComponent();
        }

        private void btnTaoDeTai_Click(object sender, EventArgs e)
        {
            FGiangVien_ThesisTopics_1 fgiangVien_ThesisTopics_1 = new FGiangVien_ThesisTopics_1();
            fgiangVien_ThesisTopics_1.ShowDialog();
        }
        private void Instance_GridView()
        {
            gvDeTai.Columns["MaDeTai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gvDeTai.Columns["MaDeTai"].HeaderText = "Mã đề tài";
            gvDeTai.Columns["TenDeTai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gvDeTai.Columns["TenDeTai"].HeaderText = "Tên đề tài";
            gvDeTai.Columns["TheLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gvDeTai.Columns["TheLoai"].HeaderText = "Thể loại";
            gvDeTai.Columns["NgayBatDau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gvDeTai.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            gvDeTai.Columns["NgayKetThuc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gvDeTai.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
            gvDeTai.Columns["MoTa"].Visible = false;
            gvDeTai.Columns["ChucNang"].Visible = false;
            gvDeTai.Columns["TenGiangVien"].Visible = false;
            gvDeTai.Columns["Khoa"].Visible = false;
            gvDeTai.Columns["Nganh"].Visible = false;
            gvDeTai.Columns["YeuCau"].Visible = false;
            gvDeTai.Columns["SoLuong"].Visible = false;
        }
        private void gvDeTai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string click = gvDeTai.Columns[e.ColumnIndex].Index.ToString();
            if (click == "0")
            {
                FGiangVien_Thesis_Edit fgiangVien_Thesis_Edit = new FGiangVien_Thesis_Edit();
                fgiangVien_Thesis_Edit.txtMaDeTai.Text = gvDeTai.Rows[e.RowIndex].Cells["MaDeTai"].Value.ToString();
                fgiangVien_Thesis_Edit.txtTen.Text = gvDeTai.Rows[e.RowIndex].Cells["TenDeTai"].Value.ToString();
                fgiangVien_Thesis_Edit.txtTheLoai.Text = gvDeTai.Rows[e.RowIndex].Cells["TheLoai"].Value.ToString();
                fgiangVien_Thesis_Edit.txtMoTa.Text = gvDeTai.Rows[e.RowIndex].Cells["MoTa"].Value.ToString();
                fgiangVien_Thesis_Edit.txtYeuCau.Text = gvDeTai.Rows[e.RowIndex].Cells["YeuCau"].Value.ToString();
                fgiangVien_Thesis_Edit.txtChucNang.Text = gvDeTai.Rows[e.RowIndex].Cells["ChucNang"].Value.ToString();
                fgiangVien_Thesis_Edit.txtSoLuong.Text = gvDeTai.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                fgiangVien_Thesis_Edit.cbbKhoa.Text = gvDeTai.Rows[e.RowIndex].Cells["Khoa"].Value.ToString();
                fgiangVien_Thesis_Edit.cbbNganh.Text = gvDeTai.Rows[e.RowIndex].Cells["Nganh"].Value.ToString();
                this.Hide();
                fgiangVien_Thesis_Edit.ShowDialog();
                this.Show();
            }
            else if (click == "1")
            {
                if (MessageBox.Show($"Bạn muốn xóa đề tài này?", "Xác minh xóa đề tài", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LuanVan lv = new LuanVan();
                    lv.MaDeTai = gvDeTai.Rows[e.RowIndex].Cells["MaDeTai"].Value.ToString();
                    gvDao.Xoa(lv);
                }

            }
        }

        private void FGiangVien_ThesisTopics_Main_Load(object sender, EventArgs e)
        {
            gvDeTai.DataSource = gvDao.LoadData("SELECT * From ThongTinDeTai");
            Instance_GridView();
        }

        private void btnQuanLiDeTai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Visible = !txtTimKiem.Visible;
            gvDeTai.Visible = !gvDeTai.Visible;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
