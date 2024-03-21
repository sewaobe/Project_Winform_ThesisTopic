using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.FormSinhVien;

namespace Winform_Project.FSinhVien
{
    public partial class FSinhVien_Reg : Form
    {
        public FSinhVien_Reg()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FSinhVien_Reg_Done fSinhVien_Reg_Done = new FSinhVien_Reg_Done();
            this.Hide();
            fSinhVien_Reg_Done.ShowDialog();
            this.Show();    
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void FSinhVien_Reg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winDataSet4._DeTai__' table. You can move, or remove it, as needed.

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            FSinhVien_Reg_New fSinhVien_Reg_New = new FSinhVien_Reg_New();
            this.Hide();
            fSinhVien_Reg_New.ShowDialog();
            this.Show();
        }
    }
}
