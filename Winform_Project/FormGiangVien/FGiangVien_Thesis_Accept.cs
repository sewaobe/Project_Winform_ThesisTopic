using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;
using Winform_Project.Model;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_Thesis_Accept : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        public FGiangVien_Thesis_Accept()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Load_fLo(string trangThai)
        {
            DataTable dtDeTai = gvDao.LoadData($"SELECT * FROM ThongTinDeTai WHERE TrangThai = '{trangThai}'");
            DataTable dtNhom = gvDao.LoadData("SELECT * FROM ThongTinNhomDangKy");
            List<LuanVan> lv_list = new List<LuanVan>();
            for (int i = 0; i < dtDeTai.Rows.Count; i++)
            {
                string MaDeTai, TenDeTai, SoLuong, MoTa, YeuCau, ChucNang, TheLoai, CongNghe, Nganh, Khoa, HocKy, TenGiangVien, TrangThai;

                MaDeTai = dtDeTai.Rows[i]["MaDeTai"].ToString();
                TenDeTai = dtDeTai.Rows[i]["TenDeTai"].ToString();
                SoLuong = dtDeTai.Rows[i]["SoLuong"].ToString();
                MoTa = dtDeTai.Rows[i]["MoTa"].ToString();
                YeuCau = dtDeTai.Rows[i]["YeuCau"].ToString();
                ChucNang = dtDeTai.Rows[i]["ChucNang"].ToString();
                TheLoai = dtDeTai.Rows[i]["TheLoai"].ToString();
                CongNghe = dtDeTai.Rows[i]["CongNghe"].ToString();
                Nganh = dtDeTai.Rows[i]["Nganh"].ToString();
                Khoa = dtDeTai.Rows[i]["Khoa"].ToString();
                HocKy = dtDeTai.Rows[i]["HocKy"].ToString();
                TenGiangVien = dtDeTai.Rows[i]["TenGiangVien"].ToString();
                TrangThai = dtDeTai.Rows[i]["TrangThai"].ToString();
                LuanVan lv = new LuanVan(MaDeTai,
                                         TenDeTai,
                                         TheLoai,
                                         SoLuong,
                                         MoTa,
                                         ChucNang,
                                         YeuCau,
                                         CongNghe,
                                         Khoa,
                                         Nganh,
                                         HocKy,
                                         TenGiangVien,
                                         TrangThai);
                lv_list.Add(lv);
            }
            
            Guna2Button hdDeTai = headerDeTai;
            Guna2Button hdNhom = headerMaNhom;
            Guna2Button hdOperation = headerOperation;
            fLoTrungTam.Controls.Add(hdDeTai);
            fLoTrungTam.Controls.Add(hdNhom);
            fLoTrungTam.Controls.Add(hdOperation);
            
            foreach (LuanVan lv in lv_list)
            {
                string sql = $"MaDeTai = '{lv.MaDeTai}'";
                //Lay MSN 
               
                DataRow[] rows = dtNhom.Select(sql);
               
                //Hien de tai
                ucDeTai uc = new ucDeTai(lv);
                uc.btnChiTiet.Visible = false;
                uc.Click += test_Click;
                fLoTrungTam.Controls.Add(uc);

                //Hien ma nhom
                Label lbl = new Label();
                if (rows.Count() > 0)
                {
                    MessageBox.Show(rows[0]["MaSoNhom"].ToString());
                    lbl.Text = rows[0]["MaSoNhom"].ToString();
                    fLoTrungTam.Controls.Add(lbl);
                }

                
                
                if (trangThai == "Da duyet")
                {
                    Guna2CirclePictureBox pic = new Guna2CirclePictureBox();
                    pic.BackColor = btnTongQuan.BackColor;
                    pic.Image = btnTongQuan.Image;
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Size = btnTongQuan.Size;
                    pic.MouseHover += picHover;
                    pic.MouseLeave += picLeave;
                    pic.Visible = true;
                    pic.Click += picClick;
                    pic.Tag = lv.MaDeTai + "," + lbl.Text;
                    
                    fLoTrungTam.Controls.Add(pic);
                }
                else
                {
                    Guna2Button btnDY = taoNut(lv, btnDongY);
                    btnDY.Tag = lbl.Text + "," + lv.MaDeTai;

                    btnDY.Click += btnDuyetClick;
                    Guna2Button btnTC = taoNut(lv, btnTuChoi);
                    btnTC.Tag = lbl.Text +","+ lv.MaDeTai;
                    btnTC.Click += btnTuChoiClick;
                    Guna2Button btn = btnDY;
                    fLoTrungTam.Controls.Add(btnDY);
                    fLoTrungTam.Controls.Add(btnTC);
                }
                
            }
            
        }
        private void test_Click(object sender, EventArgs e)
        {
            ucDeTai ucDeTai = (ucDeTai)sender;
            DataTable dt = gvDao.LoadData($"Select * FROM ThongTinNhomDangKy Where MaDeTai = '{ucDeTai.lblMaDeTai.Text}'");
            if (dt.Rows.Count > 0)
            {
                FGiangVien_Controls fGiangVien_Controls = new FGiangVien_Controls(ucDeTai.lv.MaDeTai, dt.Rows[0]["MaSoNhom"].ToString());
                fGiangVien_Controls.ShowDialog();
            }
        }
        private void picLeave(object sender, EventArgs e)
        {
            Guna2CirclePictureBox pic = (Guna2CirclePictureBox)sender;
            pic.BackColor = btnTongQuan.BackColor;
        }
        private void picHover(object sender, EventArgs e)
        {
            Guna2CirclePictureBox pic = (Guna2CirclePictureBox)sender;
            pic.BackColor = Color.SteelBlue;
        }
        private void picClick(object sender, EventArgs e)
        {
            Guna2CirclePictureBox pic = (Guna2CirclePictureBox)sender;
            string[] maSo = pic.Tag.ToString().Split(',');
            FGiangVien_Controls fGiangVien_Controls = new FGiangVien_Controls(maSo[0], maSo[1]);
            fGiangVien_Controls.ShowDialog();
        }
        private Guna2Button taoNut(LuanVan lv, Guna2Button btnType)
        {
            Guna2Button btn = new Guna2Button();
            btn.FillColor = btnType.FillColor;
            btn.ForeColor = btnType.ForeColor;
            btn.Font = btnType.Font;
            btn.Text = btnType.Text;
            btn.Size = btnType.Size;
            btn.AutoRoundedCorners = true;
            btn.Visible = true;
            return btn;
        }
        private void btnDuyetClick(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string[] maSo = btn.Tag.ToString().Split(',');
            gvDao.DuyetDeTai(maSo[0], maSo[1]);
        }
        private void btnTuChoiClick(object sender, EventArgs e)
        {
            
        }
        private void FGiangVien_Thesis_Accept_Load(object sender, EventArgs e)
        {
            Load_fLo("Da duyet");
        }

        private void fLoTrungTam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            progress.Location = new Point(btnDuyet.Location.X, btnDuyet.Location.Y + 35);
            fLoTrungTam.Controls.Clear();   
            Load_fLo("Da duyet");

        }

        private void btnCho_Click(object sender, EventArgs e)
        {
            progress.Location = new Point(btnCho.Location.X, btnCho.Location.Y + 35);
            fLoTrungTam.Controls.Clear();
            Load_fLo("Chua duyet");
        }

        /* private void btnDaDuyet_Click(object sender, EventArgs e)
         {
             gvDeTaiDaDuyet.DataSource = gvDao.LoadData("SELECT ThongTinDeTai.MaDeTai, ThongTinDeTai.TenDeTai, ThongTinDeTai.TheLoai, ThongTinDeTai.HocKy, ThongTinNhomDangKy.MaSoNhom, ThongTinNhomDangKy.TrangThai FROM ThongTinDeTai INNER JOIN ThongTinNhomDangKy ON ThongTinNhomDangKy.MaDeTai = ThongTinDeTai.MaDeTai AND ThongTinNhomDangKy.TrangThai = 'Da duyet'");
             Location_gv(gvDeTaiDaDuyet, txtTimKiemDaDuyet, gvDeTaiDaDuyet.Location.X, btnDaDuyet.Location.Y);
             if (gvDeTaiDaDuyet.Visible == true)
                 btnChuaDuyet.Location = new Point(btnDaDuyet.Location.X, gvDeTaiDaDuyet.Location.Y + gvDeTaiDaDuyet.Height + 30);
             else
                 btnChuaDuyet.Location = new Point(btnDaDuyet.Location.X, btnDaDuyet.Location.Y + btnDaDuyet.Height + 30);
         }

         private void btnChuaDuyet_Click(object sender, EventArgs e)
         {
             gvDeTaiChuaDuyet.DataSource = gvDao.LoadData("SELECT ThongTinDeTai.MaDeTai, ThongTinDeTai.TenDeTai, ThongTinDeTai.TheLoai, ThongTinDeTai.HocKy, ThongTinNhomDangKy.MaSoNhom, ThongTinNhomDangKy.TrangThai FROM ThongTinDeTai INNER JOIN ThongTinNhomDangKy ON ThongTinNhomDangKy.MaDeTai = ThongTinDeTai.MaDeTai AND ThongTinNhomDangKy.TrangThai = 'Chua duyet'");
             Location_gv(gvDeTaiChuaDuyet, txtTimKiemChuaDuyet, gvDeTaiChuaDuyet.Location.X, btnChuaDuyet.Location.Y);


         }
         private void Location_gv(DataGridView gv, Guna2TextBox txt, int x, int y)
         {
             gv.Visible = !gv.Visible;
             txt.Visible = !txt.Visible;
             txt.Location = new Point(txt.Location.X, y+50);
             gv.Location = new Point(x, y+100);
             int height_gv = 30;
             foreach (DataGridViewRow dtgvr in gv.Rows)
             {
                 height_gv += dtgvr.Height;
             }
             gv.Height = height_gv;
         }
         private void gvDeTai_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void gvDeTaiChuaDuyet_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             string click = gvDeTaiChuaDuyet.Columns[e.ColumnIndex].Index.ToString();
             if (click == "0")
             {
                 gvDao.DuyetDeTai(gvDeTaiChuaDuyet.Rows[e.RowIndex].Cells["MaSoNhom"].Value.ToString());

             }
         }*/
    }
}
