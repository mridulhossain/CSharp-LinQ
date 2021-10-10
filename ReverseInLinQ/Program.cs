using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseInLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //here we doing how data source iteration from reverse query syntex and method syntex

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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


            // if data source is an array you can do it like that
            var data = numbers.Reverse();
            foreach (var number in data)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------------------------------------------------------------");

            // if data soruce is a list you have to reverse like this
            employees.Reverse();
            foreach (var employee in employees)
            {
                Console.WriteLine($"Id - {employee.Id},first name - {employee.FirstName},last name - {employee.LastName},salary - {employee.Salary}");
            }


            Console.WriteLine("------------------------------------------------------------");


            // query syntex

            var data1 = (from emp in employees select emp).Reverse();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Id - {employee.Id},first name - {employee.FirstName},last name - {employee.LastName},salary - {employee.Salary}");
            }

            Console.WriteLine("------------------------------------------------------------");

            // query syntex 

            var data2 = (from num in numbers select num).Reverse();

            foreach (var number in data2)
            {
                Console.WriteLine(number);
            }
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }


}
