using Exo.Prof.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Exo.Prof.DAO
{
    public class ProfService
    {
        const string CONN_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBSlide;Integrated Security = True";

        public IEnumerable<Professor> Get()
        {
            using (SqlConnection connection = new SqlConnection(CONN_STRING))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT professor_id, professor_name, professor_surname, professor_hire_date, section_id, professor_office, professor_email, professor_wage FROM professor";

                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return Convert(reader);
                        }
                    }
                }
            }
        }

        private Professor Convert(IDataRecord reader)
        {
            return new Professor
            {
                professor_id = (int)reader["professor_id"],
                professor_name = (string)reader["professor_name"],
                professor_surname = (string)reader["professor_surname"],
                section_id = (int)reader["section_id"],
                professor_office = (int)reader["professor_office"],
                professor_email = (string)reader["professor_email"],
                professor_hire_date = (DateTime)reader["professor_hire_date"],
                professor_wage = (int)reader["professor_wage"]
            };
        }
    }
}
