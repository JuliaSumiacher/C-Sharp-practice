using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IAlumnoService
    {
        List<Alumno> GetAll();
        Alumno? GetById(int Id);
        Alumno? Insert(AlumnoInsertDTO alumno);
    }
}
