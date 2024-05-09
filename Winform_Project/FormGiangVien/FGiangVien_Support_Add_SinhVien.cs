using Guna.UI2.WinForms;
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
using Winform_Project.FSinhVien;
using Winform_Project.uc_SV;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_Support_Add_SinhVien : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        public static SinhVien sinhVien;
        public FGiangVien_Support_Add_SinhVien()
        {
            InitializeComponent();
            if (FGiangVien_Controls.role == 1)
                LoadDataSV();
            else
                LoadDataGV();
        }
        private void LoadDataGV()
        {
            fLoTrungTam.Controls.Clear();
            DataTable dtNhomSinhVien = conNguoiDao.LayThongTinSinhVien(FGiangVien_Controls.maSoNhom);
            for (int i = 0; i < dtNhomSinhVien.Rows.Count; i++)
            {
                SinhVien sv = new SinhVien(dtNhomSinhVien.Rows[i]["HoTen"].ToString(),
                                           dtNhomSinhVien.Rows[i]["GioiTinh"].ToString(),
                                           Convert.ToDateTime(dtNhomSinhVien.Rows[i]["NgaySinh"]),
                                           dtNhomSinhVien.Rows[i]["SDT"].ToString(),
                                           dtNhomSinhVien.Rows[i]["Khoa"].ToString(),
                                           dtNhomSinhVien.Rows[i]["Nganh"].ToString(),
                                           dtNhomSinhVien.Rows[i]["MSSV"].ToString(),
                                           dtNhomSinhVien.Rows[i]["MaSoNhom"].ToString());
                uc_SV_ThongTin uc = new uc_SV_ThongTin(sv);
                uc.btnThemSinhVien.Click += btnThemSinhVien_Click;
                fLoTrungTam.Controls.Add(uc);

            }
            
        }
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            Guna2CirclePictureBox btn = sender as Guna2CirclePictureBox;
            uc_SV_ThongTin uc = btn.Parent as uc_SV_ThongTin;
            sinhVien = uc.sv;
            this.Hide();
        }

        private void LoadDataSV()
        {
            fLoTrungTam.Controls.Clear();
            DataTable dtSinhVien = conNguoiDao.TimThongTinSinhVien(txtMSSV.Text);

            //Thêm hết sinh viên vô
            for (int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
               
                    if (dtSinhVien.Rows[i]["MaSoNhom"].ToString() == "")
                    {
                        SinhVien sinhvien = new SinhVien(dtSinhVien.Rows[i]["HoTen"].ToString(),
                                                        dtSinhVien.Rows[i]["GioiTinh"].ToString(),
                                                        Convert.ToDateTime(dtSinhVien.Rows[i]["NgaySinh"]),
                                                        dtSinhVien.Rows[i]["SDT"].ToString(),
                                                        dtSinhVien.Rows[i]["Khoa"].ToString(),
                                                        dtSinhVien.Rows[i]["Nganh"].ToString(),
                                                        dtSinhVien.Rows[i]["MSSV"].ToString(),
                                                        "");
                        uc_SV_ThongTin uc_SV_ThongTin = new uc_SV_ThongTin(sinhvien);
                        uc_SV_ThongTin.btnThemSinhVien.Image = Properties.Resources.control;
                        uc_SV_ThongTin.picAvatar.Tag = 0;
                        uc_SV_ThongTin.btnThemSinhVien.Click += btnThemSV_Click;
                        fLoTrungTam.Controls.Add(uc_SV_ThongTin);
                    }
                
            }

            //Lọc sinh viên đã có ở ngoài Reg
            foreach(uc_SV_ThongTin ucReg in FSinhVien_Reg_Done.fLoHienThiSinhVien.Controls.OfType<uc_SV_ThongTin>())
            {
                foreach (uc_SV_ThongTin ucShow in fLoTrungTam.Controls.OfType<uc_SV_ThongTin>())
                {
                    if(ucShow.lblMSSV.Text == ucReg.lblMSSV.Text)
                    {
                        fLoTrungTam.Controls.Remove(ucShow);
                        break;
                    }
                }
            }
        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            Guna2CirclePictureBox btn = (Guna2CirclePictureBox)sender;
            uc_SV_ThongTin uc = btn.Parent as uc_SV_ThongTin;
            if(int.Parse(uc.picAvatar.Tag.ToString()) == 0)
            {
                uc.btnThemSinhVien.Image = Properties.Resources.check;
                uc.picAvatar.Tag = 1;
            }
            else
            {
                uc.btnThemSinhVien.Image = Properties.Resources.control;
                uc.picAvatar.Tag = 0;   
            }
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            LoadDataSV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach(uc_SV_ThongTin uc in fLoTrungTam.Controls.OfType<uc_SV_ThongTin>())
            {
                if(int.Parse(uc.picAvatar.Tag.ToString()) == 1)
                {
                    FSinhVien_Reg_Done.fLoHienThiSinhVien.Controls.Add(uc);
                }
            }
            this.Hide();
        }
    }
}
