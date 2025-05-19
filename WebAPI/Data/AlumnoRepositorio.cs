using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class AlumnoRepositorio : IAlumnoRepositorio
    {
        private readonly AppDbContext _context;
        public AlumnoRepositorio(AppDbContext context) 
        {
            _context = context;
        }
        public List<Alumno> GetAll()
        {
            return _context.Alumnos.ToList();
        }

        public Alumno? GetById(int id)
        {
            return _context.Alumnos.Find(id);
        }

        public Alumno Insert(Alumno alumno)
        {
            _context.Alumnos.Add(alumno);
            _context.SaveChanges();
            var alumnoExtraido = _context.Alumnos.FirstOrDefault(x => x.Name == alumno.Name);
            return alumnoExtraido;
        }

    }
}
