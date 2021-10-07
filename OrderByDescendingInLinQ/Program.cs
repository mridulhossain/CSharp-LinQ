using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByDescendingInLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // today we learn about descending order method with method syntex and query syntex

            List<int> numbers = new List<int>() { 100, 8, 20, 35, 66, 2, 198, 5, 6 }; // data source
            List<string> names = new List<string>() { "Mridul", "Abir", "Ekram", "Babu", "Chayan", "Dowdhul", "Fahim", "Mubasher" }; // data source
                                            
            //student's data soruce
            List<Student> students = new List<Student>()
            {
                new Student{ Id = 1, Roll = 53, Name =  "Upama" },
                new Student{ Id = 2, Roll = 108, Name =  "Mridul" },
                new Student{ Id = 3, Roll = 413, Name =  "Bijoy" },
                new Student{ Id = 4, Roll = 25, Name =  "Abir" },
                new Student{ Id = 5, Roll = 112, Name =  "Ekram" },
                new Student{ Id = 6, Roll = 138, Name =  "Chayan" },
                new Student{ Id = 7, Roll = 189, Name =  "Himel" },
                new Student{ Id = 8, Roll = 15, Name =  "Mubasher" }
            };

            var methodSyntex = numbers.OrderByDescending(x => x).ToList();
            foreach (var number in methodSyntex)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-----------------------------------------------------------------");

            var methodSyntex2 = names.OrderByDescending(x => x).ToList();
            foreach (var name in methodSyntex2)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-----------------------------------------------------------------");

            var querySyntex = (from number in numbers orderby number descending select number).ToList();
            foreach (var number in querySyntex)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-----------------------------------------------------------------");

            var querySyntex2 = (from name in names orderby name descending select name).ToList();
            foreach (var name in querySyntex2)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-----------------------------------------------------------------");

            var querySyntex3 = (from student in students orderby student.Roll descending select student).ToList();
            foreach (var student in querySyntex3)
            {
                Console.WriteLine($"id- {student.Id}, name- {student.Name}, roll- {student.Roll} ");
            }

            Console.WriteLine("-----------------------------------------------------------------");

            var methodSyntex3 = students.OrderByDescending(x => x.Name).ToList();
            foreach (var student in methodSyntex3)
            {
                Console.WriteLine($"id- {student.Id}, name- {student.Name}, roll- {student.Roll} ");
            }


        }
    }



    //student data structure
    public class Student
    {
        public int Id { get; set; }
        public int Roll { get; set; }
        public string Name { get; set; }
    }
}
