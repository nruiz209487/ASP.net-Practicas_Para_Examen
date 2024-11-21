using BibliotecaDigital.Models.ENT;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaDigital.Models.DAL
{
    public class ClsBiblioteca
    {
        /// <summary>
        /// Lista statica y privada para que solo puedueda ser editada en la clase 
        /// </summary>
        private static List<ClsLibro> biblioteca = new List<ClsLibro>
        {
                new ClsLibro(1, "Gabriel García Márquez", 1967, "Realismo mágico", "Una historia sobre el pueblo ficticio de Macondo."),
                new ClsLibro(2, "J.K. Rowling", 1997, "Fantasía", "La primera aventura de Harry Potter en Hogwarts."),
                new ClsLibro(3, "George Orwell", 1949, "Distopía", "Un futuro totalitario y vigilancia extrema."),
                new ClsLibro(4, "Jane Austen", 1813, "Romance", "Una crítica social con un enfoque en relaciones y matrimonio."),
                new ClsLibro(5, "Fiódor Dostoyevski", 1866, "Filosófico", "Una exploración profunda de la moralidad y el crimen.")
            };


        /// <summary>
        /// Devuelve un listado de objetos ClsLibro
        /// </summary>
        /// <returns>Devuelve la lista </returns>
        public static List<ClsLibro> obtenerBiblioteca()
        {
            return biblioteca;
        }

        /// <summary>
        /// Obtiene un libro del listado apartir de su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve un objeto ClsLibro del listado</returns>
        public static ClsLibro obtenerLibro(int id)
        {
            ClsLibro obj = biblioteca.FirstOrDefault(x => x.Id == id);
            return obj;
        }
        /// <summary>
        ///Pre condicion el obj no puede ser nulo  Elimina un libro del listado recive por paarmetro un obj ClsLibro (elimina el objeto con el msimo id)
        /// </summary>
        /// <param name="obj"></param>
        public static void ElimniarLibro(ClsLibro obj)
        {
            if (biblioteca.Contains(obj))
            {
                biblioteca.Remove(obj);
            }
        }

        /// <summary>
        /// /Pre condicion el obj no puede ser nulo anyade un libro del listado recive por paarmetro un obj ClsLibro
        /// </summary>
        /// <param name="obj"></param>
        public static void AyadirLibro(ClsLibro obj)
        {
            if (!biblioteca.Contains(obj))
            {
                biblioteca.Add(obj);
            }
        }

        /// <summary>
        ///Pre condicion el obj no puede ser nulo Modifica un libro del listado recive por paarmetro un obj ClsLibro
        /// </summary>
        /// <param name="obj"></param>
        public static void ModificarLibro(ClsLibro obj)
        {
            ElimniarLibro(obj);
            AyadirLibro(obj);
        }
    }
}
