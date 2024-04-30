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
using Winform_Project.FormGiangVien;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Controls : Form
    {
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        SinhVienDao svDao = new SinhVienDao();
        public static int flag_NhanXet = 0, flag_TienDo = 0, flag_NhiemVu = 0;
        public FSinhVien_Controls()
        {
            InitializeComponent();
        }

        private void btnNhanXet_Click(object sender, EventArgs e)
        {
            btnThayDoiOFF(btnThayDoiNhanXet, FSinhVien_Controls.flag_NhanXet);
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
            btnThayDoiOFF(btnThayDoiTienDo, FSinhVien_Controls.flag_TienDo);
            progress.Location = new Point(btnTienDo.Location.X, btnNhanXet.Location.Y + 40);
            fLoTrungTam.Controls.Clear();
        }
        private void btnThayDoiON(Guna2Button btn, int flag)
        {
            if (flag != 0)
                btn.Visible = true;
        }
        private void btnThayDoiOFF(Guna2Button btn, int flag)
        {
            btn.Visible = false;
            flag = 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnNhanXet_Click(sender, e);
            btnThayDoiON(btnThayDoiNhiemVu, flag_NhiemVu);
            btnThayDoiON(btnThayDoiNhanXet, flag_NhanXet);
            btnThayDoiON(btnThayDoiTienDo, flag_TienDo);
        }

        private void btnNhiemVu_Click(object sender, EventArgs e)
        {
            btnThayDoiOFF(btnThayDoiNhiemVu, FSinhVien_Controls.flag_NhiemVu);
            progress.Location = new Point(btnNhiemVu.Location.X, btnNhanXet.Location.Y + 40);
            fLoTrungTam.Controls.Clear();
            //Form2 form2 = new Form2();
            //fLoTrungTam.Controls.Add(form2);
            //form2.Show()
            uc_SinhVien_NhiemVu uc_SinhVien_NhiemVu = new uc_SinhVien_NhiemVu();

            //Point locationOnForm = this.ParentForm.PointToScreen(fLoTrungTam.Location);
            fLoTrungTam.Controls.Add(uc_SinhVien_NhiemVu);

        }
    }
}
