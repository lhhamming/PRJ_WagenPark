using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WagenPark.Controllers
{
    public class DealerPageController : Controller
    {
        // GET: DealerPage
        public ActionResult DealerPage()
        {
            return View();
        }

        public ActionResult Database()
        {
            return View();
        }
    }
}