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

namespace Winform_Project.FormSinhVien
{
    public partial class Form1 : Form
    {
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhanXet_Click(object sender, EventArgs e)
        {
            progress.Location = new Point(btnNhanXet.Location.X, btnNhanXet.Location.Y+40);
            fLoTrungTam.Controls.Clear();
            string sqlStr = string.Format("SELECT * FROM BaoCao WHERE MaSoNhom = '{0}'", SinhVienAccount.Masonhom);
            DataTable dt = svDao.LoadData(sqlStr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string trangThai;
                if (dt.Rows[i]["TienDo"].ToString() != "NULL")
                    trangThai = "Da duyet";
                else
                    trangThai = "Chua duyet";
                BaoCao bc = new BaoCao(dt.Rows[i]["TieuDe"].ToString(), dt.Rows[i]["ThoiGianGui"].ToString(), dt.Rows[i]["FileBaoCao"].ToString(), trangThai, dt.Rows[i]["MaSoNhom"].ToString());
                ucBaoCao ucBaoCao = new ucBaoCao(bc);
                fLoTrungTam.Controls.Add(ucBaoCao);
                ucBaoCao.Show();
            }

        }

        private void btnTienDo_Click(object sender, EventArgs e)
        {
            progress.Location = new Point(btnTienDo.Location.X, btnNhanXet.Location.Y + 40);
            fLoTrungTam.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNhanXet_Click(sender, e);    
        }

        private void btnNhiemVu_Click(object sender, EventArgs e)
        {
            progress.Location = new Point(btnTienDo.Location.X, btnNhanXet.Location.Y + 40);

        }
    }
}
