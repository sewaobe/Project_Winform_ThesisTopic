using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_Thesis_Accept : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        public FGiangVien_Thesis_Accept()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FGiangVien_Thesis_Accept_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winDataSet5._DeTai__' table. You can move, or remove it, as needed.
            
        }
    }
}
