using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_Progress_Check : Form
    {
        public FSinhVien_Progress_Check()
        {
            InitializeComponent();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void FSinhVien_Progress_Check_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNhanXet_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void cbbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGiangVien.Text == "Giảng viên A")
            {
                txtNhanXet.Text = "Nhận xét của giảng viên A";
                txtDanhGia.Text = "50%";
            }
            else if (cbbGiangVien.Text == "Giảng viên B")
            {
                txtNhanXet.Text = "Nhận xét của giảng viên B";
                txtDanhGia.Text = "70%";

            }
        }
    }
}
