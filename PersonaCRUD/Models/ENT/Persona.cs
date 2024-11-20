namespace PersonaCRUD.Models.ENT
{
    public class Persona
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int Age { get; set; }

        public Persona()
        {
        }

        public Persona(int id, string name, string apellido, int age)
        {
            Id = id;
            Name = name;
            Apellido = apellido;
            Age = age;
        }
    }
}
