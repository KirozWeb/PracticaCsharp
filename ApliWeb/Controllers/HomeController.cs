using ApliWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApliWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Registra una mascota para darla en adopcion";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            ViewBag.Message = "Registra una mascota para darla en adopcion";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(Mascota mascota)
        {
            //ViewBag.Message = "Your contact page.";

            ViewBag.Message = "Gracias por registrar a: " + mascota.Nombre;

            return View();
        }

        public ActionResult Adoptar()
        {
            //ViewBag.Message = "Your contact page.";

            ViewBag.Message = "Encuentra tu mascota ideal";

            return View();
        }
    }
}