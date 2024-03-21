using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_Project.Model;

namespace Winform_Project.ClassDao
{
    internal class SinhVienDao
    {
        DBConnection db = new DBConnection();
        public SinhVienDao() { }
        public DataTable LoadData(string sqlStr)
        {
            return db.Load(sqlStr);
        }
        public void DangKy()
        {

        }
        
    }
}
