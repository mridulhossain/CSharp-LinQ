using System;
using System.Collections.Generic;
using System.Linq;

namespace WhereMethodLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Where using for filter data in link,it's a method and it's using for condition 
             * here we will doing experiment and do make some example with where method */


            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // data sources(intiger)
            List<string> names = new List<string>() { "mridul","mrid","bijoy","mubasher","upama","nicky" }; // data sources(string)

            //using query syntex
            var query = (from number in numbers where number > 5 select number).ToList(); // here we use a contion with where method for get number who bigger then 5

            foreach (var number in query)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("----------------------------------------------------------------------------------");

            //method syntex
            var methodSyntex = numbers.Where(x => x < 5).ToList();
            foreach (var number in methodSyntex)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("----------------------------------------------------------------------------------");
            //using multiple condition in query syntex
            var multipleCondition = (from number in numbers where number > 5 || number > 9 select number).ToList();

            foreach (var number in multipleCondition)
            {
                Console.WriteLine(number);
            }



            Console.WriteLine("----------------------------------------------------------------------------------");
            //using multiple condition in method syntex
            var multipleConditionMethod = numbers.Where(x => x < 5 || x > 9 ).ToList();

            foreach (var number in multipleConditionMethod)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("----------------------------------------------------------------------------------");

            var getName = (from name in names where name.Length == 5 select name).ToList();
            foreach (var name in getName)
            {
                Console.WriteLine(name);
            }



            Console.WriteLine("----------------------------------------------------------------------------------");

            //get all names where names first letter started with m
            var mNames = (from name in names where char.ToLower(name[0]) == 'm' && name.Length == 6 select name).ToList();
            foreach (var name in mNames)
            {
                Console.WriteLine(name);
            }



        }
    }
}
