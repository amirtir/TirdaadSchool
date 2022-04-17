using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TirdaadSchool.Core.DTOs;
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

        public IActionResult Index()
        {
            return View(_userservice.GetUserInformation(User.Identity.Name));
        }


        [Route("/UserPanel/EditProfile")]
        [HttpGet]
        public IActionResult EditProfile()
        {
            return View(_userservice.GetDataForEditProfileUser(User.Identity.Name));
        }

        [Route("/UserPanel/EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel  model)
        {
            if (!ModelState.IsValid){

                return View(model);
            }


            return View();
        }
    }
}