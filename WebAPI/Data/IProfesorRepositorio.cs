using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IProfesorRepositorio
    {
        List<Profesor> GetAll();
        Profesor? GetById(int id);
        Profesor? Insert(Profesor profesor);
        Profesor? Update(Profesor profesor);
    }
}