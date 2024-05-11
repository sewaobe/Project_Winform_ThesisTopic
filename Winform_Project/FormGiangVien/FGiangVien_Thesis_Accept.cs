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
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        public FGiangVien_Thesis_Accept()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Load_fLo(string trangThai)
        {
            DataTable dtDeTai = conNguoiDao.LayThongTinDeTaiDangCapNhat(trangThai);

            DataTable dtNhom = conNguoiDao.LayThongTinTatCaNhomDangKy();
            List<LuanVan> lv_list = gvDao.ChuyenDoiDuLieuSangLuanVan(dtDeTai);
            
            Guna2Button hdDeTai = headerDeTai;
            Guna2Button hdOparetor = headerOparetor;
            
            fLoTrungTam.Controls.Add(hdDeTai);
            fLoTrungTam.Controls.Add(hdOparetor);
            
            foreach (LuanVan lv in lv_list)
            {
                string sql = $"MaDeTai = '{lv.MaDeTai}'";
                //Lay MSN 
                DataRow[] rows = dtNhom.Select(sql);
                string maSoNhomDangKy = "";
                if (rows.Count() > 0)
                {
                    maSoNhomDangKy = rows[0]["MaSoNhom"].ToString();
                }
                //Hien de tai
                ucDeTai uc = new ucDeTai(lv);
                uc.lblDiem.Visible = false;
                uc.btnChiTiet.Visible = false;
                uc.Click += test_Click;
                fLoTrungTam.Controls.Add(uc);

                //Hien ma nhom
              /*  Label lbl = new Label();
                if (rows.Count() > 0)
                {
                    MessageBox.Show(rows[0]["MaSoNhom"].ToString());
                    lbl.Text = rows[0]["MaSoNhom"].ToString();
                    fLoTrungTam.Controls.Add(lbl);
                }*/


                //Click vô pictureBox - btnTongQuan
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
                    pic.Tag = lv.MaDeTai + "," + maSoNhomDangKy;
                    pic.Margin = new Padding(40, 30, 0, 0); 
                    fLoTrungTam.Controls.Add(pic);
                }
                else if(trangThai == "Chua duyet")
                {
                    Guna2Button btnDY = taoNut(lv, btnDongY);
                    btnDY.Margin = new Padding(20, 30, 0, 0);
                    btnDY.Tag = maSoNhomDangKy + "," + lv.MaDeTai;
                    btnDY.Click += btnDuyetClick;
                    Guna2Button btnTC = taoNut(lv, btnTuChoi);
                    btnTC.Margin = new Padding(20, 30, 0, 0);
                    btnTC.Tag = maSoNhomDangKy + ","+ lv.MaDeTai;
                    btnTC.Click += btnTuChoiClick;
                    fLoTrungTam.Controls.Add(btnDY);
                    fLoTrungTam.Controls.Add(btnTC);
                }
                else
                {
                    DataTable dt = gvDao.LayThongTinDeTai(lv.MaDeTai);
                    uc.lblDiem.Text = dt.Rows[0]["Diem"].ToString();
                    uc.lblDiem.Visible = true;
                    uc.lblDiemCap.Visible = true;
                }
                
            }
            
        }
        private void test_Click(object sender, EventArgs e)
        {
            ucDeTai ucDeTai = (ucDeTai)sender;
            DataTable dt = gvDao.LayThongTinNhomDangKyTheoMDT(ucDeTai.lblMaDeTai.Text);
            if (dt.Rows.Count > 0)
            {
                FGiangVien_Controls fGiangVien_Controls = new FGiangVien_Controls(ucDeTai.lv.MaDeTai, dt.Rows[0]["MaSoNhom"].ToString());
                if (dt.Rows[0]["TrangThai"].ToString() == "")
                {
                    MessageBox.Show("Đề tài chưa được duyệt!! Vui lòng duyệt đề tài");
                    fGiangVien_Controls.btnBaoCao.Visible = false;
                    fGiangVien_Controls.btnLich.Visible = false;
                    fGiangVien_Controls.btnNhiemVu.Visible = false;
                    fGiangVien_Controls.btnTienDo.Visible = false;
                    fGiangVien_Controls.btnTroChuyen.Visible = false;
                    fGiangVien_Controls.btnTongKet.Visible = false;
                    
                }
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
            btnThayDoiDuyet.Visible = true;
            btnThayDoiDuyet.Location = new Point(btnDuyet.Location.X + btnDuyet.Size.Width - 10, btnDuyet.Location.Y);
            Guna2Button btn = (Guna2Button)sender;
            string[] maSo = btn.Tag.ToString().Split(',');
            gvDao.DuyetDeTai(maSo[1], maSo[0]);
        }
        private void btnTuChoiClick(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string[] maSo = btn.Tag.ToString().Split(',');
            gvDao.KhongDuyetDeTai(maSo[1], maSo[0]);
        }
        private void FGiangVien_Thesis_Accept_Load(object sender, EventArgs e)
        {
            Load_fLo("Da duyet");
            DataTable dtDeTai = conNguoiDao.LayThongTinDeTaiDangCapNhat("Chua duyet");
            if (dtDeTai.Rows.Count > 0)
            {
                btnThayDoiCho.Visible = true;
                btnThayDoiCho.Location = new Point(btnCho.Location.X + btnCho.Size.Width - 10, btnCho.Location.Y);
            }
        }

        private void fLoTrungTam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            btnThayDoiDuyet.Visible = false;
            progress.Location = new Point(btnDuyet.Location.X, btnDuyet.Location.Y + 35);
            fLoTrungTam.Controls.Clear();   
            Load_fLo("Da duyet");

        }

        private void btnCho_Click(object sender, EventArgs e)
        {
            btnThayDoiCho.Visible = false;
            progress.Location = new Point(btnCho.Location.X, btnCho.Location.Y + 35);
            fLoTrungTam.Controls.Clear();
            Load_fLo("Chua duyet");
        }

        private void btnDaHoanThanh_Click(object sender, EventArgs e)
        {
            progress.Location = new Point(btnDaHoanThanh.Location.X, btnCho.Location.Y + 35);
            fLoTrungTam.Controls.Clear();
            Load_fLo("Da hoan thanh");
        }
    }
}
