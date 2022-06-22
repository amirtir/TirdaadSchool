
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TirdaadSchool.DataLayer.Entities.User;

namespace TirdaadSchool.Core.DTOs.AdminPanelDTOs
{
    public class FilterUsersViewModel
    {
     public   List<User> users { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }


    }
}
