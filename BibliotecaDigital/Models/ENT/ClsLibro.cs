namespace BibliotecaDigital.Models.ENT
{
    public class ClsLibro
    {


        public int Id { get; set; }
        public string Autor { get; set; }
        public int Año { get; set; }
        public string Género { get; set; }
        public string Sinopsis { get; set; }


        /// <summary>
        /// Contructor vacio para isntanciar el objeto 
        /// </summary>
        public ClsLibro()
        {
        }

        /// <summary>
        /// Contructor con todos losparametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="autor"></param>
        /// <param name="año"></param>
        /// <param name="género"></param>
        /// <param name="sinopsis"></param>
        public ClsLibro(int id, string autor, int año, string género, string sinopsis)
        {
            Id = id;
            Autor = autor;
            Año = año;
            Género = género;
            Sinopsis = sinopsis;
        }

        /// <summary>
        /// Comparador para obj del tipo libro dos libros son iguales cuando tienen el mismo ID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is ClsLibro libro &&
                   Id == libro.Id;
        }
    }
}
