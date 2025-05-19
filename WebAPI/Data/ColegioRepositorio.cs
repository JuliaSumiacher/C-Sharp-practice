using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ColegioRepositorio : IColegioRepositorio
    {
        private readonly AppDbContext _context;
        public ColegioRepositorio(AppDbContext context)
        {
            _context = context;
        }
        public List<Colegio> GetAll()
        {
            return _context.Colegios.ToList();
        }

        public Colegio? GetById(int id)
        {
            return _context.Colegios.Find(id);
        }
        public Colegio Insert(Colegio colegio)
        {
            _context.Colegios.Add(colegio);
            _context.SaveChanges();
            var colegioExtraido = _context.Colegios.FirstOrDefault(x => x.Name == colegio.Name);
            return colegioExtraido;
        }
    }
}