using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IClaseService
    {
        List<Clase> GetAll();
        Clase? GetById(int Id);
        Clase? Insert(ClaseInsertDTO clase);
        Clase? Update(int id, ClaseUpdateDTO clase);
    }
}
