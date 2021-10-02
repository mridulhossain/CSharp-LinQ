using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectManyInLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The SelectMany in LINQ is used to project each element of a sequence to an IEnumerable<T> 
             * and then flatten the resulting 
             * sequences into one sequence. 
             * That means the SelectMany operator combines the records from a sequence of results and then converts it into one result. */


            // data sources
            List<string> names = new List<string>() { "Mridul", "Bijoy", "Mubasher" };
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ Id = 1, Name = "Mridul", Skill =  new List<string>(){ "Php","Java" }},
                new Employee{ Id = 2, Name = "Bijoy", Skill =  new List<string>(){ "C#","Mysql" }},
                new Employee{ Id = 3, Name = "Mubasher", Skill =  new List<string>(){ "Python","Sql" }},
                new Employee{ Id = 4, Name = "Tanvir", Skill =  new List<string>(){ "R","Javascript" }},
                new Employee{ Id = 5, Name = "Upama", Skill =  new List<string>(){ "c++","Dart" }},

            };



            // query syntex
            var alphabet = from name in names from a in name select a;
            foreach (var letter in alphabet)
            {
                Console.WriteLine(letter);
            }


            //method syntex
            var alphabet2 = names.SelectMany(x => x).ToList();
            foreach (var letter in alphabet2)
            {
                Console.WriteLine(letter);
            }



            // you can get all skill by using SelectMany method
            var skills = employees.SelectMany(skill => skill.Skill).ToList();
            foreach (var skill in skills)
            {
                Console.WriteLine(skill);
            }



            // you can get all skill also using query syntex
            var allSkill = from employee in employees from skill in employee.Skill select skill;
            foreach (var skill in allSkill)
            {
                Console.WriteLine(skill);
            }
        }



        /// <summary>
        /// data structure
        /// </summary>
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<string> Skill { get; set; }
        }
    }
}
