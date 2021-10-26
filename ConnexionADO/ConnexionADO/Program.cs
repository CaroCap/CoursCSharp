using System;
using System.Data.SqlClient;

namespace ConnexionADO
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CONNEXION_ADO = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBSlide; Integrated Security = True";

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = CONNEXION_ADO;

                using (SqlCommand cmd = con.CreateCommand())
                {

        // AFFICHER ID, PRENOM et NOM
                    cmd.CommandText = "SELECT student_id, first_name, last_name FROM Student";
                con.Open();
                Console.WriteLine(con.State);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["student_id"]} {reader[1]} {reader[2]}");
                        }
                    }
                con.Close();
                Console.WriteLine(con.State);

        //MOYENNE ANNUELLE
                    cmd.CommandText = "SELECT AVG(year_result) FROM Student";
                    con.Open();
                    Console.WriteLine(con.State);

                    int moyenne = (int)cmd.ExecuteScalar();
                    con.Close();
                    Console.WriteLine(con.State);

                    Console.WriteLine("Moyenne annuelle : " + moyenne);
                }
            }

            Console.ReadLine();
        }
    }
}
