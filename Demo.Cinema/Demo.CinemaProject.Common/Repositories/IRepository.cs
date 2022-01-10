using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.CinemaProject.Common.Repositories
{
    // Rendre l'élément Générique avec <TEntity> pour que ça fonctionne pour tous les types d'entités différents
    // TId permet d'avoir des types différents (string, int, ...) et que ça se mette à jour même si ils sont différents. Mais du coup il faudra à chaque fois le préciser
    // La fonction s'adaptera selon le type d'entity qu'on rencontrera
    public interface IRepository<TEntity, TId> : IGetRepository<TEntity, TId>
    {
        TId Insert(TEntity entity);
        void Delete(TId id);
        void Update(TId id, TEntity entity);
    }
}
