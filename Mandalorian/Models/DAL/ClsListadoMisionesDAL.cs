using Mandalorian.Models.ENT;
using Mandalorian.Models.Exceptions;

namespace Mandalorian.Models.DAL
{
    public class ClsListadoMisionesDAL
    {
        private static List<ClsMision> listadoDeMisionesDal = new List<ClsMision>() {

         new ClsMision(1, "Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", 5000),
         new ClsMision(2, "Recuperar armadura Beskar", "Tu armadura de Beskar ha sido robada. Debes encontrarla.", 2000),
         new ClsMision(3, "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal 'Sorgon'.", 500),
         new ClsMision(4, "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", 500)

        };

        public static List<ClsMision> GetlistadoDeMisionesDal()
        {
            return listadoDeMisionesDal;
        }
        public static ClsMision ObtenerMision(int id)
        {
            ClsMision obj;
            obj = listadoDeMisionesDal.FirstOrDefault(m => m.Id == id);

            if (obj == null)
            {
                throw new MyExcepcion("Objeto no encontado");
            }
            return obj;

        }

        public static void AnyadirMision(ClsMision value)
        {
            listadoDeMisionesDal.Add(value);
        }

        public static bool ElimnarMision(int id)
        {
            ClsMision misionEliminar;
            misionEliminar = ObtenerMision(id);

            return listadoDeMisionesDal.Remove(misionEliminar);
        }

    }
}
