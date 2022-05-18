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

         int walletId=  _userService.ChargeWallet(User.Identity.Name, charge.Amount, "شارژ حساب");

            #region Online Payment

            var payment = new ZarinpalSandbox.Payment(charge.Amount);
            var res = payment.PaymentRequest("شارژ کیف پول", "https://localhost:44324/OnlinePayment/" + walletId);
            if (res.Result.Status==100)
            {
                return Redirect("http://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }

            #endregion


            return null;
        }

    }
}
