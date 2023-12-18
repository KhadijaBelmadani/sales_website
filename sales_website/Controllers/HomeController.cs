using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sales_website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Categories()
        {


            return View("Categories");
        }

        public ActionResult Offres()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Nouveautes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SeConnecter()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}