using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.EntityModel;
using Winform_Project.FormGiangVien;

namespace Winform_Project.uc_SV
{
    public partial class uc_SV_TongKet : UserControl
    {
        public SinhVienn sinhVien;
        GiangVienDao gvDao = new GiangVienDao();    
        public uc_SV_TongKet()
        {
            InitializeComponent();
        }
        public uc_SV_TongKet(SinhVienn sv)
        {
            InitializeComponent();

            this.sinhVien = sv;
            lblTen.Text = sv.HoTen;
            lblMSSV.Text = sv.MSSV;
            Load_Data(lblMSSV.Text);
        }
        private void Load_Data(string MSSV)
        {
            List<ucNhiemVu> listUcNhiemVuTatCa = gvDao.LayThongTinNhiemVu(FGiangVien_Controls.maSoNhom, "Tat ca", MSSV);
            lblTongDeTaiDuocGiao.Text = listUcNhiemVuTatCa is null ? "0" : listUcNhiemVuTatCa.Count.ToString();

            List<ucNhiemVu> listUcNhiemVuDaHoanThanh = gvDao.LayThongTinNhiemVu(FGiangVien_Controls.maSoNhom, "Da hoan thanh", MSSV);
            lblTongDeTaiDaHoanThanh.Text = listUcNhiemVuDaHoanThanh is null ? "0" : listUcNhiemVuDaHoanThanh.Count.ToString();
        }

        
    }
}
