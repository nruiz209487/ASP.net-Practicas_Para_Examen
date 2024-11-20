using PersonaCRUD.Models.DAL;
using PersonaCRUD.Models.ENT;

namespace PersonaCRUD.Models.BL
{
    public class ListadoDePersonasBL
    {
        public static List<Persona> ObtenerListado()
        {
            return ListadoDePersonasDAL.getListado();
        }
    }
}
