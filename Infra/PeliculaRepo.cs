using Domain;

namespace Infra
{
    public class PeliculaRepo : IPeliculaRepo
    {

        private readonly List<Pelicula> peliculas = new List<Pelicula>();

        public void alta(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }

        public void baja(Guid id)
        {
           var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
            if (pelicula != null)
            {
                peliculas.Remove(pelicula);
            }
        }



        public IEnumerable<Pelicula> GetAll()
        {
           return peliculas;
        }

        public void modificacion(Pelicula pelicula)
        {
            // buscamos la posicion de la peli original
            var index = peliculas.FindIndex(p => p.Id == pelicula.Id);

            if (index != -1)
            {
                // pisamos el objeto viejo completo con el nuevo
                peliculas[index] = pelicula;

            }
        }
    }
}
