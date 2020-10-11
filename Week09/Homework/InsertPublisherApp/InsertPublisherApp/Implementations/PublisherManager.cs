using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using InsertPublisherApp.Entities;
using InsertPublisherApp.Interfaces;

namespace InsertPublisherApp.Implementations
{
    class PublisherManager : IPublisherManager
    {
        private readonly string connectionString;
        public PublisherManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Create(Publisher publisher)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var commandText = @$"insert into Publisher values(@nameParam)
SELECT CONVERT(int, SCOPE_IDENTITY())
";

                var nameParam = new SqlParameter("nameParam", publisher.Name);

                var command = new SqlCommand(commandText);

                command.Parameters.Add(nameParam);

                command.Connection = connection;

                var newId = (int)command.ExecuteScalar();

                return newId;
            }
        }
    }        
}
