using WebAPI.Data;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class ColegioService : IColegioService
    {

        private readonly IColegioRepositorio _colegioRepositorio;
        public ColegioService(IColegioRepositorio colegioRepositorio)
        {
            _colegioRepositorio = colegioRepositorio;
        }
        public List<Colegio> GetAll()
        {
            return _colegioRepositorio.GetAll();
        }
        public Colegio? GetById(int id)
        {
            return _colegioRepositorio.GetById(id);
        }
        public Colegio? Insert(ColegioInsertDTO colegio)
        {
            var colegioAInsertar = new Colegio();
            //colegioAInsertar.Id = colegio.Id;
            colegioAInsertar.Name = colegio.Name;
            var colegioInserter = _colegioRepositorio.Insert(colegioAInsertar);
            return colegioInserter;

        }

        public Colegio? Update(int id, ColegioUpdateDTO colegio)
        {
            var colegioExistente = _colegioRepositorio.GetById(id);
            if (colegioExistente == null)
            {
                return null;
            }

            colegioExistente.Name = colegio.Name;

            return _colegioRepositorio.Update(colegioExistente);
        }
    }
}
