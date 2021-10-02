using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /* there type LinQ syntex
             * 1/ Query syntex
             * 2/ Method syntex
             * 3/ Mix syntex(Query + Method) */

            /* here we play three type syntex one by one , see and try */

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // data sources

            /*--------------------------------- Query syntex ----------------------------*/
            var querySyntex = from number in numbers where number > 2  select number;
            foreach (var item in querySyntex)
            {
                Console.WriteLine(item);
            }

            /*--------------------------------- Method syntex ----------------------------*/

            var methodSyntex = numbers.Where(number => number > 2);
            foreach (var item in methodSyntex)
            {
                Console.WriteLine(item);
            }

            /*--------------------------------- Mix syntex ----------------------------*/

            var mixSyntex = (from number in numbers select number).Max();
            Console.WriteLine(mixSyntex);

        }
    }
}
