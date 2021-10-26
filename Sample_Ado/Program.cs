using System;
using System.Data.SqlClient;

namespace SampleAdoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string _cnstr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ADO;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection
            {
                ConnectionString = _cnstr
            };

            Console.WriteLine(con.State);
            con.Open();
            Console.WriteLine(con.State);
            con.Close();
            Console.WriteLine(con.State);
                

        }
    }
}
