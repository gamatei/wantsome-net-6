using curs2.Entities;
using curs2.Implementations;
using curs2.Interfaces;
using Microsoft.Extensions.Configuration;
using System;

namespace curs2
{
    class Program
    {
        static void Main(string[] args)
        {
           IConfiguration config = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json", true, true)
                  .Build();


            var connectionString = config["ConnectionString"];
            Console.WriteLine((connectionString));

            IPublisherManager publisherManager = new PublisherManager(connectionString);

            int result = publisherManager.Create(
                new Entities.Publisher
                {
                    PublisherId = 1,
                    Name = "Amdrei"
                });

            //Publisher publisher = publisherManager.Read(1);
            //int result2 = publisherManager.Update(new Publisher
            //{
            //    PublisherId = 1,
            //    Name = "Florin"
            //});
        }
    }
}
