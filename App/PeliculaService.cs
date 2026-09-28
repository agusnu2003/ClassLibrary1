using Domain;

namespace App
{
    public class PeliculaService
    {
        public readonly IPeliculaRepo _repo;

        public PeliculaService(IPeliculaRepo repo)
        {
            _repo = repo;
        }

        public void alta(Pelicula pelicula)
        {
            if(string.IsNullOrWhiteSpace(pelicula.Nombre))
            {
                throw new ArgumentException("El nombre de la película no puede estar vacío.");
            }


            _repo.alta(pelicula);
        }

        public void baja(Guid id)
        {
            _repo.baja(id);
        }

       public IEnumerable <Pelicula> Getall()
        {
            return _repo.GetAll();
        }

        public void modificacion (Pelicula pelicula)
        {
            _repo.modificacion(pelicula);

                }
    }
}
