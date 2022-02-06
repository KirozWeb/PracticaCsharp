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
            //ViewBag.Message = "Your contact page.";
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
            try
            {
                if (ModelState.IsValid)
                {
                    DAL.Mascota sdb = new DAL.Mascota();
                    if (sdb.AgregarMascota(mascota))
                    {
                        ViewBag.Message = "Gracias por registrar a : " + mascota.Nombre;
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Error al registrar mascota " +ex+ ModelState.IsValid;

                return View();
            }

            
        }

        public ActionResult Adoptar(
            )
        {
            //ViewBag.Message = "Your contact page.";

            ViewBag.Message = "Encuentra tu mascota ideal";

            DAL.Mascota sdb = new DAL.Mascota();
            List<Mascota> mascotas = sdb.ObtenerMascotas();

            return View(mascotas);
        }
    }
}