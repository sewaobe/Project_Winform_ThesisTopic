﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Winform_Project.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ThongTinDeTaii
    {
        /*[Required, RegularExpression(@"^\d+$", ErrorMessage = "Chỉ được nhập chữ số.")]
        [Range(minimum: 1, maximum: 100, ErrorMessage = "Số lượng chỉ từ 1 đến 100")]*/
        public string MaDeTai { get; set; }

/*        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s]+$", ErrorMessage = "Chỉ được nhập chữ cái và số.")]
*/        public string TenDeTai { get; set; }
       /* [Required, RegularExpression(@"^\d+$", ErrorMessage = "Chỉ được nhập chữ số.")]
        [Range(minimum: 1, maximum: 4, ErrorMessage = "Số lượng chỉ từ 1 đến 4")]*/
        public string SoLuong { get; set; }

/*        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s\p{P}]+$", ErrorMessage = "Chỉ được nhập chữ cái, số và dấu câu.")]
*/        public string MoTa { get; set; }

/*        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s\p{P}]+$", ErrorMessage = "Chỉ được nhập chữ cái, số và dấu câu.")]
*/        public string YeuCau { get; set; }

/*        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s\p{P}]+$", ErrorMessage = "Chỉ được nhập chữ cái, số và dấu câu.")]
*/        public string ChucNang { get; set; }

/*        [Required, RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\d\s]+$", ErrorMessage = "Chỉ được nhập chữ cái và số.")]
*/        public string TheLoai { get; set; }

/*        [Required, RegularExpression(@"^[a-zA-Z.,?!'""-]+$", ErrorMessage = "Chỉ được nhập chữ cái và dấu câu.")]
*/        public string CongNghe { get; set; }
        public string Nganh { get; set; }
        public string Khoa { get; set; }
        public string HocKy { get; set; }
/*        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Chỉ được nhập chữ cái.")]
*/        public string TenGiangVien { get; set; }
        public string TrangThai { get; set; }
        public string Diem { get; set; }
    }
}