using Mandalorian.Models.DAL;
using Mandalorian.Models.ENT;
using Mandalorian.Models.Exceptions;

namespace Mandalorian.Models.BL
{
    public class ClsListadoMisionesBL
    {
        public static List<ClsMision> ObtenerMisiones()
        {
            List<ClsMision> resList = new List<ClsMision>();

            if (ComprobarHora())
            {
                resList = ClsListadoMisionesDAL.GetlistadoDeMisionesDal();
            }
            else
            {
                throw new MyExcepcion("Acceso denegado");
            }
            return resList;
        }

        private static bool ComprobarHora()
        {
            //  return DateTime.Now.Hour > 8;
            return true;
        }
    }
}
