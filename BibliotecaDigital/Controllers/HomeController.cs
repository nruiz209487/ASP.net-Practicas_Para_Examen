using BibliotecaDigital.Models.ENT;
using BibliotecaDigital.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaDigital.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {

            List<ClsLibro> obj = new List<ClsLibro>();
            try
            {
                obj = ClsBibliotecaVM.obtenerBiblioteca();
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Error));
            }
            return View("Index", obj);
        }

        public ActionResult Error()
        {
            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            ClsLibro obj = ClsBibliotecaVM.obtenerLibro(id);
            return View(obj);
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClsLibro model)
        {

            try
            {
                ClsBibliotecaVM.AyadirLibro(model);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            ClsLibro obj = ClsBibliotecaVM.obtenerLibro(id);
            return View(obj);
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClsLibro model)
        {
            try
            {
                ClsBibliotecaVM.ModificarLibro(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            ClsLibro obj = ClsBibliotecaVM.obtenerLibro(id);
            return View(obj);
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClsLibro model)
        {
            try
            {
                ClsBibliotecaVM.ElimniarLibro(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
