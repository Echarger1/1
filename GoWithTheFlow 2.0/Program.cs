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


            

            while (true)
            {
                Console.WriteLine("Lamp doesn't work.");
                Console.WriteLine("Is lamp pluged in?");

                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    Console.WriteLine("Is the bulb burned out?");
                    answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Console.WriteLine("Replace bulb.");
                        
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Repair Lamp.");
                        answer = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Plug in lamp.");
                        
                    }
                  
                }
                
            }



            Console.ReadKey();


        }
    }
}
