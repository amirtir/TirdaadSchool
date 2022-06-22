using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TirdaadSchool.Core.DTOs.AdminPanelDTOs;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Entities.User;

namespace TirdaadSchool.Web.Pages.Admin.Users
{
    public class EditUserModel : PageModel
    {
        IPermissionService _PermissionService;
        IUserService _UserService;

        public EditUserModel(IPermissionService permissionService, IUserService userService)
        {
            _PermissionService = permissionService;
            _UserService = userService;
        }

        [BindProperty]
        public EditUserViewModel EditUserViewModel  { get; set; }
        public void OnGet( int id)
        {
            ViewData["Roles"] = _PermissionService.GetRoles();
            EditUserViewModel = _UserService.GetUserForEditMode(id);
        }
        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
               
            }

            EditUserViewModel.UserRoles = SelectedRoles;

            int userid = _UserService.EditUserByAdmin(EditUserViewModel);
            _PermissionService.EditRolesToUser(SelectedRoles, userid);
            return Redirect("/Admin/Users");
        }
    }
}
