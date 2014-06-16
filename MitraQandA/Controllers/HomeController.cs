using MitraQandA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MitraQandA.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            QnAContext context = new QnAContext();
            var model = context.Roles.ToList();
            return View(model);
        }

    }
}
