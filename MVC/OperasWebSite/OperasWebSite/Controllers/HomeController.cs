using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Diagnostics;
using OperasWebSite.Filters;

namespace OperasWebSite.Controllers
{
    [MyActionFilterAttibute]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToString();

            return View();
        }

        public ActionResult About() {

            ViewBag.Message = "Contenido en  view About";
            return View();
        }

   }
}