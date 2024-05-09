using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDoiTuong;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Thesis_Detail : UserControl
    {
        public FSinhVien_Thesis_Detail(LuanVan lv, List<SinhVien> listSinhVien)
        {
            InitializeComponent();
            txtMaDeTai.Text = lv.MaDeTai;
            txtTenDeTai.Text = lv.TenDeTai;
            txtChucNang.Text = lv.ChucNang;
            txtCongNghe.Text = lv.CongNghe;
            txtYeuCau.Text = lv.YeuCau;
            txtKhoa.Text = lv.Khoa;
            txtNganh.Text = lv.Nganh;
            txtMoTa.Text = lv.MoTa;
            txtTheLoai.Text = lv.TheLoai;
            txtHocKy.Text = lv.HocKy;

            string tenCacThanhVien = "";
            string maNhom = "";
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                tenCacThanhVien += (listSinhVien[i].Ten) + " - ";
                maNhom = listSinhVien[i].Masonhom;
            }
            txtMaNhom.Text = maNhom;
            txtThanhVien.Text = tenCacThanhVien;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtHocKy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNganh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtThanhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNhom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCongNghe_Click(object sender, EventArgs e)
        {

        }

        private void lblTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void txtTheLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblYeuCau_Click(object sender, EventArgs e)
        {

        }

        private void lblMoTa_Click(object sender, EventArgs e)
        {

        }

        private void lblTenDeTai_Click(object sender, EventArgs e)
        {

        }

        private void lblMaDeTai_Click(object sender, EventArgs e)
        {

        }

        private void txtChucNang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYeuCau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDeTai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDeTai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCongNghe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public static void container(object form)
        {
            if (FSinhVien.FSinhVien.panelTrungTam.Controls.Count > 0) { FSinhVien.FSinhVien.panelTrungTam.Controls.Clear(); }
            try
            {
                Form fm = form as Form;
                fm.TopLevel = false;
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.Dock = DockStyle.Fill;
                FSinhVien.FSinhVien.panelTrungTam.Controls.Add(fm);
                FSinhVien.FSinhVien.panelTrungTam.Tag = fm;
                fm.Show();
            }
            catch
            {
                UserControl uc = form as UserControl;
                uc.Dock = DockStyle.Fill;
                FSinhVien.FSinhVien.panelTrungTam.Controls.Clear();
                FSinhVien.FSinhVien.panelTrungTam.Controls.Add(uc);
                uc.BringToFront();

            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            container(new FSinhVien_Accepted());
        }
    }
}
