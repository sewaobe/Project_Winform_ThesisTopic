using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Project.ClassDoiTuong
{
    public class TinNhan
    {
        private string nguoigui;
        private string nguoinhan;
        private string noidung;
        private string noidungdacbiet;
        private DateTime thoigiangui;

        public TinNhan(string nguoigui, string nguoinhan, string noidung,string noiDungDacBiet, DateTime thoigiangui)
        {
            this.nguoigui = nguoigui;
            this.nguoinhan = nguoinhan;
            this.noidung = noidung;
            this.thoigiangui = thoigiangui;
            Noidungdacbiet = noiDungDacBiet;
        }

        public string Nguoigui { get => nguoigui; set => nguoigui = value; }
        public string Nguoinhan { get => nguoinhan; set => nguoinhan = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Noidungdacbiet { get => noidungdacbiet; set => noidungdacbiet = value; }
        public DateTime Thoigiangui { get => thoigiangui; set => thoigiangui = value; }
    }
}
