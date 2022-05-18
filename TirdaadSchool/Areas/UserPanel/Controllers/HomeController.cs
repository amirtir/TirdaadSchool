using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TirdaadSchool.Core.Convertor;
using TirdaadSchool.Core.DTOs;
using TirdaadSchool.Core.Security;
using TirdaadSchool.Core.Services.Interfaces;

namespace TirdaadSchool.Web.Areas.UserPanel.Controllers
{

   [Area("UserPanel")]
    public class HomeController : Controller
    {
        private IUserService _userservice;
        public HomeController( IUserService userService )
        {
            _userservice = userService;
        }
        [Route("/UserPanel")]
        public IActionResult Index()
        {
            return View(_userservice.GetUserInformation(User.Identity.Name));
        }


        [Route("/UserPanel/EditProfile")]
        [HttpGet]
        public IActionResult EditProfile()
        {
            var Model = _userservice.GetDataForEditProfileUser(User.Identity.Name);
            return View(Model);
        }

        [Route("/UserPanel/EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(  EditProfileViewModel  model)
        {
            if (!ModelState.IsValid){

                return View(model);
            }

           

            _userservice.UpdateProfile(model);
            ViewBag.IsSucces = true;

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return View("_SuccessfulProfileEdit");
        }




        [Route("/UserPanel/ChangePassword")]
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }


        [Route("/UserPanel/ChangePassword")]
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid){

                return View(model);
            }

    

            ViewBag.status = _userservice.ChangePassword(User.Identity.Name, model);

            if (ViewBag.status == false)
            {
                ModelState.AddModelError("OldPassword", "رمز عبور فعلی اشتباه است");
                return View(model);
            }


            return View(model);
        }

        
    }
}