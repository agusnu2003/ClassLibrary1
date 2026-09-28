namespace Domain
{
    public class Pelicula
    {
        public Guid Id { get; set; } 
        public string Nombre { get; set; } 
        public string Descripcion { get; set; }

        public int horas { get; set; }

        public int minutos { get; set; }
    }
}
