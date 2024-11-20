using Mandalorian.Models.ENT;
using Mandalorian.Models.Exceptions;
using Mandalorian.VM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mandalorian.Controllers
{
    public class MisionController : Controller
    {
        // GET: MisionController
        public ActionResult MainPage()
        {
            MisionVM obj;
            List<ClsMision> getListadoVMObj;
            try
            {
                obj = new MisionVM();
                getListadoVMObj = obj.GetListadoVMObj();
            }
            catch (MyExcepcion ex)
            {

                return RedirectToAction("Error", "Mision");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Mision");
            }

            return View(getListadoVMObj);
        }

        // GET: MisionController/Details/5
        public ActionResult Details(int id)
        {
            MisionVM obj;
            ClsMision mision;

            try
            {
                obj = new MisionVM();
                mision = obj.ObtenerMision(id);


            }
            catch (Exception ex)
            {

                return RedirectToAction("Error", "Mision");
            }
            return View(mision);
        }
        public ActionResult Error(int id)
        {
            return View();
        }
        // GET: MisionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MisionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MisionVM model)
        {
            MisionVM obj;
            try
            {
                obj = new MisionVM();
                obj.NuevaMision(model.Titulo, model.Descripcion, model.Recompensa);

                return RedirectToAction(nameof(MainPage));
            }
            catch
            {
                return View(model);
            }
        }


        // GET: MisionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MisionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MisionVM model)
        {
            MisionVM obj;
            try
            {
                obj = new MisionVM();
                obj.editarMision(id, model.Descripcion, model.Recompensa);
                return RedirectToAction(nameof(MainPage));
            }
            catch
            {
                return View();
            }
        }
        // GET: MisionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MisionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            MisionVM obj;
            try
            {
                obj = new MisionVM();
                obj.EliminarMision(id);
                return RedirectToAction(nameof(MainPage));
            }
            catch
            {
                return View();
            }
        }
    }
}
