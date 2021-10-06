using System;
using System.Collections.Generic;
using System.Linq;

namespace OfTypeOperatorLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // of type using for data filtering, we will see some example
            List<object> data = new List<object>() { "Mridul","Bijoy","Mubasher","Tanvir",1,3,4,5,6,78,1 }; // data source


            // get all string data with method syntex
            var getAllStringData = data.OfType<string>().ToList();

            foreach (var name in getAllStringData)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("-----------------------------------------------------------------------------");

            // get all integer data with query syntex
            var getAllInteger = (from number in data where number is int select number).ToList();

            foreach (var number in getAllInteger)
            {
                Console.WriteLine(number);
            }
        }
    }
}
