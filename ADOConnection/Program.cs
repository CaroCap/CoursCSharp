using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string _cnstr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ADO;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            #region Demo Connexion
            /* SqlConnection con = new SqlConnection();
             con.ConnectionString = _cnstr;

             Console.WriteLine(con.State);
             con.Open();
            
            /* Code pour ouvrir la connection et la refermer automatiquement à la fin de l'accolade*/
            /* using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = _cnstr;
                con.Open();
            }*/
            #endregion
            //ReadFromStudent(_cnstr);
            //ReadFromSection(_cnstr);
            //Moyenne(_cnstr);
            Student student = new Student()
            {
                LastName = "Cap",
                FirstName = "Caroline",
                YearResult = 14,
                BirthDate = new DateTime(1990, 01, 16),
                SectionId = 1320
            };

            InsertStudent(student, _cnstr);

        }

        private static void ReadFromStudent(string _cnstr)
        {
            Console.WriteLine("\n Student - Connecté");
            // CONNECTE
            /* Code pour ouvrir la connection et la refermer automatiquement à la fin de l'accolade*/
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = _cnstr;
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "Select ID, FirstName, LastName FROM V_Student";
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["ID"]}°) {reader[1]} {reader[2]}");
                        }
                    }
                }
            }
        }

            private static void ReadFromSection(string _cnstr)
            {
            // DECONNECTE
                Console.WriteLine("\n Section - Déconnecté");
                using (SqlConnection con2 = new SqlConnection())
                    {
                        con2.ConnectionString = _cnstr;
                        using (SqlCommand cmd2 = con2.CreateCommand())
                        {
                            cmd2.CommandText = "Select ID, SectionName FROM Section";

                            SqlDataAdapter da = new SqlDataAdapter();
                            da.SelectCommand = cmd2;
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            if (ds.Tables.Count > 0)
                            {
                                foreach(DataRow dr in ds.Tables[0].Rows)
                                {
                                    Console.WriteLine($"{dr["ID"]} - {dr[1]}");
                                }
                            }
                        }
                    }
            }

        private static void Moyenne(string _cnstr)
        {
            Console.WriteLine("\n Moyenne Annuelle");
            using (SqlConnection con3 = new SqlConnection())
            {
                con3.ConnectionString = _cnstr;
                using (SqlCommand cmd3 = con3.CreateCommand())
                {
                    cmd3.CommandText = "SELECT AVG(CONVERT(float,YearResult)) FROM Student";
                    con3.Open();

                        double moyenne = (double)cmd3.ExecuteScalar();
                        Console.WriteLine(moyenne);
                }
            }
        }

        private static void InsertStudent(Student student, string _cnstr)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = _cnstr;
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [Student](FirstName, LastName, BirthDate, YearResult, SectionId) output inserted.Id Values ('" + student.FirstName + "','"+ student.LastName + "','" + student.BirthDate.ToString("yyyy-MM-dd") + "'," + student.YearResult + "," + student.SectionId + ");";
                    con.Open();
                    student.Id = (int)cmd.ExecuteScalar(); //Insérer un étudiant + récupérer son ID
                }
            }
        }


    }
}
