using System;
using System.Collections.Generic;

namespace Ex01
{
    class Program // INCOMPLETE
    {
        static void Main()
        {
            School school = new School("A I Cuza");
            school.classes.Add(new Class("12B", new Guid())
            {
                teachers = new List<Teacher>
                {
                        new Teacher("Popescu")
                        {
                                disciplines=new List<Discipline>
                                {
                                new Discipline("Latina",5,10),
                                new Discipline("Engleza",6,11),
                                new Discipline("Greaca",15,20),
                                new Discipline("Romana",5,12),
                                }
                        },

                        new Teacher("Ionescu")
                        {
                                disciplines=new List<Discipline>
                                {
                                new Discipline("Matematica",25,80),
                                new Discipline("Fizica",16,31),
                                new Discipline("Informatica",15,20),
                                new Discipline("Chimie",5,11),
                                }
                        }
                },
                students=new List<Student>
                {
                    new Student("Albu"),
                    new Student("Bahnovei",new Guid()),
                    new Student("Rusu"),
                    new Student("Radu"),
                    new Student("Mihai",new Guid()),
                    new Student("Stan"),
                    new Student("Mardare"),
                }
            });


        }
    }
}
