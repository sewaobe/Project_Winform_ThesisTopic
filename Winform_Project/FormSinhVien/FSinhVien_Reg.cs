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
using Winform_Project.FormSinhVien;


namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien_Reg : Form
    {
        SinhVien SinhVienAccount = new SinhVien("Bao", "", DateTime.Now, "", "", "", "22110285");
        SinhVienDao svDao = new SinhVienDao();
        public FSinhVien_Reg()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FSinhVien_Reg_Done fSinhVien_Reg_Done = new FSinhVien_Reg_Done();
            this.Hide();
            fSinhVien_Reg_Done.ShowDialog();
            this.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

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
        private void FSinhVien_Reg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winDataSet4._DeTai__' table. You can move, or remove it, as needed.
            gvDeTai.DataSource = svDao.LoadData("SELECT * From ThongTinDeTai");
            Instance_GridView();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (cbbNamHoc.SelectedIndex == -1 || cbbHocKy.SelectedIndex == -1)
            {
                MessageBox.Show("Mời bạn nhập đủ thông tin Khoa/Ngành/Năm/Kì của đề tài!!!!");
                return;
            }
            
            FSinhVien_Reg_New fSinhVien_Reg_New = new FSinhVien_Reg_New(cbbNamHoc.Text, cbbHocKy.Text);
            this.Hide();
            fSinhVien_Reg_New.ShowDialog();
            this.Show();
        }

        private void gvDeTai_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string click = gvDeTai.Columns[e.ColumnIndex].Index.ToString();
            if (click == "0")
            {

                FSinhVien_Reg_Done fSinhVien_Reg_Done = new FSinhVien_Reg_Done();
                fSinhVien_Reg_Done.txtMoTa.Text = gvDeTai.Rows[e.RowIndex].Cells["MoTa"].Value.ToString();
                fSinhVien_Reg_Done.txtChucNang.Text = gvDeTai.Rows[e.RowIndex].Cells["ChucNang"].Value.ToString();
                //fSinhVien_Reg_Done.txtCongNghe.Text = gvDeTai.Rows[e.RowIndex].Cells["CongNghe"].Value.ToString();
                fSinhVien_Reg_Done.txtMaDeTai.Text = gvDeTai.Rows[e.RowIndex].Cells["MaDeTai"].Value.ToString();
                fSinhVien_Reg_Done.txtTenDeTai.Text = gvDeTai.Rows[e.RowIndex].Cells["TenDeTai"].Value.ToString();
                this.Hide();
                fSinhVien_Reg_Done.ShowDialog();
                this.Show();
            }
        } 
    }
}
