using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TirdaadSchool.DataLayer.Entities.Permissions;

namespace TirdaadSchool.DataLayer.Entities.User
{
   public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Display(Name ="نام نقش")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage =" {1} نمی تواند بیشتر از {0} باشد")]

        public string RoleName { get; set; }

        public bool IsDeleted { get; set; }
        #region Relations

        public  List<UserRole> UserRoles { get; set; }
        public List<RolePermission> rolePermissions { get; set; }

        #endregion

    }
}
