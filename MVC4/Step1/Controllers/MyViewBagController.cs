using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Step1.Controllers
{
    public class MyViewBagController : Controller
    {
        //
        // GET: /MyViewBag/

        public ActionResult Index()
        {
            return View();
        }

    }
}
