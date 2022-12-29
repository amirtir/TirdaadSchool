using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TirdaadSchool.Core.Security;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Entities.User;

namespace TirdaadSchool.Web.Pages.Admin.Roles
{
    [PermissionChecker(1)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;
        public IndexModel(IPermissionService permissionService)
        {
            _permissionService=permissionService;
        }
        public List<Role> RolesList { get; set; }
        public void OnGet()
        {
            RolesList=_permissionService.GetRoles();
        }
    }
}
