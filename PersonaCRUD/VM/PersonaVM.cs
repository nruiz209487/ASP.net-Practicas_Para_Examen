using PersonaCRUD.Models.BL;
using PersonaCRUD.Models.ENT;

namespace PersonaCRUD.VM
{
    public class PersonaVM
    {
        public static List<Persona> listado = new List<Persona>()
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
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int Age { get; set; }

        public void CrearPersona(string nombre, string apellido, int edad)
        {
            int id = listado.Count + 1;
            Persona persona = new Persona(id, nombre, apellido, edad);
        }
        public void EliminarPersona(int id)
        {
            Persona persona = BuscarPersona(id);
            if (persona != null)
            {
                listado.Remove(persona);
            }
        }

        public Persona BuscarPersona(int id)
        {
            Persona persona;
            persona = listado.FirstOrDefault(m => m.Id == id);
            return persona;
        }

        public Persona ActualizarPersona(int id, string nombre, string apellido, int edad)
        {

            Persona persona = BuscarPersona(id);
            Persona nevaPersona = new(persona.Id, nombre, apellido, edad);
            listado.Remove(persona);
            return persona;
        }
    }
}
