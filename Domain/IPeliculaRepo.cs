using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IPeliculaRepo
    {
        void alta (Pelicula pelicula);
        void baja (Guid id);
        void modificacion (Pelicula pelicula);
        IEnumerable<Pelicula> GetAll();


    }
}
