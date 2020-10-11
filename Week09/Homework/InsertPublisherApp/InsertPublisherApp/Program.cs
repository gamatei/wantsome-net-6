using System;
using Microsoft.Extensions.Configuration;
using InsertPublisherApp.Interfaces;
using InsertPublisherApp.Implementations;

namespace InsertPublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                   .AddJsonFile("appsettings.json", true, true)
                   .Build();


            var connectionString = config["ConnectionString"];          

            IPublisherManager publisherManager = new PublisherManager(connectionString);


            int result = publisherManager.Create(
                new Entities.Publisher
                {                   
                    Name = "Academici"
                });
            Console.WriteLine(result);
        }
    }
}
