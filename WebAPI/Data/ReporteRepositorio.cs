using Microsoft.EntityFrameworkCore;
using WebAPI.Services;

namespace WebAPI.Data
{
    public class ReporteRepositorio : IReporteRepositorio
    {
        private readonly AppDbContext _context;

        public ReporteRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public List<object> GenerarReporte()
        {
            var resultado = _context.Colegios
                .Join(_context.Clases,
                      colegio => colegio.Id,
                      clase => clase.IdColegio,
                      (colegio, clase) => new { colegio, clase })
                .Join(_context.Profesores,
                      cc => cc.clase.IdProfesor,
                      profesor => profesor.Id,
                      (cc, profesor) => new
                      {
                          Colegio = cc.colegio.Name,
                          Clase = cc.clase.Name,
                          Profesor = profesor.Name
                      })
                .ToList<object>();

            return resultado;
        }
    }
}