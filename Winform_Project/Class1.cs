using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project
{
    public class Class1
    {
         string ten;
         string pathImg;

        public Class1()
        {
        }

        public Class1(string ten, string pathImg)
        {
            this.Ten = ten;
            this.PathImg = pathImg;
        }

        public string Ten { get => ten; set => ten = value; }
        public string PathImg { get => pathImg; set => pathImg = value; }
    }
}
