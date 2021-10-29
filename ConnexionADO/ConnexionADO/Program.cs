using ClassLibrary1;
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

            // INSTANCIER UN OBJET STUDENT
            Student etudiant1 = new Student()
            {
                first_name = "Caroline",
                last_name = "Cap",
                birth_date = new DateTime(1990,1,16),
                login = "CapCar",
                section_id = 1120,
                year_result = 16,
                course_id = "WAD21"
            };

            // INSÉRER L'OBJET DANS LA BASE DE DONNÉE ET AFFICHER ID
            using (SqlConnection connection = new SqlConnection(CONNEXION_ADO))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"INSERT INTO student(first_name, last_name, birth_date, login, section_id, year_result, course_id) output inserted.student_id values ('{etudiant1.first_name}', '{etudiant1.last_name}', '{etudiant1.birth_date.ToString("yyyy-MM-dd")}', '{etudiant1.login}', {etudiant1.section_id}, {etudiant1.year_result}, '{etudiant1.course_id}')";

                    connection.Open();
                    etudiant1.student_id = (int)command.ExecuteScalar();
                }
            }
            Console.WriteLine($"{etudiant1?.student_id} - {etudiant1.first_name} {etudiant1.last_name}");
            Console.ReadLine();
        }
    }
}
