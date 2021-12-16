using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DALCinema = Demo.Cinema.DAL.EntitiesDTO;

namespace Demo.Cinema.DAL.Handlers
{
    //ajouter public et static pour que ce soit accessible partout 
    public static class Mapper
    {
        //
        public static DALCinema.Cinema convert(IDataRecord record)
        {
            if (record is null) return null;
            return new DALCinema.Cinema
            {
                //Id = (int)record["Id"], Pour éviter les erreurs de frappe, c'est mieux d'utiliser le nameof. en plus si on change le nom de la colonne, ce sera ajusté
                //SI une des colonnes est nullable ajouter une vérification => Id = (record[nameof(DALCinema.Cinema.Id)] is DBNull)? null : (int?)record[nameof(DALCinema.Cinema.Id)],
                Id = (int)record[nameof(DALCinema.Cinema.Id)],
                Nom = (string)record[nameof(DALCinema.Cinema.Nom)],
                Ville = (string)record[nameof(DALCinema.Cinema.Ville)]
            };
        }
    }
}
