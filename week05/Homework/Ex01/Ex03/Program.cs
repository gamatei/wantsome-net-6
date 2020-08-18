using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Ion","Ionescu",6.45),
                new Student("Vasile","Vasilescu",7.83),
                new Student("John","Doe",9.76),
                new Student("George","Potur",5.49),
                new Student("Vasile","Avram",8.14),
                new Student("Alin","Georgescu",3.17),
                new Student("Mike","Williams",6.46),
                new Student("Will","Smith",8.99),
                new Student("Dan","Balan",7.81),
                new Student("Cristi","Artimon",9.07),
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("Gheorghe","Chirica",405.6,8),
                new Worker("Vasile","Nechita",502,5),
                new Worker("Ion","Lupu",300,10),
                new Worker("Serban","Vasile",713.15,7),
                new Worker("Doru","Iliescu",450.17,9),
                new Worker("Alex","Dinu",550.3,5),
                new Worker("Marin","Carp",600,9),
                new Worker("Sandu","Nastase",409.9,8),
                new Worker("Titi","Paun",455.6,6),
                new Worker("Costel","Hrebenciuc",405.6,7)
            };

            var orderedStudents = students.OrderBy(x => x.Grade);
            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerH);

            //foreach (var w in orderedWorkers)
            //{
            //    Console.WriteLine($"{w.FirstName} {w.LastName} {w.MoneyPerH}");
            //}

            //foreach (var x in orderedStudents)
            //{
            //    Console.WriteLine($"{ x.FirstName} { x.LastName} { x.Grade}");
            //}

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            //foreach (var h in humans)
            //{
            //    Console.WriteLine(h.FirstName);
            //}

            //var orderedHumans = humans.OrderBy(x => $"{x.FirstName}{x.LastName} ");
            var orderedHumans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach ( var o in orderedHumans)
            {
                Console.WriteLine($"{o.FirstName} {o.LastName}");
            }
        }
    }
}
