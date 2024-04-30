using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Winform_Project.ClassDao;
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class ucFGiangVien_Progress : UserControl
    {
        GiangVienDao gvDao = new GiangVienDao();
        private double soNhiemVuDangThucHien , soNhiemVuDaHoanThanh , soNhiemVuDaQuaHan , tongSoNhiemVu;
        public ucFGiangVien_Progress()
        {
            InitializeComponent();
            
        }
        private void Load_Chart()
        {
            chartTrangThaiNhiemVu.Series["chartPie"].Points.AddXY("Đang thực hiện",Math.Round((this.soNhiemVuDangThucHien *100/ this.tongSoNhiemVu),1).ToString());
            chartTrangThaiNhiemVu.Series["chartPie"].Points.AddXY("Đã hoàn thành", Math.Round((this.soNhiemVuDaHoanThanh *100/ this.tongSoNhiemVu),1).ToString());
            chartTrangThaiNhiemVu.Series["chartPie"].Points.AddXY("Đã quá hạn", Math.Round((this.soNhiemVuDaQuaHan *100/ this.tongSoNhiemVu),1).ToString());
            chartTrangThaiNhiemVu.Series["chartPie"].Points[0].Color = Color.FromArgb(107, 83, 255);
            chartTrangThaiNhiemVu.Series["chartPie"].Points[1].Color = Color.FromArgb(1, 220, 205);
            chartTrangThaiNhiemVu.Series["chartPie"].Points[2].Color = Color.FromArgb(241, 88, 127);
        }
        private double load_SoLuongNhiemVu(string trangThai)
        {
            List<ucNhiemVu> listUcNhiemVu = new List<ucNhiemVu>();
            listUcNhiemVu = gvDao.LayThongTinNhiemVu(FGiangVien_Controls.maSoNhom, trangThai);
            double soNhiemVuTrangThai = listUcNhiemVu is null ? 0 : listUcNhiemVu.Count;
            return soNhiemVuTrangThai;
        }
        private void ucFGiangVien_Progress_Load(object sender, EventArgs e)
        {
            this.soNhiemVuDangThucHien = load_SoLuongNhiemVu("Dang thuc hien");
            this.soNhiemVuDaHoanThanh = load_SoLuongNhiemVu("Da hoan thanh");
            this.soNhiemVuDaQuaHan = load_SoLuongNhiemVu("Qua han");
            this.tongSoNhiemVu = this.soNhiemVuDaQuaHan + this.soNhiemVuDaHoanThanh + this.soNhiemVuDangThucHien;
            Load_Chart();

        }

        private void chartTrangThaiNhiemVu_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                foreach(DataPoint dp in e.HitTestResult.Series.Points)
                {
                    int i = e.HitTestResult.PointIndex;

                    if (dp != e.HitTestResult.Series.Points[i])
                    {
                        dp.Color = Color.FromArgb(100,dp.Color);
                    }
                    else
                    {
                        dp.Color = Color.FromArgb(255, dp.Color);
                        e.Text = dp.AxisLabel.ToString()+ ": " + Math.Round((Convert.ToInt32(dp.YValues[0])* this.tongSoNhiemVu /100)).ToString();
                        chartTrangThaiNhiemVu.Series["chartPie"].BorderWidth = 10;
                    }
                }
            }
            else
            {
                chartTrangThaiNhiemVu.Series["chartPie"].BorderWidth = 1;

                foreach (DataPoint dp in chartTrangThaiNhiemVu.Series["chartPie"].Points)
                {
                    dp.Color = Color.FromArgb(200,dp.Color);
                }
            }
        }

        private void chartTrangThaiNhiemVu_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
