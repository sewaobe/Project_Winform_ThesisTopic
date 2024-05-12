using Bunifu.UI.WinForms.Helpers.Transitions;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.EntityModel;
using Winform_Project.FormGiangVien;

namespace Winform_Project
{
    public partial class FGiangVien_ThesisTopics_1 : Form
    {
        GiangVienn giangVienAccount = FDangNhap.giangVienAccount;
        ucItems uc;
        int flag = 0;
        string ten_nganh = string.Empty;
        string[] khoa = { "\\CÁC KHOA\\CLC.png", "\\CÁC KHOA\\CKĐ.png", "\\CÁC KHOA\\CƠ KHÍ MÁY.png", "\\CÁC KHOA\\CÔNG NGHỆ THÔNG TIN.png", "\\CÁC KHOA\\DIEN - DIEN TU.png", "\\CÁC KHOA\\ĐTQT.png", "\\CÁC KHOA\\HÓA THỰC PHẨM.png", "\\CÁC KHOA\\KHOA HỌC ỨNG DỤNG.png", "\\CÁC KHOA\\Kinh tế.png", "\\CÁC KHOA\\LOGO Khoa In.png", "\\CÁC KHOA\\Logo Thời trang và Du lịch.png", "\\CÁC KHOA\\NGOẠI NGỮ.png", "\\CÁC KHOA\\XÂY DỰNG.png" };
        Dictionary<string, string> khoa_nganh = new Dictionary<string, string>()
        {
            { "Chat luong cao","Chat luong cao1, Chat luong cao2, Chat luong cao3"},
            { "Co khi dien","Co khi dien1, Co khi dien2, Co khi dien3"},
            { "Co khi may","Co khi may1, Co khi may2, Co khi may3"},
            { "Cong nghe thong tin","Cong nghe thong tin1, Cong nghe thong tin2, Cong nghe thong tin3"},
            { "Dien-Dien tu","Dien-Dien tu1, Dien-Dien tu2, Dien-Dien tu3"},
            { "Dao tao quoc te","Dao tao quoc te1, Dao tao quoc te2, Dao tao quoc te3"},
            { "Hoa thuc pham","Hoa thuc pham1, Hoa thuc pham2, Hoa thuc pham3"},
            { "Khoa hoc ung dung","Khoa hoc ung dung1, Khoa hoc ung dung2, Khoa hoc ung dung3"},
            { "Khoa in","Khoa in1, Khoa in2, Khoa in3"},
            { "Khoa Du lich va thoi trang","Khoa Du lich va thoi trang1, Khoa Du lich va thoi trang2, Khoa Du lich va thoi trang3"},
            { "Ngoai ngu","Ngoai ngu1, Ngoai ngu2, Ngoai ngu3"},
            { "Xay dung","Xay dung1, Xay dung2, Xay dung3"},
        };
        string[] namHoc = {"2019-2020","2020-2021","2021-2022","2022-2023","2023-2024","2024-2025"};
        string[] hocKy = { "Ky 1", "Ky 2", "Ky 3" };
        List<string> lblPaths = new List<string>();
        public FGiangVien_ThesisTopics_1()
        {
            InitializeComponent();
            uc = this.ucItems1;

            uc.picBgk.Click += LoadDataKhoa;

        }

        private void Load_Layout(List<Nganh_Khoa> nganh, string item)
        {
            int pos_current_X = -100;
            int pos_current_Y = 0;
            foreach (Nganh_Khoa j in nganh)
            {
                ucItems uc = new ucItems(j);
                if(item == "Khoa")
                    btnQuayVe.Visible = false;
                else
                    btnQuayVe.Visible = true;
                pos_current_X += 100;
                uc.Location = new Point(pos_current_X, pos_current_Y);
                if (item == "HocKy")
                    uc.picBgk.Click += TranFroms;
                else
                    uc.picBgk.Click += LoadDataKhoa;

                flowLayoutPanel1.Controls.Add(uc);
            }
            flag += 1; 
        }
        private void LoadDataKhoa(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Guna2PictureBox gnpck = sender as Guna2PictureBox;
            if (gnpck != null )
            {
                if(flag == 1)
                    ten_nganh = gnpck.Tag.ToString();
                lblPath.Text = gnpck.Tag.ToString();
                lblPaths.Add(lblPath.Text.ToString());

            }
            if (flag == 0)
            {
                List<Nganh_Khoa> nganh = new List<Nganh_Khoa>();
                for (int i = 0; i<khoa_nganh.Count; i++)
                {
                    Nganh_Khoa nganh_Khoa = new Nganh_Khoa(khoa_nganh.ElementAt(i).Key, khoa[i]);
                    nganh.Add(nganh_Khoa);
                }
                Load_Layout(nganh, "Khoa");
            }
            else if(flag == 1)
            {
                List<Nganh_Khoa> nganh = new List<Nganh_Khoa>();
                string[] nganhs = khoa_nganh[ten_nganh].Split(',');                  
                for (int j = 0; j < 3; j++)
                {
                     Nganh_Khoa nganh_Khoa = new Nganh_Khoa(nganhs[j], "\\CÁC KHOA\\CLC.png"); 
                     nganh.Add(nganh_Khoa);
                }
                Load_Layout(nganh, "Nganh");
            }
            else if(flag == 2)
            {
                List<Nganh_Khoa> nganh = new List<Nganh_Khoa>();
                for (int i = 0; i < hocKy.Length; i++)
                {
                    Nganh_Khoa nganh_Khoa = new Nganh_Khoa(hocKy[i], "\\CÁC KHOA\\CLC.png");
                    nganh.Add(nganh_Khoa);
                }
                Load_Layout(nganh, "HocKy");

            }


        }
        private void TranFroms(Object sender, EventArgs e)
        {
            Guna2PictureBox gnpck = sender as Guna2PictureBox;
            if (gnpck != null)
                lblPaths.Add(gnpck.Tag.ToString());

            FGiangVien_ThesisTopics_Add fgiangVien_ThesisTopics_Add = new FGiangVien_ThesisTopics_Add(lblPaths[1], lblPaths[2], giangVienAccount.HoTen, lblPaths[3]);
            this.Hide();
            fgiangVien_ThesisTopics_Add.ShowDialog();
        }
        private void ucItems1_Load(object sender, EventArgs e)
        {
           
        }

        private void ucItems1_Load_1(object sender, EventArgs e)
        {

        }

        private void ucItems1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flag -=2;
            lblPath.Text = "Moi ban chon khoa";
            lblPaths.RemoveAt(lblPaths.Count - 1);
            LoadDataKhoa(sender,e);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
