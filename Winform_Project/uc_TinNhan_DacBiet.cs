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
using Winform_Project.EntityModel;

namespace Winform_Project
{
    public partial class uc_TinNhan_DacBiet : UserControl
    {
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        public Messengerr tinNhan;
        public uc_TinNhan_DacBiet(Messengerr tn)
        {
            InitializeComponent();
            int index = tn.NoiDung.LastIndexOf(".");
            string type = tn.NoiDung.Substring(index, tn.NoiDung.Length - index);
            if (type == ".docx")
                picFile.Image = Properties.Resources.words;
            else if (type == ".pdf")
                picFile.Image = Properties.Resources.file;
            lblNoiDung.Text = tn.NguoiGui + $" đã gửi 1 file {type}";
            lblThoiGian.Text = tn.ThoiGianGui.ToShortTimeString();
            this.tinNhan = tn;
        }

        private void TinNhanDacBiet_Click(object sender, EventArgs e)
        {
            conNguoiDao.MoTinNhanDacBiet(tinNhan);
        }
    }
}
