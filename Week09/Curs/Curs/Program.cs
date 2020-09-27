using System;
using System.Data.SqlClient;

namespace Curs
{
    class Program
    {
        static void Main(string[] args)
        {
            //un server name[ip]
            //un database name
            //detalii de autentificare
            //user&password
            //windows authentification[Trusted_Connection]

            var connectionString = @"Server=DESKTOP-GRF79V3\SQLEXPRESS;Database=week09;Trusted_Connection=True;";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
            }catch(Exception e)
            {
                //
                Console.WriteLine(e.Message);
            }
        }
    }
}
