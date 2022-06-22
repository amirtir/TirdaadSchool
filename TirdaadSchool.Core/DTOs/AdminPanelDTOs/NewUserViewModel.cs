using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirdaadSchool.Core.DTOs.AdminPanelDTOs
{
    public class NewUserViewModel
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

        public IFormFile AvatarFile { get; set; }

        public List<int> SelectedRoles { get; set; }
    }
}
