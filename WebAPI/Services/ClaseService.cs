using WebAPI.Data;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class ClaseService : IClaseService
    {

        private readonly IClaseRepositorio _claseRepositorio;
        public ClaseService(IClaseRepositorio claseRepositorio)
        {
            _claseRepositorio = claseRepositorio;
        }
        public List<Clase> GetAll()
        {
            return _claseRepositorio.GetAll();
        }
        public Clase? GetById(int id)
        {
            return _claseRepositorio.GetById(id);
        }

        public Clase? Insert(ClaseInsertDTO clase)
        {
            var claseAInsertar = new Clase();
            claseAInsertar.Id = clase.Id;
            claseAInsertar.Name = clase.Name;
            var claseInserter = _claseRepositorio.Insert(claseAInsertar);
            return claseInserter;
        }
    }
}
