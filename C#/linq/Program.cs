using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //// 2. Query creation.
            //// numQuery is an IEnumerable<int>
            //var numQuery =
            //    from num in numbers
            //    where (num % 2) != 0
            //    select num;

            //// 3. Query execution.
            //foreach (int num in numQuery)
            //{
            //    Console.Write("{0,1} ", num);
            //}

            //ex 2 

            // 1. Data source.
            string[] nomes = new string[5] {"Julio Silva","Joao Santos", "Julia Silva", "Michael Santos", "Ana Carolina"};

            var nameQuery =
                from name in nomes
                where (nomes.Contains("Silva"))
                select name;

            foreach (string name in nameQuery)
            {
                if (name.Contains("silva"))
                    Console.Write("{0,1} ", name);
            }

            Console.ReadKey();
        }
    }
}
