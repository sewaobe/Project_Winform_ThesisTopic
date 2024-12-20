﻿using Guna.UI2.WinForms;
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
using Winform_Project.FormGiangVien;
using Winform_Project.FormSinhVien;


namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien_Reg : Form
    {
        SinhVienn SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();
        ConNguoiDao conNguoiDao = new ConNguoiDao();
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
        
        private void FSinhVien_Reg_Load(object sender, EventArgs e)
        {
            DataTable dtDeTai = conNguoiDao.LayThongTinDeTaiDangCapNhat("Chua dang ki");
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
                if (dtDeTai.Rows[i]["TrangThai"].ToString() == "Chua dang ki")
                {
                    ThongTinDeTaii lv = new ThongTinDeTaii{MaDeTai = dtDeTai.Rows[i]["MaDeTai"].ToString(),
                                            TenDeTai = dtDeTai.Rows[i]["TenDeTai"].ToString(),
                                            TheLoai = dtDeTai.Rows[i]["TheLoai"].ToString(),
                                            SoLuong = dtDeTai.Rows[i]["SoLuong"].ToString(),
                                            MoTa = dtDeTai.Rows[i]["MoTa"].ToString(),
                                            ChucNang = dtDeTai.Rows[i]["ChucNang"].ToString(),
                                            YeuCau = dtDeTai.Rows[i]["YeuCau"].ToString(),
                                            CongNghe = dtDeTai.Rows[i]["CongNghe"].ToString(),
                                            Khoa = dtDeTai.Rows[i]["Khoa"].ToString(),
                                            Nganh = dtDeTai.Rows[i]["Nganh"].ToString(),
                                            HocKy = dtDeTai.Rows[i]["HocKy"].ToString(),
                                            TenGiangVien = dtDeTai.Rows[i]["TenGiangVien"].ToString(),
                                            TrangThai = dtDeTai.Rows[i]["TrangThai"].ToString()
                    };
                    uc_SV_DeTai uc_sv_detai = new uc_SV_DeTai(lv);
                    uc_sv_detai.btnChiTiet.Click += btnChiTiet_Click;
                    flow_DeTai.Controls.Add(uc_sv_detai);
                }
            }
            
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            uc_SV_DeTai uc = btn.Parent as uc_SV_DeTai;
            FSinhVien_Reg_Done fSinhVien_Reg_Done = new FSinhVien_Reg_Done(uc.luanvan);
            /*this.Hide();

            fSinhVien_Reg_Done.ShowDialog();
            this.Show();*/
            FSinhVien_Thesis_Detail.container(fSinhVien_Reg_Done);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //if (cbbNamHoc.SelectedIndex == -1 || cbbHocKy.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Mời bạn nhập đủ thông tin Khoa/Ngành/Năm/Kì của đề tài!!!!");
            //    return;
            //}
            FSinhVien_Reg_New fSinhVien_Reg_New = new FSinhVien_Reg_New("Ky 2");
            FSinhVien_Thesis_Detail.container(fSinhVien_Reg_New);

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
