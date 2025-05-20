using WebAPI.Data;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class ProfesorService : IProfesorService
    {

        private readonly IProfesorRepositorio _profesorRepositorio;
        public ProfesorService(IProfesorRepositorio profesorRepositorio)
        {
            _profesorRepositorio = profesorRepositorio;
        }
        public List<Profesor> GetAll()
        {
            return _profesorRepositorio.GetAll();
        }
        public Profesor? GetById(int id)
        {
            return _profesorRepositorio.GetById(id);
        }
        public Profesor? Insert(ProfesorInsertDTO profesor)
        {
            var profesorAInsertar = new Profesor();
            //profesorAInsertar.Id = profesor.Id;
            profesorAInsertar.Name = profesor.Name;
            var profesorInserter = _profesorRepositorio.Insert(profesorAInsertar);
            return profesorInserter;

        }
        public Profesor? Update(int id, ProfesorUpdateDTO profesor)
        {
            var profesorExistente = _profesorRepositorio.GetById(id);
            if (profesorExistente == null)
            {
                return null;
            }

            profesorExistente.Name = profesor.Name;

            return _profesorRepositorio.Update(profesorExistente);
        }
    }
}