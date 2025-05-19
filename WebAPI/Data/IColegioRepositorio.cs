using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IColegioRepositorio
    {
        List<Colegio> GetAll();
        Colegio? GetById(int id);
        Colegio Insert(Colegio colegio);
    }
}

