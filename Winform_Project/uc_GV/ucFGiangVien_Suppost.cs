using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class ucFGiangVien_Suppost : UserControl
    {
        GiangVienDao gvDao = new GiangVienDao();
        public ucFGiangVien_Suppost()
        {
            InitializeComponent();
        }

        
      
    }
}

