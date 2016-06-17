using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the baby crying?");

            string answer = Console.ReadLine();

            while (!(answer.ToLower == "yes") || (answer.ToLower == "no"))
            {
                Console.WriteLine. ("Type Yes or No");
                answer = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
