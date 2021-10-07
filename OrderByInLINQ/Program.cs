using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByInLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // here we see some example of orderBy, it's do ascending order your data. let's go for example
            // 

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



            // ascending data by using query syntex
            var querySyntex = (from number in numbers orderby number select number).ToList();

            foreach (var number in querySyntex)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("-----------------------------------------------------------------");



            // ascending data by using method syntex
            var methodSyntex = numbers.OrderBy(number => number).ToList();

            foreach (var number in methodSyntex)
            {
                Console.WriteLine(number);
            }




            Console.WriteLine("-----------------------------------------------------------------");

            

            // another experiment with query syntex. let's get all number who is getter then 10 and do ascending .
            var querySyntex2 = (from number in numbers where number > 10 orderby number select number).ToList();

            foreach (var number in querySyntex2)
            {
                Console.WriteLine(number);
            }



            Console.WriteLine("-----------------------------------------------------------------");


            // another experiment with query syntex , let's get all name with orderby letter
            var querySyntex3 = (from name in names orderby name select name).ToList();

            foreach (var name in querySyntex3)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("-----------------------------------------------------------------");

            // we can also order by using method syntex
            var methodSyntex2 = names.OrderBy(name => name).ToList();
            foreach (var name in methodSyntex2)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("-----------------------------------------------------------------");

            // get all number who is under the 10 and do ascending  with orderby method using method query
            var methodSyntex3 = numbers.Where(numbers => numbers < 10).OrderBy(number => number).ToList();

            foreach (var number in methodSyntex3)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-----------------------------------------------------------------");

            // let's go another experiment with student data set , get all student with ascending by roll number

            var querySyntex4 = (from student in students orderby student.Roll select student).ToList(); 

            foreach (var student in querySyntex4)
            {
                Console.WriteLine($"id- {student.Id}, name- {student.Name}, roll- {student.Roll} ");
            }

            Console.WriteLine("-----------------------------------------------------------------");

            // let's do it by method syntex
            var methodSyntex4 = students.OrderBy(x => x.Name).ToList();
            foreach (var student in methodSyntex4)
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
