using System;
using System.Data.SqlClient;

namespace Curs
{
    class Program
    {
        static void Main(string[] args)
        {        
            var connectionString = @"Server=DESKTOP-GRF79V3\SQLEXPRESS;Database=week09;Trusted_Connection=True;";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            var commandText = "select count(*) from Publisher";
            var command = new SqlCommand(commandText);

            command.Connection = connection;

            var result = command.ExecuteScalar();

            Console.WriteLine($"Response:{result}");
        }
    }
}
