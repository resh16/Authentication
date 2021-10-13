using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class RegisterModel
    {
        [Key]
        [Required(ErrorMessage = "Please Enter User Name")]
        [Display(Name ="UserName :")]
        public string User_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [Display(Name = "Email :")]
        public string UserEmail { get; set; }

    [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password :")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please Enter Conform Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Conform Password :")]
        [Compare("Password")]
        public string Conform_Pwd { get; set; }

        [Required(ErrorMessage = "Please Enter Gender")]
        [Display(Name = "Gender :")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter Martial_Status")]
        [Display(Name = "Martial Statusv:")]
        public string Martial_Status { get; set; }

       



    }
}
