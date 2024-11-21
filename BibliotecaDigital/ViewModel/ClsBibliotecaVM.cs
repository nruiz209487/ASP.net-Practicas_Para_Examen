using BibliotecaDigital.Models.BL;
using BibliotecaDigital.Models.DAL;
using BibliotecaDigital.Models.ENT;
using BibliotecaDigital.Models.Exceptions;

namespace BibliotecaDigital.ViewModel
{
    public class ClsBibliotecaVM
    {
        private static List<ClsLibro> biblioteca = ClsBibliotecaBL.obtenerBiblioteca();

        /// <summary>
        /// Facilita Comunicarse con la BL
        /// </summary>
        /// <returns>List<ClsLibro> obj </returns>
        public static List<ClsLibro> obtenerBiblioteca()
        {
            return biblioteca;
        }

        /// <summary>
        /// Pre condicion horario correcto hace como conexion a la DAL CUMPLIENDO LAS REGLAS DE NEGOCIO
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ClsMyException"></exception>
        public static ClsLibro obtenerLibro(int id)
        {
            return ClsBiblioteca.obtenerLibro(id);
        }
        /// <summary>
        /// Facilita Comunicarse con la BL
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ClsMyException"></exception>
        public static void ElimniarLibro(ClsLibro obj)
        {
            ClsBiblioteca.ElimniarLibro(obj);
        }
        /// <summary>
        /// Facilita Comunicarse con la BL
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ClsMyException"></exception>
        public static void AyadirLibro(ClsLibro obj)
        {
            ClsBiblioteca.AyadirLibro(obj);
        }
        /// <summary>
        /// Facilita Comunicarse con la BL
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ClsMyException"></exception>
        public static void ModificarLibro(ClsLibro obj)
        {
            ClsBiblioteca.ModificarLibro(obj);
        }
    }
}
