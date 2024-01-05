using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Afluex.Controllers
{
    public class AdController : Controller
    {
        // GET: Ad
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("outdoor-advertising")]
        public ActionResult outdoor_advertising()
        {
            return View("outdoor_advertising");
        }
    }
}