using CRUD_Personas.Models.ENT;

namespace CRUD_Personas.Models.DAL
{
    public class ClsListaPersonasDAL
    {
        private static List<ClsPersona> listadoPersonas = new List<ClsPersona>() {
        new ClsPersona(1, "Paco", "Parra", 25),
        new ClsPersona(2, "Ana", "Gómez", 30),
        new ClsPersona(3, "Luis", "Fernández", 22),
        new ClsPersona(4, "María", "López", 28),
        new ClsPersona(5, "Carlos", "Martínez", 35),
        new ClsPersona(6, "Sofía", "Hernández", 27),
        new ClsPersona(7, "Jorge", "Díaz", 40),
        new ClsPersona(8, "Laura", "Vargas", 19),
        new ClsPersona(9, "Diego", "Morales", 33),
        new ClsPersona(10, "Isabel", "Castro", 24),
        new ClsPersona(11, "Fernando", "Ramírez", 29),
        new ClsPersona(12, "Lucía", "Pérez", 21) };

        public static List<ClsPersona> ObtenerListadoPersonas()
        {

            return listadoPersonas;
        }
        public static ClsPersona SelecionarPersona(int id)
        {
            ClsPersona obj = new ClsPersona();
            obj = listadoPersonas.FirstOrDefault(m => m.Id == id);

            return obj;
        }

        internal static void AnyadirPersona(ClsPersona obj)
        {
            if (!listadoPersonas.Contains(obj))
                listadoPersonas.Add(obj);

        }

        internal static void EditarPersona(ClsPersona obj)
        {
            listadoPersonas.Remove(obj);
            listadoPersonas.Add(obj);

        }

        internal static void EliminarPersona(int id)
        {
            ClsPersona obj = SelecionarPersona(id);
            listadoPersonas.Remove(obj);

        }
    }


}
