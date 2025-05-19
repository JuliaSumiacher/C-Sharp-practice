using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorService _ProfesorService;

        public ProfesorController(IProfesorService profesorService)
        {
            _ProfesorService = profesorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Profesor = _ProfesorService.GetAll();
            return Ok(Profesor);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            return Ok(Id);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] ProfesorInsertDTO profesor)
        {
            var result = _ProfesorService.Insert(profesor);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ProfesorUpdateDTO profesor)
        {
            var result = _ProfesorService.Update(id, profesor);
            return Ok(result);
        }
    }
}
