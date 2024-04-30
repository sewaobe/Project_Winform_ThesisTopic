using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;
using Winform_Project.uc_SV;

namespace Winform_Project.FormSinhVien
{
    public partial class FSinhVien_ContactGV : Form
    {
        SinhVienDao svDao = new SinhVienDao();
        SinhVien SinhVienAccount = FDangNhap.SinhVienAccount;
        public FSinhVien_ContactGV()
        {
            InitializeComponent();
        }

        private void FSinhVien_ContactGV_Load(object sender, EventArgs e)
        {
            flowmess.Controls.Clear();
            string sqlStr = string.Format("SELECT * FROM SinhVien WHERE MSSV LIKE '{0}%'", textBox1.Text);
            DataTable dtSinhVien = svDao.LoadData(sqlStr);
            for (int i = 0; i < dtSinhVien.Rows.Count; i++)
            {
                if (dtSinhVien.Rows[i]["MaSoNhom"].ToString() == SinhVienAccount.Masonhom)
                {
                    SinhVien sinhvien = new SinhVien(dtSinhVien.Rows[i]["HoTen"].ToString(),
                        dtSinhVien.Rows[i]["GioiTinh"].ToString(),
                        Convert.ToDateTime(dtSinhVien.Rows[i]["NgaySinh"]),
                        dtSinhVien.Rows[i]["SDT"].ToString(),
                        dtSinhVien.Rows[i]["Khoa"].ToString(),
                        dtSinhVien.Rows[i]["Nganh"].ToString(),
                        dtSinhVien.Rows[i]["MSSV"].ToString(),
                        dtSinhVien.Rows[i]["MaSoNhom"].ToString()
                                                        );
                    uc_SV_ThongTin uc_sv_ThongTin = new uc_SV_ThongTin(sinhvien);
                    uc_sv_ThongTin.btnThemSinhVien.Click += btnThemSV_Click;
                    flowmess.Controls.Add(uc_sv_ThongTin);
                    uc_sv_ThongTin.Show();
                }
            }
            //string sqlStr = string.Format("SELECT * FROM Messenger WHERE NguoiNhan='{0}' or NguoiGui='{0}'", SinhVienAccount.Mssv);
            //DataTable dt = svDao.LoadData(sqlStr);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    Label label = new Label();
            //    label.Width = flowmess.Width / 4 * 3;
            //    if (dt.Rows[i]["NguoiGui"].ToString() == SinhVienAccount.Mssv)
            //    {
            //        label.Width = flowmess.Width;
            //        label.Left = flowmess.Width - label.Width;
            //        label.TextAlign = ContentAlignment.MiddleRight;
            //    }
            //    else
            //    {
            //        label.Width = flowmess.Width / 4 * 3;
            //    }

            //    label.Text = dt.Rows[i]["NoiDung"].ToString();
            //    flowmess.Controls.Add(label);

        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            Guna2CirclePictureBox btn = (Guna2CirclePictureBox)sender;
            uc_SV_ThongTin uc = btn.Parent as uc_SV_ThongTin;
            LoadMess(sender, e);
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (txtmess.Text.Length > 0)
            {
                string sqlStr = string.Format("SELECT * FROM ThongTinDeTai INNER JOIN ThongTinNhomDangKy On ThongTinDeTai.MaDeTai = ThongTinNhomDangKy.MaDeTai WHERE ThongTinNhomDangKy.MSSV={0}", SinhVienAccount.Mssv);
                DataTable dt = svDao.LoadData(sqlStr);
                TinNhan tinNhan = new TinNhan(SinhVienAccount.Mssv, dt.Rows[0]["TenGiangVien"].ToString(), txtmess.Text, DateTime.Now);
                svDao.GuiTinNhan(tinNhan);
                flowmess.Controls.Clear();
                txtmess.Clear();
                LoadMess(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FSinhVien_ContactGV_Load(sender, e);
        }
        private void LoadMess(object sender, EventArgs e)
        {
            string sqlStr = string.Format("SELECT * FROM Messenger WHERE NguoiNhan='{0}' or NguoiGui='{0}'", SinhVienAccount.Mssv);
            DataTable dt = svDao.LoadData(sqlStr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TextBox textBox = new TextBox();

                Label label = new Label();
                               
                label.Text = dt.Rows[i]["NoiDung"].ToString();
                label.AutoSize = true;
                label.Refresh();
                if (label.Width > 555 / 4 * 3)
                {
                    textBox.Multiline = true;
                    textBox.Width = 555 / 4 * 3;
                }
                else
                {
                    textBox.Width = label.Width;
                }
                MessageBox.Show(label.Width.ToString() + "  " + textBox.Width.ToString());
                textBox.Text = label.Text;

                //if (dt.Rows[i]["NguoiGui"].ToString() == SinhVienAccount.Mssv)
                //{
                //    textBox.Left = this.Width - textBox.Width; 
                //    textBox.Location = new Point(this.Width - textBox.Width, i*(textBox.Height+3));
                //}
                //else
                //{
                //    textBox.Location = new Point(376, i * (textBox.Height + 3));
                //}
                if (dt.Rows[i]["NguoiGui"].ToString() == SinhVienAccount.Mssv)
                {
                    label.Left = this.Width - label.Width; 
                    label.Location = new Point(this.Width - label.Width, i*(label.Height+3));
                }
                else
                {
                    label.Location = new Point(376, i * (label.Height + 3));
                }
                this.Controls.Add(label);
                //flowmess.Controls.Add(label);
            }
        }
    }


}
