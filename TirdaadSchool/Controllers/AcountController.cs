using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TirdaadSchool.Core.DTOs;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.Core.Convertor;
using TirdaadSchool.DataLayer.Entities.User;
using TirdaadSchool.Core.Generator;
using TirdaadSchool.Core.Security;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

using Microsoft.AspNetCore.Authentication;
using TirdaadSchool.Core.Senders;

namespace TirdaadSchool.Web.Controllers
{
    public class AcountController : Controller
    {
        private IUserService _userService;
        private IViewRenderService _viewrender;

        public AcountController(IUserService userService, IViewRenderService viewRender)
        {
            _userService = userService;
            _viewrender = viewRender;
        }

        #region Register

        [HttpGet]
        [Route("Register")]

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]

        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
            {

                return View(registerViewModel);
            }

            if (_userService.IsUserNameExist(registerViewModel.UserName))
            {
                ModelState.AddModelError("UserName", "این نام کاربری قبلا ثبت شده است");
                return View(registerViewModel);
            }


            if (_userService.IsEmailExist(FixedText.FixedEmail(registerViewModel.Email)))
            {
                ModelState.AddModelError("Email", "این ایمیل قبلا ثبت شده است");
                return View(registerViewModel);
            }

            //Make A User

            TirdaadSchool.DataLayer.Entities.User.User user = new DataLayer.Entities.User.User()
            {
                //Bind User
                UserName = registerViewModel.UserName,
                Email = registerViewModel.Email,
                Password = PasswordHelper.EncodePasswordMd5(registerViewModel.Password),
                RegisterDate = DateTime.Now,
                IsActive = false,
                ActiveCode = GenerateTools.GenerateCode(),
                UserAvatar = "Default.jpg",
            };

            //Add User To DataBase
            _userService.AddUser(user);
            // Send Avtivation Email

            string body = _viewrender.RenderToStringAsync("_ActiveEmail", user);

            SendEmail.Send(user.Email, "فعالسازی حساب کاربری", body);






            return View("SuccessfulRegister", user);

        }
        #endregion


        #region Login

        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {

            return View();
        }


        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginviewModel loginviewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("UserName", "اطلاعات وارد شده صحیح نمی باشد");
                return View();
            }

            var user = _userService.LoginUser(loginviewModel);
            if (user != null)
            {


                if (user.IsActive)
                {
                    //ToDo Login User

                    var claims = new List<Claim>()
                    {

                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName)
                    };

                    var identify = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identify);

                    var properties = new AuthenticationProperties()
                    {
                        IsPersistent = loginviewModel.RememberMe
                    };

                    HttpContext.SignInAsync(principal, properties);


                    //ViewBag.IsSuccess = true;
                    return Redirect("/");
                }
                else
                {
                    ModelState.AddModelError("Email", "حساب کاربری شما فعال نشده است");
                    return View(loginviewModel);

                }

            }

            ModelState.AddModelError("Email", "کاربری با مشخضات وارد شده یافت نشد");
            return View(loginviewModel);


        }
        #endregion

        #region LogOut
        [Route("LogOut")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }
        #endregion


        #region Active Acount
        [HttpGet]
        [Route("Active/{activecode}")]
        public IActionResult ActiveRegister(string activecode)
        {
            ViewBag.IsActive = _userService.ActiveAcount(activecode);
            return View();

        }
        #endregion


        #region ForgotPassword
        [HttpGet]
        [Route("/ForgotPassword")]
        public IActionResult ForgotPassword()
        {

            return View();
        }

        [HttpPost]
        [Route("/ForgotPassword")]
        public IActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
            {

                return View(forgot);
            }
            var email = FixedText.FixedEmail(forgot.Email);

            var user = _userService.GetUserByEmail(email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "کاربری با ایمیل وارد شده یافت نشد");
                return View();

            }


            var body = _viewrender.RenderToStringAsync("_ForgotPasswordEmail", user);
            SendEmail.Send(user.Email, "بازیابی کلمه عبور", body);
            ViewBag.IsSuccess = true;


            return View();
        }
        #endregion

        #region ResetPassWord
        [HttpGet]
        [Route("/ResetPassword/{activecode}")]

        public IActionResult ResetPassword( string activecode)
        {


            return View( new ResetPasswordViewModel() {ActiveCode=activecode});
        }

        [HttpPost]
        [Route("/ResetPassword/{activecode}")]

        public IActionResult ResetPassword(ResetPasswordViewModel model)
        { 
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            if (  _userService.ResetPassword(model)==false)
            {
                return BadRequest();
            }

            ViewBag.IsSuccess = true;



            return View();
        }
        #endregion


    }
}