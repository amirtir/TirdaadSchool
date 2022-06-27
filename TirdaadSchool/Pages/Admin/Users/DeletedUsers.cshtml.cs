using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TirdaadSchool.Core.DTOs.AdminPanelDTOs;
using TirdaadSchool.Core.Services.Interfaces;

namespace TirdaadSchool.Web.Pages.Admin.Users
{
    public class DeletedUsersModel : PageModel
    {
        IUserService _userservice;
        public DeletedUsersModel(IUserService userService)
        {
            _userservice = userService;
        }
        public FilterUsersViewModel Filterusers { get; set; }
        public void OnGet(int pageid = 1, string FilterEmail = "", string FilterUserName = "")
        {
            Filterusers = _userservice.GetDeletedFilterUsers(pageid, FilterEmail, FilterUserName);
        }
    }
}
