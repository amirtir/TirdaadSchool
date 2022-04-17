using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TirdaadSchool.Core.DTOs
{
  public  class LoginviewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = " {1} نمی تواند بیشتر از {0} باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = " {1} نمی تواند بیشتر از {0} باشد")]

        public string Password { get; set; }
        [Display(Name = "مرا به خاطر بسپازر")]

        public bool RememberMe { get; set; }

    }
}
