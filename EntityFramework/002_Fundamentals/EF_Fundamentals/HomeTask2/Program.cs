using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<UniversityModel>());

            using (UniversityModel db = new UniversityModel())
            {
                Teacher t1 = new Teacher { Name = "Anna Crop", Phone = "+37029648511" };
                Teacher t2 = new Teacher { Name = "Alex Cup", Phone = "+37019943066" };
                db.Teachers.AddRange(new List<Teacher> { t1, t2 });

                Student st1 = new Student { Name = "Scarlett", AdmissionYear = 2018 };
                Student st2 = new Student { Name = "Bob", AdmissionYear = 2009 };
                Student st3 = new Student { Name = "Paul", AdmissionYear = 2022 };
                db.Students.AddRange(new List<Student> { st1, st2, st3 });

                Discipline d1 = new Discipline { Name = "Math" };
                Discipline d2 = new Discipline { Name = "History" };
                Discipline d3 = new Discipline { Name = "Chemistry" };
                Discipline d4 = new Discipline { Name = "English" };
                db.Disciplines.AddRange(new List<Discipline> { d1, d2, d3, d4 });

                db.SaveChanges();

                t1.Students.Add(st2);
                t2.Students.Add(st3);
                t2.Students.Add(st1);
                t1.Students.Add(st3);

                t1.Disciplines.Add(d1);
                t1.Disciplines.Add(d2);
                t2.Disciplines.Add(d3);
                t2.Disciplines.Add(d4);
                t2.Disciplines.Add(d1);

                db.SaveChanges();

                foreach (var teacher in db.Teachers)
                {
                    Console.WriteLine($"Teacher - {teacher.Id}.{teacher.Name}");

                    if (teacher.Disciplines == null && teacher.Students == null) continue;

                    if (teacher.Disciplines != null)
                    {
                        foreach (var disc in teacher.Disciplines)
                            Console.WriteLine($"\t{disc.Name}");

                        Console.WriteLine("------------------");
                    }

                    if (teacher.Students != null)
                    {
                        foreach (var student in teacher.Students)
                            Console.WriteLine($"\t{student.Name} - {student.AdmissionYear}");

                        Console.WriteLine(new string('*', 30));
                    }
                }

                Console.ReadKey();
                Console.Clear();

                foreach (var disc in db.Disciplines)
                {
                    Console.WriteLine($"Discipline - {disc.Name}");

                    if (disc.Teachers == null) continue;

                    foreach (var teacher in disc.Teachers)
                        Console.WriteLine($"\t{teacher.Name}");

                    Console.WriteLine("------------------");
                }
            }
        }
    }
}
