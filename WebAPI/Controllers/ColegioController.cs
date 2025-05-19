using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColegioController : ControllerBase
    {
        private readonly IColegioService _ColegioService;

        public ColegioController(IColegioService colegioService)
        {
            _ColegioService = colegioService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Colegios = _ColegioService.GetAll();
            return Ok(Colegios);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            return Ok(Id);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] ColegioInsertDTO colegio)
        {
            var result = _ColegioService.Insert(colegio);
            return Ok(result);
        }
    }
}
