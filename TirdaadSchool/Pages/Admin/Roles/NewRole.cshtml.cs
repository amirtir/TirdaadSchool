using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Entities.User;

namespace TirdaadSchool.Web.Pages.Admin.Roles
{
    public class NewRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public NewRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }


        [BindProperty]
        public Role Role { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();


            Role.IsDeleted = false;
            int roleId = _permissionService.AddRole(Role);

            //TODO Add Permission

            return RedirectToPage("Index");
            
        }
    }
}

