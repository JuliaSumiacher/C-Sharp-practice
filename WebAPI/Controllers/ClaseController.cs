using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaseController : ControllerBase
    {
        private readonly IClaseService _ClaseService;

        public ClaseController(IClaseService claseService)
        {
            _ClaseService = claseService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Clases = _ClaseService.GetAll();
            return Ok(Clases);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            return Ok(Id);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] ClaseInsertDTO clase)
        {
            var result = _ClaseService.Insert(clase);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ClaseUpdateDTO clase)
        {
            var result = _ClaseService.Update(id, clase);
            return Ok(result);
        }
    }
}

