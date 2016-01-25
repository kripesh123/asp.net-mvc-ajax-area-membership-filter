using Kripesh.WebStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Kripesh.WebStore.Application.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View(new Login());
        }

        [HttpPost]
        public ActionResult Index(Login login,string ReturnUrl="")
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(login.UserName, login.Password))
                {
                    Kripesh.WebStore.Application.Models.User user = (Kripesh.WebStore.Application.Models.User)Session["user"];
                    if (user.Status)
                    {
                        FormsAuthentication.SetAuthCookie(login.UserName, false);
                        return RedirectToAction("Index", "Admin/Dashboard");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Your Account is not Active Yet");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username/Password");
                }
            }
            else
            {
                ModelState.AddModelError("", "");
            }
            return View(new Login());
        }
    }
}