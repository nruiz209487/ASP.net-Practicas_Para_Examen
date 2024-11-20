using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonaCRUD.Models.ENT;
using PersonaCRUD.VM;

namespace PersonaCRUD.Controllers
{
    public class PersonasController : Controller
    {
        // GET: PersonasController
        public ActionResult Index()
        {
            List<Persona> lista = PersonaVM.listado;
            return View(lista);
        }

        // GET: PersonasController/Details/5
        public ActionResult Details(int id)
        {
            PersonaVM personaVM = new PersonaVM();
            Persona obj = personaVM.BuscarPersona(id);
            return View(obj);
        }

        // GET: PersonasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonaVM model)
        {

            try
            {
                PersonaVM personaVM = new PersonaVM();
                personaVM.CrearPersona(model.Name, model.Apellido, model.Age);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonaVM model)
        {
            try
            {
                PersonaVM personaVM = new PersonaVM();
                personaVM.ActualizarPersona(id,model.Name, model.Apellido, model.Age);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PersonaVM model)
        {
            try
            {
                PersonaVM personaVM = new PersonaVM();
                personaVM.EliminarPersona(id);
        
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
