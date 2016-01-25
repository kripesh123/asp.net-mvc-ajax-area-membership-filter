using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Kripesh.WebStore.Application.Areas.Admin.Controllers
{

    [Authorize]
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public string Sample()
        {
            return "<h1>This is sample page.Please Login To view More</h1>";
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return Redirect("~/Login");
        }
    }
}