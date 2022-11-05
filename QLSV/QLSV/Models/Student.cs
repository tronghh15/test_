using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Models
{
    public class Student
    {
        public int Id { get; set; }

        [RegularExpression(@"[A-Z]{3}[0-9]{6}")]
        [Display(Name = "Mã số Sinh viên")]
        [StringLength(9)]
        [Required]
        public string Code { get; set; }


        [Display(Name = "Họ và tên")]
        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }


        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }

        [Display(Name = "Địa chỉ Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
