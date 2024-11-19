using Mandalorian.Models.BL;
using Mandalorian.Models.DAL;
using Mandalorian.Models.ENT;
using Mandalorian.Models.Exceptions;

namespace Mandalorian.VM
{
    public class MisionVM
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Recompensa { get; set; }

        private List<ClsMision> listadoVMObj = ClsListadoMisionesBL.ObtenerMisiones();

        public List<ClsMision> GetListadoVMObj()
        {
            return listadoVMObj;
        }


        public MisionVM()
        {

        }
        public void editarMision(int id, string descripcion, int recompensa)
        {
            ClsMision obj;
            obj = ClsListadoMisionesDAL.ObtenerMision(id);
            obj.Descripcion = descripcion;
            obj.Recompensa = recompensa;
            EliminarMision(id);
            ClsListadoMisionesDAL.AnyadirMision(obj);
        }
        public ClsMision ObtenerMision(int id)
        {
    
            ClsMision obj;
            obj = ClsListadoMisionesDAL.ObtenerMision(id);
            return obj;

        }
        public void NuevaMision(string titulo, string descripcion, int recompensa)
        {

            int idNuevo = listadoVMObj.Count + 1;
            ClsMision obj = new ClsMision(idNuevo, titulo, descripcion, recompensa);
            ClsListadoMisionesDAL.AnyadirMision(obj);

        }
        public void EliminarMision(int id)
        {
        
            ClsListadoMisionesDAL.ElimnarMision(id);

        }
    }
}
