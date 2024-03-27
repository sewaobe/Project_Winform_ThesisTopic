using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.FormGiangVien;
using Winform_Project.FSinhVien;

namespace Winform_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           /* Application.Run(new FDangNhap());*/
            Application.Run(new Form1());
        }
    }
}
