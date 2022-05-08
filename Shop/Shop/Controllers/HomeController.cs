using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Domain.Entities.User;
using Shop.BusinessLogic.Core;
namespace Shop
{
    public class HomeController : Controller
    {
        private readonly UserApi _userService = new UserApi();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Card()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult Product_details()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            UDbTable newUser = new UDbTable();
            return View(newUser);
        }
        public ActionResult Autorez()
        {
            return View();
        }
        // POST: Login/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UDbTable user)
        {
            if (ModelState.IsValid)
            {
                user.LastLogin = System.DateTime.Now;
                user.LastIp = Request.UserHostAddress;
                _userService.UserRegister(user);
            }

            return RedirectToAction("Index");
        }

    }
}