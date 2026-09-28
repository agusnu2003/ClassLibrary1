using App;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliController : ControllerBase
    {
        private readonly PeliculaService _service;

        public PeliController(PeliculaService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var peliculas = _service.Getall();
            return Ok(peliculas);

        }

        [HttpPost]

        public IActionResult Post([FromBody] PeliculaDTO pelicula)
        {
            var peliculaEntity = new Pelicula
            {
                Id = Guid.NewGuid(),
                Nombre = pelicula.Nombre,
                horas = pelicula.horas,
                Descripcion = pelicula.Descripcion,
                minutos = pelicula.minutos
            };
            try
            {
                _service.alta(peliculaEntity);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]

        public IActionResult Delete([FromBody] Guid  id)
        { 
          _service.baja(id);
            return Ok("Pelicula Eliminada");

        }

        [HttpPut]

        public IActionResult Put([FromBody] Pelicula pelicula)
        {
           
            _service.modificacion(pelicula);
            return Ok("Pelicula Modificada");
        }

    }
}
