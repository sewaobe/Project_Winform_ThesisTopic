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

namespace Winform_Project.FormSinhVien
{
    public partial class FChat_Messages : Form
    {
        ConNguoiDao conNguoiDao = new ConNguoiDao();    
        public FChat_Messages()
        {
            InitializeComponent();
        }

        private void FChat_Messages_Load(object sender, EventArgs e)
        {
            uc_User_Chat uc_User_Chat = new uc_User_Chat();
            fLoChat.Controls.Add(uc_User_Chat);

            DataTable dtNhomDangKy = conNguoiDao.LayThongTinTatCaNhomDangKy();
            DataTable dtDeTai = conNguoiDao.LayThongTinDeTaiDangCapNhat("Da duyet");
            for (int i = 0; i < dtNhomDangKy.Rows.Count; i++)
            {
                if (dtNhomDangKy.Rows[i]["MSSV"].ToString() == FDangNhap.SinhVienAccount.Mssv)
                {
                    for(int j = 0; j < dtDeTai.Rows.Count; j++)
                    {
                        if (dtNhomDangKy.Rows[i]["MaDeTai"].ToString() == dtDeTai.Rows[j]["MaDeTai"].ToString())
                        {

                        }
                    }
                }
            }
        }
    }
}
