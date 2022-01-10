﻿using Demo.CinemaProject.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.CinemaProject.DAL.RepositoriesDAO
{
    // ICinemaRepository<TCinema> TCINEMA = l'objet que je souhaite récupérer.
    public interface ICinemaRepository<TCinema> : IRepository<TCinema, int>, IGetByDiffusionRepository<TCinema>
    {
        IEnumerable<TCinema> GetByDiffusion(int id_movie, DateTime DateDiffusion);
        IEnumerable<TCinema> GetByFilm(int id_movie);
    }
}
