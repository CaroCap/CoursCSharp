using Demo.CinemaProject.Common.Repositories;
using Demo.CinemaProject.DAL.EntitiesDTO;
using Demo.CinemaProject.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DALCinema = Demo.CinemaProject.DAL.EntitiesDTO;

namespace Demo.CinemaProject.DAL.RepositoriesDAO
{
    // Une classe : une autre class => Héritage
    // Une class : Repository => Implémentation
    public class CinemaService : ServiceBase, ICinemaRepository<DALCinema.Cinema>
    // Clic sur l'ampoule de DALCinema.Cinema pour Implémenter Interface
    {
        // 1e etape ADO => ConnectionString
        // Server Explorer (onglet latéral gauche), clic sur DB créée ensemble , ALT + ENTER, copier coller la connection string
        //private string _connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Demo.Cinema.DataBase;Integrated Security=True";
        // Ouvrir Connection

        public void Delete(int id)
        {

            //ampoule sur SqlConnection pour Install package 'System.Data.SqlClient' puis Find and Install latest version
            //Création de la connection
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                //Création de la commande (ordre à executer) contenant les requêtes
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Requete 
                    // @id = Sqm parameter qui permette de sécurisé les infos rentrées dans DB pour éviter hacking
                    command.CommandText = "DELETE FROM [Cinema] WHERE [Id] = @id";
                    SqlParameter p_id = new SqlParameter()
                    {
                        ParameterName = "id",
                        Value = id //id mis dans les parenthès de Delete
                    };
                    //Ajouter le paramètre créé à la commande
                    command.Parameters.Add(p_id);
                    //ouvrir la commande
                    connection.Open();
                    // Executer la requête // ExecuteNonQuery() permet de récupérer le nombre de ligne qui sont retournées par ma commande
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<DALCinema.Cinema> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    // préféré décrire les noms de colonnes plutôt que d'utiliser * par faciliter pour gagné en efficacité pour l'application
                    // * va aller chercher toutes les colonnes à chaque ligne alors qu'on sait que le nom de la colonne n'a pas changé...
                    command.CommandText = "SELECT [Id], [Nom], [Ville] FROM [Cinema]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    // Yield Return permet de retourner la ligne jusqu'à ce qu'il n'y ait plus rien a lire.
                    // Un return normal casse la fonction qui ne retourne du coup qu'un seul événement
                    while (reader.Read()) yield return Mapper.ToCinema(reader);
                }
            }
        }

        public DALCinema.Cinema Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    // préféré décrire les noms de colonnes plutôt que d'utiliser * par faciliter pour gagné en efficacité pour l'application
                    // * va aller chercher toutes les colonnes à chaque ligne alors qu'on sait que le nom de la colonne n'a pas changé...
                    command.CommandText = "SELECT [Id],[Nom],[Ville] FROM [Cinema] WHERE [Id] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToCinema(reader);
                    return null;
                }
            }
        }

        public IEnumerable<DALCinema.Cinema> GetByDiffusion(int id_movie, DateTime DateDiffusion)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Cinema].[Id],[Nom],[Ville] FROM [Cinema] JOIN [Diffusion] ON [Cinema].[Id] = [Diffusion].[Cinema_Id] WHERE [Diffusion].[Film_Id] = @id_movie AND [Diffusion].[DateDiffusion] = @date";
                    SqlParameter p_id_movie = new SqlParameter() { ParameterName = "id_movie", Value = id_movie };
                    command.Parameters.Add(p_id_movie);
                    SqlParameter p_date = new SqlParameter() { ParameterName = "date", Value = DateDiffusion };
                    command.Parameters.Add(p_date);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToCinema(reader);
                }
            }
        }

        public Cinema GetByDiffusionId(int diffusionId)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    // préféré décrire les noms de colonnes plutôt que d'utiliser * par faciliter pour gagné en efficacité pour l'application
                    // * va aller chercher toutes les colonnes à chaque ligne alors qu'on sait que le nom de la colonne n'a pas changé...
                    command.CommandText = "SELECT [Cinema].[Id], [Nom], [Ville] FROM [Cinema] JOIN [Diffusion] ON [Cinema].[Id] WHERE [Diffusion].[id] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = diffusionId };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToCinema(reader);
                    return null;
                }
            }
        }

        public IEnumerable<DALCinema.Cinema> GetByFilm(int id_movie)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Cinema].[Id],[Nom],[Ville] FROM [Cinema] JOIN [Diffusion] ON [Cinema].[Id] = [Diffusion].[Cinema_Id] WHERE [Diffusion].[Film_Id] = @id_movie";
                    SqlParameter p_id_movie = new SqlParameter() { ParameterName = "id_movie", Value = id_movie };
                    command.Parameters.Add(p_id_movie);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToCinema(reader);
                }
            }
        }

        public int Insert(DALCinema.Cinema entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    //Output Inserted id = un ordre de récupération de données après l'insertion donc l'ID qui s'est autoincrémenté
                    command.CommandText = "INSERT INTO [Cinema]([Nom], [Ville]) OUTPUT [inserted].[Id] VALUES (@nom, @ville)";
                    // 2 paramètres
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.Nom };
                    SqlParameter p_ville = new SqlParameter { ParameterName = "ville", Value = entity.Ville };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_ville);
                    connection.Open();
                    // INSERT attend un retour en int donc il faut le caster (int)
                    //Execute Scalar permet de récupérer une info précise grâce au OUTPUT
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, DALCinema.Cinema entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Cinema] SET [Nom] = @nom, [Ville] = @ville WHERE [Id] = @id";
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.Nom };
                    SqlParameter p_ville = new SqlParameter { ParameterName = "ville", Value = entity.Ville };
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_ville);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

