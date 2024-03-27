using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class FGiangVien_ThesisTopics : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        SqlDataReader dr;
        GiangVienDao gvDao = new GiangVienDao();
        public FGiangVien_ThesisTopics()
        {
            InitializeComponent();
        }

       /* private void LoadData()
        {
            int i = 0;
            gvDeTai.Rows.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM ThongTinDeTai", conn);
            conn.Open();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                i++;
                gvDeTai.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[8].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            conn.Close();
        }*/

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(cbbKhoa.SelectedIndex == -1 || cbbNganh.SelectedIndex == -1 || cbbNamHoc.SelectedIndex == -1 || cbbHocKy.SelectedIndex == -1)
            {
                MessageBox.Show("Mời bạn nhập đủ thông tin Khoa/Ngành/Năm/Kì của đề tài!!!!");
                return;
            }
            FGiangVien_ThesisTopics_Add fgiangVien_ThesisTopics_Add = new FGiangVien_ThesisTopics_Add(cbbKhoa.Text,cbbNganh.Text,"Ten Giang Vien", cbbNamHoc.Text, cbbHocKy.Text);
            this.Hide();
            fgiangVien_ThesisTopics_Add.ShowDialog();
            this.Show();
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
        private void FGiangVien_ThesisTopics_Load(object sender, EventArgs e)
        {
            gvDeTai.DataSource = gvDao.LoadData("SELECT * From ThongTinDeTai");
            Instance_GridView();
        }
        private void Edit(object sender, EventArgs e)
        {
            MessageBox.Show("Sua thanh cong");
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
                if(MessageBox.Show($"Bạn muốn xóa đề tài này?","Xác minh xóa đề tài", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LuanVan lv = new LuanVan();
                    lv.MaDeTai = gvDeTai.Rows[e.RowIndex].Cells["MaDeTai"].Value.ToString();
                    gvDao.Xoa(lv);
                }
                
            }
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
