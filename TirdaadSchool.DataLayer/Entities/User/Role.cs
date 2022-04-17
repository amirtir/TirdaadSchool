using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TirdaadSchool.DataLayer.Entities.User
{
   public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Display(Name ="")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage =" {1} نمی تواند بیشتر از {0} باشد")]

        public string RoleName { get; set; }


        #region Relations

        public virtual IList<UserRole> UserRoles { get; set; }


        #endregion

    }
}
