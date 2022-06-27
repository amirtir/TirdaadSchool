using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Entities.User;

namespace TirdaadSchool.Web.Pages.Admin.Roles
{
    public class EditRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public EditRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
            Role=_permissionService.GetRoleById(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();


            _permissionService.UpdateRole(Role);

            //TODO Add Permission

            return RedirectToPage("Index");
        }
    }
}
