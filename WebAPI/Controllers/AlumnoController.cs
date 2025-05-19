using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnoController : ControllerBase
    {
        private readonly IAlumnoService _AlumnoService;

        public AlumnoController (IAlumnoService alumnoService)
        {
            _AlumnoService = alumnoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Alumnos = _AlumnoService.GetAll();
            return Ok(Alumnos);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            return Ok(Id);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] AlumnoInsertDTO alumno)
        {
            var result = _AlumnoService.Insert(alumno);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] AlumnoUpdateDTO alumno)
        {
            var result = _AlumnoService.Update(id, alumno);
            return Ok(result);
        }

    }
}
