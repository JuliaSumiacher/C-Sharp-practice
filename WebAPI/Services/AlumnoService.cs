using WebAPI.Data;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class AlumnoService : IAlumnoService
    {

        private readonly IAlumnoRepositorio _alumnoRepositorio;
        public AlumnoService(IAlumnoRepositorio alumnoRepositorio)
        {
            _alumnoRepositorio = alumnoRepositorio;
        }
        public List<Alumno> GetAll()
        {
            return _alumnoRepositorio.GetAll();
        }
        public Alumno? GetById(int id)
        {
            return _alumnoRepositorio.GetById(id);
        }
        public Alumno? Insert(AlumnoInsertDTO alumno)
        {
            var alumnoAInsertar = new Alumno();
            alumnoAInsertar.Id = alumno.Id;
            alumnoAInsertar.Name = alumno.Name;
            var alumnoInserter = _alumnoRepositorio.Insert(alumnoAInsertar);
            return alumnoInserter;

        }
    }
}
