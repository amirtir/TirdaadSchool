using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TirdaadSchool.Core.DTOs
{
   public class RegisterViewModel
    {

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = " {1} نمی تواند بیشتر از {0} باشد")]

        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = " {1} نمی تواند بیشتر از {0} باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = " {1} نمی تواند بیشتر از {0} باشد")]

        public string Password { get; set; }

        [Display(Name = " تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = " {1} نمی تواند بیشتر از {0} باشد")]
        [Compare("Password", ErrorMessage = "تکرار کلمه عبور با کلمه عبور مغایرت دارد")]
        public string RePassword { get; set; }
    }
}
