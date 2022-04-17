using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TirdaadSchool.DataLayer.Entities.User;

namespace TirdaadSchool.DataLayer.Entities.User
{
    public class UserRole
    {
        [Key]
        public int UR_Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        #region Relations

        public virtual User user { get; set; }
        public virtual Role role { get; set; }

        #endregion





    }


}
