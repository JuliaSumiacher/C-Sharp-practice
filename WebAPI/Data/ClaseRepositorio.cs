using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ClaseRepositorio : IClaseRepositorio
    {
        private readonly AppDbContext _context;
        public ClaseRepositorio(AppDbContext context) 
        {
            _context = context;
        }
        public List<Clase> GetAll()
        {
            return _context.Clases.ToList();
        }

        public Clase? GetById(int id)
        {
            return _context.Clases.Find(id);
        }

        public Clase Insert(Clase clase)
        {
            _context.Clases.Add(clase);
            _context.SaveChanges();
            var claseExtraida = _context.Clases.FirstOrDefault(x => x.Name == clase.Name);
            return claseExtraida;
        }

    }
}