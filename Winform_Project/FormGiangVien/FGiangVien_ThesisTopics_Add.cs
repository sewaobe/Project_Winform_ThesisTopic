using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;

namespace Winform_Project.FormGiangVien
{
    public partial class FGiangVien_ThesisTopics_Add : Form
    {
        GiangVienDao gvDao = new GiangVienDao();
        ConNguoiDao conNguoiDao = new ConNguoiDao();
        private string khoa, nganh, tenGiangVien, namHoc, hocKi;
        public FGiangVien_ThesisTopics_Add(string Khoa, string Nganh, string TenGiangVien, string HocKi)
        {
            InitializeComponent();
            this.khoa = Khoa;
            this.nganh = Nganh; 
            this.tenGiangVien = TenGiangVien;
            this.hocKi = HocKi; 
            
        }
        public FGiangVien_ThesisTopics_Add()
        {
            InitializeComponent();
        }

        private LuanVan LoadData()
        {
            return new LuanVan(txtMaDeTai.Text, 
                               txtTenDeTai.Text, 
                               txtTheLoai.Text, 
                               txtSoLuong.Text, 
                               txtMoTa.Text, 
                               txtChucNang.Text, 
                               txtYeuCau.Text, 
                               cbbCongNghe.Text,
                               khoa,
                               nganh,
                               hocKi,
                               tenGiangVien,
                               "Chua dang ki");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       /* private void Validation(object sender)
        {
            var validacao = new List<ValidationResult>();
            var contexto = new ValidationContext(sender, null, null);
            Validator.TryValidateObject(sender, contexto, validacao, true);
            foreach(var erro in validacao)
            {

                foreach (Guna2TextBox txt in this.Controls.OfType<Guna2TextBox>())
                {
                    if (txt.Tag is null == false)
                    {
                        if (txt.Tag.ToString() == erro.ErrorMessage)
                        {
                            ErrorProvider eror = new ErrorProvider();
                            eror.SetError(txt, "!!!");
                        }
                    }
                }
                
            }
        }*/
        private void btnThem_Click(object sender, EventArgs e)
        {
            LuanVan lv = LoadData();
            if(conNguoiDao.Validation(this,lv)==true)
                gvDao.Them(lv);
            else
            {
                uc_Toast_Notice uc_Toast_Notice = new uc_Toast_Notice("Thông tin đề tài chưa hợp lệ!!!!", "Thất bại");
                uc_Toast_Notice.Show();
            }
        }
    }
}
