using System.Collections.Generic;
using System.Linq;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class ReporteService : IReporteService
    {

        public IReporteRepositorio _reporteRepositorio;

        public ReporteService (IReporteRepositorio reporteRepositorio)
        {
            _reporteRepositorio = reporteRepositorio;
        }

        public List<object> GenerarReporte()
        {
            var resultado = _reporteRepositorio.GenerarReporte();
            return resultado;
        } 
        
    }
}
