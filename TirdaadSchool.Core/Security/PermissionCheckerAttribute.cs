using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using TirdaadSchool.Core.Services.Interfaces;

namespace TirdaadSchool.Core.Security
{
    public class PermissionCheckerAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        IPermissionService _permissionService;
        private int _permissionid = 0;

        public PermissionCheckerAttribute(int permissionid)
        {
            _permissionid = permissionid;
          
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _permissionService=(IPermissionService)context.HttpContext.RequestServices.GetService(typeof(IPermissionService));

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                string username= context.HttpContext.User.Identity.Name;
                if (!_permissionService.CheckPermission(_permissionid, username))
                {
                    context.Result = new RedirectResult("/Login");
                }
            }
            else
            {
                context.Result = new RedirectResult("/Login");
            }
        }
    }
}
