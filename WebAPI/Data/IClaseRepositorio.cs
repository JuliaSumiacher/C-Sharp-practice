using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IClaseRepositorio
    {
        List<Clase> GetAll();
        Clase? GetById(int id);
        Clase Insert(Clase clase);

    }
}

