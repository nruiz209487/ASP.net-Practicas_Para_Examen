using PersonaCRUD.Models.ENT;

namespace PersonaCRUD.Models.DAL
{
    public class ListadoDePersonasDAL
    {
        private static List<Persona> listado = new List<Persona>()
{
    new Persona(1, "Paco", "Parra", 25),
    new Persona(2, "Ana", "Gómez", 30),
    new Persona(3, "Luis", "Fernández", 22),
    new Persona(4, "María", "López", 28),
    new Persona(5, "Carlos", "Martínez", 35),
    new Persona(6, "Sofía", "Hernández", 27),
    new Persona(7, "Jorge", "Díaz", 40),
    new Persona(8, "Laura", "Vargas", 19),
    new Persona(9, "Diego", "Morales", 33),
    new Persona(10, "Isabel", "Castro", 24),
    new Persona(11, "Fernando", "Ramírez", 29),
    new Persona(12, "Lucía", "Pérez", 21)
};
        public static List<Persona> getListado()
        {
            return listado;
        }
        public  void CrearPersona()
        {
          
        }
    }
}
