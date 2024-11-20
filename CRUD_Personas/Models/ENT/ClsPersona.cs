namespace CRUD_Personas.Models.ENT
{
    public class ClsPersona
    {


        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public ClsPersona()
        {
   
        }

        public ClsPersona(int id, string nombre, string apellido, int edad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public override bool Equals(object? obj)
        {
            return obj is ClsPersona persona &&
                   Id == persona.Id;
        }
    }
}
