using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Afluex.Controllers
{
    public class blogController : Controller
    {
        // GET: blog
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("10-Benefits-of-Hiring-Outdoor-Advertising-Agencies-for-your-business")]
        public ActionResult outdoor_advertising()
        {
            return View("outdoor_advertising");
        }
    }
}