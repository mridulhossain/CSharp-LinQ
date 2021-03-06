using System;
using System.Collections.Generic;
using System.Linq;

namespace ThenByAndThenByDescendingInLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /* to day we learn about ThenBy  and ThenByDescending
             * ThenBy doing multi Level a ascending order.
             * first you have to use OrderBy then you have to use ThenBy for other's level
             */

            List<Employee> employees = new List<Employee>() // data source
            {
                new Employee{Id = 1, FirstName = "Sakhawat" , LastName = "Hossain" , Salary = 15000 },
                new Employee{Id = 2, FirstName = "Abir" , LastName = "Ahmed" , Salary = 20000 },
                new Employee{Id = 3, FirstName = "Bijoy " , LastName = "Babu" , Salary = 25000 },
                new Employee{Id = 4, FirstName = "Chayan" , LastName = "Dash" , Salary = 10000 },
                new Employee{Id = 5, FirstName = "Chayan" , LastName = "Nath" , Salary = 11000 },
                new Employee{Id = 6, FirstName = "Mosharaf" , LastName = "Hossain" , Salary = 30000 },
                new Employee{Id = 6, FirstName = "Balal" , LastName = "Hossain" , Salary = 40000 },
                new Employee{Id = 8, FirstName = "Ayesha" , LastName = "Anjum" , Salary = 50000 },
                new Employee{Id = 9, FirstName = "Upama" , LastName = "Chy" , Salary = 55000 },
                new Employee{Id = 10, FirstName = "Tanjib" , LastName = "Ahmed" , Salary = 75000 },

            };


            // let's see how to use ThenBy method syntex
            var data = employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ThenBy(x => x.Salary).ToList();

            foreach (var employee in data)
            {
                Console.WriteLine($"Id - {employee.Id},first name - {employee.FirstName},last name - {employee.LastName},salary - {employee.Salary}");
            }



            Console.WriteLine("-------------------------------------------------------------------------------");



            // now let's see by query syntex
            var data1 = (from employee in employees orderby employee.FirstName ascending, employee.LastName ascending, employee.Salary ascending select employee).ToList();

            foreach (var employee in data1)
            {
                Console.WriteLine($"Id - {employee.Id},first name - {employee.FirstName},last name - {employee.LastName},salary - {employee.Salary}");
            }



            Console.WriteLine("-------------------------------------------------------------------------------");


            // now we going to try ThenByDescending method syntex 
            var data2 = employees.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ThenByDescending(x => x.Salary).ToList();

            foreach (var employee in data2)
            {
                Console.WriteLine($"Id - {employee.Id},first name - {employee.FirstName},last name - {employee.LastName},salary - {employee.Salary}");
            }


            Console.WriteLine("-------------------------------------------------------------------------------");
            // now we gonna try multi level descending by query syntex
            var data3 = (from employee in employees orderby employee.FirstName descending, employee.LastName descending, employee.Salary descending select employee).ToList();

            foreach (var employee in data3)
            {
                Console.WriteLine($"Id - {employee.Id},first name - {employee.FirstName},last name - {employee.LastName},salary - {employee.Salary}");
            }

        }
    }


    // data structure
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
}
