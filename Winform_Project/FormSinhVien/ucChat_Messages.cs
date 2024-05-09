using Bunifu.UI.WinForms.Helpers.Transitions;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;
using Winform_Project.FormGiangVien;
using Winform_Project.uc_SV;

namespace Winform_Project.FormSinhVien
{
    public partial class ucChat_Messages : UserControl
    {
        ConNguoiDao conNguoiDao = new ConNguoiDao();    
        public ucChat_Messages()
        {
            InitializeComponent();
        }

        private void FChat_Messages_Load(object sender, EventArgs e)
        {
            uc_User_Chat uc_User_Chat = new uc_User_Chat();
            fLoChat.Controls.Add(uc_User_Chat);

            DataTable dtNhomDangKy = conNguoiDao.LayThongTinTatCaNhomDangKy();
            DataTable dtDeTai = conNguoiDao.LayThongTinDeTaiDangCapNhat("Da duyet");
            DataTable dtSinhVien = new DataTable();
            string maSoNhom;
            if (FGiangVien_Controls.role == 1)
            {
                dtSinhVien = conNguoiDao.LayThongTinSinhVien(FDangNhap.SinhVienAccount.Masonhom.ToString());
                maSoNhom = FDangNhap.SinhVienAccount.Masonhom;
            }
            else
            {
                dtSinhVien = conNguoiDao.LayThongTinSinhVien(FGiangVien_Controls.maSoNhom.ToString());
                maSoNhom = FGiangVien_Controls.maSoNhom;
            }

            //Kiếm giảng viên của đề tài đã đăng kí -> Load user lên khung chat
            for (int i = 0; i < dtNhomDangKy.Rows.Count; i++)
            {
                if (dtNhomDangKy.Rows[i]["MaSoNhom"].ToString() == maSoNhom)
                {

                    for (int j = 0; j < dtDeTai.Rows.Count; j++)
                    {
                        if (dtNhomDangKy.Rows[i]["MaDeTai"].ToString() == dtDeTai.Rows[j]["MaDeTai"].ToString())
                        {
                            GiangVien gv = new GiangVien(dtDeTai.Rows[j]["TenGiangVien"].ToString(),
                                                         "NULL",
                                                         DateTime.Now,
                                                         "NULL",
                                                         "NULL",
                                                         "NULL");
                            uc_SV_ThongTin uc = new uc_SV_ThongTin(gv);
                            uc.Click += uc_User_Click;
                            uc.btnThemSinhVien.Image = Properties.Resources.paper_plane;
                            if (FGiangVien_Controls.role == 1)
                                if (int.Parse(uc.btnThayDoiTroChuyen.Tag.ToString()) == 1)
                                    uc.btnThayDoiTroChuyen.Visible = true;
                            fLoDanhSachUser.Controls.Add(uc);
                            break;
                        }
                    }
                    break;
                }
            }
            //Kiếm sinh viên trong nhóm -> Load sv lên khung chat
            for(int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                SinhVien sv = new SinhVien(dtSinhVien.Rows[i]["HoTen"].ToString(),
                                           dtSinhVien.Rows[i]["GioiTinh"].ToString(),
                                           Convert.ToDateTime(dtSinhVien.Rows[i]["NgaySinh"].ToString()),
                                           dtSinhVien.Rows[i]["SDT"].ToString(),
                                           dtSinhVien.Rows[i]["Khoa"].ToString(),
                                           dtSinhVien.Rows[i]["Nganh"].ToString(),
                                           dtSinhVien.Rows[i]["MSSV"].ToString(),
                                           dtSinhVien.Rows[i]["MaSoNhom"].ToString());
                uc_SV_ThongTin uc = new uc_SV_ThongTin(sv);
                if (FGiangVien_Controls.role == 1)
                {
                    if (uc.lblMSSV.Text != FDangNhap.SinhVienAccount.Mssv)
                        if (int.Parse(uc.btnThayDoiTroChuyen.Tag.ToString()) == 1)
                            uc.btnThayDoiTroChuyen.Visible = true;
                }
                else
                {
                     if(int.Parse(uc.btnThayDoiTroChuyen.Tag.ToString()) == 1)
                        uc.btnThayDoiTroChuyen.Visible = true;
                }
                uc.Click += uc_User_Click;
                uc.btnThemSinhVien.Image = Properties.Resources.paper_plane;
                fLoDanhSachUser.Controls.Add(uc);
            }
        }
        private void uc_User_Click(object sender, EventArgs e)
        {
            //Xử lý panel_User 
            foreach (uc_SV_ThongTin uc_SV in fLoDanhSachUser.Controls.OfType<uc_SV_ThongTin>())
            {
                uc_SV.panel_User.Visible = false;
                uc_SV.BackColor = Color.WhiteSmoke;
            }
            uc_SV_ThongTin uc = sender as uc_SV_ThongTin;
            uc.panel_User.Visible = true;
            uc.BackColor = Color.White;
            uc_SV_ThongTin.flag = 0;

            //Load chat theo user
            uc_User_Chat uc_User_Chat = new uc_User_Chat();
            uc_User_Chat.picAvatar.Image = uc.picAvatar.Image;
            uc_User_Chat.lblTen.Text = uc.lblTen.Text;
            if (uc.lblMSSV.Text == "Giảng viên")
                uc_User_Chat.lblTen.Tag = uc.lblTen.Text;
            else
                uc_User_Chat.lblTen.Tag = uc.lblMSSV.Text;
            uc_User_Chat.btnGui.Click += guiTinNhan;
            uc_User_Chat.btnFile.Click += guiFile;
            fLoChat.Controls.Clear();
            fLoChat.Controls.Add(uc_User_Chat);
            Load_Chat_With_User(uc_User_Chat);
        }
        //Btn gui file
        private void guiFile(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            uc_User_Chat uc_User_Chat = btn.Parent as uc_User_Chat;
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                TinNhan tn;
                if (FGiangVien_Controls.role == 1)
                {
                    tn = new TinNhan(FDangNhap.SinhVienAccount.Mssv, uc_User_Chat.lblTen.Tag.ToString(), open.SafeFileName,open.FileName, DateTime.Now);
                    FGiangVien_Controls.flag_TroChuyen = 1;
                    foreach(uc_SV_ThongTin uc_SV_ThongTin in fLoDanhSachUser.Controls.OfType<uc_SV_ThongTin>())
                    {
                        if(uc_SV_ThongTin.lblMSSV.Text == FDangNhap.SinhVienAccount.Mssv)
                        {
                            uc_SV_ThongTin.flag = 1;
                        }
                    }
                }
                else
                {
                    tn = new TinNhan(FDangNhap.giangVienAccount.Ten, uc_User_Chat.lblTen.Tag.ToString(), open.SafeFileName, open.FileName, DateTime.Now);
                    FSinhVien_Controls.flag_TroChuyen = 1;
                    foreach (uc_SV_ThongTin uc_SV_ThongTin in fLoDanhSachUser.Controls.OfType<uc_SV_ThongTin>())
                    {
                        if (uc_SV_ThongTin.lblTen.Text == FDangNhap.giangVienAccount.Ten)
                        {
                            uc_SV_ThongTin.flag = 1;
                        }
                    }
                }
                conNguoiDao.GuiTinNhan(tn);
            }
            
        }
        //Btn gui tin nhan
        private void guiTinNhan(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            uc_User_Chat uc_User_Chat = btn.Parent as uc_User_Chat;
            TinNhan tn;
            if(FGiangVien_Controls.role == 1)
            {
                tn = new TinNhan(FDangNhap.SinhVienAccount.Mssv, uc_User_Chat.lblTen.Tag.ToString(), uc_User_Chat.txtNoiDung.Text, "C:\\Win\\Win (1)\\Winform_Project\\bin\\Debug\\qly_NV.txt", DateTime.Now);
                FGiangVien_Controls.flag_TroChuyen = 1;
                foreach (uc_SV_ThongTin uc_SV_ThongTin in fLoDanhSachUser.Controls.OfType<uc_SV_ThongTin>())
                {
                    if (uc_SV_ThongTin.lblMSSV.Text == FDangNhap.SinhVienAccount.Mssv)
                    {
                        uc_SV_ThongTin.flag = 1;
                    }
                }
            }
            else
            {
                tn = new TinNhan(FDangNhap.giangVienAccount.Ten, uc_User_Chat.lblTen.Tag.ToString(), uc_User_Chat.txtNoiDung.Text, "C:\\Win\\Win (1)\\Winform_Project\\bin\\Debug\\qly_NV.txt", DateTime.Now);
                FSinhVien_Controls.flag_TroChuyen = 1;
                foreach (uc_SV_ThongTin uc_SV_ThongTin in fLoDanhSachUser.Controls.OfType<uc_SV_ThongTin>())
                {
                    if (uc_SV_ThongTin.lblTen.Text == FDangNhap.giangVienAccount.Ten)
                    {
                        uc_SV_ThongTin.flag = 1;
                    }
                }
            }
            conNguoiDao.GuiTinNhan(tn);
        }
        //Load đoạn chat với user
        private void Load_Chat_With_User(uc_User_Chat uc_User_Chat)
        {
            uc_User_Chat.fLoTrungTam.Controls.Clear();

            DataTable dtTinNhan = new DataTable();

            if (FGiangVien_Controls.role == 1)
                dtTinNhan = conNguoiDao.LayThongTinChat(FDangNhap.SinhVienAccount.Mssv, uc_User_Chat.lblTen.Tag.ToString());
            else
                dtTinNhan = conNguoiDao.LayThongTinChat(FDangNhap.giangVienAccount.Ten, uc_User_Chat.lblTen.Tag.ToString());

            for (int i = 0; i < dtTinNhan.Rows.Count; i++)
            {
                TinNhan tn = new TinNhan(dtTinNhan.Rows[i]["NguoiGui"].ToString(),
                                         dtTinNhan.Rows[i]["NguoiNhan"].ToString(),
                                         dtTinNhan.Rows[i]["NoiDung"].ToString(),
                                         dtTinNhan.Rows[i]["NoiDungDacBiet"].ToString(),
                                         Convert.ToDateTime(dtTinNhan.Rows[i]["ThoiGianGui"].ToString())
                                         );

                string nguoiGui;
                if (FGiangVien_Controls.role == 1)
                {
                    nguoiGui = FDangNhap.SinhVienAccount.Mssv.ToString();
                }
                else
                {
                    nguoiGui = FDangNhap.giangVienAccount.Ten;
                }
                int index = tn.Noidung.IndexOf(".");
                string type = "";
                if(index != -1)
                    type = tn.Noidung.Substring(index, tn.Noidung.Length  - index);
                if (type == ".png" || type == ".docx" || type == ".pdf")
                {
                    uc_TinNhan_DacBiet uc_TinNhan_DacBiet = new uc_TinNhan_DacBiet(tn);
                    thoiGianGui.SetToolTip(uc_TinNhan_DacBiet, tn.Thoigiangui.ToLongDateString().ToString());
                    uc_TinNhan_DacBiet.Margin = new Padding(80, 5, 50, 5);
                    uc_User_Chat.fLoTrungTam.Controls.Add(uc_TinNhan_DacBiet);
                }
                else
                {
                    if (dtTinNhan.Rows[i]["NguoiGui"].ToString() == nguoiGui)
                    {
                        uc_TinNhan uc_TinNhan = new uc_TinNhan(tn);
                        thoiGianGui.SetToolTip(uc_TinNhan, tn.Thoigiangui.ToLongDateString().ToString());
                        uc_TinNhan.Margin = new Padding(110, 5, 5, 2);
                        uc_User_Chat.fLoTrungTam.Controls.Add(uc_TinNhan);
                    }
                    else
                    {
                        uc_TinNhan uc_TinNhan = new uc_TinNhan(tn);
                        thoiGianGui.SetToolTip(uc_TinNhan, tn.Thoigiangui.ToLongDateString().ToString());
                        uc_TinNhan.BackColor = Color.Gainsboro;
                        uc_User_Chat.fLoTrungTam.Controls.Add(uc_TinNhan);
                    }
                }
                }
            }
    }
}
