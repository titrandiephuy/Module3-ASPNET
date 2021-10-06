using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display (Name = "Full name")]
        [Required (ErrorMessage = "Di me may")]
        public string Fullname { get; set; }
        [Required (ErrorMessage = "Nhap vao thang cho de")]
        [Display(Name = "Gioi tinh")]
        public string Gender { get; set; }
        [Display(Name = "Ngay Sinh")]
        [DataType (DataType.Date)]
        [Required(ErrorMessage = "Nhap vao con cho nay")]
        public DateTime Dob { get; set; }
    }
}
