using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTPBD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hola";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "hola mundo hola mundo.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Jiijijia.";

            return View();
        }
    }
}