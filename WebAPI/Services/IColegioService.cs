using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IColegioService
    {
        List<Colegio> GetAll();
        Colegio? GetById(int Id);
        Colegio? Insert(ColegioInsertDTO colegio);
    }
}

