using CRUD_Personas.Models.DAL;
using CRUD_Personas.Models.ENT;
using CRUD_Personas.VM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Personas.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {

            return View(ClsPersonaVM.ObtenerListadoPersonas());
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            int idpersona = id;
            ClsPersonaVM objVm = new ClsPersonaVM();
            ClsPersona obj = objVm.SelecionarPersona(id);
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
        public ActionResult Create(ClsPersonaVM model)
        {
            ClsPersonaVM obj = new ClsPersonaVM();
            try
            {
                obj.Id = model.Id;
                obj.Nombre = model.Nombre;
                obj.Apellido = model.Apellido;
                obj.Edad = model.Edad;
                obj.AnyadirPersona(obj.Id, obj.Nombre, obj.Apellido, obj.Edad);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            ClsPersonaVM obj = new ClsPersonaVM();
            ClsPersona objVM = obj.SelecionarPersona(id);
            return View(objVM);
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClsPersonaVM model)
        {
            ClsPersonaVM obj = new ClsPersonaVM();
            try
            {
                obj.Nombre = model.Nombre;
                obj.Apellido = model.Apellido;
                obj.Edad = model.Edad;
                obj.EditarPersona(id, obj.Nombre, obj.Apellido, obj.Edad);
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
            ClsPersonaVM vm = new ClsPersonaVM();
            ClsPersona obj = vm.SelecionarPersona(id);
            return View(obj);
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClsPersonaVM model)
        {
            ClsPersonaVM vm = new ClsPersonaVM();
            try
            {
                vm.EliminarPersona(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
