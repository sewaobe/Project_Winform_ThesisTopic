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
    public partial class FSinhVien_Support : Form
    {
        public FSinhVien_Support()
        {
            InitializeComponent();
        }

        private void FSinhVien_Support_Load(object sender, EventArgs e)
        {

        }

  
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNoiDung.Visible = true;
            txtNoiDung.Visible = true;
            txtNoiDung.Text = "Thong bao A";
        }
    }
}
