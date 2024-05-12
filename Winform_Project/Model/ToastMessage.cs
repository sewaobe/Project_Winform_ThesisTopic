using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.Model
{
    public class ToastMessage
    {

        public void Check(int flag)
        {
            if (flag > 0)
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
    }
}
