using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kripesh.WebStore.Application.Models;

namespace Kripesh.WebStore.Application.Filters
{
    public class IPFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext context = HttpContext.Current;

            User user = (User)context.Session["user"];
            if(user == null)
            {
                context.Response.Redirect("~/Login");
                context.Response.End();
            }

            base.OnActionExecuting(filterContext);
        }
    }
}