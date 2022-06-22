using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TirdaadSchool.Core.DTOs.AdminPanelDTOs;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Entities.User;

namespace TirdaadSchool.Web.Pages.Admin.Users
{
    public class NewUserModel : PageModel
    {
        IPermissionService _PermissionService;
        IUserService _UserService;

        public NewUserModel(IPermissionService permissionService, IUserService userService)
        {
            _PermissionService = permissionService;
            _UserService = userService;
        }
        [BindProperty]
        public NewUserViewModel NewUserViewModel { get; set; }

        public void OnGet()
        {
            ViewData["Roles"] = _PermissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NewUserViewModel.SelectedRoles= SelectedRoles;

            int userid = _UserService.AddUserByAdmin(NewUserViewModel);
            _PermissionService.AddRolesToUser(SelectedRoles,userid);
            return Redirect("/Admin/Users");
        }
    } 
}
