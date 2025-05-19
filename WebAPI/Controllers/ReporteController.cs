using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReporteController : ControllerBase
    {
        private readonly IReporteService _reporteService;

        public ReporteController(IReporteService reporteService)
        {
            _reporteService = reporteService;
        }

        [HttpGet("colegio-clase-profesor")]
        public IActionResult GetReporte()
        {
            var reporte = _reporteService.GenerarReporte();
            return Ok(reporte);
        }
    }
}
