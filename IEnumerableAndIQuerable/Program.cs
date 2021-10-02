using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableAndIQuerable
{
    class Program
    {
        static void Main(string[] args)
        {
            /* IEnumarable is an Interface
             * it exist in system.collection namespace
             * all collection in c# implement's IEnumarable 
             * this interface is type of iteration design pattern
             * if we implement's this interface we can iterate(foreach loop) on collection 
             * it has also generics classes */

            // data sources
            List<People> peoples = new List<People>() {
                new People { Id = 1, Name = "Mridul",Age = 23 },
                new People { Id = 2, Name = "Bijoy", Age = 27 },
                new People { Id = 3, Name = "Mubasher", Age = 30 },
                new People { Id = 4,Name = "Tanvir", Age = 32 }
            };


            // Query using IEnumarable
            IEnumerable<People> peopleQuery = from people in peoples where people.Age >= 30 select people;


            // iteration
            foreach (var people in peopleQuery)
            {
                Console.WriteLine($"Id- {people.Id}, Name- {people.Name}, Age- {people.Age}");
            }


            /*IQuerable is also an interface
             * it exist in system.collection namespace
             * IQuerable is a child of IEnumarable
             * it use for other data source which is not in memory,using for other data source like sql server.
             */

            //Query using IQueryable
            IQueryable<People> peopleQuery2 = peoples.AsQueryable().Where(x =>  30 > x.Age);

            // iteration
            foreach (var people in peopleQuery2)
            {
                Console.WriteLine($"Id- {people.Id}, Name- {people.Name}, Age- {people.Age}");
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
