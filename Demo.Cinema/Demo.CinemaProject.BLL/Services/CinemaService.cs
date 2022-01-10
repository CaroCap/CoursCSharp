using Demo.CinemaProject.BLL.EntitiesBLL;
using Demo.CinemaProject.BLL.Handlers;
using Demo.CinemaProject.DAL.RepositoriesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.CinemaProject.BLL.Services
{
    public class CinemaService : ICinemaRepository<CinemaBLL>
    {
        private readonly ICinemaRepository<DAL.EntitiesDTO.Cinema> _cinemaRepository;
        public CinemaService(ICinemaRepository<DAL.EntitiesDTO.Cinema> repository)
        {
            _cinemaRepository = repository;
        }

        public void Delete(int id)
        {
            _cinemaRepository.Delete(id);
        }

        public IEnumerable<CinemaBLL> Get()
        {
            // Vu que c'est une liste d'objet IEnumerable, il faut utiliser LinQ (using) avec le .Select pour qu'il transforme chaque Cinema.
            return _cinemaRepository.Get().Select(c => c.ToBLL());
        }

        public CinemaBLL Get(int id)
        {
            return _cinemaRepository.Get(id).ToBLL();
        }

        public IEnumerable<CinemaBLL> GetByDiffusion(int id_movie, DateTime DateDiffusion)
        {
            return _cinemaRepository.GetByDiffusion(id_movie, DateDiffusion).Select(c => c.ToBLL());
        }

        public CinemaBLL GetByDiffusionId(int diffusionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CinemaBLL> GetByFilm(int id_movie)
        {
            return _cinemaRepository.GetByFilm(id_movie).Select(c => c.ToBLL());
        }

        public int Insert(CinemaBLL entity)
        {
            return _cinemaRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, CinemaBLL entity)
        {
            _cinemaRepository.Update(id, entity.ToDAL());
        }
    }
}
