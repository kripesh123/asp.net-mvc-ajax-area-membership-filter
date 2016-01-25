using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kripesh.WebStore.Application.Repository;

namespace Kripesh.WebStore.Application.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepository = new UserRepository();
        // GET: User
        public ActionResult Index()
        {
            JsonResult json = new JsonResult();
            json.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            json.Data = _userRepository.GetAll();
            return json;
        }
    }
}