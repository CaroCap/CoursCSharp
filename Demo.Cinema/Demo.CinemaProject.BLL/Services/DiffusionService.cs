using Demo.CinemaProject.BLL.EntitiesBLL;
using Demo.CinemaProject.BLL.Handlers;
using Demo.CinemaProject.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.CinemaProject.BLL.Services
{
    public class DiffusionService : IDiffusionRepository<DiffusionBLL>
    {
        private readonly IDiffusionRepository<DAL.EntitiesDTO.Diffusion> _diffusionRepository;
        private readonly IFilmRepository<DAL.EntitiesDTO.Film> _filmRepository;
        private readonly ICinemaRepository<DAL.EntitiesDTO.Cinema> _cinemaRepository;
        public DiffusionService(IDiffusionRepository<DAL.EntitiesDTO.Diffusion> repository, IFilmRepository<DAL.EntitiesDTO.Film> filmRepository, ICinemaRepository<DAL.EntitiesDTO.Cinema> cinemaRepository)
        {
            _diffusionRepository = repository;
            _filmRepository = filmRepository;
            _cinemaRepository = cinemaRepository;
        }
        public void Delete(int id)
        {
            _diffusionRepository.Delete(id);
        }

        public IEnumerable<DiffusionBLL> Get()
        {
            return _diffusionRepository.Get().Select(d =>
            {
                DiffusionBLL result = d.ToBLL();
                result.Cinema = _cinemaRepository.GetByDiffusionId(result.Id).ToBLL();
                result.Film = _filmRepository.GetByDiffusionId(result.Id).ToBLL();
                return result;
            });
        }

        public DiffusionBLL Get(int id)
        {
            DiffusionBLL result = _diffusionRepository.Get(id).ToBLL();
            result.Cinema = _cinemaRepository.GetByDiffusionId(id).ToBLL();
            result.Film = _filmRepository.GetByDiffusionId(id).ToBLL();
            return result;
        }

        public IEnumerable<DiffusionBLL> Get(DateTime date)
        {
            return _diffusionRepository.Get(date).Select(d=>d.ToBLL());
        }

        public IEnumerable<DiffusionBLL> GetByCinemaId(int cinema_id)
        {
            return _diffusionRepository.GetByCinemaId(cinema_id).Select(d =>
            {
                DiffusionBLL result = d.ToBLL();
                result.Cinema = _cinemaRepository.GetByDiffusionId(result.Id).ToBLL();
                result.Film = _filmRepository.GetByDiffusionId(result.Id).ToBLL();
                return result;
            });
        }

        public IEnumerable<DiffusionBLL> GetByFilmId(int film_id)
        {
            return _diffusionRepository.GetByFilmId(film_id).Select(d =>
            {
                DiffusionBLL result = d.ToBLL();
                result.Cinema = _cinemaRepository.GetByDiffusionId(result.Id).ToBLL();
                result.Film = _filmRepository.GetByDiffusionId(result.Id).ToBLL();
                return result;
            });
        }

        public int Insert(DiffusionBLL entity)
        {
            return _diffusionRepository.Insert(entity.toDAL());
        }

        public void Update(int id, DiffusionBLL entity)
        {
            _diffusionRepository.Update(id, entity.toDAL());
        }
    }
}
