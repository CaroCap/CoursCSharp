using Demo.CinemaProject.BLL.EntitiesBLL;

namespace Demo.CinemaProject.API.Handlers
{
    public static class Mapper // Préciser static pour le mapper ainsi que toutes ses méthodes
    {
        public static Models.Film ToAPI(this FilmBLL entity)
        {
            if(entity == null) return null;
            return new Models.Film{
                Id = entity.Id,
                Titre = entity.Titre,
                DateSortie = entity.DateSortie
            };
        }

        public static BLL.EntitiesBLL.FilmBLL ToBLL(this Models.FilmPost entiity)
        {
            if(entiity == null) return null;
            return new BLL.EntitiesBLL.FilmBLL(0, entiity.Titre, entiity.DateSortie);
        }
    }
}
