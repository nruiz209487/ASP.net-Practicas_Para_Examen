using CRUD_Personas.Models.DAL;
using CRUD_Personas.Models.ENT;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD_Personas.VM
{
    public class ClsPersonaVM
    {
        private static List<ClsPersona> listadoDePersonas = ClsListaPersonasDAL.ObtenerListadoPersonas();
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public void EliminarPersona(int id)
        {
            ClsListaPersonasDAL.EliminarPersona(id);
        }
        public static List<ClsPersona> ObtenerListadoPersonas()
        {
            return listadoDePersonas;
        }
        public ClsPersona SelecionarPersona(int id)
        {
            ClsPersona obj = new ClsPersona();
            obj = ClsListaPersonasDAL.SelecionarPersona(id);
            return obj;
        }
        public void AnyadirPersona(int Id, string Nombre, string Apellido, int Edad)
        {
            ClsPersona obj = new ClsPersona(Id, Nombre, Apellido, Edad);
            ClsListaPersonasDAL.AnyadirPersona(obj);
        }
        public void EditarPersona(int id, string nombre, string apellido, int edad)
        {
            ClsPersona obj = new(id, nombre, apellido, edad);
            ClsListaPersonasDAL.EditarPersona(obj);
        }
    }
}
