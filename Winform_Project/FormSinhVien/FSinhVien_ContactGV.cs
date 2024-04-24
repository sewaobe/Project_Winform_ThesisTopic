using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_ContactGV : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        public FSinhVien_ContactGV()
        {
            InitializeComponent();
        }

        private void FSinhVien_ContactGV_Load(object sender, EventArgs e)
        {
            string sqlStr = string.Format("SELECT * FROM Messenger WHERE NguoiNhan='{0}' or NguoiGui='{0}'", SinhVienAccount.Mssv);
            DataTable dt = svDao.LoadData(sqlStr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label label = new Label();
                label.Width = flowmess.Width / 4 * 3;
                if (dt.Rows[i]["NguoiGui"].ToString() == SinhVienAccount.Mssv)
                {
                    label.Width = flowmess.Width;
                    label.Left = flowmess.Width - label.Width;
                    label.TextAlign = ContentAlignment.MiddleRight;
                }
                else
                {
                    label.Width = flowmess.Width / 4 * 3;
                }

                label.Text = dt.Rows[i]["NoiDung"].ToString();
                flowmess.Controls.Add(label);
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (txtmess.Text.Length > 0)
            {
                string sqlStr = string.Format("SELECT * FROM ThongTinDeTai INNER JOIN ThongTinNhomDangKy On ThongTinDeTai.MaDeTai = ThongTinNhomDangKy.MaDeTai WHERE ThongTinNhomDangKy.MSSV={0}", SinhVienAccount.Mssv);
                DataTable dt = svDao.LoadData(sqlStr);
                TinNhan tinNhan = new TinNhan(SinhVienAccount.Mssv, dt.Rows[0]["TenGiangVien"].ToString(), txtmess.Text, DateTime.Now);
                svDao.GuiTinNhan(tinNhan);
                flowmess.Controls.Clear();
                txtmess.Clear();
                FSinhVien_ContactGV_Load(sender, e);
            }
            
        }
    }
}
