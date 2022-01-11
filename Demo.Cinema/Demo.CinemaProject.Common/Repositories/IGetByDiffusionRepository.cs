using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.CinemaProject.Common.Repositories
{
    //TEntity = générique car on ne sait pas si on voudra un cinema ou un film
    public interface IGetByDiffusionRepository<TEntity>
    {
        public TEntity GetByDiffusionId(int diffusionId);
    }
}
