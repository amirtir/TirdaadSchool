using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.Core.DTOs;
namespace TirdaadSchool.Web.Pages.Admin.Users
{
    public class DeleteUserModel : PageModel
    {
       private IUserService _userService;


       public InformationUserViewModel informationUserViewModel { get; set; }
        public DeleteUserModel(IUserService userService)
        {
            _userService = userService;
        }
        public void OnGet(int userid)
        {
            ViewData["UserId"] = userid;
            informationUserViewModel = _userService.GetUserInformation(userid);
        }
        public IActionResult OnPost(int UserId)
        {
            _userService.DeleteUser(UserId);
            return RedirectToPage("Index");
        }
    }
}
