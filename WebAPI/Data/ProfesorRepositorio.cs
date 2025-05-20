using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ProfesorRepositorio : IProfesorRepositorio
    {
        private readonly AppDbContext _context;
        public ProfesorRepositorio(AppDbContext context) 
        {
            _context = context;
        }
        public List<Profesor> GetAll()
        {
            return _context.Profesores.ToList();
        }

        public Profesor? GetById(int id)
        {
            return _context.Profesores.Find(id);
        }

        public Profesor Insert(Profesor profesor)
        {
            _context.Profesores.Add(profesor);
            _context.SaveChanges();
            var profesorExtraido = _context.Profesores.FirstOrDefault(x => x.Name == profesor.Name);
            return profesorExtraido;
        }

        public Profesor? Update(Profesor profesor)
        {
            _context.Profesores.Update(profesor);
            _context.SaveChanges();
            return profesor;
        }
    }
}