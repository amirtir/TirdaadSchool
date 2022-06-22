using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TirdaadSchool.Core.DTOs.AdminPanelDTOs;
using TirdaadSchool.Core.Services.Interfaces;

namespace TirdaadSchool.Web.Pages.Admin.Users
{
    public class IndexModel : PageModel
    {
        IUserService _userservice;
        public IndexModel( IUserService userService )
        {
            _userservice= userService;  
        }
        public FilterUsersViewModel Filterusers { get; set; }
        public void OnGet(int pageid=1, string FilterEmail="", string FilterUserName="")
        {
            Filterusers= _userservice.GetFilterUsers(pageid,FilterEmail,FilterUserName);
        }
    }
}
