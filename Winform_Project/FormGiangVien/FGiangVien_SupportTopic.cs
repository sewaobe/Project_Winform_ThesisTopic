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
    public partial class FGiangVien_SupportTopic : Form
    {
        public FGiangVien_SupportTopic()
        {
            InitializeComponent();
        }

      

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FGiangVien_SupportTopic_Add fGiangVien_SupportTopic_Add = new FGiangVien_SupportTopic_Add();
            this.Hide();
            fGiangVien_SupportTopic_Add.ShowDialog();
            this.Show();
        }

        private void FGiangVien_SupportTopic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winDataSet2._DeTai__' table. You can move, or remove it, as needed.

        }
    }
}
