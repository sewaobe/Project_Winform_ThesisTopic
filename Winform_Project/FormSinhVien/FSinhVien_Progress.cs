using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Winform_Project.FormSinhVien;
using System.Data.SqlClient;
using Winform_Project.Model;
using System.Data.SqlTypes;
using Winform_Project.ClassDao;
using System.Windows.Forms.DataVisualization.Charting;
using Winform_Project.ClassDoiTuong;
using System.Reflection;
using System.IO;


namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien_Progress : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;

        public FSinhVien_Progress()
        {
            InitializeComponent();
        }
        private void FSinhVien_Progress_Load(object sender, EventArgs e)
        {
            //string sqlStr = string.Format("SELECT * FROM TienDo INNER JOIN ThongTinNhomDangKy On TienDo.MaSoNhom = ThongTinNhomDangKy.MaSoNhom WHERE ThongTinNhomDangKy.MSSV={0}", SinhVienAccount.Mssv);
            string sqlStr = string.Format("SELECT * FROM TienDo WHERE MaSoNhom='{0}'", SinhVienAccount.Masonhom);
            DataTable dt = svDao.LoadData(sqlStr);
            chartTienDo.ChartAreas["ChartArea1"].AxisX.Title = "Lần Báo Cáo";
            chartTienDo.ChartAreas["ChartArea1"].AxisY.Title = "Tiến Độ";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chartTienDo.Series["TienDo"].Points.AddXY(dt.Rows[i]["LanBaoCao"], dt.Rows[i]["TienDo"]);
            }
           
        }
        bool expand1 = false;
        bool expand2 = false;   
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if(expand1 == false)
            {
                flowLayoutPanel1.Height += 15;
                if(flowLayoutPanel1.Height >= flowLayoutPanel1.MaximumSize.Height)
                {
                    flowLayoutPanel2.Location = new Point(flowLayoutPanel2.Location.X, flowLayoutPanel1.MaximumSize.Height);
                    timer1.Stop();
                    expand1 = true;
                }
            }
            else
            {
                flowLayoutPanel1.Height -= 15;
                if(flowLayoutPanel1.Height<= flowLayoutPanel1.MinimumSize.Height) 
                {
                    flowLayoutPanel2.Location = new Point(flowLayoutPanel2.Location.X, flowLayoutPanel1.MinimumSize.Height);
                    timer1.Stop();
                    expand1 = false;
                }
            }*/
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            object fileName = "";
            object filePath = "";
            if(open.ShowDialog()==DialogResult.OK)
            {
                fileName = open.SafeFileName;
                filePath = open.FileName;
            }
            txtFile.Text = fileName.ToString();
        }

        private void btnXemNhanXet_Click(object sender, EventArgs e)
        {

             string sqlStr = string.Format("SELECT * FROM TienDo WHERE MaSoNhom='{0}' and LanBaoCao='{1}'", SinhVienAccount.Masonhom, cbbLanBaoCao.SelectedIndex+1);
            DataTable dtTienDo = svDao.LoadData(sqlStr);
            if (dtTienDo.Rows.Count > 0)
            {
                txtDanhGia.Text = dtTienDo.Rows[0]["TienDo"].ToString();
                txtNhanXet.Text = dtTienDo.Rows[0]["NhanXet"].ToString();
            }

        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            DataTable dt = svDao.LoadData(string.Format("SELECT * FROM ThongTinNhomDangKy WHERE MSSV={0}", SinhVienAccount.Mssv));
            //svDao.guiBaoCao(dt.Rows[0]["MaSoNhom"].ToString(), dt.Rows[0]["MaDeTai"].ToString(), txtFile.Text);
        }
    }
}
