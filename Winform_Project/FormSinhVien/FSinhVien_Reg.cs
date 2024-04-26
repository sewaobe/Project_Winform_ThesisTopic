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
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();
        public FSinhVien_Reg()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FSinhVien_Reg_Done fSinhVien_Reg_Done = new FSinhVien_Reg_Done(null);
            this.Hide();
            fSinhVien_Reg_Done.ShowDialog();
            this.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private void Instance_GridView()
        {

        }
        private void FSinhVien_Reg_Load(object sender, EventArgs e)
        {
            Instance_GridView();
            DataTable dtDeTai = svDao.LoadData("SELECT * From ThongTinDeTai");
            for (int i = 0; i < dtDeTai.Rows.Count; i++)
            {
                //đổ data vô các combobox
                if(!cbbGiangVien.Items.Contains(dtDeTai.Rows[i]["TenGiangVien"].ToString()))
                {
                    cbbGiangVien.Items.Add(dtDeTai.Rows[i]["TenGiangVien"].ToString());
                }
                if(!cbbTheLoai.Items.Contains(dtDeTai.Rows[i]["TheLoai"].ToString()))
                {
                    cbbTheLoai.Items.Add(dtDeTai.Rows[i]["TheLoai"].ToString());
                }

                //thêm uc_DeTai
                LuanVan lv = new LuanVan(dtDeTai.Rows[i]["MaDeTai"].ToString(),
                                        dtDeTai.Rows[i]["TenDeTai"].ToString(),
                                        dtDeTai.Rows[i]["TheLoai"].ToString(),
                                        dtDeTai.Rows[i]["SoLuong"].ToString(),
                                        dtDeTai.Rows[i]["MoTa"].ToString(),
                                        dtDeTai.Rows[i]["ChucNang"].ToString(),
                                        dtDeTai.Rows[i]["YeuCau"].ToString(),
                                        dtDeTai.Rows[i]["CongNghe"].ToString(),
                                        dtDeTai.Rows[i]["Khoa"].ToString(),
                                        dtDeTai.Rows[i]["Nganh"].ToString(),
                                        dtDeTai.Rows[i]["HocKy"].ToString(),
                                        dtDeTai.Rows[i]["TenGiangVien"].ToString(),"Chua Duyet"
                                        //dtDeTai.Rows[i]["TrangThai"].ToString()
                                        );
                uc_SV_DeTai uc_sv_detai = new uc_SV_DeTai(lv);
                flow_DeTai.Controls.Add(uc_sv_detai);
                uc_sv_detai.Show();
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //if (cbbNamHoc.SelectedIndex == -1 || cbbHocKy.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Mời bạn nhập đủ thông tin Khoa/Ngành/Năm/Kì của đề tài!!!!");
            //    return;
            //}

            FSinhVien_Reg_New fSinhVien_Reg_New = new FSinhVien_Reg_New("hoc ki 2");
            this.Hide();
            fSinhVien_Reg_New.ShowDialog();
            this.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //uc_SV_DeTai uc_sv_detai = new uc_SV_DeTai();
            //flow_DeTai.Controls.Add(uc_sv_detai);
            //uc_sv_detai.Show();
        }
        private void timkiem()
        {
            if (txtTimKiem.Text.Length > 0 || cbbGiangVien.SelectedIndex != 0 || cbbTheLoai.SelectedIndex != 0 || cbbHocKy.SelectedIndex != 0)
            {
                foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
                {
                    if ((uc.lblTenDeTai2.Text.Contains(txtTimKiem.Text) && txtTimKiem.Text.Length > 0) || uc.lblGVHD2.Text.Contains(cbbGiangVien.Text) || uc.lblTheLoai2.Text.Contains(cbbTheLoai.Text) || uc.lblHocKy2.Text.Contains(cbbHocKy.Text))
                    {
                        uc.Visible = true;
                    }
                    else { uc.Visible = false; }
                }
            }
            else
            {
                foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
                {
                    uc.Visible = true;
                }
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
            //if (txtTimKiem.Text.Length > 0)
            //{
            //    foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
            //    {
            //        if (uc.lblTenDeTai2.Text.Contains(txtTimKiem.Text) == false)
            //        {
            //            uc.Visible = false;
            //        }
            //        else { uc.Visible = true; }
            //    }
            //}
            //else
            //{
            //    foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
            //    {
            //        uc.Visible = true;
            //    }
            //}
        }

        private void cbbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            timkiem();
            //if (cbbGiangVien.SelectedIndex!=-1)
            //{
            //    foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
            //    {
            //        if (uc.lblGVHD2.Text.Contains(cbbGiangVien.Text) == false)
            //        {
            //            uc.Visible = false;
            //        }
            //        else { uc.Visible = true; }
            //    }
            //}
            //else
            //{
            //    foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
            //    {
            //        uc.Visible = true;
            //    }
            //}
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            timkiem();
            //if (cbbTheLoai.SelectedIndex != -1)
            //{
            //    foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
            //    {
            //        if (uc.lblTheLoai2.Text.Contains(cbbTheLoai.Text) == false)
            //        {
            //            uc.Visible = false;
            //        }
            //        else { uc.Visible = true; }
            //    }
            //}
            //else
            //{
            //    foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
            //    {
            //        uc.Visible = true;
            //    }
            //}
        }

        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            timkiem();
            //if (cbbHocKy.SelectedIndex != -1)
            //{
            //    foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
            //    {
            //        if (uc.lblHocKy2.Text.Contains(cbbHocKy.Text) == false)
            //        {
            //            uc.Visible = false;
            //        }
            //        else { uc.Visible = true; }
            //    }
            //}
            //else
            //{
            //    foreach (uc_SV_DeTai uc in flow_DeTai.Controls)
            //    {
            //        uc.Visible = true;
            //    }
            //}
        }
    }
}
