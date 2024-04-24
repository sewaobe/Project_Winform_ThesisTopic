using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;


namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Progress_Check : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        private int index;
        public FSinhVien_Progress_Check(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void FSinhVien_Progress_Check_Load(object sender, EventArgs e)
        {
            string sqlStr = string.Format("SELECT * FROM ThongTinNhomDangKy WHERE MSSV={0}", SinhVienAccount.Mssv);
            DataTable dtThongTinNhom = svDao.LoadData(sqlStr);
            sqlStr = string.Format("SELECT * FROM TienDo WHERE MaSoNhom={0} and LanBaoCao={1}", dtThongTinNhom.Rows[0]["MaSoNhom"],index);
            DataTable dtTienDo = svDao.LoadData(sqlStr);
            sqlStr = string.Format("SELECT * FROM ThongTinDeTai WHERE MaDeTai={0}", dtThongTinNhom.Rows[0]["MaDeTai"]);
            DataTable dtThongTinDeTai = svDao.LoadData(sqlStr);           
            if (dtThongTinDeTai.Rows.Count > 0)
            {
                txtDanhGia.Text = dtTienDo.Rows[0]["TienDo"].ToString();
                txtNhanXet.Text = dtTienDo.Rows[0]["NhanXet"].ToString();
                txtTenGiangVien.Text = dtThongTinDeTai.Rows[0]["TenGiangVien"].ToString();
            }
            
        }

        private void txtNhanXet_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtDanhGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
