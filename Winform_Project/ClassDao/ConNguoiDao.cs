using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_Project.Model;

namespace Winform_Project.ClassDao
{
    internal class ConNguoiDao
    {
        DBConnection db = new DBConnection();
        public DataTable LoadData(string sqlStr)
        {
            return db.Load(sqlStr);
        }
        public void Them(string sqlStr)
        {
            string sql = sqlStr;
        }
    }
}
