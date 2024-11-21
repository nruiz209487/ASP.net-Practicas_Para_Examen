using BibliotecaDigital.Models.DAL;
using BibliotecaDigital.Models.ENT;
using BibliotecaDigital.Models.Exceptions;
using System.Collections.Generic;

namespace BibliotecaDigital.Models.BL
{
    public class ClsBibliotecaBL
    {

        /// <summary>
        /// Comprueba si la hora esta entre las 11 y 6
        /// </summary>
        /// <returns>devuelve un booleano con la comprobacion</returns>
        private static bool ComprobarBibliotecaAbierta()
        {
            return DateTime.Now.Hour <= 11 && DateTime.Now.Hour >= 6;
        }
        /// <summary>
        /// Pre condicion horario correcto hace como conexion a la DAL CUMPLIENDO LAS REGLAS DE NEGOCIO
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ClsMyException"></exception>
        public static List<ClsLibro> obtenerBiblioteca()
        {
            if (ComprobarBibliotecaAbierta())
            {
                throw new ClsMyException("Error la bibloteca no esta abierta entre las 11 y las 6");
            }

            return ClsBiblioteca.obtenerBiblioteca();
        }
        /// <summary>
        /// Pre condicion horario correcto hace como conexion a la DAL CUMPLIENDO LAS REGLAS DE NEGOCIO
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ClsMyException"></exception>
        public static ClsLibro obtenerLibro(int id)
        {
            if (!ComprobarBibliotecaAbierta())
            {
                throw new ClsMyException("Error la bibloteca no esta abierta entre las 11 y las 6");
            }
            return ClsBiblioteca.obtenerLibro(id);
        }
        /// <summary>
        /// Pre condicion horario correcto hace como conexion a la DAL CUMPLIENDO LAS REGLAS DE NEGOCIO
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ClsMyException"></exception>
        public static void ElimniarLibro(ClsLibro obj)
        {
            if (!ComprobarBibliotecaAbierta())
            {
                throw new ClsMyException("Error la bibloteca no esta abierta entre las 11 y las 6");
            }
            ClsBiblioteca.ElimniarLibro(obj);
        }
        /// <summary>
        /// Pre condicion horario correcto hace como conexion a la DAL CUMPLIENDO LAS REGLAS DE NEGOCIO
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ClsMyException"></exception>
        public static void AyadirLibro(ClsLibro obj)
        {
            if (!ComprobarBibliotecaAbierta())
            {
                throw new ClsMyException("Error la bibloteca no esta abierta entre las 11 y las 6");
            }
            ClsBiblioteca.AyadirLibro(obj);
        }
        /// <summary>
        /// Pre condicion horario correcto hace como conexion a la DAL CUMPLIENDO LAS REGLAS DE NEGOCIO
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ClsMyException"></exception>
        public static void ModificarLibro(ClsLibro obj)
        {
            if (!ComprobarBibliotecaAbierta())
            {
                throw new ClsMyException("Error la bibloteca no esta abierta entre las 11 y las 6");
            }
            ClsBiblioteca.ModificarLibro(obj);
        }
    }
}
