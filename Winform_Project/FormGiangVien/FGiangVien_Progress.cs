using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class FGiangVien_Progress : Form
    {
        public FGiangVien_Progress()
        {
            InitializeComponent();
        }

        
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FGiangVien_Progress_Check fGiangVien_Progress_Check = new FGiangVien_Progress_Check();
            this.Hide();
            fGiangVien_Progress_Check.ShowDialog();
            this.Show();
        }

        private void FGiangVien_Progress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winDataSet3._DeTai__' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
