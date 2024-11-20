using BindingSinModelo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BindingSinModelo.Controllers
{
        public class HomeController : Controller
        {
            public string nombre = "paco";

            public ActionResult Index()
            {
                ViewBag.Nombre = nombre; // Asignar el valor inicial al ViewBag
                return View(); // Retorna la vista Index
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Index(string nombre)
            {
                try
                {
                    ViewBag.Nombre = nombre; // Asignar el valor ingresado al ViewBag
                    return View("Saludo");  // Retornar directamente la vista Saludo
                }
                catch
                {
                    return View();
                }
            }

            public ActionResult Saludo()
            {
                return View(); // Retorna la vista Saludo
            }
        }
    }
