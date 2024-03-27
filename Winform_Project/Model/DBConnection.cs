using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDoiTuong;

namespace Winform_Project.Model
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        
        public void ThucThi(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thuc thi thanh cong");
                }
                else
                {
                    MessageBox.Show("Thuc thi that bai");

                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Loi thuc thi");
            }
        }
        public DataTable Load(string sqlStr)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dtSinhVien = new DataTable();
            adapter.Fill(dtSinhVien);
            conn.Close();
            return dtSinhVien;
        }
        
    }
}
