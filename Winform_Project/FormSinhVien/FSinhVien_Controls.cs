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
using System.Windows.Forms.DataVisualization.Charting;
using Winform_Project.ClassDao;
using Winform_Project.EntityModel;
using Winform_Project.FormGiangVien;
using Winform_Project.uc_SV;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Controls : Form
    {
        SinhVienn SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();
        ConNguoiDao conNguoiDao = new ConNguoiDao();    
        public static int flag_NhiemVu = 0, flag_NhanXet = 0, flag_TienDo = 0, flag_Lich = 0, flag_TroChuyen = 0;

        public FSinhVien_Controls()
        {
            InitializeComponent();
        }
        private void btnThayDoiOn(int flag, Guna2Button btn)
        {
            if (flag == 1)
                btn.Visible = true;
        }
        private void btnThayDoiOff(int flag, Guna2Button btn)
        {
            flag = 0;
            btn.Visible = false;
        }
            private void btnNhanXet_Click(object sender, EventArgs e)
        {
            btnThayDoiOff(FSinhVien_Controls.flag_NhanXet, btnThayDoiNhanXet);
            progress.Location = new Point(btnNhanXet.Location.X, btnNhanXet.Location.Y+40);
            fLoTrungTam.Controls.Clear();
            Button btnThemBaocao = new Button();
            btnThemBaocao.Size = new Size(196, 200);
            btnThemBaocao.BackColor = Color.White;
            btnThemBaocao.Text = "Thêm Báo Cáo";
            btnThemBaocao.Click += BtnThemBaocao_Click;
            fLoTrungTam.Controls.Add(btnThemBaocao);

            
            DataTable dt = svDao.LayBaoCaoCuaNhomDangKy(SinhVienAccount.MaSoNhom);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string trangThai;
                if (dt.Rows[i]["TienDo"].ToString() != "NULL" && dt.Rows[i]["TienDo"].ToString() != "")
                    trangThai = "Da duyet";
                else
                    trangThai = "Chua duyet";
                string File = dt.Rows[i]["FileBaoCao"].ToString();
                byte[] data = System.Text.Encoding.ASCII.GetBytes(File);
                BaoCaoo bc = new BaoCaoo{ TieuDe = dt.Rows[i]["TieuDe"].ToString(),
                                       ThoiGianGui = dt.Rows[i]["ThoiGianGui"].ToString(),
                                       FileBaoCao = data,
                                       NhanXet = dt.Rows[i]["NhanXet"].ToString(),
                                       TienDo = dt.Rows[i]["TienDo"].ToString(),
                                       MaSoNhom = dt.Rows[i]["MaSoNhom"].ToString(),
                                       TrangThai = trangThai};
                ucBaoCao ucBaoCao = new ucBaoCao(bc);
                ucBaoCao.btnDanhGia.Visible= false;
                ucBaoCao.btnXoa.Visible= false;
                ucBaoCao.Click += UcBaoCao_Click;
                fLoTrungTam.Controls.Add(ucBaoCao);
                ucBaoCao.Show();
            }

        }

        private void BtnThemBaocao_Click(object sender, EventArgs e)
        {
            FSinhVien_Progress_Check fSinhVien_Progress_Check = new FSinhVien_Progress_Check();
            /*fGiangVien_Progress_Check.lblNhanXet.Visible = false;
            fGiangVien_Progress_Check.lblsinhvien.Visible = true;
            fGiangVien_Progress_Check.btnGuiBaoCao.Visible = true;
            fGiangVien_Progress_Check.btnGui.Visible = false;
            fGiangVien_Progress_Check.btnThoat.Visible = true;
            fGiangVien_Progress_Check.lblDanhGia.Visible = false;
            fGiangVien_Progress_Check.progress.Visible = false;
            fGiangVien_Progress_Check.txtNhanXet.Visible = false;
            fGiangVien_Progress_Check.label1.Visible = false;*/
            fSinhVien_Progress_Check.ShowDialog();
            FGiangVien_Controls.flag_BaoCao = 1;
            btnNhanXet_Click(btnNhanXet, e);
        }

        private void UcBaoCao_Click(object sender, EventArgs e)
        {
            var uc = sender as ucBaoCao;
            BaoCaoo bc = uc.baoCao;
            FGiangVien_Progress_Check fGiangVien_Progress_Check = new FGiangVien_Progress_Check();
            fGiangVien_Progress_Check.txtNhanXet.Text = bc.NhanXet;
            fGiangVien_Progress_Check.txtTieuDe.Text = bc.TieuDe;
            fGiangVien_Progress_Check.progress.Value = Convert.ToInt32(bc.TienDo);
            fGiangVien_Progress_Check.lblValueProgress.Text = bc.TienDo;
            fGiangVien_Progress_Check.lblValueProgress.Visible = true;

            fGiangVien_Progress_Check.Show();


        }

        private void btnTienDo_Click(object sender, EventArgs e)
        {
            btnThayDoiOff(FSinhVien_Controls.flag_TienDo, btnThayDoiTienDo);

            progress.Location = new Point(btnTienDo.Location.X, btnNhanXet.Location.Y + 40);
            fLoTrungTam.Controls.Clear();
            Chart chart = new Chart();
            chart.Size = new Size(900, 410);

            ChartArea chartArea = new ChartArea();
            chartArea.Name = "MainArea";
            chart.ChartAreas.Add(chartArea);
            Series series = new Series
            {
                Name = "DataSeries",
                ChartType = SeriesChartType.Column,
                ChartArea = "MainArea"
            };
            // Đặt tên cho các trục
            chartArea.AxisX.Title = "Tiêu Đề";
            chartArea.AxisY.Title = "Tiến Độ";
            DataTable dt = svDao.LayBaoCaoCuaNhomDangKy(SinhVienAccount.MaSoNhom);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //if (dt.Rows[i]["TrangThai"] == "Da duyet")
                {
                    series.Points.AddXY(dt.Rows[i]["TieuDe"], dt.Rows[i]["TienDo"]);
                }
            }
            chart.Series.Add(series);
            fLoTrungTam.Controls.Add(chart);
            chart.Show();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            progress.Location = new Point(btnXemDiem.Location.X, btnNhanXet.Location.Y + 30);
            uc_GV_TongKet uc_GV_TongKet = new uc_GV_TongKet();
            DataTable dtSinhVien = conNguoiDao.LayThongTinSinhVien(SinhVienAccount.MaSoNhom);
            for (int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                SinhVienn sv = new SinhVienn
                {
                    HoTen = dtSinhVien.Rows[i]["HoTen"].ToString(),
                    GioiTinh = dtSinhVien.Rows[i]["GioiTinh"].ToString(),
                    NgaySinh = Convert.ToDateTime(dtSinhVien.Rows[i]["NgaySinh"]),
                    SDT = dtSinhVien.Rows[i]["SDT"].ToString(),
                    Khoa = dtSinhVien.Rows[i]["Khoa"].ToString(),
                    Nganh = dtSinhVien.Rows[i]["Nganh"].ToString(),
                    MSSV = dtSinhVien.Rows[i]["MSSV"].ToString(),
                    MaSoNhom = dtSinhVien.Rows[i]["MaSoNhom"].ToString()
                };

                uc_SV_TongKet uc_SV_TongKet = new uc_SV_TongKet(sv);
                uc_SV_TongKet_DanhGia uc_SV_TongKet_DanhGia = new uc_SV_TongKet_DanhGia(sv);
                uc_SV_TongKet_DanhGia.btnXacNhan.Visible = false;
                if (dtSinhVien.Rows[i]["Diem"].ToString() != "")
                {
                    string ketQua;
                    int diem = 0;
                    if (int.TryParse(dtSinhVien.Rows[i]["Diem"].ToString(), out diem))
                    {
                        if (diem < 5)
                            ketQua = "D";
                        else if (diem >= 5 && diem < 6.5)
                            ketQua = "C";
                        else if (diem >= 6.5 && diem < 8)
                            ketQua = "B";
                        else if (diem >= 8 && diem < 9)
                            ketQua = "A";
                        else
                            ketQua = "A+";
                        uc_SV_TongKet.lblKetQua.Text = ketQua;
                        uc_SV_TongKet.progress.Value = diem * 10;
                        uc_SV_TongKet_DanhGia.progress.Value = diem * 10;
                        uc_SV_TongKet_DanhGia.lblKetQua.Text = ketQua;
                        uc_SV_TongKet_DanhGia.btnXacNhan.Text = "Đã xác nhận";
                        uc_SV_TongKet_DanhGia.btnXacNhan.Enabled = false;
                        uc_SV_TongKet_DanhGia.progress.AllowCursorChanges = false;
                    }
                }
                uc_SV_TongKet.pic.Click += Load_UC_DanhGia;
                uc_GV_TongKet.fLo_UC_SV_TongKet.Controls.Add(uc_SV_TongKet);
                uc_GV_TongKet.fLo_UC_SV_TongKet_DanhGia.Controls.Add(uc_SV_TongKet_DanhGia);
            }
            fLoTrungTam.Controls.Clear();
            fLoTrungTam.Controls.Add(uc_GV_TongKet);
        }
        private void Load_UC_DanhGia(object sender, EventArgs e)
        {


            Guna2PictureBox guna2PictureBox = sender as Guna2PictureBox;
            uc_SV_TongKet uc = guna2PictureBox.Parent as uc_SV_TongKet;
            FlowLayoutPanel fLo = uc.Parent as FlowLayoutPanel;
            uc_GV_TongKet uc_GV_TongKet = fLo.Parent as uc_GV_TongKet;
            uc_SV_TongKet_DanhGia uc_SV_TongKet_DanhGia = new uc_SV_TongKet_DanhGia(uc.sinhVien);
            uc_GV_TongKet.fLo_UC_SV_TongKet_DanhGia.Controls.Clear();
            uc_GV_TongKet.fLo_UC_SV_TongKet_DanhGia.Controls.Add(uc_SV_TongKet_DanhGia);


        }
        private void btnTroChuyen_Click(object sender, EventArgs e)
        {
            btnThayDoiOff(FSinhVien_Controls.flag_TroChuyen, btnThayDoiTroChuyen);

            progress.Location = new Point(btnTroChuyen.Location.X, btnNhanXet.Location.Y + 40);

            fLoTrungTam.Controls.Clear();
            ucChat_Messages ucChat_Messages = new ucChat_Messages();
            fLoTrungTam.Controls.Add(ucChat_Messages);
        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            btnThayDoiOff(FSinhVien_Controls.flag_Lich, btnThayDoiLich);

            progress.Location = new Point(btnLich.Location.X, btnNhanXet.Location.Y + 40);

            fLoTrungTam.Controls.Clear();
            uc_Calendar uc_Calendar = new uc_Calendar();
            fLoTrungTam.Controls.Add(uc_Calendar);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNhanXet_Click(sender, e);
            btnThayDoiOn(FSinhVien_Controls.flag_NhiemVu, btnThayDoiNhiemVu);
            btnThayDoiOn(FSinhVien_Controls.flag_TienDo, btnThayDoiTienDo);
            btnThayDoiOn(FSinhVien_Controls.flag_NhanXet, btnThayDoiNhanXet);
            btnThayDoiOn(FSinhVien_Controls.flag_Lich, btnThayDoiLich);
            btnThayDoiOn(FSinhVien_Controls.flag_TroChuyen, btnThayDoiTroChuyen);
        }

        private void btnNhiemVu_Click(object sender, EventArgs e)
        {
            btnThayDoiOff(FSinhVien_Controls.flag_NhiemVu, btnThayDoiNhiemVu);

            progress.Location = new Point(btnNhiemVu.Location.X, btnNhanXet.Location.Y + 40);
            fLoTrungTam.Controls.Clear();
            //Form2 form2 = new Form2();
            //fLoTrungTam.Controls.Add(form2);
            //form2.Show()
            FSinhVien_NhiemVu form2 = new FSinhVien_NhiemVu();
            form2.TopLevel = false;
            fLoTrungTam.Controls.Add(form2);
            //panelNhiemVu.Controls.Add(form2);

            //Point locationOnForm = this.ParentForm.PointToScreen(fLoTrungTam.Location);
            //Point locationOnForm = fLoTrungTam.FindForm().PointToScreen(fLoTrungTam.Location);
            //form2.Location = locationOnForm;

            form2.Show();

        }
    }
}
