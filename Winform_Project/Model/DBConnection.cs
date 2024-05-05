using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
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

                if (sqlStr.Contains("@"))
                {
                    cmd.Parameters.Add("@File", SqlDbType.VarBinary).Value = SinhVienDao.buffer_s;
                }

                if (cmd.ExecuteNonQuery() > 0)
                {
                    uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Thực thi thành công", "Thành công");
                    uc_Toast_Notice.Show();
                }
                else
                {
                    uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Thực thi thất bại", "Thất bại");
                    uc_Toast_Notice.Show();
                }
            }
            catch
            {
                uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Thực thi lỗi", "Thất bại");
                uc_Toast_Notice.Show();
            }
            finally
            {
                conn.Close();
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
