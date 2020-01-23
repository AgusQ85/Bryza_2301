using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bryza_2301.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nic o nas, bez nas!.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ośrodek wypoczynkowy BRYZA.";

            return View();
        }
    }
}