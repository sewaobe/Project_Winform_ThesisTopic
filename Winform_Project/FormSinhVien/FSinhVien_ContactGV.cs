using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;
using Winform_Project.FSinhVien;
using Winform_Project.uc_SV;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_ContactGV : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVien sv=new SinhVien();
        GiangVien gv;
        public FSinhVien_ContactGV()
        {
            InitializeComponent();
        }

        private void AppendText(string text, bool isMine)
        {
            rtbMessages.SelectionStart = rtbMessages.TextLength;
            rtbMessages.SelectionLength = 0;
            rtbMessages.SelectionColor = isMine ? Color.White : Color.Black;
            rtbMessages.SelectionBackColor = isMine ? Color.Blue : Color.LightGray;
            rtbMessages.SelectionAlignment = isMine ? HorizontalAlignment.Right : HorizontalAlignment.Left;
            rtbMessages.AppendText(text + "\n");
            rtbMessages.ScrollToCaret();
        }
        private void FSinhVien_ContactGV_Load(object sender, EventArgs e)
        {
            flowmess.Controls.Clear();
            string sqlStr = string.Format("SELECT * FROM ThongTinDeTai INNER JOIN ThongTinNhomDangKy On ThongTinDeTai.MaDeTai = ThongTinNhomDangKy.MaDeTai WHERE ThongTinNhomDangKy.MSSV={0}", SinhVienAccount.Mssv);
            DataTable dt = svDao.LoadData(sqlStr);


            uc_SV_ThongTin uc_sv_ThongTin = new uc_SV_ThongTin();
            uc_sv_ThongTin.lblTen.Text = dt.Rows[0]["TenGiangVien"].ToString();
            uc_sv_ThongTin.lblMSSV.Visible = false;
            uc_sv_ThongTin.btnThemSinhVien.Click += btnMessGV_Click;
            flowmess.Controls.Add(uc_sv_ThongTin);



            sqlStr = string.Format("SELECT * FROM SinhVien WHERE MSSV LIKE '{0}%'", textBox1.Text);
            DataTable dtSinhVien = svDao.LoadData(sqlStr);
            for (int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                if (dtSinhVien.Rows[i]["MaSoNhom"].ToString() == SinhVienAccount.Masonhom && dtSinhVien.Rows[i]["MSSV"].ToString() != SinhVienAccount.Mssv)
                {
                    SinhVien sinhvien = new SinhVien(dtSinhVien.Rows[i]["HoTen"].ToString(),
                        dtSinhVien.Rows[i]["GioiTinh"].ToString(),
                        Convert.ToDateTime(dtSinhVien.Rows[i]["NgaySinh"]),
                        dtSinhVien.Rows[i]["SDT"].ToString(),
                        dtSinhVien.Rows[i]["Khoa"].ToString(),
                        dtSinhVien.Rows[i]["Nganh"].ToString(),
                        dtSinhVien.Rows[i]["MSSV"].ToString(),
                        dtSinhVien.Rows[i]["MaSoNhom"].ToString()
                                                        );
                    uc_sv_ThongTin = new uc_SV_ThongTin(sinhvien);
                    uc_sv_ThongTin.btnThemSinhVien.Click += btnThemSV_Click;
                    flowmess.Controls.Add(uc_sv_ThongTin);
                    uc_sv_ThongTin.Show();
                }
            }


        }

        private void btnMessGV_Click(object sender, EventArgs e)
        {
            Guna2CirclePictureBox btn = (Guna2CirclePictureBox)sender;
            uc_SV_ThongTin uc = btn.Parent as uc_SV_ThongTin;
            sv = null;
            ChangeUCColor(uc);
            LoadMess(sender, e, sv);
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            Guna2CirclePictureBox btn = (Guna2CirclePictureBox)sender;
            uc_SV_ThongTin uc = btn.Parent as uc_SV_ThongTin;
            ChangeUCColor(uc);
            sv = uc.sv;
            LoadMess(sender, e,uc.sv);
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (txtmess.Text.Length > 0)
            {
                TinNhan tinNhan;
                if (sv == null)
                {
                    string sqlStr = string.Format("SELECT * FROM ThongTinDeTai INNER JOIN ThongTinNhomDangKy On ThongTinDeTai.MaDeTai = ThongTinNhomDangKy.MaDeTai WHERE ThongTinNhomDangKy.MSSV={0}", SinhVienAccount.Mssv);
                    DataTable dt = svDao.LoadData(sqlStr);
                    tinNhan = new TinNhan(SinhVienAccount.Mssv, dt.Rows[0]["TenGiangVien"].ToString(), txtmess.Text, DateTime.Now);
                }
                else { tinNhan = new TinNhan(SinhVienAccount.Mssv,sv.Mssv, txtmess.Text, DateTime.Now); }

                svDao.GuiTinNhan(tinNhan);
                flowmess.Controls.Clear();
                txtmess.Clear();
                FSinhVien_ContactGV_Load(sender, e);
                LoadMess(sender, e, sv);
            }
        }


        private void LoadMess(object sender, EventArgs e, SinhVien sv)
        {
            string sqlStr;
            rtbMessages.Clear();
            if (sv == null)
            {
                sqlStr = string.Format("SELECT * FROM ThongTinDeTai INNER JOIN ThongTinNhomDangKy On ThongTinDeTai.MaDeTai = ThongTinNhomDangKy.MaDeTai WHERE ThongTinNhomDangKy.MSSV={0}", SinhVienAccount.Mssv);
                DataTable dt = svDao.LoadData(sqlStr);
                sqlStr = string.Format("SELECT * FROM Messenger WHERE (NguoiNhan='{0}' and NguoiGui='{1}') or (NguoiNhan='{1}' and NguoiGui='{0}')", SinhVienAccount.Mssv, dt.Rows[0]["TenGiangVien"].ToString());
                lblContactName.Text = dt.Rows[0]["TenGiangVien"].ToString();
            }
            else
            {
                sqlStr = string.Format("SELECT * FROM Messenger WHERE (NguoiNhan='{0}' and NguoiGui='{1}') or (NguoiNhan='{1}' and NguoiGui='{0}')", SinhVienAccount.Mssv, sv.Mssv);
                lblContactName.Text = sv.Ten;
            }
            DataTable dtmess = svDao.LoadData(sqlStr);
            for (int i = 0; i < dtmess.Rows.Count; i++)
            {
                if (dtmess.Rows[i]["NguoiGui"].ToString() == SinhVienAccount.Mssv)
                {
                    AppendText(dtmess.Rows[i]["NoiDung"].ToString() + "\n", true);
                }
                else
                {
                    AppendText(dtmess.Rows[i]["NoiDung"].ToString() + "\n", false);

                }
            }
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            FSinhVien_ContactGV_Load(sender, e);
        }
        private void ChangeUCColor(UserControl uc)
        {
            foreach (UserControl control in flowmess.Controls)
            {
                control.BackColor = Color.LightGray;
            }
            uc.BackColor = Color.Blue;
        }
    }


}
