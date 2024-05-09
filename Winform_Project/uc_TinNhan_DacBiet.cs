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

namespace Winform_Project
{
    public partial class uc_TinNhan_DacBiet : UserControl
    {
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        public TinNhan tinNhan;
        public uc_TinNhan_DacBiet(TinNhan tn)
        {
            InitializeComponent();
            int index = tn.Noidung.IndexOf(".");
            string type = tn.Noidung.Substring(index, tn.Noidung.Length - index);
            if (type == ".docx")
                picFile.Image = Properties.Resources.words;
            else if (type == ".pdf")
                picFile.Image = Properties.Resources.file;
            lblNoiDung.Text = tn.Nguoigui + $" đã gửi 1 file {type}";
            lblThoiGian.Text = tn.Thoigiangui.ToShortTimeString();
            this.tinNhan = tn;
        }

        private void TinNhanDacBiet_Click(object sender, EventArgs e)
        {
            conNguoiDao.MoTinNhanDacBiet(tinNhan);
        }
    }
}
