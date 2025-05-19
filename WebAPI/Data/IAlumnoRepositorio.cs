using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IAlumnoRepositorio
    {
        List<Alumno> GetAll();
        Alumno? GetById(int id);
        Alumno? Insert(Alumno alumno);
        Alumno? Update(Alumno alumno);

    }
}
