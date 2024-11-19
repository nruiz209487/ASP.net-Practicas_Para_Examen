namespace Mandalorian.Models.ENT
{
    public class ClsMision
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Recompensa { get; set; }
        public ClsMision() { }

        public ClsMision(int id, string titulo, string descripcion, int recompensa)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Recompensa = recompensa;
        }

        public override bool Equals(object? obj)
        {
            return obj is ClsMision mision &&
                   Id == mision.Id &&
                   Titulo == mision.Titulo &&
                   Descripcion == mision.Descripcion;
        }
    }
}
