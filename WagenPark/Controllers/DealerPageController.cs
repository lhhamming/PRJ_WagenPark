using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WagenPark.Controllers
{
    [Authorize(Roles = "Dealer , Admin")]
    public class DealerPageController : Controller
    {
        // GET: DealerPage
        public ActionResult DealerPage()
        {
            return View();
        }
    }
}