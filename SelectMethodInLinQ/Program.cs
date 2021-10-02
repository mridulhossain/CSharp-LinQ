using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableAndIQuerable
{
    class Program
    {
        static void Main(string[] args)
        {
          
            /* here we see how select method work in LinQ and doing some experiment */

            // data sources
            List<People> peoples = new List<People>() {
                new People { Id = 1, Name = "Mridul",Age = 23 },
                new People { Id = 2, Name = "Bijoy", Age = 27 },
                new People { Id = 3, Name = "Mubasher", Age = 30 },
                new People { Id = 4,Name = "Tanvir", Age = 32 }
            };


            // get all names by using query structure
            var names = from people in peoples select people.Name;
            names.ToList();


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }



            // get all name by using method
            var names1 = peoples.Select(x => x.Name).ToList();

            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }


            // get name and age by using mix method

            var data = (from people in peoples select new People() { Name = people.Name, Age = people.Age }).ToList();

            foreach (var people in data)
            {
                Console.WriteLine($"Name - {people.Name} and Age - {people.Age}");
            }



            // you can also use anonymous type like this 

            var data1 = (from people in peoples select new { peopleId = people.Id, peopleName = people.Name, peopleAge = people.Age }).ToList();

            foreach (var peopleData in data1)
            {
                Console.WriteLine($"Id - {peopleData.peopleId },Name - {peopleData.peopleName}, Age - {peopleData.peopleAge}");
            }


            // you can select also like this
            var data2 = peoples.Select(people => new { peopleId = people.Id, peopleName = people.Name, peopleAge = people.Age }).ToList();

            foreach (var peopleData in data2)
            {
                Console.WriteLine($"Id - {peopleData.peopleId },Name - {peopleData.peopleName}, Age - {peopleData.peopleAge}");
            }


            // this is another method select and get index
            var data3 = peoples.Select((people,index) => new { peopleId = index, peopleName = people.Name, peopleAge = people.Age }).ToList();

            foreach (var peopleData in data3)
            {
                Console.WriteLine($"Id - {peopleData.peopleId },Name - {peopleData.peopleName}, Age - {peopleData.peopleAge}");
            }

        }


        /// <summary>
        /// People datastructure
        /// </summary>
        public class People
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
