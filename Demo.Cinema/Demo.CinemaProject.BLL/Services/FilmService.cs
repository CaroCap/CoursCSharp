using Demo.CinemaProject.BLL.EntitiesBLL;
using Demo.CinemaProject.BLL.Handlers;
using Demo.CinemaProject.Common.Repositories;
using Demo.CinemaProject.DAL.RepositoriesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.CinemaProject.BLL.Services
{
    //Ajouter public pour la classe + :IRepository pour qu'elle implémente la classe
    public class FilmService : IFilmRepository<FilmBLL>
    {
        // On va créer un IRepository de ce IRepository
        private readonly IFilmRepository<DAL.EntitiesDTO.Film> _filmRepository;

        public FilmService(IFilmRepository<DAL.EntitiesDTO.Film> repository)
        {
            _filmRepository = repository;
        }

        // Création du CRUD 
        public void Delete(int id)
        {
            _filmRepository.Delete(id);
        }

        public IEnumerable<FilmBLL> Get()
        {
            // Vu que c'est une liste d'objet IEnumerable, il faut utiliser LinQ (using) avec le .Select pour qu'il transforme chaque film.
            return _filmRepository.Get().Select(f => f.ToBLL());
        }

        public FilmBLL Get(int id)
        {
            return _filmRepository.Get(id).ToBLL();
        }

        public IEnumerable<FilmBLL> GetByYear(int year)
        {
            return _filmRepository.GetByYear(year).Select(f => f.ToBLL());
        }

        public int Insert(FilmBLL entity)
        {
            return _filmRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, FilmBLL entity)
        {
            _filmRepository.Update(id, entity.ToDAL());
        }
    }
}
