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
using Winform_Project.ClassDoiTuong;
using Winform_Project.FormGiangVien;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Controls : Form
    {
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();
        public static int flag_NhiemVu = 0, flag_NhanXet = 0, flag_TienDo = 0;

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

            string sqlStr = string.Format("SELECT * FROM BaoCao WHERE MaSoNhom = '{0}'", SinhVienAccount.Masonhom);
            DataTable dt = svDao.LoadData(sqlStr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string trangThai;
                if (dt.Rows[i]["TienDo"].ToString() != "NULL" && dt.Rows[i]["TienDo"].ToString() != "")
                    trangThai = "Da duyet";
                else
                    trangThai = "Chua duyet";
                BaoCao bc = new BaoCao(dt.Rows[i]["TieuDe"].ToString(), 
                                       dt.Rows[i]["ThoiGianGui"].ToString(), 
                                       dt.Rows[i]["FileBaoCao"].ToString(),
                                       dt.Rows[i]["NhanXet"].ToString(),
                                       dt.Rows[i]["TienDo"].ToString(),
                                       dt.Rows[i]["MaSoNhom"].ToString(),
                                       trangThai);
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
        }

        private void UcBaoCao_Click(object sender, EventArgs e)
        {
            var uc = sender as ucBaoCao;
            BaoCao bc = uc.baoCao;
            MessageBox.Show(bc.NhanXet);
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
            string sqlStr = string.Format("SELECT * FROM BaoCao WHERE MaSoNhom='{0}'", SinhVienAccount.Masonhom);
            DataTable dt = svDao.LoadData(sqlStr);
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

        private void btnLich_Click(object sender, EventArgs e)
        {
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
