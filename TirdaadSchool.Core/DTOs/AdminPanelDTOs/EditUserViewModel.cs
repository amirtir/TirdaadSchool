using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TirdaadSchool.Core.DTOs.AdminPanelDTOs
{
    public class EditUserViewModel
    {
        public int UserId { get; set; }
        public  string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = " {1} نمی تواند بیشتر از {0} باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
       
        [MaxLength(200, ErrorMessage = " {1} نمی تواند بیشتر از {0} باشد")]

        public string Password { get; set; }

        public IFormFile AvatarFile { get; set; }

        public string AvatarName { get; set; }
        public List<int> UserRoles { get; set; }

    }
}
