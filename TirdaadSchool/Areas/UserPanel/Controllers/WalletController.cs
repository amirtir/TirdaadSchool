using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TirdaadSchool.Core.DTOs.WalletDTOs;
using TirdaadSchool.Core.Services.Interfaces;

namespace TirdaadSchool.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
   
    public class WalletController : Controller
    {
        private IUserService _userService;
        public WalletController( IUserService userService)
        {
          _userService=userService;
        }

        [Route("/UserPanel/Wallet")]
        [HttpGet]
        public IActionResult Index()
        {
         ViewBag.list= _userService.GetWalletUser(User.Identity.Name);
            return View();
        }
        [Route("/UserPanel/Wallet")]
        [HttpPost]
        public IActionResult Index( WalletChargeViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.list = _userService.GetWalletUser(User.Identity.Name);
                return View(charge);
            }

            _userService.ChargeWallet(User.Identity.Name, charge.Amount, "شارژ حساب");





            //ToDo: Online Payment
            return null;
        }

    }
}
