using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IProfesorService
    {
        List<Profesor> GetAll();
        Profesor? GetById(int Id);
        Profesor? Insert(ProfesorInsertDTO profesor);
    }
}

