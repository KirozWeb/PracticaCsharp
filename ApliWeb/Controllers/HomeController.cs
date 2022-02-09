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

        public ActionResult Adoptar()
        {
            //ViewBag.Message = "Your contact page.";

            ViewBag.Message = "Encuentra tu mascota ideal";

            DAL.Mascota sdb = new DAL.Mascota();
            List<Mascota> mascotas = sdb.ObtenerMascotas();

            return View(mascotas);
        }

        public ActionResult AdoptoMascota(int id)
        {
            //ViewBag.Message = "Your contact page.";

            //aqui se llama a la funcion actualizar mascota
            try
            {
                if (id == 1)
                {
                    DAL.Mascota sdb = new DAL.Mascota();
                    if (sdb.AdoptoMascota(id))
                    {
                        ViewBag.Message = "Gracias por adoptar a un pequeño ";
                        //ModelState.Clear();
                    }
                }
                //return View();
                return RedirectToAction("Adoptar", "Home", "Gracias");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error al adoptar mascota " + ex;

                //return View();
                return RedirectToAction("Adoptar", "Home", "Error");
            }
            
        }

        public ActionResult Usuarios()
        {
            //ViewBag.Message = "Your contact page.";

            ViewBag.Message = "Registrese para poder adoptar";         

            return View();
        }

        [HttpPost]
        public ActionResult Usuarios(Usuario usuario)
        {
            //ViewBag.Message = "Your contact page.";
            try
            {
                if (ModelState.IsValid)
                {
                    DAL.Usuario sdb = new DAL.Usuario();
                    if (sdb.AgregarUsuario(usuario))
                    {
                        ViewBag.Message = "Gracias por registrarse: "+ usuario.Nombre;
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error al registrar usuario " + ex + ModelState.IsValid;

                return View();
            }


        }

        public ActionResult ListaUsuarios()
        {
            //ViewBag.Message = "Your contact page.";

            ViewBag.Message = "Registrese para poder adoptar";

            DAL.Usuario sdb = new DAL.Usuario();
            List<Usuario> usuarios = sdb.ObtenerUsuario();

            return View(usuarios);
        }
    }
}